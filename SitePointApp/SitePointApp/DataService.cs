using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitePointApp
{
    public static class DataService
    {
        public static IList<Article> GetArticles()
        {
            return new List<Article>
            {
                new Article
                {
                    Title = "Quick Tip: Installing React",
                    Author = "Jon Shaffer",
                    ArticleUrl = "https://www.sitepoint.com/quick-tip-installing-react-native/"
                },
                new Article
                {
                    Title = "Displaying Collections of Items on Windows Phone",
                    Author = "Deivi Taka",
                    ArticleUrl = "https://www.sitepoint.com/displaying-collections-of-items-on-windows-phone/"
                },
                new Article
                {
                    Title = "Using C and C++ Code in an Android App with the NDK",
                    Author = "Rico Zuñiga",
                    ArticleUrl = "https://www.sitepoint.com/using-c-and-c-code-in-an-android-app-with-the-ndk/"
                },
                new Article
                {
                    Title = "Using Classy to Create Stylesheets for Native iOS Apps",
                    Author = "Chris Ward",
                    ArticleUrl = "https://www.sitepoint.com/using-classy-to-create-stylesheets-for-native-ios-apps/"
                },
                new Article
                {
                    Title = "Fast, Lightweight Data Storage for Cordova Apps with LokiJS",
                    Author = "Wern Ancheta",
                    ArticleUrl = "https://www.sitepoint.com/fast-lightweight-data-storage-for-cordova-apps-with-lokijs/"
                },
                new Article
                {
                    Title = "How to Make Your Web App Smarter with Image Recognition",
                    Author = "Patrick Catanzariti",
                    ArticleUrl = "https://www.sitepoint.com/how-to-make-your-web-app-smarter-with-image-recognition/"
                }
            };
        }
    }
}
