using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api1.Models;
using Microsoft.Extensions.Logging;

namespace Api1.Controllers
{
    [Route("act/[controller]")]
    [ApiController]
    //Этот атрибут указывает, что контроллер отвечает на запросы веб-API.
    public class TodoItemsController : ControllerBase
    {


        private readonly TodoContext _context;

        public TodoItemsController(TodoContext context, ILogger<TodoItemsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        private readonly ILogger<TodoItemsController> _logger;

        //public TodoItemsController(ILogger<TodoItemsController> logger)
        //{
        //    _logger = logger;
        //}


        // logger.LogInformation("Processing request {0}", context.Request.Path);

        // GET: api/TodoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
        {
            _logger.LogInformation(DateTime.Now.ToLongTimeString() + ": The GET request is done.");
            return await _context.TodoItems.ToListAsync();
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetTodoItem(long id)
        {
            var todoItem = await _context.TodoItems.FindAsync(id);

            if (todoItem == null)
            {
                _logger.LogInformation(DateTime.Now.ToLongTimeString() + ": The GET request is not done. There is no item with such id");
                return NotFound();
            }

            _logger.LogInformation(DateTime.Now.ToLongTimeString() + ": The GET request is done.");
            return todoItem;
        }

        // PUT: api/TodoItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(long id, TodoItem todoItem)
        {
            if (id != todoItem.Id)
            {
                _logger.LogInformation(DateTime.Now.ToLongTimeString() + ": The PUT request isn't done. No such Id");
                return BadRequest();
            }

            _context.Entry(todoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                _logger.LogInformation(DateTime.Now.ToLongTimeString() + ": The PUT request is done");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(id))
                {
                   _logger.LogInformation(DateTime.Now.ToLongTimeString() + ": The PUT request isn't done. There is no item with this id");
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TodoItems
        //Этот метод получает значение элемента списка дел из текста HTTP-запроса.
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem )
        {
            _context.TodoItems.Add(todoItem);
            await _context.SaveChangesAsync();
           _logger.LogInformation(DateTime.Now.ToLongTimeString() + ": New POST request is got");
            return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
        }

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TodoItem>> DeleteTodoItem(long id)
        {
            var todoItem = await _context.TodoItems.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(todoItem);
            await _context.SaveChangesAsync();
            _logger.LogInformation(DateTime.Now.ToLongTimeString() + ": The DELETE request is done");

            return todoItem;
        }

        private bool TodoItemExists(long id)
        {
            return _context.TodoItems.Any(e => e.Id == id);
        }
    }
}
