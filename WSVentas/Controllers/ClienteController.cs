using System.Collections.Generic;
using System.Linq;
using System.Net;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WSVentas.Data.Entities;
using WSVentas.Data.Repository;
using WSVentas.Models.Response;
using Modelos = WSVentas.Models;

namespace WSVentas.Controllers
{
    [Route("api/clientes")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IDataRepository<Cliente> _dataRepository;
        private readonly IMapper _mapper;

        public ClienteController(IDataRepository<Cliente> dataRepository, IMapper mapper)
        {
            _dataRepository = dataRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var clientes = _dataRepository.GetAll();

            var dadaa = clientes.ToList().ConvertAll(r => _mapper.Map<Modelos.Cliente>(r));

            var respuesta = new Respuesta<List<Modelos.Cliente>>(dadaa);

            return Ok(new ApiResponse(respuesta.Contenido));
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            var employee = _dataRepository.Get(id);

            if (employee == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            return Ok(employee);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Modelos.Cliente cliente)
        {
            try
            {
                if (cliente == null)
                {
                    return BadRequest("Employee is null.");
                }

                //_dataRepository.Add(_mapper.Map<Cliente>(cliente));

                var respuesta = new Respuesta<Modelos.Cliente>(cliente);

                return CreatedAtRoute("Post", respuesta.Contenido);
            }
            catch (System.Exception ex)
            {
                return Ok(new Respuesta(ex.Message, ex.InnerException));
            }            
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Modelos.Cliente cliente)
        {
            if (cliente == null)
            {
                return BadRequest("Employee is null.");
            }

            var clienteToUpdate = _dataRepository.Get(id);

            if (clienteToUpdate == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            _dataRepository.Update(clienteToUpdate, _mapper.Map<Cliente>(cliente));

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var employee = _dataRepository.Get(id);

            if (employee == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            _dataRepository.Delete(employee);
            return NoContent();
        }
    }
}