using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BolidIntegrServ.Data;
using BolidIntegrServ.Models;

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
        IQueryable<pList> pListQuery = _dbContext.pList;
        IQueryable<pLogData> pLogDataQuery = _dbContext.pLogData;
        
        var pListEntity = await pListQuery.SingleOrDefaultAsync(pList => pList.TabNumber == tabNumber);
        
        if (pListEntity == null)
        {
            return NotFound();
        }
        
        var pLogDataEntities = await pLogDataQuery.FirstOrDefaultAsync(pLogData => pLogData.HozOrgan == pListEntity.ID);

        return Ok(pLogDataEntities);
    }
}