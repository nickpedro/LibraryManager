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
        private readonly IOpenLibraryService _openLibraryService;

        public LivroController(
            ILivroService service,
            IOpenLibraryService openLibraryService)
        {
            _service = service;
            _openLibraryService = openLibraryService;
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

        [HttpGet("buscar-isbn/{isbn}")]
        public async Task<IActionResult> BuscarPorIsbn(string isbn)
        {
            var resultado =
                await _openLibraryService.BuscarLivroPorIsbnAsync(isbn);

            if (resultado == null)
            {
                return NotFound(
                    "Livro não encontrado na Open Library.");
            }

            return Ok(resultado);
        }

        // Busca os dados na Open Library e cadastra o livro no banco.
        [HttpPost("cadastrar-isbn")]
        public async Task<IActionResult> CadastrarPorIsbn(LivroIsbnRequest request)
        {
            var livro = await _service.AddByIsbnAsync(request);

            return CreatedAtAction(
                nameof(GetById),
                new { id = livro.Id },
                livro);
        }

        [HttpPost]
        public async Task<IActionResult> Create(LivroRequest request)
        {
            await _service.AddAsync(request);

            return Created();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(
            int id,
            LivroRequest request)
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