# tmpps.boardless.infrastructure.authentication

## command

#### build

`dotnet build Tmpps.Boardless.Infrastructure.Authentication.Tests/`

#### test

`dotnet test Tmpps.Boardless.Infrastructure.Authentication.Tests/`

#### register nuget

```bash
dotnet build -c Release Tmpps.Boardless.Infrastructure.Authentication
# replace version,api-key
dotnet pack -c Release --include-source -p:PackageVersion=${version} Tmpps.Boardless.Infrastructure.Authentication
dotnet nuget push ./Tmpps.Boardless.Infrastructure.Authentication/bin/Release/Tmpps.Boardless.Infrastructure.Authentication.${version}.nupkg -k ${api-key} -s https://api.nuget.org/v3/index.json
```

## use circleCI CLI

#### validation config

`circleci config validate`

#### test

`circleci local execute --job test`

#### release

```bash
git tag X.Y.Z
git push origin --tags
```
