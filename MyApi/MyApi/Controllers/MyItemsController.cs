using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApi.Models;

namespace MyApi.Controllers
{// маршрутизация Возьмите строку шаблона в атрибуте [Route] контроллера
    //Замените[controller] именем контроллера(по соглашению это имя класса контроллера 
    //без суффикса "Controller"). В этом примере класс контроллера имеет имя MyItems, 
    //а сам контроллер, соответственно, — "MyItems". В ASP.NET Core маршрутизация реализуется 
    //без учета регистра символов
    [Route("api/MyItems")]
    [ApiController]//Этот атрибут указывает, что контроллер отвечает на запросы веб-API.
    public class MyItemsController : ControllerBase
    {
        private readonly MyContext _context;

        public MyItemsController(MyContext context)
        {
            _context = context;
        }

        // POST: api/MyItems
        //В случае успеха возвращает код состояния HTTP 201. HTTP 201 представляет собой стандартный
        //ответ для метода HTTP POST, создающий ресурс на сервере.
        //Добавляет в ответ заголовок Location.Заголовок Location указывает URI новой созданной задачи.

        // GET: api/MyItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MyItem>>> GetTodoItems()
        {
            return await _context.TodoItems.ToListAsync();
        }



        // GET: api/MyItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MyItem>> GetMyItem(long id)
        {
            var myItem = await _context.TodoItems.FindAsync(id);

            if (myItem == null)
            {
                return NotFound();
            }

            return myItem;
        }

        // PUT: api/MyItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(long id, MyItem todoItem)
        {
            if (id != todoItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(todoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MyItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MyItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
//В случае успеха возвращает код состояния HTTP 201. HTTP 201 представляет собой стандартный
//ответ для метода HTTP POST, создающий ресурс на сервере.
//Добавляет в ответ заголовок Location.Заголовок Location указывает URI новой созданной задачи.

       [HttpPost]
        public async Task<ActionResult<MyItem>> PostMyItem(MyItem myItem)
        {
            _context.TodoItems.Add(myItem);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetMyItem", new { id = myItem.Id }, myItem);
            return CreatedAtAction(nameof(GetMyItem), new { id = myItem.Id }, myItem);
        }

        // DELETE: api/MyItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MyItem>> DeleteMyItem(long id)
        {
            var myItem = await _context.TodoItems.FindAsync(id);
            if (myItem == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(myItem);
            await _context.SaveChangesAsync();

            return myItem;
        }

        private bool MyItemExists(long id)
        {
            return _context.TodoItems.Any(e => e.Id == id);
        }
    }
}
