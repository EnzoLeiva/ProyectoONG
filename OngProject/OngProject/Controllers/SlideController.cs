using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OngProject.Core.Models;
using OngProject.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class SlideController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SlideController(ApplicationDbContext context)
        {
            this._context = context;
        }


        [HttpGet]
        [Route("/Slides")]
        public IActionResult GetSlides()
        {
            var SlidesList = _context.Slides.ToList();
           
            return Ok(SlidesList);
        }





        [HttpPost]
        [Route("/Slides/createSlides")]

        public async Task<IActionResult> Post(SlideModel newSlide)
        {
            var previus = await _context.Slides.FirstOrDefaultAsync(x => x.Order == newSlide.Order);

            if (previus != null)
            {
                return BadRequest($"Character {newSlide.Order} already exists");
            }

            var charEntity = new SlideModel
            {
                ImageUrl = newSlide.ImageUrl,
                Text = newSlide.Text,
                Order = newSlide.Order,
            

            };

          

            await _context.Slides.AddAsync(charEntity);

            await _context.SaveChangesAsync();

            return Ok();



        }


        [HttpPut("/SlidesUpdate/{id}")]
        public async Task<IActionResult> updateCharacter(long id, SlideModel slide)
        {
            if (id != slide.Id)
            {
                return BadRequest();
            }

            _context.Entry(slide).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SlideExists(id))
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


        [HttpDelete("/SlidesDelete/{id}")]
        public async Task<IActionResult> DeleteCharacters(int id)
        {
            var characters = await _context.Slides.FindAsync(id);

            if (characters == null)
            {
                return NotFound();
            }

            _context.Slides.Remove(characters);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SlideExists(long id) =>
     _context.Slides.Any(e => e.Id == id);










    }




}