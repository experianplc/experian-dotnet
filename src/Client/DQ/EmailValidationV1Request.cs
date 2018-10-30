namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// The email validation v1 request.
    /// </summary>
    [DataContract]
  public class EmailValidationV1Request
    {
    /// <summary>
    /// The input email address.
    /// </summary>
    /// <value>The input email address.</value>
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
}
}
