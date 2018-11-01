namespace Experian.Api.Client.DQ
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// The address validation v0 request.
    /// </summary>
    [DataContract]
  public class AddressValidationV0Request
    {
    /// <summary>
    /// The address components to be validated, such as line1, line2, line3, locality, province, postal_code, country.
    /// </summary>
    /// <value>The address components to be validated, such as line1, line2, line3, locality, province, postal_code, country.</value>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public List<string> Address { get; set; }

    /// <summary>
    /// The area such as town or city or municipality of the address.
    /// </summary>
    /// <value>The area such as town or city or municipality of the address.</value>
    [DataMember(Name="locality", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locality")]
    public string Locality { get; set; }

    /// <summary>
    /// The region where the address is located.
    /// </summary>
    /// <value>The region where the address is located.</value>
    [DataMember(Name="region", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "region")]
    public string Region { get; set; }

    /// <summary>
    /// The postal or ZIP code of the address.
    /// </summary>
    /// <value>The postal or ZIP code of the address.</value>
    [DataMember(Name="postal_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postal_code")]
    public string PostalCode { get; set; }
}
}
