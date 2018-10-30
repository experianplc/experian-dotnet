namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    public class ProblemDetails
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "status")]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or Sets Detail
        /// </summary>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "detail")]
        public string Detail { get; set; }

        /// <summary>
        /// Gets or Sets Instance
        /// </summary>
        [DataMember(Name="instance", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "instance")]
        public string Instance { get; set; }
    }
}
