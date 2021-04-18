using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using RecipeBook.Data;
using RecipeBook.Data.Model;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecipeBook.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private ApplicationDbContext _context;

        public RecipesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<RecipesController>
        [HttpGet]
        public IEnumerable<Recipe> Get()
        {

            return _context.Recipes.ToList();
        }

        // GET api/<RecipesController>/5
        [HttpGet("{id}")]
        public Recipe Get(int id)
        {
            return _context.Recipes.Find(new object[] { id });
        }

        // POST api/<RecipesController>
        [HttpPost]
        public void Post([FromBody] Recipe value)
        {
            _context.Recipes.Add(value);
            _context.SaveChanges();
        }

        // PUT api/<RecipesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Recipe formData)
        {
            using IDbContextTransaction transaction = _context.Database.BeginTransaction();
            Delete(id);

            _context.Recipes.Add(formData);

            _context.SaveChanges();

            transaction.Commit();
        }

        // DELETE api/<RecipesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Recipe oldValue = _context.Recipes.Find(new object[] { id });
            if (oldValue != null)
            {
                _context.Recipes.Remove(oldValue);
            }
        }
    }
}
