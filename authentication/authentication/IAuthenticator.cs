using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;

namespace authentication
{
	public interface IAuthenticator
	{
		Task<MobileServiceClient> AuthenticateFB();
		Task<MobileServiceClient> AuthenticateTW();
		Task<MobileServiceClient> AuthenticateMS();
		Task<MobileServiceClient> AuthenticateGP();
	}
}
