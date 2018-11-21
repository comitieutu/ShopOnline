using System.Threading.Tasks;

namespace ComiShop.Services
{
    public interface IEmailService
    {
        Task SendEmail(string email, string subject, string message);
    }
}
