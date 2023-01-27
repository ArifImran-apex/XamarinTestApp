using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit.UI.Views.Options;
using Xamarin.Forms;

namespace XamarinTestApp
{
    public partial class MainPage : BaseContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var messageOptions = new MessageOptions
            {
                Message = "Toast with Padding and round corner",
                Foreground = Color.White,
                Font = Font.SystemFontOfSize(15,FontAttributes.Italic),
                Padding = new Thickness(20)
            };

            var options = new ToastOptions
            {
                MessageOptions = messageOptions,
                CornerRadius = new Thickness(40, 40, 40, 40),
                
                BackgroundColor = Color.FromHex("#CC0000")
            };
            Application.Current.MainPage.DisplayToastAsync(options);            
        }
    }
}
