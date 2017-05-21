using PixaImagenes.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PixaImagenes
{
    public partial class App : Application
    {
        public static PixaClient PixaClient { get; private set; }

        public App()
        {
            InitializeComponent();
            PixaClient = new PixaClient("5392706-f5e479ff283c464487f394f41");
            var badPage = new MainPage(new DataTemplate(typeof(PixaBadCell))) { Title = "Bad" };
            var standarPage = new MainPage(new DataTemplate(typeof(PixaStandardCell))) { Title = "Meh" };
            var cachedPage = new MainPage(new DataTemplate(typeof(PixaGoodCell))) { Title = "Good" };

            var otherPage = new BigImagePage();

            var tabs = new TabbedPage();
            tabs.Children.Add(badPage);
            tabs.Children.Add(standarPage);
            tabs.Children.Add(cachedPage);
            tabs.Children.Add(otherPage);

            MainPage = tabs;

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
