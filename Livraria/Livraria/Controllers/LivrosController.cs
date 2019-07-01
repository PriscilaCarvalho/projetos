using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Livraria.Models;

namespace Livraria.Controllers
{
    public class LivrosController : ApiController
    {
        private LivrariaContext db = new LivrariaContext();

        // GET: api/Livros
        public IQueryable<LivroDTO> GetLivros()
        {
            var livros = from b in db.Livros orderby b.Titulo
                          select new LivroDTO()
                          {
                              Id = b.Id,
                              Titulo = b.Titulo,                              
                          };


            return livros;
        }

        // GET: api/Livros/5
        [ResponseType(typeof(LivroDetalheDTO))]
        public IHttpActionResult GetLivro(int id)
        {
            var livro = db.Livros.Where(w => w.Id == id).FirstOrDefault();

            if (livro == null)
                return NotFound();

            return Ok(livro);
        }

        // PUT: api/Livros/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLivro(int id, Livro livro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != livro.Id)
            {
                return BadRequest();
            }

            db.Entry(livro).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LivroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Livros
        [ResponseType(typeof(LivroDTO))]
        public async Task<IHttpActionResult> PostLivro(Livro livro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Livros.Add(livro);
            await db.SaveChangesAsync();

            var dto = new LivroDTO()
            {
                Id = livro.Id,
                Titulo = livro.Titulo,                
            };

            return CreatedAtRoute("DefaultApi", new { id = livro.Id }, dto);
            
        }

        // DELETE: api/Livros/5
        [ResponseType(typeof(Livro))]
        public async Task<IHttpActionResult> DeleteLivro(int id)
        {
            Livro livro = await db.Livros.FindAsync(id);
            if (livro == null)
            {
                return NotFound();
            }

            db.Livros.Remove(livro);
            await db.SaveChangesAsync();

            return Ok(livro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LivroExists(int id)
        {
            return db.Livros.Count(e => e.Id == id) > 0;
        }
    }
}