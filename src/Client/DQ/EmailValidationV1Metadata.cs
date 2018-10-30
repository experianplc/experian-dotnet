namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Metadata containing additional dataset specific values where relevant.
    /// </summary>
    [DataContract]
  public class EmailValidationV1Metadata
    {
    /// <summary>
    /// The request response code.
    /// </summary>
    /// <value>The request response code.</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// The request response message.
    /// </summary>
    /// <value>The request response message.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Additional information regarding Certainty responses when verbose flag is True.
    /// </summary>
    /// <value>Additional information regarding Certainty responses when verbose flag is True.</value>
    [DataMember(Name="email_verbose", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email_verbose")]
    public string EmailVerbose { get; set; }
}
}
