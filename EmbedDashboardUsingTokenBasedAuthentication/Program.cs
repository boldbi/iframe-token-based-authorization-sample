using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace EmbedDashboardUsingTokenBasedAuthentication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable declaration to form the embed URL 

            string secretCode = "TVGajVPZ5M89IPfFqSnszgAzVl27Jbkd";  // secret code generated in the Bold BI application
            var dashboardUrl = "http://localhost:5315/bi/site/site1/dashboards/3125a7dd-8dc9-4c5a-9239-6cd63c244400/Sales/Sales%20Analysis%20Dashboard?"; // URL of the dashboard to be embedded. Add '? or &' at the end of the URL based on your dashboard URL

            // Variable declaration to form the signature for the embed URL 

            var nonce = Guid.NewGuid().ToString(); // random string
            var userInfo = "nithya.gopal@syncfusion.com"; // email address of the user
            //bool canSaveView = true; // enable or disable permission to create, open, update, delete view 
            //bool hasViews = true; // enable or disable the permission to check the views of the dashboard
            //bool hasExport = true; // enable or disable the permission to export the dashboards and widgets
            //bool hasDashboardComments = true; // enable or disable the permission to comment related actions to dashboards
            //bool hasWidgetComments = true; // enable or disable the permission to comment related actions to widgets
            bool isMarkFavorite = true; // enable to disable the permission to make the dashboard favorite
            double timeStamp = DateTimeToUnixTimeStamp(DateTime.UtcNow); // current time as UNIX time stamp
            var expirationTime = "691200"; // alive time of the token
           
            //string embedMessage = "embed_nonce=" + nonce + "&embed_user_email=" + userInfo + "&embed_timestamp=" + timeStamp + "&expirationTime=" + expirationTime ;
            string embedMessage = "embed_nonce=" + nonce + "&embed_user_email=" + userInfo + "&embed_timestamp=" + timeStamp + "&embed_dashboard_comments=" + "false" + "&embed_widget_comments=" +"false" + "&canSaveView=" + "false" + "&isMarkFavorite=" + isMarkFavorite + "&embed_dashboard_views_edit=" + "true" + "&embed_dashboard_views=" + "true" + "&embed_dashboard_favorite=" + "true" + "&embed_datasource_filter=" + "&&Parameter1=QUICK";

            string signature = SignURL(embedMessage.ToLower(), secretCode);
            string embedSignature = embedMessage.ToLower() + "&embed_signature=" + signature;
            var embedUrl = dashboardUrl + embedSignature;
            var iframe = "<iframe src='" + embedUrl + "' id='dashboard-frame' width='1200px' height='600px' allowfullscreen frameborder='0'></iframe>";
            var filePath = @"..\..\..\embed.html"; // file named embed will be created in the extracted location in which the embed URL will be maintained
            File.WriteAllText(filePath, iframe);
            string url = filePath;
            Process.Start("chrome.exe", url); // By default, the embed dashboard will be rendered in Google Chrome. Can update the browser as you wish
        }
        static string SignURL(string embedMessage, string secretcode)
        {
            var encoding = new UTF8Encoding();
            var keyBytes = encoding.GetBytes(secretcode);
            var messageBytes = encoding.GetBytes(embedMessage);
            using (var hmacsha1 = new HMACSHA256(keyBytes))
            {
                var hashMessage = hmacsha1.ComputeHash(messageBytes);
                return Convert.ToBase64String(hashMessage);
            }
        }

        static double DateTimeToUnixTimeStamp(DateTime dateTime)
        {
            DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            long unixTimeStampInTicks = (dateTime.ToUniversalTime() - unixStart).Ticks;
            return unixTimeStampInTicks / TimeSpan.TicksPerSecond;
        }
    }
}
