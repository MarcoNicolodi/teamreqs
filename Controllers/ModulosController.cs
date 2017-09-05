using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using teamREQUIREMENTS.Persistencia;
using teamREQUIREMENTS.Persistencia.Models;

namespace teamREQUIREMENTS.Controllers {
    
    [Route("api/[controller]")]
    public class ModulosController : Controller{
        private readonly IUnitOfWork _unitOfWork;
        
        public ModulosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            using(_unitOfWork)
            {
                var modulos = _unitOfWork.Modulos.GetAll();
                if(modulos.Count() > 0)
                    return Ok(modulos);

                return NotFound();
            }           
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            using(_unitOfWork)
            {
                var modulo = _unitOfWork.Modulos.Get(id);
                if(modulo != null)
                    return Ok(modulo);

                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Modulo modulo)
        {
            if(modulo == null)
                return BadRequest();

            using (_unitOfWork){
                _unitOfWork.Modulos.Add(modulo);
                var rows = _unitOfWork.Save();
                if(rows != 1)
                    return BadRequest();

                return Ok(modulo);
            }            
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, [FromBody] Modulo modulo)
        {
            if(modulo == null || id != modulo.Id)
                return BadRequest();

            using(_unitOfWork)
            {
                _unitOfWork.Modulos.Update(modulo);
                _unitOfWork.Save();
                return Ok(modulo);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using(_unitOfWork)
            {
                var entity = _unitOfWork.Modulos.Get(id);
                if(entity != null)
                    return NotFound();

                _unitOfWork.Modulos.Remove(entity);
                _unitOfWork.Save();
                return Ok(entity);
            }
        }
    }
}