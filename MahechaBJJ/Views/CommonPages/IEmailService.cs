using System;
using MahechaBJJ.Model;

namespace MahechaBJJ.Views.CommonPages
{
    public interface IEmailService
    {
        void StartEmailActivity(EmailMessage message);
    }
}
