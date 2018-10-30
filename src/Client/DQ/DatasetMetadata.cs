namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// The &lt;seealso cref&#x3D;\&quot;T:Experian.Hub.RealTimeHubService.Models.DatasetMetadata\&quot; /&gt;.
    /// </summary>
    [DataContract]
  public class DatasetMetadata
    {
    /// <summary>
    /// The metadata code.
    /// </summary>
    /// <value>The metadata code.</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// The metadata message.
    /// </summary>
    /// <value>The metadata message.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// The metadata value.
    /// </summary>
    /// <value>The metadata value.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }
}
}
