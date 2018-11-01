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
  public class EmailEnrichV0Result
    {
    /// <summary>
    /// The email address submitted to be validated, such as example@example.com.
    /// </summary>
    /// <value>The email address submitted to be validated, such as example@example.com.</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// The outcome (confidence level) of the validation search.
    /// </summary>
    /// <value>The outcome (confidence level) of the validation search.</value>
    [DataMember(Name="confidence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "confidence")]
    public string Confidence { get; set; }

    /// <summary>
    /// List of email corrections returned to help correct syntax mistakes in input.
    /// </summary>
    /// <value>List of email corrections returned to help correct syntax mistakes in input.</value>
    [DataMember(Name="corrections", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "corrections")]
    public List<string> Corrections { get; set; }

    /// <summary>
    /// The dataset and specific attributes to be returned.
    /// </summary>
    /// <value>The dataset and specific attributes to be returned.</value>
    [DataMember(Name="attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributes")]
    public EmailEnrichV0AttributesResult Attributes { get; set; }
}
}
