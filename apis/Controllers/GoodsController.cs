using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoughDataWebApi.apis.Datas;
using RoughDataWebApi.apis.Models;
using RoughDataWebApi.apis.Dtos;

namespace apis.Controllers
{
    [Route("api/moudle-api-endpoint")] // sample : [Route("api/user")], [Route("api/sales")], [Route("api/registration")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GoodsController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(string? searchDocnr = null, int page = 1, int pageSize = 10)
        {
            var results = new Dictionary<string, object>{
                { "success", false },
                { "message", "Server Error" },
                { "count", 0 },
                { "data", new List<object>() },
            };

            if (_context.TableModel == null)
            {
                results["message"] = "No tableData available.";
                return NotFound(results);
            }

            var query = _context.TableModel.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchDocnr))
            {
                query = query.Where(g => g.COL_3_STRNG.Contains(searchDocnr));
            }
            
            var totalCount = await query.CountAsync();

            
            var tableDataList = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            if (!tableDataList.Any())
            {
                var TableDto = tableDataList.Select(g => new TableDto(g)).ToList();

                results["success"] = true;
                results["message"] = "Records found successfully";
                results["count"] = TableDto.Count;
                results["data"] = TableDto;
                return Ok(results);
            }
            else
            {
                results["message"] = "Records not found.";
                return BadRequest(results);
            }

        }

    }
}
