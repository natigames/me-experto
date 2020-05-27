using System;
using System.Collections.Generic;
using experto.Model;
using Xamarin.Forms;
using SQLite;

namespace experto
{
    public partial class NewPage : ContentPage
    {
        public NewPage()
        {
            InitializeComponent();
        }

        void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            Post post = new Post()
            {
                Experience = experienceEntry.Text
            };

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                int rows = conn.Insert(post);

                if (rows > 0)
                    DisplayAlert("success", "Experince succesfully added", "ok");
                else
                    DisplayAlert("failure", "unable to insert", "ok");
            }


        }
    }
}
