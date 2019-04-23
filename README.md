# Bitmovin C# API Client

***Important! This is an alpha version, there may be breaking changes.***

[![bitmovin](http://bitmovin-a.akamaihd.net/webpages/bitmovin-logo-github.png)](http://www.bitmovin.com)

C#-Client which enables you to seamlessly integrate the Bitmovin API into your projects. Using this API client requires an active account.

[Sign up for a Bitmovin Account!](https://dashboard.bitmovin.com/signup)

The full API reference can be found [here](https://bitmovin.com/docs).

## Installation

### Nuget

Add this dependency to your project:

Package Manager
```shell
Install-Package Bitmovin.Api.Sdk -Version 1.14.0-alpha.0
```

.NET CLI

```shell
dotnet add package Bitmovin.Api.Sdk --version 1.14.0-alpha.0
```

## Initialization

```csharp
    using Bitmovin.Api;

    var bitmovinApi = BitmovinApi.Builder
        .WithApiKey(API_KEY)
        .WithLogger(new XunitLogger(output))
        .Build();  
```
