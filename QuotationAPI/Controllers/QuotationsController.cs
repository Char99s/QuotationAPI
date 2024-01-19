using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using QuotationAPI.Data;
using QuotationAPI.Models.Dto;

namespace QuotationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotationsController : ControllerBase
    {
        private readonly DataContext _context;

        public QuotationsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("Search")]
        public async Task<ActionResult> SearchByMakeOrOwner(String? searchTerm, Boolean isReversed, int page)
        {
            int pageSize = 10;

            IEnumerable<QuotationDto>? toReturn = null;

            if (searchTerm.IsNullOrEmpty())
            {
                toReturn = await _context.Quotations
                .Select(q => new QuotationDto
                {
                    QuotationNumber = q.Id,
                    PolicyOwner = q.PolicyOwner.FirstName + " " + q.PolicyOwner.LastName,
                    CarMake = q.Car.Make,
                    CarYearOfMake = q.Car.YearOfMake,
                    QuotationStatus = q.QuotationStatus,
                    CreationDate = q.CreationDate
                }).OrderByDescending(q => q.CreationDate)
                .ToListAsync();
            }
            else
            {
                toReturn = await _context.Quotations
                .Where(q => q.Car.Make.Contains(searchTerm) ||
                q.PolicyOwner.FirstName.Contains(searchTerm) ||
                q.PolicyOwner.LastName.Contains(searchTerm) ||
                (q.PolicyOwner.FirstName + " " + q.PolicyOwner.LastName).Contains(searchTerm))
                .OrderByDescending(q => q.CreationDate)
                .Select(q => new QuotationDto
                {
                    QuotationNumber = q.Id,
                    PolicyOwner = q.PolicyOwner.FirstName + " " + q.PolicyOwner.LastName,
                    CarMake = q.Car.Make,
                    CarYearOfMake = q.Car.YearOfMake,
                    QuotationStatus = q.QuotationStatus,
                    CreationDate = q.CreationDate
                }).ToListAsync();
            }

            if (toReturn.Count() == 0)
                return NotFound();

            var totalCount = toReturn.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

            if (isReversed)
                toReturn = toReturn.OrderBy(q => q.CreationDate).ToList();

            toReturn = toReturn.Skip((page - 1) * pageSize).Take(pageSize);

            var result = new
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                Quotations = toReturn.ToList()
            };

            return Ok(result);
        }
    }
}
