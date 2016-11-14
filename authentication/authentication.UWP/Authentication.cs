using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(authentication.UWP.Authentication))]


namespace authentication.UWP
{
	public sealed partial class Authentication : IAuthenticator
	{
		public async Task<MobileServiceClient> AuthenticateFB()
		{
			try
			{
				var msc = new MobileServiceClient(keys.mobileServiceAdressASP);
				await msc.LoginAsync(MobileServiceAuthenticationProvider.Facebook,
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
				await msc.LoginAsync(MobileServiceAuthenticationProvider.Twitter,
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
				await msc.LoginAsync(MobileServiceAuthenticationProvider.MicrosoftAccount,
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
				await msc.LoginAsync(MobileServiceAuthenticationProvider.Google,
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
