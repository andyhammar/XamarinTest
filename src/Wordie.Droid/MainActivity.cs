using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using CommonLib;

namespace Wordie.Droid
{
    [Activity(Label = "Wordie.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            var button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += async delegate
            {
                //button.Text = string.Format("{0} clicks!", count++);
                var fetcher = new WebFetcher();
                var word = await fetcher.GetWord();

                var textView = FindViewById<TextView>(Resource.Id.MyTextView);
                textView.Text = word;
            };

        }
    }
}

