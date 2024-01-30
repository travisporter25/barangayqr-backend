using AspNet.Security.OpenIdConnect.Extensions;
using AspNet.Security.OpenIdConnect.Primitives;
using AspNet.Security.OpenIdConnect.Server;
using BarangayQR.Domain.Models;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace BarangayQR.OAuth.OAuthorization
{
    public class AuthorizationProvider : OpenIdConnectServerProvider
    {
        User user = null;
        public AuthorizationProvider()
        {

        }

        public override Task ValidateTokenRequest(ValidateTokenRequestContext context)
        {
            if (!context.Request.HasParameter("grant_type"))
            {
                context.Reject(
                    error: OpenIdConnectConstants.Errors.InvalidRequest,
                    description: "Grant type is missing"
                );
            }
            else
            {
                string grantType = context.Request.GetParameter("grant_type").Value.ToString().ToLower();
                string userName = null;
                string password = null;
            }

            if (!context.Request.HasParameter("username"))
            {
                context.Reject(
                    error: OpenIdConnectConstants.Errors.InvalidRequest,
                    description: "Username parameter is missing"
                );
                return Task.FromResult(0);
            }
            else
            {
                string grantType = context.Request.GetParameter("username").Value.ToString().ToLower();
                string userName = null;
                string password = null;
            }

            if (!context.Request.HasParameter("password"))
            {
                context.Reject(
                    error: OpenIdConnectConstants.Errors.InvalidRequest,
                    description: "Username parameter is missing"
                );
                return Task.FromResult(0);
            }
            else
            {
                string grantType = context.Request.GetParameter("password").Value.ToString().ToLower();
                string userName = null;
                string password = null;
            }


        }
        public override Task HandleTokenRequest(HandleTokenRequestContext context)
        {
            if (user != null)
            {
                var identity = new ClaimsIdentity("ASOSOAuth");
                identity.AddClaim(OpenIdConnectConstants.Claims.Subject, user.UserId.ToString());
                identity.AddClaim(OpenIdConnectConstants.Claims.Subject, user.BranchId.ToString(), OpenIdConnectConstants.Destinations.AccessToken);
                identity.AddClaim(OpenIdConnectConstants.Claims.Subject, user.ClientId.ToString());

                var ticket = new AuthenticationTicket(new ClaimsPrincipal(identity), new AuthenticationProperties(), "ASOSOAuth");
                context.Validate(ticket);
            }

            return Task.FromResult(0);
            
        }
    }
}
