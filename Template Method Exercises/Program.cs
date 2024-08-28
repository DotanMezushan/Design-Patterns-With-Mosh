using Template_Method_Exercises;

MarketingCampaignTemplate emailCampaign = new EmailCampaign();
emailCampaign.RunCampaign();

Console.WriteLine();

MarketingCampaignTemplate socialMediaCampaign = new SocialMediaCampaign();
socialMediaCampaign.RunCampaign();