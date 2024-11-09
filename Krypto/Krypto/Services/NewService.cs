using Krypto.Interface;

namespace Krypto.Services
{
    public class NewService : INewService
    {
        public string GetMessage()
        {
            return "I am new service";
        }
    }
}
