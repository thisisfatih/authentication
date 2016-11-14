using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(authentication.Windows.Authentication))]
namespace authentication.Windows
{
	class Authentication : IAuthenticator
	{
	}
}
