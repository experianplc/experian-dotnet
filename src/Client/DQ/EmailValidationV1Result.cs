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
  public class EmailValidationV1Result
    {
    /// <summary>
    /// The submitted email address.
    /// </summary>
    /// <value>The submitted email address.</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// The email status.
    /// </summary>
    /// <value>The email status.</value>
    [DataMember(Name="confidence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "confidence")]
    public string Confidence { get; set; }

    /// <summary>
    /// The summary of request’s status.
    /// </summary>
    /// <value>The summary of request’s status.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Additional information regarding Certainty responses when verbose flag is True.
    /// </summary>
    /// <value>Additional information regarding Certainty responses when verbose flag is True.</value>
    [DataMember(Name="verbose", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verbose")]
    public string Verbose { get; set; }

    /// <summary>
    /// A list of email corrections returned. If available Email Validate API can also return email corrections for syntax mistakes in an email. A maximum of 8 email corrections can be returned in the responses, if available.
    /// </summary>
    /// <value>A list of email corrections returned. If available Email Validate API can also return email corrections for syntax mistakes in an email. A maximum of 8 email corrections can be returned in the responses, if available.</value>
    [DataMember(Name="corrections", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "corrections")]
    public List<string> Corrections { get; set; }
}
}
