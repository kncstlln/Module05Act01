using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module05Act01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            mySwitch.Toggled += MySwitch_Toggled;
        }

        private void MySwitch_Toggled(object sender, ToggledEventArgs e)
        {
            // Handle the Toggled event here
            if (e.Value)
            {
                myLabel.Text = "Switch is ON";
            }
            else
            {
                myLabel.Text = "Switch is OFF";
            }
        }
    }
}