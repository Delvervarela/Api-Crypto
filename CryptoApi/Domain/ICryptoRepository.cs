namespace CryptoApi.Domain
{
    public interface ICryptoRepository
    {
        IReadOnlyCollection<Crypto> GetAll();
        Crypto? GetById(string id);
    }
}
