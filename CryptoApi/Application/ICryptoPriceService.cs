namespace CryptoApi.Application
{
    public interface ICryptoPriceService
    {
        Task<GetCryptoPricesResponse> GetCurrentPricesAsync(CancellationToken ct = default);
        Task<CryptoPricesUpdatedMessage?> GetDueUpdatesAsync(CancellationToken ct = default);
    }
}
