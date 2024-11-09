using Krypto.Interfaces;

namespace Krypto.Repositories
{
    public class NewRepository : IRepository
    {
        public string GetData()
        {
            return "Sample data from repository";
        }
    }
}
