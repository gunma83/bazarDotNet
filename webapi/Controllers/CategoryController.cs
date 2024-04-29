using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webapi.BazarDaElioDb;
using webapi.Models;
using Categories = webapi.BazarDaElioDb.Categories;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
      
        [HttpGet]
        public ActionResult<List<Categories>> GetCategories()
        {

                BazarDaElioContext bazarDaElioContext = new BazarDaElioContext();
                var categorie = bazarDaElioContext.Categories;
                 
                return Ok(categorie.ToList());
        }

        [HttpPut]
        public ActionResult<ResponseDTO> AddCategories([FromBody] CategoryInsertRequest request)
        {
            try
            {
                using (var bazarDaElioContext = new BazarDaElioContext())
                {
                    var newCategory = new Categories
                    {
                        Categoria = request.CategoryName,
                        DescrizioneCategoria= request.CategoryDescription,
                        CreatedDateTime = request.CategoryCreationDate ?? DateTime.Now,
                        ImmagineCategoria = request.ImmagineCategoria
                    };

                    bazarDaElioContext.Categories.Add((Categories)newCategory);

                    bazarDaElioContext.SaveChanges();

                    return Ok(new ResponseDTO { Detail = "Categoria aggiunta con successo" });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO { Detail = $"Si è verificato un errore durante l'aggiunta della categoria: {ex.Message}" });
            }
        }

        [HttpDelete]
        public ActionResult<ResponseDTO> DeleteCategories([FromBody] string catoria)
        {
            try
            {

                var bazarDaElioContext = new BazarDaElioContext();
                var categToDelete = bazarDaElioContext.Categories.Where(item => item.Categoria == catoria).FirstOrDefault();

                bazarDaElioContext.Categories.Remove(categToDelete);

                bazarDaElioContext.SaveChanges();


                return Ok(new ResponseDTO { Detail = "Categoria eliminata con successo" });
                
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDTO { Detail = $"Si è verificato un errore durante l'eliminazione della categoria: {ex.Message}" });
            }
        }
    }
}
