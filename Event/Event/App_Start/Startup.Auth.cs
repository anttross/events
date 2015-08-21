using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Facebook;
using Owin;

namespace Event
{
    public partial class Startup
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Enable the application to use a cookie to store information for the signed in user
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });
            // Use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Uncomment the following lines to enable logging in with third party login providers
            //app.UseMicrosoftAccountAuthentication(
            //    clientId: "",
            //    clientSecret: "");

            //app.UseTwitterAuthentication(
            //   consumerKey: "",
            //   consumerSecret: "");

            var facebookAuthenticationOptions = new FacebookAuthenticationOptions()
            {
                AppId = "1610907412530093",
                AppSecret = "c1bf0fa3ed887572a54a21a3ab2f2082"
            };
            facebookAuthenticationOptions.Scope.Add("email");
            app.UseFacebookAuthentication(facebookAuthenticationOptions);

            app.UseGoogleAuthentication(
                clientId: "327546397623-h7gvq4pt4llsasl65pmd0osuddim2r8s.apps.googleusercontent.com",
                clientSecret: "kGGXUiz8aBM1B8X0g-r8iFHT");
        }
    }
}