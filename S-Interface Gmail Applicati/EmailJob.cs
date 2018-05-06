using System;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Quartz;
using Google.Apis.Util.Store;

namespace S_Interface_Gmail_Applicati
{
    public class EmailJob : IJob
    {

        public void Execute(IJobExecutionContext context)
        {
            JobKey key = context.JobDetail.Key;
            JobDataMap dataMap = context.JobDetail.JobDataMap;

            string receiverName = dataMap.GetString("Name");
            string receiverAddress = dataMap.GetString("Email");
            string subject = dataMap.GetString("EmailSubject");
            string body = dataMap.GetString("EmailBody");

            //var clientId = "139337999099-f4450qvvnouohbpcdn3s4mlg476e4p00.apps.googleusercontent.com";
            //var clientSecret = "75kZznA-j5N-ohY4BmdijOeK";
            //string sendername = "Computational Physiology Labs";
            //string senderAddress = "cpl201819@gmail.com";
                       
            NewMethod(receiverName, receiverAddress, subject, body);

        }

        private void NewMethod(String receiverName, string receiverAddress, string subject, string body)
        {
            try
            {
                UserCredential credential;

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
                        ApplicationName = "Gmail API",
                    });

                    var text = string.Format("From: {0} <{1}>\nTo: {2} <{3}>\nSubject: {4}\nDate: Thu, 29 Mar 2018 22:19:06 -0600\nMessage-ID: <1234@local.machine.example>\n\n{5}",
                          "Computational Physiology Labs",
                          "cpl201819@gmail.com",
                          receiverName,
                          receiverAddress,
                          subject,
                          body);

                    Console.WriteLine("Send email:\n{0}", text);

                    var encodedText = System.Text.Encoding.UTF8.GetBytes(text);
                    //var encodedText = System.Web.HttpServerUtility.UrlTokenEncode(Encoding.UTF8.GetBytes(text));

                    var convertedText = Convert.ToBase64String(encodedText).Replace('+', '-').Replace('/', '_').Replace("=", "");

                    Console.WriteLine("Raw email:\n{0}", encodedText);

                    var message = new Google.Apis.Gmail.v1.Data.Message { Raw = convertedText };



                    var request = service.Users.Messages.Send(message, "me").Execute();

                    Console.WriteLine(
                        string.IsNullOrEmpty(request.Id) ? "Issue sending, returned id: {0}" : "Email looks good, id populated: {0}",
                        request.Id);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception encountered: {0}", e.Message);
            }
        }
    }
}
