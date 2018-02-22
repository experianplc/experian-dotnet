namespace Experian.Api.Client.Tests
{
    using Xunit;

    [CollectionDefinition("Service collection")]
    public sealed class ServiceCollection : ICollectionFixture<AuthorisationFixture>
    {
    }
}