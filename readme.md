# tmpps.boardless.infrastructure.authentication

## register nuget

```bash
npm run publish
# replace version,api-key
dotnet nuget push ./Tmpps.Boardless.Infrastructure.Authentication/bin/Release/Tmpps.Boardless.Infrastructure.Authentication.${version}.nupkg -k ${api-key} -s https://api.nuget.org/v3/index.json
```
