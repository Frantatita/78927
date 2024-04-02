using System;
using WSDL.mensajes;

namespace WSDL.operaciones{
    public class Operaciones : Mensajes{

        private string[] nombres; 

        public string Saludar(string nombre){

            AlmacenarNombre(nombre);
            string msj = "hola " + nombre;
            return msj;
        }

            
        public string Mostrar(string id){
            return "x";
        }

        private void AlmacenarNombre(string nombre)
        {
            // Buscamos una posición vacía en el arreglo para almacenar el nombre
            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i] == null)
                {
                    nombres[i] = nombre;
                    break;
                }
            }
        }

    }

}