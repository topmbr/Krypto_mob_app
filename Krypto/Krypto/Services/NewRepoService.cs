using Krypto.Interface;
using Krypto.Interfaces;

namespace Krypto.Services
{
    public class NewRepoService : INewService
    {
        private readonly IRepository _repository;

        public NewRepoService(IRepository repository)
        {
            _repository = repository;
        }

        public string GetMessage()
        {
            return _repository.GetData();
        }

    }
}
