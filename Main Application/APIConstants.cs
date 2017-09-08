using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_Music_Video_Downloader__W10_
{
    public class APIConstants
    {
        public static string HockeyAppAPIKey
        {
            get {
                throw new Exception("Please get the HockeyApp API key from https://hockeyapp.net/#s!!!"); // comment out this line for the one below.
                //return "Please get the HockeyApp API key from https://hockeyapp.net/#s!!!";
            }
            set { }
        }


        public static string[] YouTubeAPIKeys
        {
            get {
                return new string[] { "AZzaSyA8eiZmM1FaDVj1y-df2KTyQ_vz_y9M39w" }; // official api key}; 
            }
            set { }
        }
        public static string[] YouTubeClientSecrets
        {
            get
            {
                return new string[] { "Zqfi2UEREF545th45ty4hFWxPDMcem" }; // official api key}; 
            }
            set { }
        }

        public static string[] YouTubeClientIds
        {
            get
            {
                return new string[] { "XXXXXXXXXXXXXX-XXXXXXXXXXXXXXXc.apps.googleusercontent.com" }; // official api key}; 
            }
            set { }
        }
    }
}
