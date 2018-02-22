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

        public static async Task<ReverseAddressesReponse>       PostReverseAddressAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, ReverseAddressesRequest request)
        {
            var url = ServiceUri[(env, ReverseAddresses)];
            return await serviceClient.SendRequestAsync<ReverseAddressesRequest, ReverseAddressesReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<BankruptcyReponse>             PostBankruptcyAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, BankruptcyRequest request)
        {
            var url = ServiceUri[(env, Bankruptcies)];
            return await serviceClient.SendRequestAsync<BankruptcyRequest, BankruptcyReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<BusinessContactsReponse>       PostBusinessContactsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, BusinessContactsRequest request)
        {
            var url = ServiceUri[(env, BusinessContacts)];
            return await serviceClient.SendRequestAsync<BusinessContactsRequest, BusinessContactsReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<BusinessFactsReponse>          PostBusinessFactsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, BusinessFactsRequest request)
        {
            var url = ServiceUri[(env, Facts)];
            return await serviceClient.SendRequestAsync<BusinessFactsRequest, BusinessFactsReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<CorporateRegistrationsReponse> PostCorporateRegistrationsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, CorporateRegistrationsRequest request)
        {
            var url = ServiceUri[(env, CorporateRegistrations)];
            return await serviceClient.SendRequestAsync<CorporateRegistrationsRequest, CorporateRegistrationsReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<CollectionsReponse>            PostCollectionsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, BisRequest request)
        {
            var url = ServiceUri[(env, Collections)];
            return await serviceClient.SendRequestAsync<BisRequest, CollectionsReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<CorporateLinkageReponse>       PostCorporateLinkageAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, CorporateLinkageRequest request)
        {
            var url = ServiceUri[(env, CorporateLinkage)];
            return await serviceClient.SendRequestAsync<CorporateLinkageRequest, CorporateLinkageReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<CreditStatusReponse>           PostCreditStatusAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, CreditStatusRequest request)
        {
            var url = ServiceUri[(env, CreditStatus)];
            return await serviceClient.SendRequestAsync<CreditStatusRequest, CreditStatusReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<BisResponse>               PostFactsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, BisRequest request)
        {
            var url = ServiceUri[(env, Facts)];
            return await serviceClient.SendRequestAsync<BisRequest, BisResponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<FraudShieldsReponse>           PostFraudShieldsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, FraudShieldsRequest request)
        {
            var url = ServiceUri[(env, FraudShields)];
            return await serviceClient.SendRequestAsync<FraudShieldsRequest, FraudShieldsReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<HeadersReponse>                PostHeadersAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, HeadersRequest request)
        {
            var url = ServiceUri[(env, Headers)];
            return await serviceClient.SendRequestAsync<HeadersRequest, HeadersReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<JudgmentsReponse>              PostJudgmentsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, JudgmentsRequest request)
        {
            var url = ServiceUri[(env, Judgments)];
            return await serviceClient.SendRequestAsync<JudgmentsRequest, JudgmentsReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<LegalCollectionsSummariesReponse> PostLegalCollectionSummariesAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, LegalFilingsCollectionsSummariesRequest request)
        {
            var url = ServiceUri[(env, LegalCollectionSummaries)];
            return await serviceClient.SendRequestAsync<LegalFilingsCollectionsSummariesRequest, LegalCollectionsSummariesReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<LiensReponse>                  PostLiensAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, LiensRequest request)
        {
            var url = ServiceUri[(env, Liens)];
            return await serviceClient.SendRequestAsync<LiensRequest, LiensReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<ReverseAddressesReponse>       PostReverseAddressesAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, ReverseAddressesRequest request)
        {
            var url = ServiceUri[(env, ReverseAddresses)];
            return await serviceClient.SendRequestAsync<ReverseAddressesRequest, ReverseAddressesReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<ReversePhonesReponse>          PostReversePhonesAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, ReversePhonesRequest request)
        {
            var url = ServiceUri[(env, ReversePhones)];
            return await serviceClient.SendRequestAsync<ReversePhonesRequest, ReversePhonesReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<ReverseTaxIdsReponse>          PostReverseTaxidsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, ReverseTaxIdsRequest request)
        {
            var url = ServiceUri[(env, ReverseTaxIds)];
            return await serviceClient.SendRequestAsync<ReverseTaxIdsRequest, ReverseTaxIdsReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<RiskDashboardsReponse>         PostRiskDashboardsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, RiskDashboardsRequest request)
        {
            var url = ServiceUri[(env, RiskDashboards)];
            return await serviceClient.SendRequestAsync<RiskDashboardsRequest, RiskDashboardsReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<ScoresReponse>                 PostScoresAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, BisRequest request)
        {
            var url = ServiceUri[(env, Scores)];
            return await serviceClient.SendRequestAsync<BisRequest, ScoresReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<SearchReponse>                 PostSearchAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, SearchRequest request)
        {
            var url = ServiceUri[(env, Search)];
            return await serviceClient.SendRequestAsync<SearchRequest, SearchReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<TradesReponse>                 PostTradesAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, TradesRequest request)
        {
            var url = ServiceUri[(env, Trades)];
            return await serviceClient.SendRequestAsync<TradesRequest, TradesReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<UccFilingsReponse>             PostUccFilingsAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, UccFilingsRequest request)
        {
            var url = ServiceUri[(env, UccFilings)];
            return await serviceClient.SendRequestAsync<UccFilingsRequest, UccFilingsReponse>(url, authToken, request).ConfigureAwait(false);
        }

        public static async Task<ScoresSearchReponse>           PostScoresSearchAsync(this ServiceClient serviceClient, Environ env, AuthResult authToken, BisRequest request)
        {
            var url = ServiceUri[(env, ScoresSearch)];
            return await serviceClient.SendRequestAsync<BisRequest, ScoresSearchReponse>(url, authToken, request).ConfigureAwait(false);
        }
    }
}
