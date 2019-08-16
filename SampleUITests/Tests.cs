using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SampleUITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            //app = ConfigureApp.Android.StartApp();
            app = AppInitializer.StartApp(platform);
            //app.Repl();
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            app.Screenshot("Welcome screen.");
            Assert.IsTrue(results.Any());
        }

        [Test]
        public void TwoClicks()
        {
            
            app.Tap(c => c.Marked("Click Me!"));
            app.Tap(c => c.Class("ButtonRenderer"));
            //app.Repl();
            //AppResult[] results = app.WaitForElement(c => c.Marked("You clicked 2 times."));
            Assert.AreEqual("You clicked 2 times.",app.Query(c => c.Class("ButtonRenderer")).First().Text);
        }

    }
}
