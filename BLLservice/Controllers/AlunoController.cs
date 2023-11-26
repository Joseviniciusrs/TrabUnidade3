using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL;
using MODEL;

namespace BLLservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        [HttpGet(Name = "GetAluno")]
        public ActionResult<List<TbAluno>> GetAluno()
        {
            try
            {
                List<TbAluno> list = AlunoBLL.getAll();
                if(list != null) { return Ok(list); }
                return NotFound();
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost(Name = "PostAluno")]
        public ActionResult<TbAluno> AddAluno(TbAluno aln)
        {
            try
            {
                TbAluno alun = AlunoBLL.Add(aln);
                
                return aln == null ? NotFound(): Ok(alun);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete(Name = "DeleteAluno")]
        public ActionResult<TbAluno> DeleteAluno(int id)
        {
            try
            {
                TbAluno alun = AlunoBLL.GetById(id);
                AlunoBLL.Remove(alun);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
