using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace HeroAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController: ControllerBase
    {
        private readonly ApplicationDbContext ctx;

        public CharacterController(ApplicationDbContext dbContext)
        {
            ctx = dbContext;
        }

        [HttpPost(Name = "Add a character")]
        public async Task<ActionResult> AddCharacter(Character request)
        {
            await ctx.Character.AddAsync(new Character()
            {
                Id = request.Id,
                Name = request.Name,
                PrimaryPlaystyle = request.PrimaryPlaystyle,
                SecondaryPlaystyle = request.SecondaryPlaystyle,
                SwordUser = request.SwordUser,
                Tier = request.Tier,
            });

            await ctx.SaveChangesAsync();
            return Ok(ctx.Character);
        }
        
        [HttpGet(Name = "Show all characters")]

        public async Task<IEnumerable<Character>> Get()
        {
            return await ctx.Character.ToListAsync();
        }
        /*
        [HttpPost(Name = "Delete a character")]
        public async Task<ActionResult> DeleteCharacter(Character request)
        {
            await ctx.Character.AddAsync(new Character()
            {
                Id = request.Id,
                Name = request.Name,
                PrimaryPlaystyle = request.PrimaryPlaystyle,
                SecondaryPlaystyle = request.SecondaryPlaystyle,
                SwordUser = request.SwordUser,
                Tier = request.Tier,
            });

            await ctx.SaveChangesAsync();
            return Ok(ctx.Character);
        }*/
    }
}