﻿using SnappetChallenge.Application.Mappers;
using SnappetChallenge.Infra.Data.Interfaces;

namespace SnappetChallenge.Application
{
    public class ApplicationService
    {
        private readonly IUnitOfWork _uow;

        public ApplicationService(IUnitOfWork uow)
        {
            _uow = uow;
            DomainToViewModelMappingProfile.Init();
        }

        public void BeginTransaction()
        {
            _uow.BeginTransaction();
        }

        public void Commit()
        {
            _uow.Commit();
        }
    }
}
