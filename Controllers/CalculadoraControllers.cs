using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace Gerenciador_de_tarefas.Controllers
{
    [ApiController]
    [Route("calculadora")]
    public class CalculadoraControllers : ControllerBase
    {
        [HttpGet]
        public int somar()
        {
            return 20;
        }
        
    }
}