using FashionTrend.Application.UseCases._Supplier.CreateSupplier;
using FashionTrend.Application.UseCases._Supplier.DeleteSupplier;
using FashionTrend.Application.UseCases._Supplier.GetAllSupplier;
using FashionTrend.Application.UseCases._Supplier.UpdateSupplier;
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

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateSupplierRequest request)
        {
            var supplier = await _mediator.Send(request);
            return Ok(supplier);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id is null)
                return BadRequest();

            var delete = new DeleteSupplierRequest(id.Value);
            var resposta = await _mediator.Send(delete);

            return Ok(resposta);
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<GetAllSupplierRequest>>> GetAll(CancellationToken cancellationToken)
        {
            var resposta = await _mediator.Send(new GetAllSupplierRequest(), cancellationToken);
            return Ok(resposta);
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(Guid? id, UpdateSupplierRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            var resposta = await _mediator.Send(request);
            return Ok(resposta);
        }

    }
}
