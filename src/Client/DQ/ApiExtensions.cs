namespace Experian.Api.Client.DQ
{
    using System.Threading.Tasks;

    public static class ApiExtensions
    {
        internal const string DQProduction = "https://api.experianaperture.io/";
        internal const string EmailValidationV1 = "email/validation/v1";
        internal const string PhoneValidationV2 = "phone/validation/v2";
        internal const string EnrichmentV2 = "/enrichment/v2/#/";
        internal const string AddressSearchV1 = "/address/search/v1/#/";

        /// <summary>
        /// Posts an email address to the service to be validated and, once completed, returns the results of the validation.
        /// </summary>
        /// <param name="serviceClient">The service client instance.</param>
        /// <param name="authToken">The Auth-Token header to authenticate the service.</param>
        /// <param name="headers">The headers for the request.</param>
        /// <param name="request">The body of the request.</param>
        /// <returns>EmailValidationV1Response</returns>
        public static async Task<EmailValidationV1Response> PostEmailValidationV1PostAsync(this ServiceClient serviceClient, string authToken, DataQualityHeaders headers, EmailValidationV1Request request)
        {
            return await serviceClient.SendRequestAsync<EmailValidationV1Request, DataQualityHeaders, EmailValidationV1Response>(DQProduction + EmailValidationV1, authToken, headers, request).ConfigureAwait(false);
        }

        /// <summary>
        /// Posts a phone number to the service to be validated and, once completed, returns the results of the validation.
        /// </summary>
        /// <param name="serviceClient">The service client instance.</param>
        /// <param name="authToken">The Auth-Token header to authenticate the service.</param>
        /// <param name="headers">The headers for the request.</param>
        /// <param name="request">The body of the request.</param>
        /// <returns>PhoneValidationV2Response</returns>
        public static async Task<PhoneValidationV2Response> PhoneValidationV2PostAsync(this ServiceClient serviceClient, string authToken, DataQualityEnrichHeaders headers, PhoneValidationV2Request request)
        {
            return await serviceClient.SendRequestAsync<PhoneValidationV2Request, DataQualityHeaders, PhoneValidationV2Response>(DQProduction + EmailValidationV1, authToken, headers, request).ConfigureAwait(false);
        }

        /// <summary>
        /// Given the search keys and specified attributes, a match type is determined and the enriched data is returned.
        /// </summary>
        /// <param name="serviceClient">The service client instance.</param>
        /// <param name="authToken">The Auth-Token header to authenticate the service.</param>
        /// <param name="country">The 3-character ISO country code. Examples: USA, GBR or AUS.</param>
        /// <param name="headers">The headers for the request.</param>
        /// <param name="request">The body of the request.</param>
        /// <returns>EnrichmentV2Response</returns>
        public static async Task<EnrichmentV2Response> PostEnrichmentV2ByCountryPostAsync(this ServiceClient serviceClient, string authToken, string country, DataQualityEnrichHeaders headers, EnrichmentV2Request request)
        {
            var path = DQProduction + EnrichmentV2.Replace("#", country);

            return await serviceClient.SendRequestAsync<EnrichmentV2Request, DataQualityHeaders, EnrichmentV2Response>(path, authToken, headers, request).ConfigureAwait(false);
        }
    }
}