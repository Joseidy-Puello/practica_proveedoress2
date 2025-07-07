using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    //clase base PROVEEDOR
    public abstract class PROVEEDOR
    {
        // Propiedades comunes a todos los proveedores

        public string RNC {  get; set; }
        public string NOMBRE { get; set; }
        public string TELEFONO { get; set; }
        public string PRODUCTO { get; set; }
        public string TIPO { get; set; }

        // Constructor para inicializar las propiedades comunes
        protected PROVEEDOR(string nombre, string telefono, string producto)
        {
            NOMBRE = nombre;
            TELEFONO = telefono;
            PRODUCTO = producto;
        }

        // Métodos ABSTRACTOS: Obligan a las clases hijas a implementarlos.

        /// <summary>
        /// Devuelve el identificador que se guardará en la columna RNC de la BD.
        /// </summary>
        public abstract string ObtenerIdentificadorPrincipal();

        /// <summary>
        /// Valida los datos específicos del proveedor (RNC para Local, Pasaporte para Internacional).
        /// </summary>
        public abstract bool EsValido();

        /// <summary>
        /// Devuelve el tipo de proveedor ("LOCAL" o "INTERNACIONAL").
        /// </summary>
        public abstract string ObtenerTipo();
    }
}
