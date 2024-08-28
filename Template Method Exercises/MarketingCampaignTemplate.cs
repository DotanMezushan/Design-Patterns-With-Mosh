using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Exercises
{
    abstract class MarketingCampaignTemplate
    {
        public void RunCampaign()
        {
            CreateContent();
            SelectTargetAudience();
            ScheduleCampaign();
            LaunchCampaign();
            AnalyzeResults();
        }

        protected abstract void CreateContent();
        protected abstract void SelectTargetAudience();
        protected abstract void ScheduleCampaign();
        protected abstract void LaunchCampaign();
        protected abstract void AnalyzeResults();
    }
}
