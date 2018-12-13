using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AtB_Tracker
{
    public class TestPage : ContentPage
    {
        public TestPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Test Xamarin.Forms!" }
                }
            };
        }
    }
}