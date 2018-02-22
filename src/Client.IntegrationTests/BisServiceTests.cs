namespace Experian.Api.Client.IntegrationTests
{
    using System;
    using Experian.Api.Client.Bis;
    using Xunit;

    [Collection("Service collection")]
    [Trait("Category", "CI")]
    public sealed class BisServiceTests
    {
        // tests based on Sandbox data from: https://developer.experian.com/product/businesses
        public BisServiceTests(AuthorisationFixture fixture)
        {
            this.Fixture = fixture;
        }

        private AuthorisationFixture Fixture { get; }

        [Fact]
        public void Bankruptcies()
        {
            var request = new BankruptcyRequest()
            {
                Bin               = "404197602",
                Subcode           = "0517614",
                BankruptcySummary = true,
                BankruptcyDetail  = true,
            };

            var response = this.Fixture.ServiceClient.PostBankruptcyAsync(Client.Environ.Sandbox, this.Fixture.ObtainAuthToken(), request);

            // Low-fi check for now.
            Assert.NotNull(response.Result);
        }

        [Fact]
        public void BusinessContacts()
        {
            var request = new BusinessContactsRequest()
            {
                Bin      = "725862571",
                Subcode  = "0517614",
                Comments = "test",
            };

            var response = this.Fixture.ServiceClient.PostBusinessContactsAsync(Client.Environ.Sandbox, this.Fixture.ObtainAuthToken(), request);
            Assert.NotNull(response.Result);
        }

        [Fact]
        public void BusinessFacts()
        {
            var request = new BusinessFactsRequest()
            {
                Bin     = "807205801",
                Subcode = "0517614",
            };

            var response = this.Fixture.ServiceClient.PostBusinessFactsAsync(Client.Environ.Sandbox, this.Fixture.ObtainAuthToken(), request);
            Assert.NotNull(response.Result);
        }

        [Fact]
        public void Search()
        {
            var request = new SearchRequest()
            {
                Name = "Experian",
                City = "Costa Mesa",
                State = "CA",
                Subcode = "0517614",
                Street = "475 ANTON BLVD",
                Zip = "92626",
                Phone = "9495673800",
                TaxId = "176970333",
                Geo = true,
                Comments = "testing",
            };

            var response = this.Fixture.ServiceClient.PostSearchAsync(Client.Environ.Sandbox, this.Fixture.ObtainAuthToken(), request);
            Assert.NotNull(response.Result);
        }

        ////[Fact]
        ////public void Collections()
        ////{
        ////    var request = new BusinessRequest()
        ////    {
        ////        Bin     = "700880075",
        ////        Subcode = "0517614",
        ////        CollectionsSummary = true,
        ////        CollectionsDetail = true,
        ////    };

        ////    var response = this.Fixture.ServiceClient.PostCollectionsAsync(Client.Environment.Sandbox, this.Fixture.ObtainAuthToken(), request);
        ////    Assert.NotNull(response.Result);
        ////}

        [Fact]
        public void Linkage()
        {
            var request = new CorporateLinkageRequest()
            {
                Bin = "700513485",
                Subcode = "0517614",
                ModelCode = "000224",
                CorporateLinkagePartial = true,
                CorporateLinkageFull = true,
            };

            var response = this.Fixture.ServiceClient.PostCorporateLinkageAsync(Client.Environ.Sandbox, this.Fixture.ObtainAuthToken(), request);
            Assert.NotNull(response.Result);
        }

        [Fact]
        public void CorporateRegistrations()
        {
            var request = new CorporateRegistrationsRequest()
            {
                Bin = "700000001",
                Subcode = "0517614",
                StatusDescriptionDetail = true,
            };

            var response = this.Fixture.ServiceClient.PostCorporateRegistrationsAsync(Client.Environ.Sandbox, this.Fixture.ObtainAuthToken(), request);
            Assert.NotNull(response.Result);
        }

        [Fact]
        public void CreditStatus()
        {
            var request = new CreditStatusRequest()
            {
                Bin = "807205801",
                Subcode = "0517614",
            };

            var response = this.Fixture.ServiceClient.PostCreditStatusAsync(Client.Environ.Sandbox, this.Fixture.ObtainAuthToken(), request);
            Assert.NotNull(response.Result);
        }

        [Fact]
        public void FraudShields()
        {
            var request = new FraudShieldsRequest()
            {
                Bin     = "807205801",
                Subcode = "0517614",
            };

            var response = this.Fixture.ServiceClient.PostFraudShieldsAsync(Client.Environ.Sandbox, this.Fixture.ObtainAuthToken(), request);
            Assert.NotNull(response.Result);
        }

        [Fact]
        public void Headers()
        {
            var request = new HeadersRequest()
            {
                Bin = "807205801",
                Subcode = "0517614",
            };

            var response = this.Fixture.ServiceClient.PostHeadersAsync(Client.Environ.Sandbox, this.Fixture.ObtainAuthToken(), request);
            Assert.NotNull(response.Result);
        }

        [Fact]
        public void Judgments()
        {
            var request = new JudgmentsRequest()
            {
                Bin = "700969989",
                Subcode = "0517614",
                JudgmentSummary = true,
                JudgmentDetail = true,
             };

            var response = this.Fixture.ServiceClient.PostJudgmentsAsync(Client.Environ.Sandbox, this.Fixture.ObtainAuthToken(), request);
            Assert.NotNull(response.Result);
        }

        [Fact]
        public void LegalFilingsandCollectionSummaries()
        {
            var request = new LegalFilingsCollectionsSummariesRequest()
            {
                Bin = "800914632",
                Subcode     = "0517614",
                LegalFilingsCollectionsSummary = true,
                LegalFilingsSummary = true
            };

            var response = this.Fixture.ServiceClient.PostLegalCollectionSummariesAsync(Client.Environ.Sandbox, this.Fixture.ObtainAuthToken(), request);
            Assert.NotNull(response.Result);
        }

        [Fact]
        public void Liens()
        {
            var request = new LiensRequest()
            {
                    Bin = "701000078",
                    Subcode = "0517614",
                    LienSummary = true,
                    LienDetail = true
            };

            var response = this.Fixture.ServiceClient.PostLiensAsync(Client.Environ.Sandbox, this.Fixture.ObtainAuthToken(), request);
            Assert.NotNull(response.Result);
        }

        ////[Fact]
        ////public void PremierProfiles()
        ////{
        ////    var request = new BusinessRequest()
        ////    {
        ////        Bin           = "800914632",
        ////        Subcode       = "0517614",
        ////        RiskModelCode = "000224",
        ////    };

        ////    var response = this.Fixture.ServiceClient.PostPremierProfileAsync(Client.Environment.Sandbox, this.Fixture.ObtainAuthToken(), request);
        ////    Assert.NotNull(response.Result);
        ////}

        [Fact]
        public void ReverseAddress()
        {
            var request = new ReverseAddressesRequest()
            {
                Subcode = "0517614",
                Street  = "1 Infinite Loop",
                City    = "Cupertino",
                State   = "CA",
                Zip     = "10118",
            };

            var response = this.Fixture.ServiceClient.PostReverseAddressAsync(Client.Environ.Sandbox, this.Fixture.ObtainAuthToken(), request);

            Assert.NotNull(response.Result);
        }

        [Fact]
        public void ReversePhones()
        {
            var request = new ReversePhonesRequest()
            {
                Subcode = "0517614",
                Phone   = "8006927753",
            };

            var response = this.Fixture.ServiceClient.PostReversePhonesAsync(Client.Environ.Sandbox, this.Fixture.ObtainAuthToken(), request);
            Assert.NotNull(response.Result);
        }

        [Fact]
        public void ReverseTaxIDs()
        {
            var request = new ReverseTaxIdsRequest()
            {
                Subcode = "0517614",
                TaxId   = "156706138",
            };

            var response = this.Fixture.ServiceClient.PostReverseTaxidsAsync(Client.Environ.Sandbox, this.Fixture.ObtainAuthToken(), request);
            Assert.NotNull(response.Result);
        }

        [Fact]
        public void RiskDashboards()
        {
            var request = new RiskDashboardsRequest()
            {
                Bin       = "807205801",
                Subcode   = "0517614",
                ModelCode = "000224",
            };

            var response = this.Fixture.ServiceClient.PostRiskDashboardsAsync(Client.Environ.Sandbox, this.Fixture.ObtainAuthToken(), request);
            Assert.NotNull(response.Result);
        }

    ////    [Fact]
    ////public void Scores()
    ////{
    ////    var request = new ScoresSearchRequest()
    ////    {
    ////        Bin = "700000001",
    ////        Subcode         = "0517614",
    ////        ModelCode       = "000224",
    ////        FsrScore        = true,
    ////        CommercialScore = true,
    ////    };

    ////        var response = this.Fixture.ServiceClient.PostScoresSearchAsync(Client.Environment.Sandbox, this.Fixture.ObtainAuthToken(), request);
    ////        Assert.NotNull(response.Result);
    ////}

        ////[Fact]
        ////public void ScoresAutoSearch()
        ////{
        ////    var request = new ScoresAutoRequest()
        ////    {
        ////        Name                 = "Experian",
        ////        City                 = "Costa Mesa",
        ////        State                = "CA",
        ////        Subcode              = "0517614",
        ////        Street               = "475 ANTON BLVD",
        ////        Zip                  = "92626",
        ////        Phone                = "9495673800",
        ////        TaxId                = "176970333",
        ////        Geo                  = true,
        ////        Comments             = "testing",
        ////        ModelCode            = "000224",
        ////        MatchReliabilityCode = 83,
        ////        CommercialScore      = true,
        ////        FsrScore             = true,
        ////    };

        ////    var response = this.Fixture.ServiceClient.PostScoresSearchAsync(Client.Environment.Sandbox, this.Fixture.ObtainAuthToken(), request);
        ////    Assert.NotNull(response.Result);
        ////}

        [Fact]
        public void Trades()
        {
            var request = new TradesRequest()
            {
                Bin                 = "700000001",
                Subcode             = "0517614",
                TradePaymentSummary = true,
                TradePaymentTotals  = true,
                TradePaymentExperiences = true,
                TradePaymentTrends  = true,
            };

            var response = this.Fixture.ServiceClient.PostTradesAsync(Client.Environ.Sandbox, this.Fixture.ObtainAuthToken(), request);
            Assert.NotNull(response.Result);
        }

        [Fact]
        public void UccFilings()
        {
            var request = new UccFilingsRequest()
            {
                Bin = "700969989",
                Subcode             = "0517614",
                UccFilingsSummary   = true,
                UccFilingsDetail    = true,
            };

            var response = this.Fixture.ServiceClient.PostUccFilingsAsync(Client.Environ.Sandbox, this.Fixture.ObtainAuthToken(), request);
            Assert.NotNull(response.Result);
        }

        ////[Fact]
        ////public void Search()
        ////{
        ////    var request = new SearchRequest()
        ////    {
        ////        Name      = "Experian",
        ////        City      = "Costa Mesa",
        ////        State     = "CA",
        ////        Subcode   = "0517614",
        ////        Street    = "475 ANTON BLVD",
        ////        Zip       = "92626",
        ////        Phone     = "9495673800",
        ////        TaxId     = "176970333",
        ////        Geo       = true,
        ////        Comments  = "testing"
        ////    };
        ////};

        ////    var response = this.Fixture.ServiceClient.PostReverseAddress(this.Fixture.ObtainAuthToken(), request);

        ////    // Low-fi check for now.
        ////    Assert.NotNull(response.Result);
        ////}
    }
}
