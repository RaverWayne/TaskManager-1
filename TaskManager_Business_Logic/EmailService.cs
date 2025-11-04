using MailKit.Net.Smtp;
using MimeKit;
using System;

namespace TaskManager_Business_Logic
{
    public class EmailService
    {
        private readonly string smtpHost;
        private readonly int smtpPort;
        private readonly string smtpUsername;
        private readonly string smtpPassword;
        private readonly string fromEmail;
        private readonly string fromName;


        public EmailService(string smtpHost, int smtpPort, string smtpUsername,
                          string smtpPassword, string fromEmail, string fromName)
        {
            this.smtpHost = smtpHost;
            this.smtpPort = smtpPort;
            this.smtpUsername = smtpUsername;
            this.smtpPassword = smtpPassword;
            this.fromEmail = fromEmail;
            this.fromName = fromName;
        }

        public EmailService()
        {
            try
            {
                smtpHost = System.Configuration.ConfigurationManager.AppSettings["SmtpHost"];
                smtpPort = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SmtpPort"]);
                smtpUsername = System.Configuration.ConfigurationManager.AppSettings["SmtpUsername"];
                smtpPassword = System.Configuration.ConfigurationManager.AppSettings["SmtpPassword"];
                fromEmail = System.Configuration.ConfigurationManager.AppSettings["SmtpFromEmail"];
                fromName = System.Configuration.ConfigurationManager.AppSettings["SmtpFromName"];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Warning: Could not load email settings from config: {ex.Message}");
            }
        }

        public bool SendTaskAddedEmail(string recipientEmail, string taskText)
        {
            string subject = "✅ Task Added Successfully";
            string body = $@"
                <html>
                <body style='font-family: Arial, sans-serif; line-height: 1.6; color: #333;'>
                    <div style='max-width: 600px; margin: 0 auto; padding: 20px; border: 1px solid #ddd; border-radius: 5px;'>
                        <h2 style='color: #4CAF50; border-bottom: 2px solid #4CAF50; padding-bottom: 10px;'>
                            Task Added
                        </h2>
                        <p>A new task has been added to your task manager.</p>
                        <div style='background-color: #f9f9f9; padding: 15px; border-left: 4px solid #4CAF50; margin: 20px 0;'>
                            <strong>Task:</strong><br/>
                            <span style='font-size: 16px;'>{taskText}</span>
                        </div>
                        <p style='color: #666; font-size: 14px;'>
                            Added on: {DateTime.Now:MMMM dd, yyyy 'at' hh:mm tt}
                        </p>
                        <hr style='border: none; border-top: 1px solid #eee; margin: 20px 0;'/>
                        <p style='color: #999; font-size: 12px;'>
                            This is an automated notification from Task Manager System.
                        </p>
                    </div>
                </body>
                </html>";

            return SendEmail(recipientEmail, subject, body);
        }

        public bool SendTaskUpdatedEmail(string recipientEmail, string oldTaskText, string newTaskText)
        {
            string subject = "🔄 Task Updated";
            string body = $@"
                <html>
                <body style='font-family: Arial, sans-serif; line-height: 1.6; color: #333;'>
                    <div style='max-width: 600px; margin: 0 auto; padding: 20px; border: 1px solid #ddd; border-radius: 5px;'>
                        <h2 style='color: #2196F3; border-bottom: 2px solid #2196F3; padding-bottom: 10px;'>
                            Task Updated
                        </h2>
                        <p>A task has been modified in your task manager.</p>
                        <div style='background-color: #fff3cd; padding: 15px; border-left: 4px solid #ffc107; margin: 20px 0;'>
                            <strong>Previous Task:</strong><br/>
                            <span style='text-decoration: line-through; color: #999;'>{oldTaskText}</span>
                        </div>
                        <div style='background-color: #d1ecf1; padding: 15px; border-left: 4px solid #2196F3; margin: 20px 0;'>
                            <strong>Updated Task:</strong><br/>
                            <span style='font-size: 16px;'>{newTaskText}</span>
                        </div>
                        <p style='color: #666; font-size: 14px;'>
                            Updated on: {DateTime.Now:MMMM dd, yyyy 'at' hh:mm tt}
                        </p>
                        <hr style='border: none; border-top: 1px solid #eee; margin: 20px 0;'/>
                        <p style='color: #999; font-size: 12px;'>
                            This is an automated notification from Task Manager System.
                        </p>
                    </div>
                </body>
                </html>";

            return SendEmail(recipientEmail, subject, body);
        }

        public bool SendTaskDeletedEmail(string recipientEmail, string taskText)
        {
            string subject = "🗑️ Task Deleted";
            string body = $@"
                <html>
                <body style='font-family: Arial, sans-serif; line-height: 1.6; color: #333;'>
                    <div style='max-width: 600px; margin: 0 auto; padding: 20px; border: 1px solid #ddd; border-radius: 5px;'>
                        <h2 style='color: #f44336; border-bottom: 2px solid #f44336; padding-bottom: 10px;'>
                            Task Deleted
                        </h2>
                        <p>A task has been removed from your task manager.</p>
                        <div style='background-color: #ffebee; padding: 15px; border-left: 4px solid #f44336; margin: 20px 0;'>
                            <strong>Deleted Task:</strong><br/>
                            <span style='font-size: 16px; text-decoration: line-through;'>{taskText}</span>
                        </div>
                        <p style='color: #666; font-size: 14px;'>
                            Deleted on: {DateTime.Now:MMMM dd, yyyy 'at' hh:mm tt}
                        </p>
                        <hr style='border: none; border-top: 1px solid #eee; margin: 20px 0;'/>
                        <p style='color: #999; font-size: 12px;'>
                            This is an automated notification from Task Manager System.
                        </p>
                    </div>
                </body>
                </html>";

            return SendEmail(recipientEmail, subject, body);
        }

        private bool SendEmail(string recipientEmail, string subject, string htmlBody)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(fromName, fromEmail));
                message.To.Add(new MailboxAddress("", recipientEmail));
                message.Subject = subject;

                var bodyBuilder = new BodyBuilder
                {
                    HtmlBody = htmlBody
                };
                message.Body = bodyBuilder.ToMessageBody();

                using (var client = new SmtpClient())
                {
                    client.Connect(smtpHost, smtpPort, MailKit.Security.SecureSocketOptions.StartTls);
                    client.Authenticate(smtpUsername, smtpPassword);
                    client.Send(message);
                    client.Disconnect(true);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send email: {ex.Message}");
                return false;
            }
        }
    }
}