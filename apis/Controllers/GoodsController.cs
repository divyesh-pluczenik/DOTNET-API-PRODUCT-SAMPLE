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
    [Route("api/goods")]
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

            if (_context.Goods == null)
            {
                results["message"] = "No goods available.";
                return NotFound(results);
            }

            var query = _context.Goods.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchDocnr))
            {
                query = query.Where(g => g.TGD_DOCNR.Contains(searchDocnr));
            }
            
            var totalCount = await query.CountAsync();

            
            var goods = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            if (!goods.Any())
            {
                var goodsDto = goods.Select(g => new GoodsDto(g)).ToList();

                results["success"] = true;
                results["message"] = "Records found successfully";
                results["count"] = goodsDto.Count;
                results["data"] = goodsDto;
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
