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
                return ConfigureApp.Android.ApkFile(@"C:\Users\Sayali.Sheode\AppData\Local\Xamarin\Mono for Android\Archives\2019-08-16\FirstXamarinApp.Android 8-16-19 9.17 AM.apkarchive\com.companyname.firstxamarinapp.apk").StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}