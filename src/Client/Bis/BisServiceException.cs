namespace Experian.Api.Client.Bis
{
    using System;

    public class BisServiceException : Exception
    {
        private const long SerialVersionUID = 1982347L;

        public BisServiceException(string message)
            : base(message)
        {
        }

        public BisServiceException(string message, BisErrorResponse serviceError)
            : base(message)
        {
            this.ErrorResponse = serviceError;
        }

        public BisServiceException(string message, Exception ex, BisErrorResponse serviceError)
            : base(message, ex)
        {
            this.ErrorResponse = serviceError;
        }

        public BisServiceException(Exception ex, BisErrorResponse serviceError)
            : base(ex.Message, ex)
        {
            this.ErrorResponse = serviceError;
        }

        public BisErrorResponse ErrorResponse { get; }
    }
}
