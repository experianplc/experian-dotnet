namespace Experian.Api.Client.IntegrationTests
{
    using Xunit;

    [CollectionDefinition("Service collection")]
    public sealed class ServiceCollection : ICollectionFixture<AuthorisationFixture>
    {
    }
}