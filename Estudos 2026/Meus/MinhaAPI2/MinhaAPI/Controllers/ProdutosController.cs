using Microsoft.AspNetCore.Mvc;

namespace MinhaAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController: ControllerBase {
    [HttpGet]
    public IActionResult GetTodos() {
        var produtos = new[] {
            new { Id = 1, Nome = "Notebook", Preco = 3500.00},
            new { Id = 2, Nome = "Mouse", Preco = 150.00},
            new { Id = 3, Nome = "Teclado", Preco = 200.00}
        };
        return Ok(produtos);
    }
}