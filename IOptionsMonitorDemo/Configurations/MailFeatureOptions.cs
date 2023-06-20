namespace IOptionsMonitorDemo.Configurations
{
    public class MailFeatureOptions
    {
        public bool IsEnabled { get; set; }
        public string SmtpServer { get; set; }
        public string FromEmailAddress { get; set; }
        public string Subject { get; set; }
    }
}
