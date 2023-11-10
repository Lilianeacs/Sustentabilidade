﻿using FashionTrend.Application.UseCases.CreateSupplier;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FashionTrend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        IMediator _mediator;

        public SupplierController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateSupplierRequest request)
        {
            var user = await _mediator.Send(request);
            return Ok(user);
        }

        


    }
}