using System.Linq;
using Microsoft.AspNetCore.Mvc;
using teamREQUIREMENTS.Persistencia;
using teamREQUIREMENTS.Persistencia.Models;

namespace teamREQUIREMENTS.Controllers
{
    [Route("api/[controller]")]
    public class RequisitosFuncionaisController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public RequisitosFuncionaisController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            using(_unitOfWork)
            {
                var RequisitosFuncionais = _unitOfWork.RequisitosFuncionais.GetAll();
                if(RequisitosFuncionais.Count() > 0)
                    return Ok(RequisitosFuncionais);

                return NotFound();
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using(_unitOfWork){
                var RequisitoFuncional = _unitOfWork.RequisitosFuncionais.Get(id);
                if(RequisitoFuncional != null)
                    return Ok(RequisitoFuncional);
                
                return NotFound();
            }                        
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]RequisitoFuncional req)
        {
            if(req == null)
                return BadRequest();

            using(_unitOfWork)
            {
                _unitOfWork.RequisitosFuncionais.Add(req);
                var rows = _unitOfWork.Save();
                if(rows != 1)
                {
                    return NotFound();
                }

                return Ok();
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]RequisitoFuncional req)
        {
            if(req == null)
                return BadRequest();

            using(_unitOfWork)
            {
                var requisitoFuncional = _unitOfWork.RequisitosFuncionais.Get(id);
                if(requisitoFuncional == null)
                    return NotFound();

                _unitOfWork.RequisitosFuncionais.Add(requisitoFuncional);
                if(_unitOfWork.Save() != 0)
                    return Ok(requisitoFuncional);

                return Ok();
                
            }
            
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using(_unitOfWork)
            {
                var req = _unitOfWork.RequisitosFuncionais.Get(id);
                if(req == null)
                    return NotFound();

                _unitOfWork.RequisitosFuncionais.Remove(req);
                return Ok(req);
            }
            
        }
    }
}
