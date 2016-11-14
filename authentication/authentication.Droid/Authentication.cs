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

using Microsoft.WindowsAzure.MobileServices;

[assembly: Xamarin.Forms.Dependency(typeof(authentication.Droid.Authentication))]

namespace authentication.Droid
{
	public class Authentication : IAuthenticator
	{
		public async Task<MobileServiceClient> AuthenticateFB()
		{
			try
			{
				var msc = new MobileServiceClient(keys.mobileServiceAdressASP);
				await (msc)
					.LoginAsync(Forms.Context, MobileServiceAuthenticationProvider.Facebook,
					new Dictionary<string, string>() { { "access_type", "offline" } });
				return msc;
			}
			catch (Exception e)
			{
				var x = e.ToString();
			}
			return null;
		}
		public async Task<MobileServiceClient> AuthenticateTW()
		{
			try
			{
				var msc = new MobileServiceClient(keys.mobileServiceAdressASP);
				await (msc)
					.LoginAsync(Forms.Context, MobileServiceAuthenticationProvider.Twitter,
					new Dictionary<string, string>() { { "access_type", "offline" } });
				return msc;
			}
			catch (Exception e)
			{
				var x = e.ToString();
			}
			return null;
		}
		public async Task<MobileServiceClient> AuthenticateMS()
		{
			try
			{
				var msc = new MobileServiceClient(keys.mobileServiceAdressASP);
				await (msc)
					.LoginAsync(Forms.Context, MobileServiceAuthenticationProvider.MicrosoftAccount,
					new Dictionary<string, string>() { { "access_type", "offline" } });
				return msc;
			}
			catch (Exception e)
			{
				var x = e.ToString();
			}
			return null;
		}
		public async Task<MobileServiceClient> AuthenticateGP()
		{
			try
			{
				var msc = new MobileServiceClient(keys.mobileServiceAdressASP);
				await (msc)
					.LoginAsync(Forms.Context, MobileServiceAuthenticationProvider.Google,
					new Dictionary<string, string>() { { "access_type", "offline" } });
				return msc;
			}
			catch (Exception e)
			{
				var x = e.ToString();
			}
			return null;
		}
	}
}