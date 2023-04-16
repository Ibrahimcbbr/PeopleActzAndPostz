using PeopleActzAndPostz.Domain.Models.DTOs.AppUsers.Accounts.RequestDtos;

namespace PeopleActzAndPostz.Application.Common.Contracts.Email
{
    public interface IMailService
    {
        Task SendEmailConfirmationMail(EmailRequest request, string token);
        Task SendPasswordResetEmail(EmailRequest request, string token);
    }
}
