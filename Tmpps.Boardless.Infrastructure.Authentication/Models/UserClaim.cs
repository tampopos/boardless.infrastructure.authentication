using System.Globalization;
using Tmpps.Infrastructure.JsonWebToken.Interfaces;

namespace Tmpps.Boardless.Infrastructure.Authentication.Models
{
    public class UserClaim : IJwtClaimInfo
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public CultureInfo CultureInfo { get; set; }
    }
}