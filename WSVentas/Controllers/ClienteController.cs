using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WSVentas.Data.Entities;
using WSVentas.Data.Repository;

namespace WSVentas.Controllers
{
    [Route("api/clientes")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IDataRepository<Cliente> _dataRepository;

        public ClienteController(IDataRepository<Cliente> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Cliente> clientes = _dataRepository.GetAll();

            return Ok(clientes);
        }
    }
}