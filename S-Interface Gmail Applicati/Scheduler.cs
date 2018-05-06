using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_Interface_Gmail_Applicati
{
    public class Scheduler
    {
        int count = 0;
        ISchedulerFactory schedFact;
        IScheduler sched;

        public void Start(String Name, String Email, String EmailSubject, String EmailBody, DateTime date)

        {
            count = count + 1;

            schedFact = new StdSchedulerFactory();

            sched = schedFact.GetScheduler();
            sched.Start();

                   
            IJobDetail job = JobBuilder.Create<EmailJob>().
              WithIdentity("IDGJob" + count.ToString(), "IDG")
             .UsingJobData("Name", Name)
             .UsingJobData("Email", Email)
             .UsingJobData("EmailSubject", EmailSubject)
             .UsingJobData("EmailBody", EmailBody)
             .Build();

            ITrigger trigger = TriggerBuilder.Create()
             .WithIdentity("Trigger" + count.ToString(), "TriggerGrp")
               .StartAt(date)
               .WithPriority(1)
               .Build();
            sched.ScheduleJob(job, trigger);

        }

        public void Stop()
        {
            if (sched != null)
            {
                sched.Shutdown();
            }
        }
    }
}
