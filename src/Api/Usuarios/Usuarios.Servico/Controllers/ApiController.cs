using Microsoft.AspNetCore.Mvc;
using System;

namespace Usuarios.Servico.Controllers
{

    public abstract class ApiController : ControllerBase
    {
      
        protected new IActionResult Response(object result = null)
        {
            try
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }
            catch (Exception ex)
            {

                return BadRequest(new
                {
                    success = false,
                    errors = ex.Message
                });
            }
        }

    }
}