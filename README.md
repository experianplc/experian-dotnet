# Experian API .Net Library

The Experian .Net library provides convenient access to the RESTful Experian APIs from Applications written in .Net.
This package is for use with .Net Applications (.Net Standard 2.0+) that uses Experian client_id, client_secret, username, password obtainable from the developer portal and subcode (if applicable).

| **Build Status**| **Windows** |
|-|-|
| **C#** | ![Build Status](https://edq-repo.visualstudio.com/_apis/public/build/definitions/971383a4-87aa-4b6c-bae6-4fb8fbf6b84e/814/badge)|

## API Documentation

For Detailed documentation of Experian APIs, visit [Experian Developers Portal](http://developer.experian.com/)

## .Net Setup & Development

Please note that this code is in preview. This specifically means the following:

* While a Nuget package is planned, currently the code is only available as a .Net Standard Library.
* The Nuget package will only contain the Experian.Api.Client library.
* The Test libraries and Benchmark console app are for testing/informational purposes only.
* Currently only Business Information Services are included.

### Prerequisites to use

1. .Net Standard 2.0 (.Net Framework 4.6.1, .Net Core 2.0)
2. Nuget 3.x+

### Prerequisites to Build

1. .Net Core SDK 2.1.4
2. Git Client

## Package Usage

ServiceClient is the main component. It is a thin wrapper to HttpClient that adds methods to call our Authentication API and the Service Endpoint. By including a Service collection namespace (e.g. using Experian.Api.Client.Bis) you will also bring in that service collections request/response models and helper extension methods for ServiceClient.

### ServiceClient configuration

The service client uses an underlying HttpClient that it can create itself or can be passed in. If you need to configure special headers or a proxy, simply configure a HttpClient as desired then pass it to the ServiceClient Constructor.

### Authentication before Calling the API

#### Api.Experian.Com

Services on api.Experian.com such as Business Information Services require a Bearer token (in this case a OAuth Access token). This token can be obtained with the code below.

```csharp
    var serviceClient = new ServiceClient();
    var authResult    = serviceClient.SendAuthenticationRequestAsync(new AuthRequest(Username, Password), ClientId, ClientSecret, ServiceClient.OAuthSandboxUrl).Result;
```
The ClientId, ClientSecret can be obtained from an App created in the developer.experian.com portal. The username and password are your credentials for the portal. The authenticated response returns the the access token, the token type (bearer), the time the token was created (in milliseconds from the Unix Time/Epoch UTC). It also gives you the time the token will expire and you need to get another one (you should write your re-authenticate logic based on this field rather than a fixed time period). 

### Example

```csharp
namespace Experian.Api.Example
{
    using System;
    using Experian.Api.Client;
    using Experian.Api.Client.Bis;

    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            var request = new ReverseAddressesRequest()
                            {
                                Subcode = "0517614",
                                Street  = "1 Infinite Loop",
                                City    = "Cupertino",
                                State   = "CA",
                                Zip     = "10118",
                            };

            ClientId         = "YOURCLIENTID";
            ClientSecret     = "YOURCLIENTSECRET";
            Username         = "YOURUSERNAME";
            Password         = "YOURPASSWORD";

            var client       = new ServiceClient();
            var authResponse = client.SendAuthenticationRequestAsync(new AuthRequest(Username, Password), ClientId, ClientSecret, ServiceClient.OAuthSandboxUrl).Result;
            var response     = client.PostReverseAddressAsync(Environ.Sandbox, authResponse, request).Result;
            Console.WriteLine(response.Success);
            Console.ReadKey();
        }
    }
}
```

### Developer Secrets

To prevent the included integration tests and the benchmarking console app containing secrets the .Net User Secrets tool is use. You only need to restore the packages (this is typically done as part of or prior to the build). Then from the individual projects folder simply type:

```bash
dotnet user-secrets set ClientId YOURCLIENTID
dotnet user-secrets set ClientSecret YOURCLIENTSECRET
dotnet user-secrets set Username YOURUSERNAME
dotnet user-secrets set Password YOURPASSWORD
```

This will set up your local system to hold these secrets without checking them into source control.

For IntegrationTests on a build server environment variables can be used instead.

## BIS Service usage

##### Bankruptcies

```csharp
            var request = new BankruptcyRequest()
            {
                Bin               = "404197602",
                Subcode           = "0517614",
                BankruptcySummary = true,
                BankruptcyDetail  = true,
            };

            var response = serviceClient.PostBankruptcyAsync(Environ.Sandbox, authResponse, request);
```

##### Business Contacts

```csharp
            var request = new BusinessContactsRequest()
            {
                Bin      = "725862571",
                Subcode  = "0517614",
                Comments = "test",
            };

            var response = serviceClient.PostBusinessContactsAsync(Environ.Sandbox, authResponse, request);
```

##### Business Facts

```csharp
            var request = new BusinessFactsRequest()
            {
                Bin     = "807205801",
                Subcode = "0517614",
            };

            var response = serviceClient.PostBusinessFactsAsync(Environ.Sandbox, authResponse, request);
```

##### Collections

```csharp
    var request = new BusinessRequest()
    {
        Bin                = "700880075",
        Subcode            = "0517614",
        CollectionsSummary = true,
        CollectionsDetail  = true,
    };

    var response = serviceClient.PostCollectionsAsync(Environment.Sandbox, authResponse, request);
```

##### Corporate Linkage

```csharp
            var request = new CorporateLinkageRequest()
            {
                Bin                     = "700513485",
                Subcode                 = "0517614",
                ModelCode               = "000224",
                CorporateLinkagePartial = true,
                CorporateLinkageFull    = true,
            };

            var response = serviceClient.PostCorporateLinkageAsync(Environ.Sandbox, authResponse, request);
```

##### Corporate Registrations

```csharp
            var request = new CorporateRegistrationsRequest()
            {
                Bin                     = "700000001",
                Subcode                 = "0517614",
                StatusDescriptionDetail = true,
            };

            var response = serviceClient.PostCorporateRegistrationsAsync(Environ.Sandbox, authResponse, request);
```

##### Credit Status

```csharp
            var request = new CreditStatusRequest()
            {
                Bin     = "807205801",
                Subcode = "0517614",
            };

            var response = serviceClient.PostCreditStatusAsync(Environ.Sandbox, authResponse, request);
```

##### Fraud Shields

```csharp
            var request = new FraudShieldsRequest()
            {
                Bin     = "807205801",
                Subcode = "0517614",
            };

            var response = serviceClient.PostFraudShieldsAsync(Environ.Sandbox, authResponse, request);
```

#### Headers

```csharp
            var request = new HeadersRequest()
            {
                Bin     = "807205801",
                Subcode = "0517614",
            };

            var response = serviceClient.PostHeadersAsync(Environ.Sandbox, authResponse, request);
```

##### Judgements

```csharp
            var request = new JudgmentsRequest()
            {
                Bin             = "700969989",
                Subcode         = "0517614",
                JudgmentSummary = true,
                JudgmentDetail  = true,
             };

            var response = serviceClient.PostJudgmentsAsync(Environ.Sandbox, authResponse, request);
```

##### Legal Collection Summaries

```csharp

            var request = new LegalFilingsCollectionsSummariesRequest()
            {
                Bin                            = "800914632",
                Subcode                        = "0517614",
                LegalFilingsCollectionsSummary = true,
                LegalFilingsSummary            = true
            };

            var response = serviceClient.PostLegalCollectionSummariesAsync(Environ.Sandbox, authResponse, request);
```
##### Liens

```csharp
            var request = new LiensRequest()
            {
                    Bin         = "701000078",
                    Subcode     = "0517614",
                    LienSummary = true,
                    LienDetail  = true
            };

            var response = serviceClient.PostLiensAsync(Environ.Sandbox, authResponse, request);
```

##### Risk Dashboards

```csharp
            var request = new RiskDashboardsRequest()
            {
                Bin       = "807205801",
                Subcode   = "0517614",
                ModelCode = "000224",
            };

            var response = serviceClient.PostRiskDashboardsAsync(Environ.Sandbox, authResponse, request);
```

##### Scores

```csharp
        var request = new ScoresRequest()
        {
            Bin = "700000001",
            Subcode         = "0517614",
            ModelCode       = "000224",
            FsrScore        = true,
            CommercialScore = true,
        };

        var response = serviceClient.PostScoresAsync(Environment.Sandbox, authResponse, request);
```

##### Trades

```csharp
            var request = new TradesRequest()
            {
                Bin                     = "700000001",
                Subcode                 = "0517614",
                TradePaymentSummary     = true,
                TradePaymentTotals      = true,
                TradePaymentExperiences = true,
                TradePaymentTrends      = true,
            };

            var response = serviceClient.PostTradesAsync(Environ.Sandbox, authResponse, request);
```

##### UCC Filings

```csharp
            var request = new UccFilingsRequest()
            {
                Bin               = "700969989",
                Subcode           = "0517614",
                UccFilingsSummary = true,
                UccFilingsDetail  = true,
            };

            var response = serviceClient.PostUccFilingsAsync(Environ.Sandbox, authResponse, request);
```

##### Reverse Addresses	

```csharp
            var request = new ReverseAddressesRequest()
            {
                Subcode = "0517614",
                Street  = "1 Infinite Loop",
                City    = "Cupertino",
                State   = "CA",
                Zip     = "10118",
            };

            var response = serviceClient.PostReverseAddressAsync(Environ.Sandbox, authResponse, request);
```

##### Reverse Phones

```csharp
            var request = new ReversePhonesRequest()
            {
                Subcode = "0517614",
                Phone   = "8006927753",
            };

            var response = serviceClient.PostReversePhonesAsync(Environ.Sandbox, authResponse, request);
```

##### Reverse TaxIDs

```csharp
            var request = new ReverseTaxIdsRequest()
            {
                Subcode = "0517614",
                TaxId   = "156706138",
            };

            var response = serviceClient.PostReverseTaxidsAsync(Environ.Sandbox, authResponse, request);
```

##### Search

```csharp
            var request = new SearchRequest()
            {
                Name     = "Experian",
                City     = "Costa Mesa",
                State    = "CA",
                Subcode  = "0517614",
                Street   = "475 ANTON BLVD",
                Zip      = "92626",
                Phone    = "9495673800",
                TaxId    = "176970333",
                Geo      = true,
                Comments = "testing",
            };

            var response = serviceClient.PostSearchAsync(Environ.Sandbox, authResponse, request);
```

### An example `response` object

```json
{
    "requestId": "XXXX-XXXX-XXXX-XXXX",
    "success": true,
    "results": [...]
}
```

#### `error` object
```json
{
    "success": false,
    "requestId": "XXXX-XXXX-XXXX-XXXX",
    "errors": [
        {
            "errorCode": XXXX,
            "errorType": "Error Type",
            "message": "Error Message"
        }
    ]
}
```
