using System.Web.Http;
using ToDoList.Domain.Repositories;
using LisToDo.Data.Repositories;
using System.Web.Http.Description;
using System.Linq;
using System.Net;

namespace LisToDoWeb.Api.Controllers
{
    public class ListToDoController : ApiController
    {
        private IListToDoRepository _repository = new ListToDoRepository();
        
        public IQueryable<ToDoList.Domain.ListToDo> GetListToDO()
        {
            return _repository.Get().AsQueryable();
        }

        public IHttpActionResult PostToDoList(ToDoList.Domain.ListToDo listToDo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _repository.Create(listToDo);
            return CreatedAtRoute("DefaultApi", new { id = listToDo.Id }, listToDo);
        }
        public IHttpActionResult GetListToDO(int id)
        {
            ToDoList.Domain.ListToDo listToDo = _repository.Get(id);
            if (listToDo == null)
            {
                return NotFound();
            }

            return Ok(listToDo);
        }
        [Route("api/Finalizar/{id:int}")]
        [HttpGet]
        public IHttpActionResult GetFinalizaItem(int id)
        {
            _repository.Finaliza(id);

            return Ok();
        }

        public IHttpActionResult PutLista(int id, ToDoList.Domain.ListToDo listToDo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != listToDo.Id)
            {
                return BadRequest();
            }
            _repository.UpDate(listToDo);

            return StatusCode(HttpStatusCode.NoContent);
        }
        public IHttpActionResult DeleteList(int id)
        {
            ToDoList.Domain.ListToDo listToDo = _repository.Get(id);
            if (listToDo == null)
            {
                return NotFound();
            }
            _repository.Delete(id);

            return Ok(listToDo);
        }
    }
}
