using Application.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/spendings")]
    public class SpendingController : Controller
    {
        private readonly SpendingService _spendingService;
        private readonly IMapper _mapper;

        public SpendingController(SpendingService spendingService, IMapper mapper)
        {
            _spendingService = spendingService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateSpendingRequest request)
        {
            var id = await _spendingService.Create(new Application.DTOs.CreateSpendingDto
            {
                Amount = request.Amount,
                Date = request.Date,
                Description = request.Description,
                Name = request.Name 
            });
            return Json(new { id });
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var spendings = await _spendingService.GetAll();
            return Json(spendings);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var spending = await _spendingService.GetById(id);
            if (spending == null)
            {
                return NotFound();
            }
            return Json(spending);
        }
    }
}
