using System;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Quartz;
using Quartz.Impl;
using System.Threading.Tasks;
using System.Collections.Generic;
using Google.Apis.Util.Store;
using System.IO;

namespace S_Interface_Gmail_Applicati
{
    public class Readmails
    {

        public String[] GetEmails()
        {
            String[] EmailArray;
            EmailArray = new String[10];
            List<string> EmailList = new List<string>();

        UserCredential credential;
        try
        {
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                             GoogleClientSecrets.Load(stream).Secrets,
                new[] { GmailService.Scope.GmailReadonly, GmailService.Scope.MailGoogleCom, GmailService.Scope.GmailModify },
                "user",
                CancellationToken.None,
                new FileDataStore(this.GetType().ToString())).Result;


                var service = new GmailService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = this.GetType().ToString()
                });


                var emailListRequest = service.Users.Messages.List("me");
                emailListRequest.LabelIds = "INBOX";
                emailListRequest.IncludeSpamTrash = false;
                emailListRequest.Q = "is:unread";

                //get our emails
                var emailListResponse = emailListRequest.Execute();


                if (emailListResponse != null && emailListResponse.Messages != null)
                {
                    //loop through each email and get what fields you want...
                    foreach (var email in emailListResponse.Messages)
                    {

                        var emailInfoRequest = service.Users.Messages.Get("me", email.Id);

                        //make another request for that email id...
                        var emailInfoResponse = emailInfoRequest.Execute();

                        if (emailInfoResponse != null)
                        {
                            String from = "";
                            String date = "";
                            String subject = "";
                            //String body = "";
                            //loop through the headers and get the fields we need...


                            foreach (var mParts in emailInfoResponse.Payload.Headers)
                            {
                                if (mParts.Name == "Date")
                                {
                                    date = mParts.Value;
                                }
                                else if (mParts.Name == "From")
                                {
                                    from = mParts.Value;
                                }
                                else if (mParts.Name == "Subject")
                                {
                                    subject = mParts.Value;
                                }


                            }

                            EmailList.Add("From: " + from + " " + "Date: " +  date + " " + "Subject: " + subject);
                        }


                    }
                }

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Failed to get messages!", "Failed Messages!", MessageBoxButtons.OK);
            MessageBox.Show(ex.ToString());
        }

        EmailArray = EmailList.ToArray();
        return EmailArray;
    }
}
   }
