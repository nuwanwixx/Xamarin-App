using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Face_2_Face.Droid
{
	[Activity (Label = "Face_2_Face.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;
        string password;
        string email;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            TextView textViewEmail = FindViewById<TextView>(Resource.Id.textViewEmail);
            EditText editTextEmail1 = FindViewById<EditText>(Resource.Id.editTextEmail);

            TextView textViewPassword = FindViewById<TextView>(Resource.Id.textViewPassword);
            EditText editTextPassword1 = FindViewById<EditText>(Resource.Id.editTextPassword);


            Button loginBtn = FindViewById<Button>(Resource.Id.BtnLogin);
            Button forgotBtn = FindViewById<Button>(Resource.Id.btnForgot);
            Button signUpBtn = FindViewById<Button>(Resource.Id.BtnSignUp);


            editTextEmail1.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                email = editTextEmail1.Text;
            };

            editTextPassword1.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                password = editTextPassword1.Text;
            };



           loginBtn.Click += (object o ,System.EventArgs e) => {
                if (email == "123@gmail.com" && password == "123")
                    Toast.MakeText(this, "Successful Login", ToastLength.Short).Show();
               else { 
                    Toast.MakeText(this, "Invalid Login", ToastLength.Short).Show();
                   editTextEmail1.Text = ("");
                   editTextPassword1.Text = (""); 
               }

           };

            signUpBtn.Click += delegate { 
                SetContentView(Resource.Layout.SignUp);
               // throw new NotImplementedException();
            };
        }

        
    }
}


