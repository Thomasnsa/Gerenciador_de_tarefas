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

        [HttpGet]
        public List<Models.Usuario> Listar()
        {
            Models.GerenciadorDeTarefasContext db = new Models.GerenciadorDeTarefasContext();

            List<Models.Usuario> lista = db.Usuarios.ToList();

            return lista;
        }

        [HttpPut]
        public void Alterar(Models.Usuario usuario)
        {
            Models.GerenciadorDeTarefasContext db = new Models.GerenciadorDeTarefasContext();

            Models.Usuario usuarioAtual = db.Usuarios.First(x => x.Id == usuario.Id);

            usuarioAtual.Nome = usuario.Nome;
            usuarioAtual.Email = usuario.Email;
            usuarioAtual.Nascimento = usuario.Nascimento;

            db.SaveChanges();
        }

        [HttpDelete]
        public void Excluir(Models.Usuario id)
        {
            Models.GerenciadorDeTarefasContext db = new Models.GerenciadorDeTarefasContext();

            Models.Usuario usuario = db.Usuarios.First(x => x.Id == id.Id);

            db.Usuarios.Remove(usuario);

            db.SaveChanges();
        }
    }
}