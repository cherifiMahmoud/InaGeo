using InaGeo.Application.Features.Versions.Commands.CreateVersion;
using InaGeo.Application.Features.Versions.Commands.DeleteVersion;
using InaGeo.Application.Features.Versions.Commands.UpdateVersion;
using InaGeo.Application.Features.Versions.Queries.GetVersionList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InaGeo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        private readonly IMediator _mediator;
        public VersionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllVersion")]
        public async Task<ActionResult<List<GetVersionListViewModel>>> GetAllVersions()
        {
            var dtos = await _mediator.Send(new GetVersionListQuery());
            return Ok(dtos);
        }

        [HttpPost(Name = "AddVersion")]
        public async Task<ActionResult<string>> Create([FromBody] CreateVersionCommand createVersionCommand)
        {
            var id = await _mediator.Send(createVersionCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateVersion")]
        public async Task<ActionResult> Update([FromBody] UpdateVersionCommand updateVersionCommand)
        {
            await _mediator.Send(updateVersionCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteVersion")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteVersionCommand = new DeleteVersionCommand() { IdVersion = id };
            await _mediator.Send(deleteVersionCommand);
            return NoContent();
        }


    }
}
