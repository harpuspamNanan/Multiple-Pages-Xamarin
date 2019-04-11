using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MultiplePages
{
    [Activity(Label = "page2")]
    public class Page2Activity : Activity
    {
        TextView welcomeTv;
        Button backBtn;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.page_2_layout);            // To Connect the Second Page layout with the .cs file

            backBtn = (Button)FindViewById(Resource.Id.backBtn);
            welcomeTv = (TextView)FindViewById(Resource.Id.tvWelcome);
            welcomeTv.Text = "Hey ";

            backBtn.Click += delegate
            {
                
                Intent intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
        }
    }
}