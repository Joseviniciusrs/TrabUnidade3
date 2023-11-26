using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODEL;

namespace BLLservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepeticaoController : ControllerBase
    {
        [HttpGet(Name = "GetRepeticao")]
        public ActionResult<List<TbRepeticao>> GetRepeticao()
        {
            try
            {
                List<TbRepeticao> list = RepeticaoBLL.getAll();
                if (list != null) { return Ok(list); }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost(Name = "PostRepeticao")]
        public ActionResult<TbRepeticao> AddRepeticao(TbRepeticao rpt)
        {
            try
            {
                TbRepeticao rep = RepeticaoBLL.Add(rpt);

                return rpt == null ? NotFound() : Ok(rep);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete(Name = "DeleteRepeticao")]
        public ActionResult<TbRepeticao> DeleteRepeticao(int id)
        {
            try
            {
                TbRepeticao rep = RepeticaoBLL.GetById(id);
                RepeticaoBLL.Remove(rep);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
