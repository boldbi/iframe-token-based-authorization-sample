﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmbedDashboardWithTokenAuthentication
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Variable declaration to form the embed URL 
            var dashboardUrl = "https://demo.admin.com/bi/en-us/dashboards/af43fb72-1e4e-45d5-9783-2a905a928792/Sales/Northwind%20Traders%20Sales%20Analysis(114)?"; // URL of the dashboard to be embedded. Add '? or &' at the end of the URL based on your dashboard URL\r\n"; // URL of the dashboard to be embedded. Add '? or &' at the end of the URL based on your dashboard URL
   
            // Mandatory Parameters to embed the dashboard with token based authentication.
            var nonce = Guid.NewGuid().ToString(); // To generate random GUID string
            var userEmail = "demo@admin.com"; // User email id.
            double timeStamp = Math.Round((DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds); // Current time as UNIX time stamp
            string embedSecretKey = "TVGajVPZ5M89IPfFqSnszgAzVl27Jbkd";  // Secret key generated in the Bold BI application

            // Optional dashboard embed parameter
            bool canSaveView = true; // To show or hide the Save and SaveAs icon in the filter overview.
            bool hasViews = true; // To show or hide the views icon from the toolbar.
            bool hasExport = true; // To show or hide the export icon from the toolbar.
            bool hasDashboardComments = true; // To show or hide the dashboard comments icon from the toolbar.
            bool isMarkFavorite = true; // To show or hide the dashboard favorite icon from the toolbar. 
            var expirationTime = "518400"; // Alive time of the token(Expiration time is 518400s)

            // Variable declaration to form the signature for the embed URL 
            string embedParameters = "embed_nonce=" + nonce + "&embed_user_email=" + userEmail + "&embed_dashboard_views_edit=" + canSaveView + "&embed_dashboard_views=" + hasViews + "&embed_dashboard_export=" + hasExport + "&embed_dashboard_comments=" + hasDashboardComments + "&embed_dashboard_favorite=" + isMarkFavorite + "&embed_timestamp=" + timeStamp + "&embed_expirationtime=" + expirationTime;

            string signature = SignURL(embedParameters, embedSecretKey);
            string embedSignature = embedParameters + "&embed_signature=" + signature;
            var embedUrl = dashboardUrl + embedSignature;
            var iframe = "<iframe src='" + embedUrl + "' id='dashboard-frame' width='100%' height='100%' allowfullscreen frameborder='0'></iframe>";
            var filePath = System.AppDomain.CurrentDomain.BaseDirectory + "embed.html"; // file named embed will be created in the extracted location in which the embed URL will be maintained
            File.WriteAllText(filePath, iframe);
            string url = filePath;
            Process.Start("chrome.exe", url); // By default, the embed dashboard will be rendered in Google Chrome. Can update the browser as you wish
        }

        // This method generates the hashed signature using the HMACSHA256 algorithm, which should be appended to the existing iframe URL as a query parameter named ‘embed_signature’.
        static string SignURL(string embedParameters, string embedSecretKey)
        {
            var encoding = new UTF8Encoding();
            var keyBytes = encoding.GetBytes(embedSecretKey);
            var messageBytes = encoding.GetBytes(embedParameters);
            using (var hmacsha1 = new HMACSHA256(keyBytes))
            {
                var hashMessage = hmacsha1.ComputeHash(messageBytes);
                return Convert.ToBase64String(hashMessage);
            }
        }
    }
}