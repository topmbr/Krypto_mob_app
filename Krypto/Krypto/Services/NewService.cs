﻿using Krypto.Interface;
using Krypto.Interfaces;
using Krypto.Repositories;

namespace Krypto.Services
{
    public class NewService : INewService
    {
        private readonly IRepository _repository;

        public NewService(IRepository repository)
        {
            _repository = repository;
        }

        public string GetMessage()
        {
            return _repository.GetData();
        }
    }
}
