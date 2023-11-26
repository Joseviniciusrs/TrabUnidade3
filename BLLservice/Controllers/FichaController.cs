using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODEL;

namespace BLLservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FichaController : ControllerBase
    {
        [HttpGet(Name = "GetFicha")]
        public ActionResult<List<TbFichatr>> GetFicha()
        {
            try
            {
                List<TbFichatr> list = FichaTreinoBLL.getAll();
                if (list != null) { return Ok(list); }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost(Name = "PostFicha")]
        public ActionResult<TbFichatr> AddFicha(TbFichatr fic)
        {
            try
            {
                TbFichatr ftr = FichaTreinoBLL.Add(fic);

                return fic == null ? NotFound() : Ok(ftr);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete(Name = "DeleteFicha")]
        public ActionResult<TbFichatr> DeleteFicha(int id)
        {
            try
            {
                TbFichatr ftr = FichaTreinoBLL.GetById(id);
                FichaTreinoBLL.Remove(ftr);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
