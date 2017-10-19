using System;
using System.Collections;
using System.Collections.Generic;

namespace DALayer
{
    #region [UTILeS]
    public struct UsuarioStruct
    {
        public string login;
        public Categoria_Usuario category;
        public UsuarioStruct(string login, Categoria_Usuario categoriaUsuario)
        {
            this.login = login;
            this.category = categoriaUsuario;
        }
    }
    #endregion

    public class Usuario : _Usuario
    {
        #region Constructores
        public Usuario(string usuario, string contrasenna)
        {
            this.Nombre = usuario;
            this.Password = contrasenna;
            this.Categoria = Categoria_Usuario.Aplicador;            
        }
        public Usuario(string usuario, string contrasenna, Categoria_Usuario categoria)
        {
            this.Nombre = usuario;
            this.Password = contrasenna;
            this.Categoria = categoria;
        }

        public Usuario()
        {}

        #endregion

        #region Metodos
        public List<UsuarioStruct> Lista_Usuarios() // PENDIENTE
        {
            var list_us = new List<UsuarioStruct>();
            loadAll();
            if(this.RowCount > 0)
                do
                {
                    list_us.Add( new UsuarioStruct(this.Nombre, this.Categoria) );
                } while ( this.MoveNext() );
            return list_us;
        }
        public bool ExisteUsuario( string nombre )
        {
            return this.LoadByID( nombre ) > 0;
        }
        public void cambiar_contrasenna( string vieja, string nueva )
        {
            if ( vieja.Equals( Password ) )
            {
                Password = nueva;
                Save();
            }
            else throw new Exception( "Compruebe la contraseña antigua" );
        }
        public void cambiar_categoria( Categoria_Usuario categoria )
        {
            this.Categoria = categoria;
            Save();
        }
        #endregion
    }
}
