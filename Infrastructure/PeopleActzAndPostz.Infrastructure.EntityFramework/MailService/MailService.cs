using MailKit.Net.Smtp;
using MimeKit;
using PeopleActzAndPostz.Application.Common.Contracts.Email;
using PeopleActzAndPostz.Domain.Common.Constants;
using PeopleActzAndPostz.Domain.Common.Settings;
using PeopleActzAndPostz.Domain.Models.DTOs.AppUsers.Accounts.RequestDtos;

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.MailService
{
    public class MailService : IMailService
    {
        private readonly EmailConfigurationSettings _emailConfigurationSettings;

        public MailService(EmailConfigurationSettings emailConfigurationSettings)
        {
            _emailConfigurationSettings = emailConfigurationSettings;
        }

        public async Task SendEmailConfirmationMail(EmailRequest request, string token)
        {
            var mail = new MimeMessage();
            mail.From.Add(new MailboxAddress("PeopleActzAndPostz", _emailConfigurationSettings.Username + "@gmail.com"));
            mail.To.Add(MailboxAddress.Parse(request.To));
            mail.Subject = request.Subject;
            mail.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = EmailTemplates.EmailMessage(EmailTemplates.AccountActivation(request.To, token))
            };
          await SendEmailAsync(mail);
        }

        public async Task SendPasswordResetEmail(EmailRequest request, string token)
        {
            var mail = new MimeMessage();
            mail.From.Add(new MailboxAddress("PeopleActzAndPostz", _emailConfigurationSettings.Username + "@yandex.com"));
            mail.To.Add(MailboxAddress.Parse(request.To));
            mail.Subject = request.Subject;
            mail.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = EmailTemplates.EmailMessage(EmailTemplates.PasswordReset(request.To, token))
            };

            await SendEmailAsync(mail);

        }
        private async Task SendEmailAsync(MimeMessage mail)
        {
            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(_emailConfigurationSettings.Host, _emailConfigurationSettings.Port, MailKit.Security.SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_emailConfigurationSettings.Username, _emailConfigurationSettings.Password);
            await smtp.SendAsync(mail);
            await smtp.DisconnectAsync(true);
        }
    }
}
