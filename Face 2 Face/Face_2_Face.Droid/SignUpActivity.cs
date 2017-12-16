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

namespace Face_2_Face.Droid
{
    [Activity(Label = "SignUpActivity")]
    public class SignUpActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SignUp);

            Button submitBtn;
            String signUpName, signUpEmail, signUpPassword, signUpReEnterPassword;

            submitBtn = FindViewById<Button>(Resource.Id.signUpSubmitBtn);

            EditText nameET, emailET, passwordET, reEnterPasswordET;

            nameET = FindViewById<EditText>(Resource.Id.signUpNameText);
            emailET = FindViewById<EditText>(Resource.Id.signUpEmailText);
            passwordET = FindViewById<EditText>(Resource.Id.signUpPasswordText);
            reEnterPasswordET = FindViewById<EditText>(Resource.Id.signUpReEnterPasswordText);

            nameET.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                signUpName = nameET.Text;
            };

            emailET.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                signUpEmail = emailET.Text;
            };
            passwordET.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                signUpPassword = passwordET.Text;
            };
            reEnterPasswordET.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                signUpReEnterPassword = reEnterPasswordET.Text;
            };


            submitBtn.Click += delegate
            {
                SetContentView(Resource.Layout.Main);
            };
        }
    }
}