using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace authentication
{
	public class App : Application
	{
		public static MobileServiceClient msc { get; set; }

		public App()
		{
			var fb = new Button();
			fb.Text = "Facebook Login";
			fb.Clicked += fbClicked;

			var tw = new Button();
			tw.Text = "Twitter Login";
			tw.Clicked += twClicked;

			var gp = new Button();
			gp.Text = "Google Login";
			gp.Clicked += gpClicked;

			var ms = new Button();
			ms.Text = "Microsoft Login";
			ms.Clicked += msClicked;

			var logout = new Button();
			logout.Text = "Logout";
			logout.Clicked += logoutClicked;

			// The root page of your application
			var content = new ContentPage
			{
				Title = "Authentication",
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "Xamarin Forms Authentication Sample!"
						},
						fb,tw,gp,ms,
						logout,
					}
				}
			};

			MainPage = new NavigationPage(content);
		}
		private async void msClicked(object sender, EventArgs e)
		{
			await DependencyService.Get<IAuthenticator>().AuthenticateMS();
		}
		private async void gpClicked(object sender, EventArgs e)
		{
			await DependencyService.Get<IAuthenticator>().AuthenticateGP();
		}
		private async void twClicked(object sender, EventArgs e)
		{
			await DependencyService.Get<IAuthenticator>().AuthenticateTW();
		}
		private async void fbClicked(object sender, EventArgs e)
		{
			await DependencyService.Get<IAuthenticator>().AuthenticateFB();
		}

		private async void logoutClicked(object sender, EventArgs e)
		{
			if (msc!=null)
			{
				await msc.LogoutAsync();
			}
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
