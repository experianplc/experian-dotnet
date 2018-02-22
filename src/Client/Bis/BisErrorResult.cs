namespace Experian.Api.Client.Bis
{
    public sealed class BisErrorResult
    {
        public string ErrorCode { get; set; }

        public string ErrorType { get; set; }

        public string Message   { get; set; }
    }
}