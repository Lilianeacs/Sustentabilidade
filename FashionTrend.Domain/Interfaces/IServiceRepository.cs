﻿using FashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionTrend.Domain.Interfaces
{
    public interface IServiceRepository : IBaseRepository<Service>
    {
        Task<List<Service>> GetByType(string type, CancellationToken cancellationToken);
        Task<List<Service>> GetByMachine(string machine, CancellationToken cancellationToken);
        Task<List<Service>> GetByMaterial(string material, CancellationToken cancellationToken);
    }
}