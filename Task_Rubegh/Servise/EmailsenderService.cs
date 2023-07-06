using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Rubegh.Abstructions.Services;

namespace Task_Rubegh.Servise
{
    internal class EmailsenderService : IEmailSenderService
    {

        public void SendEmail(string email, string text)
        {
            Console.WriteLine($"{text} is send to {email}");
        }
    }
}
