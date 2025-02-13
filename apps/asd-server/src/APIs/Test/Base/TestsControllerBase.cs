using Asd.APIs;
using Asd.APIs.Common;
using Asd.APIs.Dtos;
using Asd.APIs.Errors;
using Microsoft.AspNetCore.Mvc;

namespace Asd.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class TestsControllerBase : ControllerBase
{
    protected readonly ITestsService _service;

    public TestsControllerBase(ITestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Test
    /// </summary>
    [HttpPost()]
    public async Task<ActionResult<Test>> CreateTest(TestCreateInput input)
    {
        var test = await _service.CreateTest(input);

        return CreatedAtAction(nameof(Test), new { id = test.Id }, test);
    }

    /// <summary>
    /// Delete one Test
    /// </summary>
    [HttpDelete("{Id}")]
    public async Task<ActionResult> DeleteTest([FromRoute()] TestWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteTest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Tests
    /// </summary>
    [HttpGet()]
    public async Task<ActionResult<List<Test>>> Tests([FromQuery()] TestFindManyArgs filter)
    {
        return Ok(await _service.Tests(filter));
    }

    /// <summary>
    /// Meta data about Test records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> TestsMeta([FromQuery()] TestFindManyArgs filter)
    {
        return Ok(await _service.TestsMeta(filter));
    }

    /// <summary>
    /// Get one Test
    /// </summary>
    [HttpGet("{Id}")]
    public async Task<ActionResult<Test>> Test([FromRoute()] TestWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Test(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Test
    /// </summary>
    [HttpPatch("{Id}")]
    public async Task<ActionResult> UpdateTest(
        [FromRoute()] TestWhereUniqueInput uniqueId,
        [FromQuery()] TestUpdateInput testUpdateDto
    )
    {
        try
        {
            await _service.UpdateTest(uniqueId, testUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
