﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace experto
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            //InitializeComponent();
            Map map = new Map
            {
                IsShowingUser = true
            };
            Content = map;

        }
    }
}
