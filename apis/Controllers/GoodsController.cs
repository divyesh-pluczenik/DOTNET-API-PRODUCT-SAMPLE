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
        public async Task<IActionResult> GetAllAsync()
        {
            var results = new Dictionary<string, object>
            {
                { "success", false },
                { "data", new List<object>() },
                { "message", "Server Error" },
                { "count", 0 }
            };

            if (_context.Goods == null)
            {
                results["message"] = "No goods available.";
                return Ok(results);
            }

            var goods = await _context.Goods.ToListAsync();

            if (goods.Any())
            {
                var goodsDto = goods.Select(g => new GoodsDto(g)).ToList(); // Pass the Goods entity to GoodsDto

                results["success"] = true;
                results["message"] = "Records found successfully";
                results["data"] = goodsDto;
                results["count"] = goodsDto.Count;
            }
            else
            {
                results["message"] = "Records not found.";
            }

            return Ok(results);
        }
    }
}
