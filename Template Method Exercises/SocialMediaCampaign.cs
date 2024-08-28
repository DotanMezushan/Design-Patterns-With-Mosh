using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Exercises
{
    class SocialMediaCampaign : MarketingCampaignTemplate
    {
        protected override void CreateContent()
        {
            Console.WriteLine("Creating social media posts");
        }

        protected override void SelectTargetAudience()
        {
            Console.WriteLine("Selecting social media audience");
        }

        protected override void ScheduleCampaign()
        {
            Console.WriteLine("Scheduling social media posts");
        }

        protected override void LaunchCampaign()
        {
            Console.WriteLine("Launching social media campaign");
        }

        protected override void AnalyzeResults()
        {
            Console.WriteLine("Analyzing social media engagement");
        }
    }
}
