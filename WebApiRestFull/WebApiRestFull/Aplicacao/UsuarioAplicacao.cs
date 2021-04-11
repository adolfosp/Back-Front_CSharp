using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRestFull.Models;

namespace WebApiRestFull.Aplicacao
{
    public class UsuarioAplicacao
    {
        private List<Usuarios> usuarios = new List<Usuarios>
        {
            new Usuarios {Id =0, Nome = "Adolfo", Email = "123@gmail.com", Senha="456"},
            new Usuarios {Id =1, Nome = "Alberto", Email = "alberto@gmail.com", Senha="1156"},
            new Usuarios {Id =3, Nome = "Mateus", Email = "mateus@gmail.com", Senha="45556"},
            new Usuarios {Id =4, Nome = "Carlos", Email = "carlos@gmail.com", Senha="45666"}
        };

        public bool Adicionar(Usuarios usuarioRecebido)
        {
            var usuarioInserir = usuarioRecebido;
            var ultimoIdCadastrado = usuarios[usuarios.Count - 1].Id;
            usuarioInserir.Id = ultimoIdCadastrado + 1;

            try
            {
                usuarios.Add(usuarioInserir);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remover(int Id)
        {
            try
            {
                usuarios.Remove(usuarios.Where(x => x.Id == Id).ToList()[0]);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Alterar(Usuarios usuarioRecebido)
        {
            try
            {
                usuarios[usuarioRecebido.Id].Nome = usuarioRecebido.Nome;
                usuarios[usuarioRecebido.Id].Senha = usuarioRecebido.Senha;
                usuarios[usuarioRecebido.Id].Email = usuarioRecebido.Email;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Usuarios ExibirUsuario(int id)
        {
            try
            {
                return usuarios.Where(x => x.Id == id).ToList()[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Usuarios> ExibirTodos()
        {
            return usuarios;
        }


    }
}