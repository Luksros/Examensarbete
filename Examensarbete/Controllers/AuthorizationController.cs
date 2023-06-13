using Azure.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph;
using Microsoft.Graph.Models;

namespace Examensarbete.Controllers
{
    public class AuthorizationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public async void GetToken()
        //{
        //    string[] scopes = { "User.Read", "Files.ReadWrite" };
        //    string clientId = "fc292f24-6c9b-41e7-8e41-851763124e8e";
        //    string tenantId = "common";

        //    InteractiveBrowserCredentialOptions interactiveBrowserCredentialOptions = new()
        //    {
        //        ClientId = clientId,
        //        TenantId = tenantId,
        //        AuthorityHost = AzureAuthorityHosts.AzurePublicCloud,
        //        RedirectUri = new Uri("http://localhost:5024"),
        //    };
        //    InteractiveBrowserCredential interactiveBrowserCredential = new(interactiveBrowserCredentialOptions);

        //    GraphServiceClient graphClient = new GraphServiceClient(interactiveBrowserCredential, scopes);

        //    User me = await graphClient.Me.GetAsync();
        //}
    }
}
