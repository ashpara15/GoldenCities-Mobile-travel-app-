﻿using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace GoldenCities
{
    public partial class GoldenCitiesPage : ContentPage
    {
        public GoldenCitiesPage()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(GoldenCitiesPage)}: ctor");
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void Handle_ClickedLogin(object sender, System.EventArgs e)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(Handle_ClickedLogin)}");
            Navigation.PushAsync(new LoginPage());
        }

        void Handle_ClickedRegister(object sender, System.EventArgs e)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(Handle_ClickedRegister)}");
            Navigation.PushAsync(new RegisterActivity());
        }



    }
}
