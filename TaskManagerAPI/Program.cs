using TaskManager_Business_Logic;
using TaskManager_Data_Logic;

namespace TaskManagerAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.Configure<EmailSettings>(
                builder.Configuration.GetSection("EmailSettings"));

            builder.Services.AddScoped<EmailService>(serviceProvider =>
            {
                var config = builder.Configuration.GetSection("EmailSettings");
                return new EmailService(
                    smtpHost: config["SmtpHost"],
                    smtpPort: int.Parse(config["SmtpPort"]),
                    smtpUsername: config["SmtpUsername"],
                    smtpPassword: config["SmtpPassword"],
                    fromEmail: config["FromEmail"],
                    fromName: config["FromName"]
                );
            });

            builder.Services.AddSingleton<ITaskDataService, JsonFileDataService>();
            builder.Services.AddScoped<TaskManagerService>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}