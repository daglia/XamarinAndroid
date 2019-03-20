using System;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace XamarinAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, View.IOnClickListener
    {
        private Button btn1, btn2;
        private Switch swch1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            //btn1 = FindViewById<Button>(Resource.Id.button1);
            //btn2 = FindViewById<Button>(Resource.Id.button2);
            //btn1.Click += Btn1_Click;
            //btn1.SetOnClickListener(this);
            //btn2.SetOnClickListener(this);
        }

        private void Btn1_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "Button 1e tıklandi", ToastLength.Long).Show();
        }

        private int a = 0;
        public void OnClick(View v)
        {
            Button btn = (Button)v;

            if (btn.Id == 1)
            {
                Toast.MakeText(this, "Button 1e tıklandi", ToastLength.Long).Show();
                try
                {
                    int b = a / a;
                }
                catch (Exception ex)
                {
                    Log.Error("Bölmede Hata", ex.Message);
                }
            }
            else
            {
                Toast.MakeText(this, "Button 2ye tıklandi", ToastLength.Long).Show();
            }
        }
    }
}