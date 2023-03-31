using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoListApi.Models;

namespace ToDoListApi.Controllers
{
    //scafolded item add controller using ef actions
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListsController : ControllerBase
    {
        private readonly TodoContext _context;

        public ToDoListsController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/ToDoLists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDoList>>> Gettbl_TodoList()
        {
          if (_context.tbl_TodoList == null)
          {
              return NotFound();
          }
            return await _context.tbl_TodoList.ToListAsync();
        }

        // GET: api/ToDoLists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ToDoList>> GetToDoList(int id)
        {
          if (_context.tbl_TodoList == null)
          {
              return NotFound();
          }
            var toDoList = await _context.tbl_TodoList.FindAsync(id);

            if (toDoList == null)
            {
                return NotFound();
            }

            return toDoList;
        }

        // PUT: api/ToDoLists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToDoList(int id, ToDoList toDoList)
        {
            if (id != toDoList.Id)
            {
                return BadRequest();
            }

            _context.Entry(toDoList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToDoListExists(id))
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

        // POST: api/ToDoLists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ToDoList>> PostToDoList(ToDoList toDoList)
        {
          if (_context.tbl_TodoList == null)
          {
              return Problem("Entity set 'TodoContext.tbl_TodoList'  is null.");
          }
            _context.tbl_TodoList.Add(toDoList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetToDoList", new { id = toDoList.Id }, toDoList);

            //header içine location ekler
            //location: https://localhost:7244/api/ToDoLists/4 
            //db ye veri ekledi.
            //postman indirt.
            //rest service nedir
            //*Postman, API geliştirme için bir işbirliği platformudur. Postman'ın özellikleri, bir API oluşturmanın her adımını basitleştirir ve işbirliğini kolaylaştırarak daha iyi API'leri daha hızlı oluşturabilmenizi sağlar
            //rest servis denetlemek için uygulama
            //ssl sertification disabledemek lazım yoksa bilgileri çekemiyor.
            //post için body raw json format
            //CORS EKLETİP PROJEYE ULAŞTIRTABİLİRSİN.
        }

        // DELETE: api/ToDoLists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToDoList(int id)
        {
            if (_context.tbl_TodoList == null)
            {
                return NotFound();
            }
            var toDoList = await _context.tbl_TodoList.FindAsync(id);
            if (toDoList == null)
            {
                return NotFound();
            }

            _context.tbl_TodoList.Remove(toDoList);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ToDoListExists(int id)
        {
            return (_context.tbl_TodoList?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
