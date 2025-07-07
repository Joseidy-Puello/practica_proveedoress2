using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class ProveedorInternacional : PROVEEDOR
    {
        public string Pasaporte { get; set; }

        public ProveedorInternacional(string pasaporte, string nombre, string telefono, string producto)
            : base(nombre, telefono, producto)
        {
            Pasaporte = pasaporte;
        }

        // Implementación de los métodos abstractos

        public override string ObtenerIdentificadorPrincipal()
        {
            // El Pasaporte se guardará en la columna RNC de la BD
            return Pasaporte;
        }

        public override bool EsValido()
        {
            // Regla de negocio: Pasaporte no puede estar vacío.
            return !string.IsNullOrWhiteSpace(Pasaporte);
        }

        public override string ObtenerTipo()
        {
            return "INTERNACIONAL"; // Coincide con tu BD
        }
    }
}
