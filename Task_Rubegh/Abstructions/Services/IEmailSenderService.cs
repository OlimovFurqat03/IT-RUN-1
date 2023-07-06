using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Rubegh.Abstructions.Services
{
    public interface IEmailSenderService
    {
        void SendEmail(string  email, string text);       
    }
}
