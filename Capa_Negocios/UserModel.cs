using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_Modulos.CACHE; // Para usar la clase UserKey que almacena los datos del usuario logueado

namespace Capa_Negocios
{
    public class UserModel
    {
        #region Login Negocios

            private UserKey userE = new UserKey();

            public bool LoginUser(string user, string password)

            {   //Si el usuario o la contraseña son nulos o vacíos, lanzamos una excepción          
                if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(password))
                {
                    return false;
                }
                //Llama al metodo de la capa de datos para autenticar al usuario y llenar la cache
                return userE.Login(user, password);
            }
    }
        #endregion
}

