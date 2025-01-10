using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Safetica_nUnit;
using System;
using static OpenQA.Selenium.BiDi.Modules.BrowsingContext.Locator;
using Action = Safetica_nUnit.CommonTest;

namespace Safetica_nUnit
{
    [TestFixture] 
    public class TeamsChromeTest()
    {
        [Test]
        public void Test()
        {
            CommonTest.Setup("Test");
            Log.LogThis("test");
            Thread.Sleep(1000);
            Log.LogThis("test2");
            Log.LogThis("test3");
        }


        [Test] 
        public void Attach1FileFromOnedrive()
        {
            CommonTest.Setup("Attach1FileFromOnedrive");
            CommonTest.StartChromeDriver();

            try
            {
            CommonTest.Login();
                Log.LogThis("login succesful");
            }
            catch (Exception e)
            {
                Log.LogThis("login failed");
                Log.LogThis(e.Message);
            }
            
            CommonTest.SwichChat();

            CommonTest.Attach(1);

            CommonTest.Logout();
            CommonTest.QuitDriver();
        }

        [Test] 
        public void Send1Message()
        {
            CommonTest.StartChromeDriver();
            CommonTest.Login();
            CommonTest.SwichChat();

            CommonTest.SendMessage("Lorem ipsum dolor sit amet");

            CommonTest.Logout();
            CommonTest.QuitDriver();
        }
    }
    public class TeamsFirefoxTest()
    {
        [Test] 
        public void Attach2ilesFromOnedrive()
        {
            CommonTest.StartFirefoxDriver();
            CommonTest.Login();
            CommonTest.SwichChat();

            CommonTest.Attach(2);

            CommonTest.Logout();
            CommonTest.QuitDriver();
        }

        [Test] 
        public void Send3Messages()
        {
            CommonTest.StartFirefoxDriver();
            CommonTest.Login();
            CommonTest.SwichChat();

            CommonTest.SendMessage("Lorem ipsum");
            CommonTest.SendMessage("dolor sit amet");
            CommonTest.SendMessage("consectetur adipiscing elit");

            CommonTest.Logout();
            CommonTest.QuitDriver();
        }
    }
}