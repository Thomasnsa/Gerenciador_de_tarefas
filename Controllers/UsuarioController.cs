using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace Gerenciador_de_tarefas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public Models.Usuario Salvar(Models.Usuario usuario)
        {
            Models.GerenciadorDeTarefasContext db = new Models.GerenciadorDeTarefasContext();
            
            db.Usuarios.Add(usuario);
            db.SaveChanges();

            return usuario;
        }
    }
}