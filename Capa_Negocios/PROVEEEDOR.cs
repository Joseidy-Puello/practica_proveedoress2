using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace Capa_Negocios
    {
        // ✅ Abstracción: Esta clase representa lo esencial de cualquier proveedor
        // ✅ Es abstracta porque define lo común y obliga a las clases hijas a implementar lo específico
        public abstract class PROVEEDOR
        {
            // 🔁 Propiedades comunes a todo proveedor
            public string RNC { get; set; }
            public string NOMBRE { get; set; }
            public string TELEFONO { get; set; }
            public string PRODUCTO { get; set; }
            public string TIPO { get; set; }

            // ✅ Constructor base: se usa en las clases hijas a través de herencia
            protected PROVEEDOR(string rnc, string nombre, string telefono, string producto, string tipo)
            {
                RNC = rnc;
                NOMBRE = nombre;
                TELEFONO = telefono;
                PRODUCTO = producto;
                TIPO = tipo;
            }

            // ✅ Métodos abstractos: obligan a las subclases a definir su comportamiento
            public abstract string ObtenerIdentificadorPrincipal();  // Abstracción
            public abstract bool EsValido();                         // Validación personalizada
            public abstract string ObtenerTipo();                   // Abstracción
        }
    }

