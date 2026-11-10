namespace CryptoApi.Application
{
    public record GetCryptoPricesResponse
    {
        public IReadOnlyCollection<CryptoPriceItem> Prices { get; init; }
       = Array.Empty<CryptoPriceItem>();
    }
}
