using BasicFBGraphApi.Models;
using Facebook;
using System.Text.Json;

namespace BasicFBGraphApi.GraphService
{
    public class FacebookGraphApi : IGraphApi
    {
        static FacebookData fbModel = new FacebookData();
        //static InstagramData igModel = new InstagramData();

        private dynamic fbAccData;
        private dynamic fbPageData;
        private dynamic igAccData;
        public FacebookData GetProperties(string token)
        {
            var account = new FacebookClient(token);
            fbAccData = account.Get("me?fields=id,first_name,last_name,name,name_format,email,accounts");

            fbModel.first_name = fbAccData.first_name;
            fbModel.last_name = fbAccData.last_name;
            fbModel.email = fbAccData.email;
            fbModel.id = fbAccData.id;
            fbModel.name = fbAccData.name;
            fbModel.name_format = fbAccData.name_format;
            fbAccData = account.Get("me/accounts?fields=id");
            fbModel.accounts = JsonSerializer.Serialize(fbAccData.data[0].id);
            string igPageLink = (fbModel.accounts + "?fields=name,about,birthday,category,is_always_open,followers_count,id,instagram_business_account,link,name_with_location_descriptor").Replace("\"", "");
            fbPageData = account.Get(igPageLink);
            fbModel.igName = fbPageData.name;
            fbModel.about = fbPageData.about;
            fbModel.birthday = fbPageData.birthday;
            fbModel.category = fbPageData.category;
            fbModel.is_always_open = fbPageData.is_always_open;
            fbModel.followers_count = fbPageData.followers_count;
            fbModel.igId = fbPageData.id;
            fbModel.instagram_business_account = fbPageData.instagram_business_account.id;
            fbModel.link = fbPageData.link;
            fbModel.name_with_location_descriptor = fbPageData.name_with_location_descriptor;

            return fbModel;

        }
    }
}
