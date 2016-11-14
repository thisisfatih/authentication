using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;
using System.Threading.Tasks;
using UIKit;

[assembly: Dependency(typeof(authentication.iOS.Authentication))]

namespace authentication.iOS
{
	public class Authentication : IAuthenticator
	{
		public async Task<MobileServiceClient> AuthenticateFB()
		{
			try
			{
				var msc = new MobileServiceClient(keys.mobileServiceAdressASP);
				await (msc)
					.LoginAsync(UIApplication.SharedApplication.KeyWindow.RootViewController, MobileServiceAuthenticationProvider.Facebook,
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
					.LoginAsync(UIApplication.SharedApplication.KeyWindow.RootViewController, MobileServiceAuthenticationProvider.Twitter,
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
					.LoginAsync(UIApplication.SharedApplication.KeyWindow.RootViewController, MobileServiceAuthenticationProvider.MicrosoftAccount,
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
					.LoginAsync(UIApplication.SharedApplication.KeyWindow.RootViewController, MobileServiceAuthenticationProvider.Google,
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
