using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App01_LayoutXF
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void GoPaginaAbsolute(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Absolute.AbsolutePage());
        }
        private void GoPaginaRelative(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Relative.RelativePage());
        }
        private void GoPaginaGrid(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Grid.GridPage());
        }
        private void GoPaginaScroll(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Scroll.ScrollPage());
        }
        private void GoPaginaStack(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Stack.StackPage());
        }
    }
}
