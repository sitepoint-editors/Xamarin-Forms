using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace SitePointApp
{
    public class ArticleContentPage : ContentPage
    {
        private WebView _webView;
        public ArticleContentPage()
        {
            Content = _webView = new WebView();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Title = Article.Title;
            _webView.Source = new UrlWebViewSource {Url = Article.ArticleUrl};
        }

        public Article Article { get; set; } 
    }
}
