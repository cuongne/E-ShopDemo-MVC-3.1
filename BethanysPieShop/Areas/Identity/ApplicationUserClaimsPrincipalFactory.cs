using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BethanysPieShop.Areas.Identity
{
    public class ApplicationUserClaimsPrincipalFactory:UserClaimsPrincipalFactory
        <IdentityUser>
    {
        public ApplicationUserClaimsPrincipalFactory(
            UserManager<IdentityUser> userManager,
            IOptions<IdentityOptions> options
            ) : base(userManager, options)
        {
        }

        protected override async Task<ClaimsIdentity>
            GenerateClaimsAsync(IdentityUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);

            identity.AddClaim(new Claim("PhoneNumber",
                user.PhoneNumber));
            identity.AddClaim(new Claim("UserName",
                user.UserName));
            identity.AddClaim(new Claim("Email",
                user.Email));
            return identity;
        }
    }
}
