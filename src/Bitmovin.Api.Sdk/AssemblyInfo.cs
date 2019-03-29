using System;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using RestEase;

[assembly: AllowPartiallyTrustedCallers]
[assembly: ComVisible(false)]
[assembly: NeutralResourcesLanguage("en")]

// This is needed as we want keep our Restease interfaces internal
[assembly: InternalsVisibleTo(RestClient.FactoryAssemblyName)]
