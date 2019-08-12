using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SampleUITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.ApkFile("C:/Users/Sayali.Sheode/Desktop/com.companyname.firstxamarinapp.apk").StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}