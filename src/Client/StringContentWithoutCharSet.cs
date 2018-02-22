namespace Experian.Api.Client
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;

    internal sealed class StringContentWithoutCharset : StringContent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringContentWithoutCharset"/> class.
        /// Removes charset from media type to workaround incorrect server implementation.
        /// </summary>
        /// <param name="content">Content to send</param>
        /// <param name="encoding">Encoding that will be ignored</param>
        /// <param name="contentType">Content type to use</param>
        public StringContentWithoutCharset(string content, Encoding encoding, string contentType)
            : base(content, encoding, contentType)
            => Headers.ContentType = new MediaTypeHeaderValue(contentType);
    }
}
