using ApiSaSTokenStorageTables.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSaSTokenStorageTables.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableTokenController : ControllerBase
    {
        private ServiceSaSToken service;

        public TableTokenController(ServiceSaSToken service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("[action]/{curso}")]
        public ActionResult<string> GenerateToken(string curso)
        {
            string token =
                this.service.GenerateSasToken(curso);

            //return Ok(
            //    new
            //    {
            //        numeroregistros = 5,
            //        datos = new List<int>()
            //    });

            return Ok(
                new
                {
                    token = token
                });
        }
    }
}
