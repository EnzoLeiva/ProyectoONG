using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using OngProject.Core.Interfaces.IServices.SendEmail;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace OngProject.Core.Services.SendEmail
{
    public class SendEmailService : ISendEmailService
    {
        private readonly IConfiguration _configuration;
        public SendEmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<bool> send(string email)
        {
           
                var apiKey = _configuration["SENDGRID_API_KEY:Key"];
                var client = new SendGridClient(apiKey);
                var from = new EmailAddress(_configuration["SENDGRID_API_KEY:FromEmail"], "Example User");
                var subject = "Correo de api somos mas";
                var to = new EmailAddress(email, "Example User");
                var plainTextContent = "Este es el cuerpo de un correo enviado a traves de la api somos mas";
                var htmlContent = "<strong>Este es el cuerpo de un correo enviado a traves de la api somos mas</strong>";
                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                var response = await client.SendEmailAsync(msg);

                return response.IsSuccessStatusCode;

          
        }
    }
}
