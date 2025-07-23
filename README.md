<p align="center">
  <a href="https://www.bitmovin.com">
    <img alt="Bitmovin C# API SDK Header" src="https://cdn.bitmovin.com/frontend/encoding/openapi-clients/readme-headers/ReadmeHeader_C%23.png" >
  </a>

  <h4 align="center">
    C# API SDK which enables you to seamlessly integrate the Bitmovin API into your projects.
  </h4>

  <p align="center">
    <a href="https://badge.fury.io/nu/Bitmovin.Api.Sdk"><img src="https://badge.fury.io/nu/Bitmovin.Api.Sdk.svg" alt="NuGet version" height="18"></a>
    <a href="LICENSE"><img src="https://img.shields.io/badge/License-MIT-yellow.svg" alt="License"></img></a>
  </p>
</p>

Using this API client requires an active account.

> Don't have an account yet? [Sign up for a free Bitmovin trial plan](https://dashboard.bitmovin.com/signup)!

---

## Documentation & Release Notes
+ Full Bitmovin API reference documentation: https://bitmovin.com/docs/encoding/api-reference
+ SDK reference documentation for .NET: [https://bitmovin.github.io/bitmovin-api-sdk-dotnet](https://bitmovin.github.io/bitmovin-api-sdk-dotnet/api/Bitmovin.Api.Sdk.BitmovinApi.html)
+ Release Notes: https://bitmovin.com/docs/encoding/changelogs/rest

## Support
If you have any questions regarding the SDK, provided examples or our services, please log in to your Bitmovin Dashboard at https://bitmovin.com/dashboard and [create a support ticket](https://bitmovin.com/dashboard/support/cases/create?tab=encoding). Our team will get back to you as soon as possible :+1:

---
## Installation

### Nuget

Add this dependency to your project:

Package Manager
```shell
Install-Package Bitmovin.Api.Sdk -Version 1.236.0
```

.NET CLI

```shell
dotnet add package Bitmovin.Api.Sdk --version 1.236.0
```

## Initialization

```csharp
    using Bitmovin.Api;

    var bitmovinApi = BitmovinApi.Builder
        .WithApiKey(API_KEY)
        .WithLogger(new XunitLogger(output))
        .Build();  
```

## Examples
You can find sample workflow scripts in the [Bitmovin API SDK examples](https://github.com/bitmovin/bitmovin-api-sdk-examples) repository.

---

## Deprecated API Client (Legacy)

`bitmovin-api-sdk-dotnet` is the latest Bitmovin API client for .NET Core 2.0+ and .NET Framework 4.6.1+. It guarantees 100% specification conformity at any given time and access to all features of the API as soon as they are released. 

However, if you need to use the previous version for legacy reasons, you can still find it at [bitmovin-dotnet](https://github.com/bitmovin/bitmovin-dotnet).
