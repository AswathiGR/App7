﻿
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App7;

namespace App7
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ShellPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
