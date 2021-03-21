using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WS_green_leaves.Models;
using WS_green_leaves.Models.Request;
using WS_green_leaves.Models.Response;

namespace WS_green_leaves.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        //Obtencion de datos
        [HttpGet]
        public IActionResult Get()
        {
            Response oResponse = new Response();

            try
            {
                using (green_leavas_dbContext db = new green_leavas_dbContext())
                {
                    var lst = db.Usuarios.OrderByDescending(d => d.Id).ToList();
                    oResponse.Success = true;
                    oResponse.Data = lst;
                }
            }
            catch (Exception ex)
            {
                oResponse.Message = ex.Message;
            }

            return Ok(oResponse);
        }

        [HttpPost]
        public IActionResult Add(Usuario_Request oUsurioRequest)
        {
            Response oResponse = new Response();

            try
            {
                using (green_leavas_dbContext db = new green_leavas_dbContext())
                {
                    Usuario oUsuario = new Usuario();
                    oUsuario.Nombre = oUsurioRequest.Nombre;
                    oUsuario.Email = oUsurioRequest.Email;
                    oUsuario.Telefono = oUsurioRequest.Telefono;
                    oUsuario.Fecha = oUsurioRequest.Fecha;
                    oUsuario.Ciudad = oUsurioRequest.Ciudad;
                    db.Add(oUsuario);
                    db.SaveChanges();
                    
                    oResponse.Success = true;
                }
            }
            catch (Exception ex)
            {
                oResponse.Message = ex.Message;
            }
            return Ok(oResponse);
        }
    }
}
