namespace Experian.Api.Client.DQ
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// The address lookup v0 suggestion.
    /// </summary>
    [DataContract]
  public class AddressLookupV0Suggestion
    {
    /// <summary>
    /// A possible match against the user's input query string.
    /// </summary>
    /// <value>A possible match against the user's input query string.</value>
    [DataMember(Name="suggestion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suggestion")]
    public string Suggestion { get; set; }

    /// <summary>
    /// Address components that were matched.
    /// </summary>
    /// <value>Address components that were matched.</value>
    [DataMember(Name="matched", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "matched")]
    public List<List<int?>> Matched { get; set; }

    /// <summary>
    /// A suggestion is returned with a format value.  If selected by the user, a call is triggered to format and finalise the address.
    /// </summary>
    /// <value>A suggestion is returned with a format value.  If selected by the user, a call is triggered to format and finalise the address.</value>
    [DataMember(Name="format", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "format")]
    public string Format { get; set; }
}
}
