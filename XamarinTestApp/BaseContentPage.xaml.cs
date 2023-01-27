using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BaseContentPage : ContentPage
    {
        private bool absoluteLayoutWrapped;
        public BaseContentPage()
        {
            InitializeComponent();
        }

        protected override void OnChildAdded(Element child)
        {
            base.OnChildAdded(child);
            if (!absoluteLayoutWrapped)
            {
                absoluteLayoutWrapped = true;
                var originalView = this.Content;
                var parentAbsLayout = new AbsoluteLayout();
                parentAbsLayout.Children.Add(originalView);
                var balControl = new BalloonControl();
                AbsoluteLayout.SetLayoutFlags(balControl, AbsoluteLayoutFlags.All);
                AbsoluteLayout.SetLayoutBounds(balControl, new Rectangle(0.5,0.9,0.5,0.1));
                parentAbsLayout.Children.Add(balControl);
                this.Content = parentAbsLayout;
            }
        }
    }
}