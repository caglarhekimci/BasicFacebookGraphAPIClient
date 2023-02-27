namespace BasicFBGraphApi.Models
{
    public class FacebookData
    {
        public string id { get; set; } = null;
        public string email { get; set; } = null;
        public string first_name { get; set; } = null;
        public string last_name { get; set; } = null;
        public string name_format { get; set; } = null;
        public string name { get; set; } = null;
        public string accounts { get; set; } = null;
        public string token { get; set; }

        #region FaceBookPage
        public string igName { get; set; } = null;
        public string igId { get; set; } = null;
        public string about { get; set; } = null;
        public string birthday { get; set; } = null;
        public string category { get; set; } = null;
        public bool is_always_open { get; set; }
        public long followers_count { get; set; }
        public string instagram_business_account { get; set; } = null;
        public string link { get; set; } = null;
        public string name_with_location_descriptor { get; set; } = null;
        #endregion FaceBookPage
    }
}
