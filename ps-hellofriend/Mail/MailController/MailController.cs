using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.IO;
using System.Text;
using Mailzory;

using System.Globalization;

namespace ps_hellofriend.Mail.MailController
{
    public class MailController : Controller
    {
        MailController mailController = new MailController();

        MailMessage message = new MailMessage();




        public enum EmailType
        {
            CANCELLED,
            NEW,
            UPDATED,
            ACCEPTED,
            REJECTED
        }

        public enum EmailTarget
        {
            CLIENT,
            CLIENT_OWN,
            RESTAURANT
        }
       
        //Culture type accepted

        CultureInfo ES = new CultureInfo("es");
        CultureInfo DE = new CultureInfo("de");
        CultureInfo EN = new CultureInfo("en"); //en-GB

        public enum CultureType
        {
            ES,
            EN,
            DE
        }
        


        // Selecct Path templates:        

        public void SendHtmlMail() {
            //var tempalteForderPath = Path.Combine("Mail/Templates", "Mail.cshtml");
            var templateForderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Mail/Templates");
            var email = new Email(templateForderPath);
        }


        //   
        public void SendMailLang(EmailType type, EmailTarget targetUser, CultureType lang) {


        }


        // Send Mail with Templates: 
        private string createEmailBody(string message, CultureType lang) {

            if (lang == CultureType.DE) {
                //Read templates DE:

            } else if (lang ==CultureType.EN) {
                //Read templates EN:

            }else{
                //Read templates ES:
            }

            return "";
        }




    }
}