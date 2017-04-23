using System;
using System.Net;

namespace is_site_up
{
    public class UrlCheck
    {
        public string m_Url { get; set; }

        public bool CheckIfSiteIsUp()
        {
            bool isSiteUp;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(m_Url);

            try
            {
                HttpWebResponse response = (HttpWebResponse) request.GetResponse(); // TODO https://www.crackisgood.com stuck
                isSiteUp = true;
                response.Close();
            }
            catch
            {
                isSiteUp = false;
            }

            return isSiteUp;
        }
    }
}
