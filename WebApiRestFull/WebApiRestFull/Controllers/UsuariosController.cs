using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApiRestFull.Aplicacao;
using WebApiRestFull.Models;

namespace WebApiRestFull.Controllers
{
    public class UsuariosController : ApiController
    {
        //explicacao: na rota eu coloco http://localhost:64510/api/usuarios/ExibirTodos -> usuarios referece ao 'Usuarios'Controller
        static private readonly UsuarioAplicacao usuarioAplicacao = new UsuarioAplicacao();

        [HttpPost]
        //FromBody, pega todos os valores e coloca dentro do objeto
        public IHttpActionResult Adicionar([FromBody]Usuarios usuario)
        {
            try
            {
                var sucesso = usuarioAplicacao.Adicionar(usuario);
                if (sucesso)
                {
                    return Ok("Usuário inserido com sucesso");
                }
                else
                {
                    return BadRequest("Não conseguimos inserir o usuário. Por favor tente novamente");
                }
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu algum erro, por favor tente novamente");
            }
        }

        [HttpPut]
        public IHttpActionResult Alterar([FromBody]Usuarios usuario)
        {
            try
            {
                var sucesso = usuarioAplicacao.Alterar(usuario);

                if (sucesso)
                {
                    return Ok("Usuario atualizado com sucesso");
                }
                else
                {
                    return BadRequest("Não conseguimos atualizar o usuário. Por favor tente novamente");
                }
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu algum erro , por favor tente novamente");

            }
        }

        [HttpDelete]
        public IHttpActionResult Remover([FromBody]int idUsuario)
        {
            try
            {
                var sucesso = usuarioAplicacao.Remover(idUsuario);

                if (sucesso)
                {
                    return Ok("Usuário removido com sucesso");
                }
                else
                {
                    return BadRequest("Não conseguimos remover o usuário. Por favor tente novamente");
                }
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu algum erro, por favor tente novamente.");
            }
        }

        [HttpPost]

        public IHttpActionResult ExibirUsuario([FromBody] int idUsuario)
        {
            try
            {
                var usuarioRetornar = usuarioAplicacao.ExibirUsuario(idUsuario);
                if(usuarioRetornar != null)
                {
                    var usuarioSerializado = Newtonsoft.Json.JsonConvert.SerializeObject(usuarioRetornar);
                    return Ok(usuarioSerializado);
                }
                else
                {
                    return BadRequest("Nenhum usuário foi encontrado com esse ID, por favor, tente novamente");
                }
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu algum erro, por favor tente novamente");
            }
        }

        [HttpGet]
        public IHttpActionResult ExibirTodos()
        {
            try
            {
                var usuarios = usuarioAplicacao.ExibirTodos();

                if(usuarios != null)
                {
                    var usuariosSerializados = JsonConvert.SerializeObject(usuarios);
                    return Ok(usuariosSerializados);
                }
                else
                {
                    return BadRequest("Nenhum usuário cadastrado");
                }
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu algum erro, por favor tente novamente");
            }
        }
    }
}