namespace Experian.Api.Client.DQ
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Details about the result. Includes the validated data and its confidence level.
    /// </summary>
    [DataContract]
  public class AddressSearchV0Result
    {
    /// <summary>
    /// The number of returned suggestions.
    /// </summary>
    /// <value>The number of returned suggestions.</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// The total number of suggestions that match the input.
    /// </summary>
    /// <value>The total number of suggestions that match the input.</value>
    [DataMember(Name="total_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_count")]
    public int? TotalCount { get; set; }

    /// <summary>
    /// A number of possible matches against the user's input query string.
    /// </summary>
    /// <value>A number of possible matches against the user's input query string.</value>
    [DataMember(Name="suggestions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suggestions")]
    public List<AddressSearchV0Suggestion> Suggestions { get; set; }
}
}
