namespace Adsisplus.Cotyrsa.BusinessEntities.Catalogos
{
    /// <summary>
    /// Representa la información de un tornillo
    /// </summary>
    public class Tornillo
    {
        /// <summary>
        /// Identificador del tornillo
        /// </summary>
        public short TornilloId { get; set; }

        /// <summary>
        /// Descripción del tornillo
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Factor del tornillo
        /// </summary>
        public double Factor { get; set; }

        /// <summary>
        /// Masa del tornillo
        /// </summary>
        public double Peso { get; set; }

        /// <summary>
        /// Unidad de medida
        /// </summary>
        public UnidadMedicion UnidadMedicion { get; set; }

        /// <summary>
        /// Identificador de la undiad de medida
        /// </summary>
        public int UnidadMedicionId { get; set; }

        /// <summary>
        /// Indica si está activo
        /// </summary>
        public bool Activo { get; set; }

    }
}
