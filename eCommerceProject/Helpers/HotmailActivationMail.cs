using System.Text;

namespace eCommerceProject.Helpers
{
    public class HotmailActivationMail
    {
        public static void SendActivationMail(string receiver)
        {
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.To.Add(receiver);
            mail.From = new System.Net.Mail.MailAddress("YOUR_EMAIL");
            mail.Subject = "Test Activation";
            mail.SubjectEncoding = System.Text.Encoding.UTF8;

            string linkk = "https://localhost:7069/Account/EmailActivation?eee=";


            var HtmlBody = new StringBuilder();
            HtmlBody.AppendFormat("Welcome, ");
            HtmlBody.AppendLine(@"Click the link below to activate your account.");
            HtmlBody.AppendLine("<a href=\"" + linkk + "\">ACTIVATE</a>");
            mail.Body = HtmlBody.ToString();
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = System.Net.Mail.MailPriority.Normal;
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();


            client.Credentials = new System.Net.NetworkCredential("YOUR_EMAIL", "YOUR_PASSWORD");
            client.Port = 587;
            client.Host = "smtp.office365.com";
            client.EnableSsl = true;
            try
            {
                client.Send(mail);

            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                string errorMessage = string.Empty;
                while (ex2 != null)
                {
                    errorMessage += ex2.ToString();
                    ex2 = ex2.InnerException;
                }

            }

        }
    }
}
