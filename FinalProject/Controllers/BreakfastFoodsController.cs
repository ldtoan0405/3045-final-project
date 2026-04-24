using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreakfastFoodsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BreakfastFoodsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/BreakfastFoods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BreakfastFood>>> GetBreakfastFoods(int? id)
        {
            // If id is null or 0, return the first 5 records
            if (id == null || id == 0)
            {
                return await _context.BreakfastFoods.Take(5).ToListAsync();
            }

            // Otherwise, find the specific food item
            var breakfastFood = await _context.BreakfastFoods.FindAsync(id);

            if (breakfastFood == null)
            {
                return NotFound();
            }

            return Ok(new List<BreakfastFood> { breakfastFood });
        }

        // PUT: api/BreakfastFoods/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBreakfastFood(int id, BreakfastFood breakfastFood)
        {
            if (id != breakfastFood.Id)
            {
                return BadRequest();
            }

            _context.Entry(breakfastFood).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BreakfastFoodExists(id))
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

        // POST: api/BreakfastFoods
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BreakfastFood>> PostBreakfastFood(BreakfastFood breakfastFood)
        {
            _context.BreakfastFoods.Add(breakfastFood);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBreakfastFood", new { id = breakfastFood.Id }, breakfastFood);
        }

        // DELETE: api/BreakfastFoods/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBreakfastFood(int id)
        {
            var breakfastFood = await _context.BreakfastFoods.FindAsync(id);
            if (breakfastFood == null)
            {
                return NotFound();
            }

            _context.BreakfastFoods.Remove(breakfastFood);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BreakfastFoodExists(int id)
        {
            return _context.BreakfastFoods.Any(e => e.Id == id);
        }
    }
}
