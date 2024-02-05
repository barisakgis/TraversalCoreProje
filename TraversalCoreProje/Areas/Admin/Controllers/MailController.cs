using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
 
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(MailRequest mailRequest )
        {
            MimeMessage mimeMessage =new MimeMessage();

            // MailboxAddress mailboxAddressFrom = new MailboxAddress(mailRequest.Name, mailRequest.SenderMail);
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "traversalcore@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);


            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodybuilder = new BodyBuilder();
            bodybuilder.TextBody = mailRequest.Body;
            mimeMessage.Body = bodybuilder.ToMessageBody();

            mimeMessage.Subject = mailRequest.Subject;
             

            SmtpClient client = new  SmtpClient ();
            client.Connect("smtp.gmail.com", 587, false);

            client.Authenticate("traversalcore@gmail.com", "bbbbbbbb"); 
            // gmail da iki adımlı doğrulama olacak ve yok kısmına tıklayarak google dan şifre verecek onu buraya yazacaz

            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }
    }
}
