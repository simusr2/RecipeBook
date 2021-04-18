using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using RecipeBook.Data;
using RecipeBook.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

            if (_context.Recipes.Count(t => t.RecipeName == "Prova") == 0)
            {

                _context.Recipes.Add(new Recipe
                {
                    RecipeName = "Prova",
                    RecipeDescription = "Prova!!!"
                });
                _context.SaveChanges();
            }


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
        }

        // PUT api/<RecipesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Recipe value)
        {
            using IDbContextTransaction transaction = _context.Database.BeginTransaction();
            Recipe oldValue = _context.Recipes.Find(new object[] { id });
            if (oldValue != null)
            {
                _context.Recipes.Remove(oldValue);
            }
            _context.Recipes.Add(value);

            transaction.Commit();
        }

        // DELETE api/<RecipesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
