namespace Experian.Api.Client.Bis
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Experian.Api.Client;

    public static class ApiExtensions
    {
        internal const string BisStaging              = "https://stg-us-api.experian.com/businessinformation/businesses/v1/";
        internal const string BisProduction           = "https://prod-us-api.experian.com/businessinformation/businesses/v1/";
        internal const string BisSandbox              = "https://sandbox-us-api.experian.com/businessinformation/businesses/v1/";

        private const string Bankruptcies             = "bankruptcies";
        private const string BusinessContacts         = "businesscontacts";
        private const string CorporateRegistrations   = "corporateregistrations";
        private const string Collections              = "collections";
        private const string CorporateLinkage         = "corporatelinkage";
        private const string CreditStatus             = "creditstatus";
        private const string Facts                    = "facts";
        private const string FraudShields             = "fraudshields";
        private const string Headers                  = "headers";
        private const string Judgments                = "judgments";
        private const string LegalCollectionSummaries = "legalcollectionsummaries";
        private const string Liens                    = "liens";
        private const string PremierProfiles          = "reports/premierprofiles";
        private const string ReverseAddresses         = "reverseaddresses";
        private const string ReversePhones            = "reversephones";
        private const string ReverseTaxIds            = "reversetaxids";
        private const string RiskDashboards           = "riskdashboards";
        private const string Scores                   = "scores";
        private const string ScoresSearch             = "scores/search";
        private const string Search                   = "search";
        private const string Trades                   = "trades";
        private const string UccFilings               = "uccfilings";

        private static readonly IList<string>                              Services    = new List<string>()
        {
            Search,
            Bankruptcies,
            BusinessContacts,
            CorporateRegistrations,
            Collections,
            CorporateLinkage,
            CreditStatus,
            Facts,
            FraudShields,
            Headers,
            Judgments,
            LegalCollectionSummaries,
            Liens,
            PremierProfiles,
            ReverseAddresses,
            ReversePhones,
            ReverseTaxIds,
            RiskDashboards,
            ScoresSearch,
            Scores,
            Trades,
            UccFilings,
        };

        private static readonly IDictionary<Environ, string>           EndpointUri = new Dictionary<Environ, string>()
        {
            { Environ.Production, BisProduction },
            { Environ.Staging,    BisStaging    },
            { Environ.Sandbox,    BisSandbox    },
        };

        private static readonly IDictionary<(Environ, string), string> ServiceUri  = new Dictionary<(Environ, string), string>();

        static ApiExtensions()
        {
            foreach (Environ environment in System.Enum.GetValues(typeof(Environ)))
            {
                foreach (var service in Services)
                {
                    ServiceUri.Add((environment, service), EndpointUri[environment] + service);
                }
            }
        }

        public static async Task<ReverseAddressesResponse>       PostReverseAddressAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, ReverseAddressesRequest request)
        {
            var url = ServiceUri[(env, ReverseAddresses)];
            return await serviceClient.SendRequestAsync<ReverseAddressesRequest, ReverseAddressesResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<BankruptcyResponse>             PostBankruptcyAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, BankruptcyRequest request)
        {
            var url = ServiceUri[(env, Bankruptcies)];
            return await serviceClient.SendRequestAsync<BankruptcyRequest, BankruptcyResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<BusinessContactsResponse>       PostBusinessContactsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, BusinessContactsRequest request)
        {
            var url = ServiceUri[(env, BusinessContacts)];
            return await serviceClient.SendRequestAsync<BusinessContactsRequest, BusinessContactsResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<BusinessFactsResponse>          PostBusinessFactsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, BusinessFactsRequest request)
        {
            var url = ServiceUri[(env, Facts)];
            return await serviceClient.SendRequestAsync<BusinessFactsRequest, BusinessFactsResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<CorporateRegistrationsResponse> PostCorporateRegistrationsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, CorporateRegistrationsRequest request)
        {
            var url = ServiceUri[(env, CorporateRegistrations)];
            return await serviceClient.SendRequestAsync<CorporateRegistrationsRequest, CorporateRegistrationsResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<CollectionsResponse>            PostCollectionsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, CollectionsRequest request)
        {
            var url = ServiceUri[(env, Collections)];
            return await serviceClient.SendRequestAsync<CollectionsRequest, CollectionsResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<CorporateLinkageResponse>       PostCorporateLinkageAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, CorporateLinkageRequest request)
        {
            var url = ServiceUri[(env, CorporateLinkage)];
            return await serviceClient.SendRequestAsync<CorporateLinkageRequest, CorporateLinkageResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<CreditStatusResponse>           PostCreditStatusAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, CreditStatusRequest request)
        {
            var url = ServiceUri[(env, CreditStatus)];
            return await serviceClient.SendRequestAsync<CreditStatusRequest, CreditStatusResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<BisResponse>               PostFactsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, BisRequest request)
        {
            var url = ServiceUri[(env, Facts)];
            return await serviceClient.SendRequestAsync<BisRequest, BisResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<FraudShieldsResponse>           PostFraudShieldsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, FraudShieldsRequest request)
        {
            var url = ServiceUri[(env, FraudShields)];
            return await serviceClient.SendRequestAsync<FraudShieldsRequest, FraudShieldsResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<HeadersResponse>                PostHeadersAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, HeadersRequest request)
        {
            var url = ServiceUri[(env, Headers)];
            return await serviceClient.SendRequestAsync<HeadersRequest, HeadersResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<JudgmentsResponse>              PostJudgmentsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, JudgmentsRequest request)
        {
            var url = ServiceUri[(env, Judgments)];
            return await serviceClient.SendRequestAsync<JudgmentsRequest, JudgmentsResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<LegalCollectionsSummariesResponse> PostLegalCollectionSummariesAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, LegalFilingsCollectionsSummariesRequest request)
        {
            var url = ServiceUri[(env, LegalCollectionSummaries)];
            return await serviceClient.SendRequestAsync<LegalFilingsCollectionsSummariesRequest, LegalCollectionsSummariesResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<LiensResponse>                  PostLiensAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, LiensRequest request)
        {
            var url = ServiceUri[(env, Liens)];
            return await serviceClient.SendRequestAsync<LiensRequest, LiensResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<ReverseAddressesResponse>       PostReverseAddressesAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, ReverseAddressesRequest request)
        {
            var url = ServiceUri[(env, ReverseAddresses)];
            return await serviceClient.SendRequestAsync<ReverseAddressesRequest, ReverseAddressesResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<ReversePhonesResponse>          PostReversePhonesAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, ReversePhonesRequest request)
        {
            var url = ServiceUri[(env, ReversePhones)];
            return await serviceClient.SendRequestAsync<ReversePhonesRequest, ReversePhonesResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<ReverseTaxIdsResponse>          PostReverseTaxidsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, ReverseTaxIdsRequest request)
        {
            var url = ServiceUri[(env, ReverseTaxIds)];
            return await serviceClient.SendRequestAsync<ReverseTaxIdsRequest, ReverseTaxIdsResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<RiskDashboardsResponse>         PostRiskDashboardsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, RiskDashboardsRequest request)
        {
            var url = ServiceUri[(env, RiskDashboards)];
            return await serviceClient.SendRequestAsync<RiskDashboardsRequest, RiskDashboardsResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<ScoresResponse>                 PostScoresAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, ScoresRequest request)
        {
            var url = ServiceUri[(env, Scores)];
            return await serviceClient.SendRequestAsync<ScoresRequest, ScoresResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<SearchResponse>                 PostSearchAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, SearchRequest request)
        {
            var url = ServiceUri[(env, Search)];
            return await serviceClient.SendRequestAsync<SearchRequest, SearchResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<TradesResponse>                 PostTradesAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, TradesRequest request)
        {
            var url = ServiceUri[(env, Trades)];
            return await serviceClient.SendRequestAsync<TradesRequest, TradesResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<UccFilingsResponse>             PostUccFilingsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, UccFilingsRequest request)
        {
            var url = ServiceUri[(env, UccFilings)];
            return await serviceClient.SendRequestAsync<UccFilingsRequest, UccFilingsResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<ScoresSearchResponse>           PostScoresSearchAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, BisRequest request)
        {
            var url = ServiceUri[(env, ScoresSearch)];
            return await serviceClient.SendRequestAsync<BisRequest, ScoresSearchResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<PremierProfilesResponse> PostPremierProfilesAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, PremierProfilesRequest request)
        {
            var url = ServiceUri[(env, PremierProfiles)];
            return await serviceClient.SendRequestAsync<PremierProfilesRequest, PremierProfilesResponse>(url, authToken, request).ConfigureAwait(false);
        }
    }
}
