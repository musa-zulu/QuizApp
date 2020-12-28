using QuizApp.Domain.Settings;
using System.Threading.Tasks;

namespace QuizApp.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
