using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    
    public class ProveedorLocal : PROVEEDOR
    {
        public string RNC { get; set; }

        public ProveedorLocal(string rnc, string nombre, string telefono, string producto)
            : base(nombre, telefono, producto)
        {
            RNC = rnc;
        }

        // Implementación de los métodos abstractos

        public override string ObtenerIdentificadorPrincipal()
        {
            return RNC;
        }

        public override bool EsValido()
        {
            // Regla de negocio: RNC debe tener 9 dígitos.
            return !string.IsNullOrWhiteSpace(RNC) && RNC.Length == 9;
        }

        public override string ObtenerTipo()
        {
            return "LOCAL"; // Coincide con tu BD
        }
    }
}
