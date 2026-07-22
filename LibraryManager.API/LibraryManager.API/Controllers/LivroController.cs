using LibraryManager.API.DTOs;
using LibraryManager.API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivroController : ControllerBase
    {
        private readonly ILivroService _service;

        public LivroController(ILivroService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var livros = await _service.GetAllAsync();
            return Ok(livros);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var livro = await _service.GetByIdAsync(id);

            if (livro == null)
                return NotFound();

            return Ok(livro);
        }

        [HttpPost]
        public async Task<IActionResult> Create(LivroRequest request)
        {
            await _service.AddAsync(request);

            return Created();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, LivroRequest request)
        {
            await _service.UpdateAsync(id, request);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);

            return NoContent();
        }
    }
}