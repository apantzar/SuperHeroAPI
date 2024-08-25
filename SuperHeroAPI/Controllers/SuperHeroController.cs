using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Data;
using SuperHeroAPI.Entities;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        private readonly DataContext _context;

        public SuperHeroController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            var heroes = await _context.SuperHeroes.ToListAsync();

            return Ok(heroes);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<List<SuperHero>>> GetHero(int id)
        {
            var hero = await _context.SuperHeroes.FindAsync(id);

            if (hero is null)
            {
                return NotFound("Hero not found :( ");
            }

            return Ok(hero);
        }


        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero superhero)
        {
            _context.SuperHeroes.Add(superhero);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero superhero)
        {
            var hero = await _context.SuperHeroes.FindAsync(superhero.Id);

            if (hero is null)
                return NotFound("Hero not found!");

            hero.Name = superhero.Name;
            hero.FirstName = superhero.FirstName;
            hero.LastName = superhero.LastName;
            hero.Place = superhero.Place;

            await _context.SaveChangesAsync();

            return Ok();

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeletHero(int id)
        {

            var hero = await _context.SuperHeroes.FindAsync(id);

            if (hero is null)
                return NotFound("Hero not found!");

            _context.SuperHeroes.Remove(hero);

            await _context.SaveChangesAsync();
            return Ok("Hero deleted");

        }
    }
}
