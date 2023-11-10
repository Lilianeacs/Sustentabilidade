﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionTrend.Application.UseCases.CreateSupplier
{
    public sealed record CreateSupplierResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TipoMaquina { get; set; }
        public string TipoMaterial { get; set; }
    }
}