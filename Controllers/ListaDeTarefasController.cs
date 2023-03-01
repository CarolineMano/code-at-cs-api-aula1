using code_at_cs_api_aula1.Entities;
using Microsoft.AspNetCore.Mvc;

namespace code_at_cs_api_aula1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListaDeTarefasController : ControllerBase
    {
        private static List<Tarefa> _tarefas;

        static ListaDeTarefasController()
        {
            _tarefas = new List<Tarefa>();
        }

        // GET: api/<ListaDeTarefasController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tarefas);
        }

        // POST api/<ListaDeTarefasController>
        [HttpPost]
        public IActionResult Post([FromBody] Tarefa value)
        {
            // 201
            _tarefas.Add(value);
            return StatusCode(201);
        }

        // DELETE api/<ListaDeTarefasController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            // 204
            var tarefa = _tarefas.FirstOrDefault(t => t.Id == id);
            _tarefas.Remove(tarefa);
            return StatusCode(204);
        }
    }
}
