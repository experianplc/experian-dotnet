namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// The email enrich v0 request.
    /// </summary>
    [DataContract]
  public class EmailEnrichV0Request
    {
    /// <summary>
    /// The email address submitted to be validated, such as example@example.com.
    /// </summary>
    /// <value>The email address submitted to be validated, such as example@example.com.</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// The email validation search timeout in seconds. If a timeout occurs, the email certainty status of Unknown will be returned. This setting will have an impact on performance and accuracy. A low value (e.g. 3 seconds) might lead to an inaccurate email result of Unknown status; while a higher value will impact the performance of the returned result.
    /// </summary>
    /// <value>The email validation search timeout in seconds. If a timeout occurs, the email certainty status of Unknown will be returned. This setting will have an impact on performance and accuracy. A low value (e.g. 3 seconds) might lead to an inaccurate email result of Unknown status; while a higher value will impact the performance of the returned result.</value>
    [DataMember(Name="timeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeout")]
    public int? Timeout { get; set; }

    /// <summary>
    /// The dataset and specific attributes to be returned.
    /// </summary>
    /// <value>The dataset and specific attributes to be returned.</value>
    [DataMember(Name="attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributes")]
    public EmailEnrichV0DatasetAttributes Attributes { get; set; }
}
}
