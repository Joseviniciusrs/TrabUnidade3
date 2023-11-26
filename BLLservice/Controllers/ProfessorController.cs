using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODEL;

namespace BLLservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        [HttpGet(Name = "GetProfessor")]
        public ActionResult<List<TbProfessor>> GetProfessor()
        {
            try
            {
                List<TbProfessor> list = ProfessorBLL.getAll();
                if (list != null) { return Ok(list); }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost(Name = "PostProfessor")]
        public ActionResult<TbProfessor> AddProfessor(TbProfessor pro)
        {
            try
            {
                TbProfessor prof = ProfessorBLL.Add(pro);

                return pro == null ? NotFound() : Ok(prof);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete(Name = "DeleteProfessor")]
        public ActionResult<TbProfessor> DeleteProfessor(int id)
        {
            try
            {
                TbProfessor prof = ProfessorBLL.GetById(id);
                ProfessorBLL.Remove(prof);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
