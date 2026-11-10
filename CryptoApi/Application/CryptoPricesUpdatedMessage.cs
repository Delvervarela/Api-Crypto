namespace CryptoApi.Application
{
    public record  CryptoPricesUpdatedMessage
    {

        public IReadOnlyCollection<CryptoPriceItem> Updates { get; set; }
        = Array.Empty < CryptoPriceItem>();
    }
}
