﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltraGroupHotelAPI.Domain.Common;

namespace UltraGroupHotelAPI.Application.Contracts.Persistence
{
    public interface IUnitOfWork: IDisposable
    {
        IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : EntityBase;

        Task<int> Complete();

    }
}
