using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Negocios;

   namespace Capa_Negocios
   {
        // ✅ Herencia: ProveedorLocal hereda de la clase abstracta PROVEEDOR
        public class ProveedorLocal : PROVEEDOR
        {
            // ✅ Constructor: llama al constructor base con "LOCAL" como tipo fijo
            public ProveedorLocal(string rnc, string nombre, string telefono, string producto)
                : base(rnc, nombre, telefono, producto, "LOCAL")
            {
            }

            // ✅ Implementación obligatoria de métodos abstractos
            public override string ObtenerIdentificadorPrincipal() => RNC;

            // ✅ Validación personalizada: RNC debe tener exactamente 9 dígitos
            public override bool EsValido() =>
                !string.IsNullOrWhiteSpace(RNC) && RNC.Length == 9;

            public override string ObtenerTipo() => "LOCAL";
        }
   }
