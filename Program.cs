using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Safetica_nUnit;
using System;
using System.Reflection;
using static OpenQA.Selenium.BiDi.Modules.BrowsingContext.Locator;
using Action = Safetica_nUnit.CommonTest;

namespace Safetica_nUnit
{
    [TestFixture] 
    public class TeamsChromeTest()
    {
        [SetUp]
        public void SetUp()
        {
            CommonTest.Setup(TestContext.CurrentContext.Test.Name);
            CommonTest.StartChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
            {
                CommonTest.Logout();
                CommonTest.QuitDriver();
                CommonTest.Passed(TestContext.CurrentContext.Test.Name);
            }
            else
            {
                CommonTest.QuitDriver();
                CommonTest.Failed(TestContext.CurrentContext.Test.Name);
            }
        }

        [Test] 
        public void Attach1FileFromOnedrive()
        {
            CommonTest.Login();
            CommonTest.SwichChat();
            CommonTest.Attach(1);
            CommonTest.Passed(TestContext.CurrentContext.Test.Name);
        }

        [Test] 
        public void Send1Message()
        {
            CommonTest.Login();
            CommonTest.SwichChat();

            CommonTest.SendMessage("Lorem ipsum dolor sit amet");
        }
    }

    [TestFixture]
    public class TeamsFirefoxTest()
    {
        [SetUp]
        public void SetUp()
        {
            CommonTest.Setup(TestContext.CurrentContext.Test.Name);
            CommonTest.StartFirefoxDriver();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
            {
                CommonTest.Logout();
                CommonTest.QuitDriver();
                CommonTest.Passed(TestContext.CurrentContext.Test.Name);
            }
            else
            {
                CommonTest.QuitDriver();
                CommonTest.Failed(TestContext.CurrentContext.Test.Name);
            }
        }

        [Test] 
        public void Attach2FilesFromOnedrive()
        {
            CommonTest.Login();
            CommonTest.SwichChat();

            CommonTest.Attach(2);
        }

        [Test] 
        public void Send3Messages()
        {
            CommonTest.Login();
            CommonTest.SwichChat();

            CommonTest.SendMessage("Lorem ipsum");
            CommonTest.SendMessage("dolor sit amet");
            CommonTest.SendMessage("consectetur adipiscing elit");
        }
    }
}