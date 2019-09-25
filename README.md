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

***Important! This is an alpha version, there may be breaking changes.***

Using this API client requires an active account.

> Don't have an account yet? [Sign up for a free Bitmovin trial plan](https://dashboard.bitmovin.com/signup)!

For full documentation of all available API endpoints, see the [Bitmovin API reference](https://bitmovin.com/docs).

## Installation

### Nuget

Add this dependency to your project:

Package Manager
```shell
Install-Package Bitmovin.Api.Sdk -Version 1.24.0-alpha.0
```

.NET CLI

```shell
dotnet add package Bitmovin.Api.Sdk --version 1.24.0-alpha.0
```

## Initialization

```csharp
    using Bitmovin.Api;

    var bitmovinApi = BitmovinApi.Builder
        .WithApiKey(API_KEY)
        .WithLogger(new XunitLogger(output))
        .Build();  
```
