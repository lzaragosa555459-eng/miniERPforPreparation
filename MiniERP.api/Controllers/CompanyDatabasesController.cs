using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniERP.Domain.Entities;
using MiniERP.Infrastructure.Data;

namespace MiniERP.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CompanyDatabasesController : ControllerBase
{
    private readonly MasterErpDbContext _context;

    public CompanyDatabasesController(MasterErpDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CompanyDatabase>>> GetCompanyDatabases()
    {
        return await _context.CompanyDatabases
            .Include(x => x.Company)
            .ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<CompanyDatabase>> CreateCompanyDatabase(
        CompanyDatabase companyDatabase)
    {
        _context.CompanyDatabases.Add(companyDatabase);

        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetCompanyDatabases),
            new { id = companyDatabase.CompanyDatabaseId },
            companyDatabase);
    }
}