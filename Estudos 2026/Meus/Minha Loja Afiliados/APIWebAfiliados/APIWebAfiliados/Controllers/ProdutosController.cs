using Microsoft.AspNetCore.Mvc;
namespace APIWebAfiliados.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase {
        private static List<Produto> listaDeProdutos = new List<Produto>();

        [HttpGet]
        public IEnumerable<Produto> Get() {
            return listaDeProdutos;
        }
    }
}
