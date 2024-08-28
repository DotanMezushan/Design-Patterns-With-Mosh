using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Exercises
{
    class EmailCampaign : MarketingCampaignTemplate
    {
        protected override void CreateContent()
        {
            Console.WriteLine("Creating email content");
        }

        protected override void SelectTargetAudience()
        {
            Console.WriteLine("Selecting email recipients");
        }

        protected override void ScheduleCampaign()
        {
            Console.WriteLine("Scheduling email send time");
        }

        protected override void LaunchCampaign()
        {
            Console.WriteLine("Launching email campaign");
        }

        protected override void AnalyzeResults()
        {
            Console.WriteLine("Analyzing email open and click rates");
        }
    }
}
