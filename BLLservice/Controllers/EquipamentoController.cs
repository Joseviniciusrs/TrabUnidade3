using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODEL;

namespace BLLservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipamentoController : ControllerBase
    {
        [HttpGet(Name = "GetEquipamento")]
        public ActionResult<List<TbEquipamento>> GetEquipamento()
        {
            try
            {
                List<TbEquipamento> list = EquipamentoBLL.getAll();
                if (list != null) { return Ok(list); }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost(Name = "PostEquipamento")]
        public ActionResult<TbEquipamento> AddEquipamento(TbEquipamento eqp)
        {
            try
            {
                TbEquipamento equip = EquipamentoBLL.Add(eqp);

                return eqp == null ? NotFound() : Ok(equip);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete(Name = "DeleteEquipamento")]
        public ActionResult<TbEquipamento> DeleteEquipamento(int id)
        {
            try
            {
                TbEquipamento equip = EquipamentoBLL.GetById(id);
                EquipamentoBLL.Remove(equip);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
