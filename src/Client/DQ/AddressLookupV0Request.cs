namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The address lookup v0 request.
    /// </summary>
    [DataContract]
    public class AddressLookupV0Request
    {
        /// <summary>
        /// The first line of the address.
        /// </summary>
        /// <value>The first line of the address.</value>
        [DataMember(Name="line1", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "line1")]
        public string Line1 { get; set; }

        /// <summary>
        /// The second line of the address.
        /// </summary>
        /// <value>The second line of the address.</value>
        [DataMember(Name="line2", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "line2")]
        public string Line2 { get; set; }

        /// <summary>
        /// The third line of the address.
        /// </summary>
        /// <value>The third line of the address.</value>
        [DataMember(Name="line3", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "line3")]
        public string Line3 { get; set; }

        /// <summary>
        /// The area such as town or city or municipality of the address.
        /// </summary>
        /// <value>The area such as town or city or municipality of the address.</value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "locality")]
        public string Locality { get; set; }

        /// <summary>
        /// The area such as state or county or province of the address.
        /// </summary>
        /// <value>The area such as state or county or province of the address.</value>
        [DataMember(Name="province", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "province")]
        public string Province { get; set; }

        /// <summary>
        /// The postal or ZIP code of the address.
        /// </summary>
        /// <value>The postal or ZIP code of the address.</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "postal_code")]
        public string PostalCode { get; set; }
    }
}
