﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace experto
{
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NewPage());
        }

    }


}
