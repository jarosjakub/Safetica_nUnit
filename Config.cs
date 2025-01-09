using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Safetica_nUnit;

namespace Safetica_nUnit
{
    public static class Config
    {
        //setup constants
        public static string url = "https://teams.microsoft.com/v2/";
        public static string email = "qa@safeticaservices.onmicrosoft.com";
        public static string password = "automation.Safetica2004";

        //login xpaths
        public static string xpath_email = "/html/body/div/form[1]/div/div/div[2]/div[1]/div/div/div/div/div[1]/div[3]/div/div/div/div[2]/div[2]/div/input[1]";
        public static string xpath_next = "/html/body/div/form[1]/div/div/div[2]/div[1]/div/div/div/div/div[1]/div[3]/div/div/div/div[4]/div/div/div/div/input";
        public static string xpath_password = "/html/body/div/form[1]/div/div/div[2]/div[1]/div/div/div/div/div/div[3]/div/div[2]/div/div[3]/div/div[2]/input";
        public static string xpath_login = "//*[@id=\"idSIButton9\"]";
        public static string xpath_stayYes = "/html/body/div/form/div/div/div[2]/div[1]/div/div/div/div/div/div[3]/div/div[2]/div/div[3]/div[2]/div/div/div[2]/input";
        public static string xpath_chat = "/html/body/div[1]/div/div/div/div[4]/div/div/div[2]/div[1]/div[1]/div/div[1]/div[2]/div/div/div[3]/div[1]/span";

        //message xpaths
        public static string xpath_message_input = "/html/body/div[1]/div/div/div/div[7]/div/div/div[3]/div/div[3]/div/div[2]/div/div[2]/div[1]/div";
        public static string xpath_message_send = "/html/body/div[1]/div/div/div/div[7]/div/div/div[3]/div/div[3]/div/div[2]/div/div[2]/div[2]/div[2]/button[2]";
        
        //attachment xpaths
        public static string xpath_plus_button = "/html/body/div[1]/div/div/div/div[7]/div/div/div[3]/div/div[3]/div/div[2]/div/div[2]/div[2]/div[1]/button[3]";
        public static string xpath_attach_file = "/html/body/div[10]/div/div[2]/div/div/div[2]/div/div/div/ul/li[1]/div/div/div/div/div/div/div/div[2]/span";
        public static string xpath_cloud_file = "/html/body/div[10]/div/div[2]/ul/li[1]/a/span[2]/span";
        public static string xpath_iframe = "/html/body/div[10]/div/div[2]/div/div/div/iframe";
        public static string xpath_my_files = "/html/body/div/div/div/div/div[2]/div/div[1]/div[2]/div/div/div/div/nav/div[1]/div/ul/li[1]";
        public static string xpath_pdffile = "/html/body/div[1]/div/div/div/div[2]/div/div[2]/main/div/div/div/div/div/div/div/div/div/div[2]/div/div/div/div[2]/div/div/div[1]/div/div";
        public static string xpath_txtfile = "/html/body/div[1]/div/div/div/div[2]/div/div[2]/main/div/div/div/div/div/div/div/div/div/div[2]/div/div/div/div[3]/div/div/div[1]/div/div";
        public static string xpath_xlsxfile = "/html/body/div[1]/div/div/div/div[2]/div/div[2]/main/div/div/div/div/div/div/div/div/div/div[2]/div/div/div/div[4]/div/div/div[1]/div/div";
        public static string xpath_attach_button = "/html/body/div[1]/div/div/div/div[2]/div/div[2]/div[2]/div/div[2]/div/div/div/div[1]/button";
        public static string xpath_attachment_send = "/html/body/div[1]/div/div/div/div[7]/div/div/div[3]/div/div[3]/div/div[3]/div[3]/button[2]/div/span";

        //logout xpaths
        public static string xpath_user_icon = "/html/body/div[1]/div/div/div/div[1]/div/div/div[2]/div[3]/div/button";
        public static string xpath_logout = "/html/body/div[10]/div/div[2]/div[1]/div[3]/button/span";
        public static string xpath_dialog_logout = "/html/body/div[10]/div[2]/div[2]/div[2]/button[2]";


    }
}
