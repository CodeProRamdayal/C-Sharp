using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Oops
{

    public interface IEmailService
    {
        public void sendEmail(string message);
    }


    public class EmailService : IEmailService { 
    
        public void sendEmail(string message)
        {
            Console.WriteLine($"Hi {message}");
        }
    }

    public class UserService {

        private readonly IEmailService _emailService;

        public UserService(IEmailService emailService)
        {
            _emailService = emailService;
            _emailService.sendEmail("Ramdayal");
        }
    
    }

    internal class DependenciesInjection
    {
        public DependenciesInjection()
        {
            IEmailService emailservice = new EmailService();
            UserService user = new UserService(emailservice);
        }
    }
}
