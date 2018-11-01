namespace Experian.Api.Client
{
   using System.Collections.Generic;

    public interface IHeader
    {
        Dictionary<string, string> Headers { get; }
    }
}