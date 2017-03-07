using Microsoft.Identity.Client;
using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace B2CAppMobile
{
    public class App : Application
    {


        public static PublicClientApplication PublicClientApplication;

        // Provided Authentication Tenant
        public static string Authority = "https://login.microsoftonline.com/b2ccharm.onmicrosoft.com";
        public static string ClientId = "7393f3b7-7c95-490e-b854-5cae8b7d160a";
        public static ExternalLoginInfo[] ExternalLogins;
        public static string[] Scope = { ClientId };


        /*
        // Elkay Test Authentication Tenant
        public static string Authority = "https://login.microsoftonline.com/BlueMetalElkay.onmicrosoft.com/";
        public static string ClientId = "377cd8c6-a9df-4a55-aac5-8055475a550f";
        public static ExternalLoginInfo[] ExternalLogins;
        public static string[] Scope = { ClientId };
        */



        public App()
        {
            
            try
            {
                PublicClientApplication = new PublicClientApplication(Authority, ClientId);
                InitializeExternalLogins();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("PublicClientAppliation initialization exception: " + ex.ToString());
            }
   

            var mainPage = new MainPage();
            MainPage = new NavigationPage(mainPage);


        }





        private static ExternalLoginInfo CreatePolicy(string authenticationType, string caption)
        {
            return new ExternalLoginInfo(
                Authority,
                authenticationType,
                caption,
                Scope);
        }

        private static void InitializeExternalLogins()
        {
            // Provided Authentication Policies
            ExternalLogins = new[]
            {
                CreatePolicy("B2C_1_wingtiptoyssignup", "A basic sign-up or sign-in policy for local, Facebook, Google, and Microsoft accounts"),
                CreatePolicy("B2C_1A_SignupWithRest", "An advanced sign-up or sign-in policy that integrates with a REST API"),
                CreatePolicy("B2C_1A_SignupWithRestAndIdp", "An advanced sign-up or sign-in policy that integrates with a custom identity provider")
            };

            /*
            // Elkay Test Authentication Policies
            ExternalLogins = new[]
            {
                CreatePolicy("B2C_1_DefaultSignInSignUp", "A basic sign-up or sign-in policy for local, Facebook, Google, and Microsoft accounts")
            };
            */
        }






        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
