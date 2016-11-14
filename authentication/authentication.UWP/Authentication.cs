using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(authentication.UWP.Authentication))]


namespace authentication.UWP
{
	class Authentication : IAuthenticator
	{
	}
}
