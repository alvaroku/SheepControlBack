namespace Business.Definitions
{
    public interface IEmailSender
    {
        Task SendEmail(string emailTo, string body, string subject);
    }
}
