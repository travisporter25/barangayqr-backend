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
        //User user = null;
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
                string grantType = null;
                string userName = context.Request.Username;
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
                string grantType = null;
                string userName = null;
                string password = context.Request.Password;
            }

            context.Skip();
            return Task.FromResult(0);

        }
        public override Task HandleTokenRequest(HandleTokenRequestContext context)
        {
            //if (user != null)
            //{
            User user = new User 
            {
                UserId = Guid.NewGuid(),
                BranchId = Guid.NewGuid(),
                ClientId = Guid.NewGuid()
            };
                var identity = new ClaimsIdentity("ASOSOAuth");
                identity.AddClaim(OpenIdConnectConstants.Claims.Subject, user.UserId.ToString());
                identity.AddClaim(OpenIdConnectConstants.Claims.Subject, user.BranchId.ToString(), OpenIdConnectConstants.Destinations.AccessToken);
                identity.AddClaim(OpenIdConnectConstants.Claims.Subject, user.ClientId.ToString());

                var ticket = new AuthenticationTicket(new ClaimsPrincipal(identity), new AuthenticationProperties(), "ASOSOAuth");
                context.Validate(ticket);
            //}

            return Task.FromResult(0);
            
        }
    }
}
