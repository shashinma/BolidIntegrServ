using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BolidIntegrServ.Data;

namespace BolidIntegrServ.Controllers;

[ApiController]
[Route("[controller]")]
public class OrionController : ControllerBase
{
    private readonly OrionDbContext _dbContext;


    public OrionController(OrionDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpGet("GetEntityByTabNumber/{tabNumber}")]
    public async Task<IActionResult> GetEntityByTabNumber(string tabNumber)
    {
        var pListEntity = await _dbContext.pList.FirstOrDefaultAsync(e => e.TabNumber == tabNumber );

        if (pListEntity == null)
        {
            return NotFound();
        }

        var pLogDataEntities = await _dbContext.pLogData.FirstOrDefaultAsync(e => e.HozOrgan == pListEntity.ID);

        return Ok(pLogDataEntities);
    }
}