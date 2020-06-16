﻿using projeto_desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_desktop.Repositories
{
    public class UsuarioRepository
    {
        private static List<Usuario> usuarios;
       
        private static int contador = 1;

        public UsuarioRepository()
        {
            
            if (usuarios == null)
            {
                usuarios = new List<Usuario>();

                usuarios.Add(new Usuario
                {
                    codigo = 1,
                    nome = "Gabriela",
                    email = "Gabriela@email",
                    senha = "1234",
                   endereco = "rua pascoal pavan",
                    
                }
               );
                contador++;
                usuarios.Add(new Usuario
                {
                    codigo = 2,
                    nome = "Bianca",
                    email = "bianca@gmail",
                    senha = "1234",
                    endereco = "rua pascoal",
                    
                }
                );
                contador++;
            }
        }

        public List<Usuario> buscarTodos()
        {
            return usuarios;
        }
     
        public void adicionar(Usuario usuario)
        {
            usuario.codigo = contador;

            usuarios.Add(usuario);
            contador++;
        }
     
        public void editar(Usuario usuario)
        {
            Usuario u = usuarios.Find(x => x.codigo == usuario.codigo);
            usuarios[usuarios.IndexOf(u)] = usuario;
        }
        public void deletar(int codigo)
        {
           
            Usuario usuario = usuarios.Find(x => x.codigo == codigo);

            usuarios.Remove(usuario);
        }
    }
}
