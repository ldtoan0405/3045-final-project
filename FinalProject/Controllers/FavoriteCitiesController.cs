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
    public class FavoriteCitiesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FavoriteCitiesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/FavoriteCities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FavoriteCity>>> GetFavoriteCities(int? id)
        {
            // If id is null or 0, return the first 5 records
            if (id == null || id == 0)
            {
                return await _context.FavoriteCities.Take(5).ToListAsync();
            }

            // Otherwise, find the specific city
            var favoriteCity = await _context.FavoriteCities.FindAsync(id);

            if (favoriteCity == null)
            {
                return NotFound();
            }

            return Ok(new List<FavoriteCity> { favoriteCity });
        }

        // PUT: api/FavoriteCities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFavoriteCity(int id, FavoriteCity favoriteCity)
        {
            if (id != favoriteCity.Id)
            {
                return BadRequest();
            }

            _context.Entry(favoriteCity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavoriteCityExists(id))
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

        // POST: api/FavoriteCities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FavoriteCity>> PostFavoriteCity(FavoriteCity favoriteCity)
        {
            _context.FavoriteCities.Add(favoriteCity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFavoriteCity", new { id = favoriteCity.Id }, favoriteCity);
        }

        // DELETE: api/FavoriteCities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFavoriteCity(int id)
        {
            var favoriteCity = await _context.FavoriteCities.FindAsync(id);
            if (favoriteCity == null)
            {
                return NotFound();
            }

            _context.FavoriteCities.Remove(favoriteCity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FavoriteCityExists(int id)
        {
            return _context.FavoriteCities.Any(e => e.Id == id);
        }
    }
}
