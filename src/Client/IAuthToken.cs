namespace Experian.Api.Client
{
    public interface IAuthToken
    {
        string Value { get; }

        string TokenType { get; }
    }
}
