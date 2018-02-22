namespace Experian.Api.Client.Bis
{
    public sealed class ContactsAndTitlesResult
    {
        private int SequenceNumber { get; set; }

        private string Cid { get; set; }

        private string Title { get; set; }

        private bool ContactActivityIndicator { get; set; }

        private string ContactSupplier { get; set; }

        private string FirstName { get; set; }

        private string MiddleName { get; set; }

        private string LastName { get; set; }

        private string GenerationCode { get; set; }
    }
}