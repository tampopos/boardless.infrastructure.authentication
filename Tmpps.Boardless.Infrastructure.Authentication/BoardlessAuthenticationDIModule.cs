using System.Threading;
using Tmpps.Boardless.Infrastructure.Authentication.Models;
using Tmpps.Infrastructure.Common.DependencyInjection.Builder;
using Tmpps.Infrastructure.Common.DependencyInjection.Builder.Interfaces;
using Tmpps.Infrastructure.JsonWebToken.Interfaces;

namespace Tmpps.Boardless.Infrastructure.Authentication
{
    public class BoardlessAuthenticationDIModule : IDIModule
    {
        private LifetimeType claimContextLifetimeType;

        public BoardlessAuthenticationDIModule(LifetimeType claimContextLifetimeType)
        {
            this.claimContextLifetimeType = claimContextLifetimeType;
        }
        public void DefineModule(IDIBuilder builder)
        {
            builder.RegisterType<UserClaimContext>(x => x.As<IClaimContext<UserClaim>>().LifetimeType = this.claimContextLifetimeType);
            builder.RegisterType<CancellationTokenSource>(x => x.SingleInstance());
        }
    }
}