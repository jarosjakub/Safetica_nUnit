using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safetica_nUnit
{
    public static class CommonTest
    {
        public static void Setup(string test)
        {
            Log.Setup();
            Log.LogThis("Executing test " + test);
        }

        public static void Passed(string test)
        {
            Log.LogThis("Test " + test + " passed");
        }

        public static void Failed(string test)
        {
            Log.LogThis("Test " + test + " failed");
        }


        public static void StartChromeDriver()
        {
            Driver.driver = new ChromeDriver();
        }

        public static void StartFirefoxDriver()
        {
            FirefoxProfile profile = new FirefoxProfile();
            profile.SetPreference("network.cookie.cookieBehavior", 0); 
            profile.SetPreference("privacy.cookieBanner.showDefault", false); 
            profile.SetPreference("privacy.cookieBanner.showGlobal", false); 
            profile.SetPreference("dom.webnotifications.enabled", false); 

            FirefoxOptions options = new FirefoxOptions();
            options.Profile = profile;

            Driver.driver = new FirefoxDriver(options);
        }


        public static void Login() 
        {
            try
            {
                Driver.driver.Navigate().GoToUrl(Config.url);

                Thread.Sleep(5000);

                IWebElement emailBox = Driver.driver.FindElement(By.XPath(Config.xpath_email));
                IWebElement nextButton = Driver.driver.FindElement(By.XPath(Config.xpath_next));

                emailBox.SendKeys(Config.email);
                nextButton.Click();

                Thread.Sleep(5000);
    
                IWebElement passwordBox = Driver.driver.FindElement(By.XPath(Config.xpath_password));
                IWebElement loginButton = Driver.driver.FindElement(By.XPath(Config.xpath_login));

                passwordBox.SendKeys(Config.password);
                loginButton.Click();

                Thread.Sleep(5000);

                IWebElement stayButtonYes = Driver.driver.FindElement(By.XPath(Config.xpath_stayYes));

                stayButtonYes.Click();

                Thread.Sleep(10000);

                Log.LogThis("login successful");
            }
            catch (Exception e)
            {
                Log.LogThis("login failed: " + e.Message);
                Assert.Fail();
            }
        }

        public static void SwichChat()
        {
            try
            {
                IWebElement chat = Driver.driver.FindElement(By.XPath(Config.xpath_chat));
                chat.Click();


                IWebElement safeticaQA = Driver.driver.FindElement(By.XPath(Config.xpath_safeticaQA));
                safeticaQA.Click();

                Log.LogThis("chat navigation successful");
            }

            catch (Exception e)
            {
                Log.LogThis("chat navigation failed: " + e.Message);
                Assert.Fail();
            }
        }

        public static void SendMessage(string message)
        {
            try
            {

            IWebElement messageBox = Driver.driver.FindElement(By.XPath(Config.xpath_message_input));
            IWebElement messageSendButton = Driver.driver.FindElement(By.XPath(Config.xpath_message_send));

            messageBox.SendKeys(message);
            messageSendButton.Click();

            Log.LogThis("sending message successful");
            }

            catch (Exception e)
            {
                Log.LogThis("sending message failed: " + e.Message);
                Assert.Fail();
            }
        }

        public static void Attach(int count)
        {
            try
            {
                IWebElement plusButton = Driver.driver.FindElement(By.XPath(Config.xpath_plus_button));
                plusButton.Click();

                Thread.Sleep(2000);

                IWebElement attachButton = Driver.driver.FindElement(By.XPath(Config.xpath_attach_file));
                attachButton.Click();

                Thread.Sleep(2000);

                IWebElement attachCloudFileButton = Driver.driver.FindElement(By.XPath(Config.xpath_cloud_file));
                attachCloudFileButton.Click();

                Thread.Sleep(2000);

                IWebElement iframe = Driver.driver.FindElement(By.XPath(Config.xpath_iframe));
                Driver.driver.SwitchTo().Frame(iframe);

                Thread.Sleep(5000);

                IWebElement myFilesButton = Driver.driver.FindElement(By.XPath(Config.xpath_my_files));
                myFilesButton.Click();

                Thread.Sleep(2000);
                
                IWebElement pdfCheckbox = Driver.driver.FindElement(By.XPath(Config.xpath_pdffile));
                IWebElement txtCheckbox = Driver.driver.FindElement(By.XPath(Config.xpath_txtfile));
                IWebElement xlsxCheckbox = Driver.driver.FindElement(By.XPath(Config.xpath_xlsxfile));


                switch (count)
                {
                    case 1:
                        pdfCheckbox.Click();
                        break;
                    case 2:
                        pdfCheckbox.Click();
                        txtCheckbox.Click();
                        break;
                    case 3:
                        pdfCheckbox.Click();
                        txtCheckbox.Click();
                        xlsxCheckbox.Click();
                        break;
                    
                }

                IWebElement attachFileButton = Driver.driver.FindElement(By.XPath(Config.xpath_attach_button));
                attachFileButton.Click();

                Thread.Sleep(2000);

                Driver.driver.SwitchTo().DefaultContent();

                IWebElement attachmentSendButton = Driver.driver.FindElement(By.XPath(Config.xpath_attachment_send));
                attachmentSendButton.Click();

                Log.LogThis("attaching successful");
            }

            catch (Exception e)
            {
                Log.LogThis("attaching failed: " + e.Message);
                Assert.Fail();
            }
        }

        public static void Logout()
        {
            try
            {
                IWebElement userButton = Driver.driver.FindElement(By.XPath(Config.xpath_user_icon));
                userButton.Click();

                IWebElement logoutButton = Driver.driver.FindElement(By.XPath(Config.xpath_logout));
                logoutButton.Click();

                IWebElement logoutDialogButton = Driver.driver.FindElement(By.XPath(Config.xpath_dialog_logout));
                logoutDialogButton.Click();

                Log.LogThis("logout successful");
            }

            catch (Exception e)
            {
                Log.LogThis("logout failed: " + e.Message);
                Assert.Fail();
            }

        }
        public static void QuitDriver()
        {
            try
            {
                Driver.driver.Quit();
                Log.LogThis("driver termination successful");
            }

            catch (Exception e)
            {
                Log.LogThis("driver termination failed: " + e.Message);
                Assert.Fail();
            }

        }
    }
}
