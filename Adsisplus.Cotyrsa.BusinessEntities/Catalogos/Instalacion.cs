using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adsisplus.Cotyrsa.BusinessEntities.Catalogos
{
    /// <summary>
    /// Representa la información de la instalación de un sistema
    /// </summary>
    public class Instalacion
    {
        /// <summary>
        /// Identificador de la instalación
        /// </summary>
        public short InstalacionId { get; set; }

        /// <summary>
        /// Descripción de la instalación
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Costo de la instalación
        /// </summary>
        public int InstalacionCantidad { get; set; }

        /// <summary>
        /// Costo de la desinstalación
        /// </summary>
        public int DesinstalacionCantidad { get; set; }

        /// <summary>
        /// Factor de multiplicidad del costo
        /// </summary>
        public double Factor { get; set; }

        /// <summary>
        /// Indica si el elemento está activo
        /// </summary>
        public bool Activo { get; set; }

        /// <summary>
        /// Identificador del producto
        /// </summary>
        public short SubproductoId { get; set; }


        #region Unidad medida
        public int UnidadMedicionId { get; set; }

        public UnidadMedicion UnidadMedicion { get; set; }
        #endregion


    }
}
