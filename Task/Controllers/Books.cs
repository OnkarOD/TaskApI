using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;


    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {


        private readonly AppDbContext _context;

        public BooksController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddBook([FromBody] Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return Ok(book);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet("filterByAuthor")]
        public IActionResult FilterByAuthor(int authorId)
        {
            var books = _context.Books
                .Where(b => b.AuthorId == authorId)
                .Include(b => b.Author)
                .ToList();

            return Ok(books);
        }

    }


