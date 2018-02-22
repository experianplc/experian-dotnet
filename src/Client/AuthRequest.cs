namespace Experian.Api.Client
{
    public sealed class AuthRequest
    {
        public AuthRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
