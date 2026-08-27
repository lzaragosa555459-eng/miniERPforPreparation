using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CompanyEntity = MiniERP.Domain.Entities.Company;
using MiniERP.Infrastructure.Data;

namespace MiniERP.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CompaniesController : ControllerBase
{
    private readonly MasterErpDbContext _context;

    public CompaniesController(MasterErpDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CompanyEntity>>> GetCompanies()
    {
        return await _context.Companies.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<CompanyEntity>> CreateCompany(CompanyEntity company)
    {
        _context.Companies.Add(company);

        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetCompanies),
            new { id = company.CompanyId },
            company);
    }
}