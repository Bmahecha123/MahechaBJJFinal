﻿using System;
using Android.Content;
using MahechaBJJ.Droid.Service;
using MahechaBJJ.Model;
using MahechaBJJ.Service;
using MahechaBJJ.Views.CommonPages;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(EmailService_Android))]
namespace MahechaBJJ.Droid.Service
{
    public class EmailService_Android : IEmailService
    {
        public EmailService_Android()
        {
        }

        public void StartEmailActivity(EmailMessage emailMessage)
        {
            var email = new Intent(Intent.ActionSend);
            //var email = new Intent(Android.Content.Intent.ActionSend);
            //var email = Forms.Context(new Intent(Android.Content.Intent.ActionSend));
            email.PutExtra(Intent.ExtraEmail, new string[] { "admin@mahechabjj.com" });
            email.PutExtra(Intent.ExtraSubject, emailMessage.Subject);
            email.PutExtra(Intent.ExtraText, emailMessage.Body);
            email.SetType("message/rfc822");
            Forms.Context.StartActivity(Intent.CreateChooser(email, "Send Email"));
        }
    }
}
