using System;
using Xamarin.Forms;

namespace CrossTemplate1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            label.Text = TheClassLibrary.TheClass.Value;
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}
