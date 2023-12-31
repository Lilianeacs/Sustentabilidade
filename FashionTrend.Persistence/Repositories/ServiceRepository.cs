﻿using FashionTrend.Domain.Entities;
using FashionTrend.Domain.Interfaces;
using FashionTrend.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace FashionTrend.Persistence.Repositories
{
    public class ServiceRepository : BaseRepository<Service>, IServiceRepository
    {
        public ServiceRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Service>> GetByMachine(string machine, CancellationToken cancellationToken)
        {
            return await Context.Services.Where(
            x => x.MachineType.Any(s => s.Equals(machine))).ToListAsync(cancellationToken);
        }

        public async Task<List<Service>> GetByMaterial(string material, CancellationToken cancellationToken)
        {
            return await Context.Services.Where(
            x => x.MaterialType.Any(s => s.Equals(material))).ToListAsync(cancellationToken);
        }

        public async Task<List<Service>> GetByType(string type, CancellationToken cancellationToken)
        {
            return await Context.Services.Where(
                x => x.Type.Any(s => s.Equals(type))).ToListAsync(cancellationToken);
        }
    }
}
