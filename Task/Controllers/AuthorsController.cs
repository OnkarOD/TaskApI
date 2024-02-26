using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;


    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthorsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddAuthor([FromBody] Author author)
        {
            _context.Authors.Add(author);
            await _context.SaveChangesAsync();
            return Ok(author);
        }
    }




