﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Adsisplus.Cotyrsa.DataAccess.Context
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbTyrsa")]
	public partial class RielDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public RielDataContext() : 
				base(global::Adsisplus.Cotyrsa.DataAccess.Properties.Settings.Default.dbTyrsaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public RielDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RielDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RielDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RielDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<entRielRueda> entRielRueda
		{
			get
			{
				return this.GetTable<entRielRueda>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosRielPortaRueda")]
		public ISingleResult<stp_ListarDatosRielPortaRuedaResult> stp_ListarDatosRielPortaRueda([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intRielPortaRuedaID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCotizacionID, intRielPortaRuedaID);
			return ((ISingleResult<stp_ListarDatosRielPortaRuedaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarRielesRuedaMetalicaCartonFlow")]
		public ISingleResult<entRielRueda> stp_ListarRielesRuedaMetalicaCartonFlow([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintTipoCartonFlowID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> intCalibreAceroID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintCantidadRiel, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intNumNivel, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decLargoPerfil, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintCantidadRuegas, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decPrecioRuedas, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decTipoCambio)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sintTipoCartonFlowID, intCalibreAceroID, sintCantidadRiel, intNumNivel, decLargoPerfil, sintCantidadRuegas, decPrecioRuedas, decTipoCambio);
			return ((ISingleResult<entRielRueda>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarRielesRuedaPlasticaCartonFlow")]
		public ISingleResult<entRielRueda> stp_ListarRielesRuedaPlasticaCartonFlow([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintTipoCartonFlowID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> intCalibreAceroID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decAncho, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decLargo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintCantidadRiel, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> decTotalKiloUnitario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intNumNivel, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decLargoPerfil, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintCantidadRuegas, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decPrecioRuedas, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decTipoCambio, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intInternacion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decCostoInternacion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sintTipoCartonFlowID, intCalibreAceroID, decAncho, decLargo, sintCantidadRiel, decTotalKiloUnitario, intNumNivel, decLargoPerfil, sintCantidadRuegas, decPrecioRuedas, decTipoCambio, intInternacion, decCostoInternacion);
			return ((ISingleResult<entRielRueda>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class entRielRueda
	{
		
		private short _sintTipoCartonFlowID;
		
		private short _sintCalibre;
		
		private string _vchTipoCartonFlow;
		
		private decimal _decAncho;
		
		private decimal _decLargo;
		
		private int _intTotalRieles;
		
		private int _intTotalRuedas;
		
		private decimal _decCostoTotalRuedas;
		
		private decimal _decClip;
		
		private short _sintPesoPieza;
		
		private decimal _decTotalKiloUnitario;
		
		private decimal _decPrecioUnitario;
		
		private string _vchLeyenda;
		
		private decimal _decTotalInternacion;
		
		public entRielRueda()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintTipoCartonFlowID")]
		public short sintTipoCartonFlowID
		{
			get
			{
				return this._sintTipoCartonFlowID;
			}
			set
			{
				if ((this._sintTipoCartonFlowID != value))
				{
					this._sintTipoCartonFlowID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintCalibre")]
		public short sintCalibre
		{
			get
			{
				return this._sintCalibre;
			}
			set
			{
				if ((this._sintCalibre != value))
				{
					this._sintCalibre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchTipoCartonFlow", CanBeNull=false)]
		public string vchTipoCartonFlow
		{
			get
			{
				return this._vchTipoCartonFlow;
			}
			set
			{
				if ((this._vchTipoCartonFlow != value))
				{
					this._vchTipoCartonFlow = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decAncho")]
		public decimal decAncho
		{
			get
			{
				return this._decAncho;
			}
			set
			{
				if ((this._decAncho != value))
				{
					this._decAncho = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLargo")]
		public decimal decLargo
		{
			get
			{
				return this._decLargo;
			}
			set
			{
				if ((this._decLargo != value))
				{
					this._decLargo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intTotalRieles")]
		public int intTotalRieles
		{
			get
			{
				return this._intTotalRieles;
			}
			set
			{
				if ((this._intTotalRieles != value))
				{
					this._intTotalRieles = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intTotalRuedas")]
		public int intTotalRuedas
		{
			get
			{
				return this._intTotalRuedas;
			}
			set
			{
				if ((this._intTotalRuedas != value))
				{
					this._intTotalRuedas = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decCostoTotalRuedas")]
		public decimal decCostoTotalRuedas
		{
			get
			{
				return this._decCostoTotalRuedas;
			}
			set
			{
				if ((this._decCostoTotalRuedas != value))
				{
					this._decCostoTotalRuedas = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decClip")]
		public decimal decClip
		{
			get
			{
				return this._decClip;
			}
			set
			{
				if ((this._decClip != value))
				{
					this._decClip = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintPesoPieza")]
		public short sintPesoPieza
		{
			get
			{
				return this._sintPesoPieza;
			}
			set
			{
				if ((this._sintPesoPieza != value))
				{
					this._sintPesoPieza = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTotalKiloUnitario")]
		public decimal decTotalKiloUnitario
		{
			get
			{
				return this._decTotalKiloUnitario;
			}
			set
			{
				if ((this._decTotalKiloUnitario != value))
				{
					this._decTotalKiloUnitario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioUnitario")]
		public decimal decPrecioUnitario
		{
			get
			{
				return this._decPrecioUnitario;
			}
			set
			{
				if ((this._decPrecioUnitario != value))
				{
					this._decPrecioUnitario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchLeyenda", CanBeNull=false)]
		public string vchLeyenda
		{
			get
			{
				return this._vchLeyenda;
			}
			set
			{
				if ((this._vchLeyenda != value))
				{
					this._vchLeyenda = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTotalInternacion")]
		public decimal decTotalInternacion
		{
			get
			{
				return this._decTotalInternacion;
			}
			set
			{
				if ((this._decTotalInternacion != value))
				{
					this._decTotalInternacion = value;
				}
			}
		}
	}
	
	public partial class stp_ListarDatosRielPortaRuedaResult
	{
		
		private int _intRielPortaRuedaID;
		
		private System.Nullable<int> _intElementoID;
		
		private System.Nullable<int> _intCotizacionID;
		
		private System.Nullable<int> _intDetCotizaID;
		
		private System.Nullable<int> _intCalibreAceroID;
		
		private System.Nullable<int> _intUnidadMedicionID;
		
		private System.Nullable<short> _sintMonedaID;
		
		private System.Nullable<decimal> _decLargo;
		
		private System.Nullable<int> _intNumNivel;
		
		private System.Nullable<int> _intClip;
		
		private System.Nullable<int> _intCantidadRuedaRiel;
		
		private System.Nullable<int> _intCantidad;
		
		private System.Nullable<decimal> _decCostoPorRuedaUSD;
		
		private System.Nullable<decimal> _decTipoCambio;
		
		private System.Nullable<decimal> _decTotalRielPartida;
		
		private System.Nullable<bool> _bitPlastica;
		
		private System.Nullable<bool> _bitActivo;
		
		public stp_ListarDatosRielPortaRuedaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intRielPortaRuedaID", DbType="Int NOT NULL")]
		public int intRielPortaRuedaID
		{
			get
			{
				return this._intRielPortaRuedaID;
			}
			set
			{
				if ((this._intRielPortaRuedaID != value))
				{
					this._intRielPortaRuedaID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intElementoID", DbType="Int")]
		public System.Nullable<int> intElementoID
		{
			get
			{
				return this._intElementoID;
			}
			set
			{
				if ((this._intElementoID != value))
				{
					this._intElementoID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCotizacionID", DbType="Int")]
		public System.Nullable<int> intCotizacionID
		{
			get
			{
				return this._intCotizacionID;
			}
			set
			{
				if ((this._intCotizacionID != value))
				{
					this._intCotizacionID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intDetCotizaID", DbType="Int")]
		public System.Nullable<int> intDetCotizaID
		{
			get
			{
				return this._intDetCotizaID;
			}
			set
			{
				if ((this._intDetCotizaID != value))
				{
					this._intDetCotizaID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCalibreAceroID", DbType="Int")]
		public System.Nullable<int> intCalibreAceroID
		{
			get
			{
				return this._intCalibreAceroID;
			}
			set
			{
				if ((this._intCalibreAceroID != value))
				{
					this._intCalibreAceroID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intUnidadMedicionID", DbType="Int")]
		public System.Nullable<int> intUnidadMedicionID
		{
			get
			{
				return this._intUnidadMedicionID;
			}
			set
			{
				if ((this._intUnidadMedicionID != value))
				{
					this._intUnidadMedicionID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintMonedaID", DbType="SmallInt")]
		public System.Nullable<short> sintMonedaID
		{
			get
			{
				return this._sintMonedaID;
			}
			set
			{
				if ((this._sintMonedaID != value))
				{
					this._sintMonedaID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLargo", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> decLargo
		{
			get
			{
				return this._decLargo;
			}
			set
			{
				if ((this._decLargo != value))
				{
					this._decLargo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intNumNivel", DbType="Int")]
		public System.Nullable<int> intNumNivel
		{
			get
			{
				return this._intNumNivel;
			}
			set
			{
				if ((this._intNumNivel != value))
				{
					this._intNumNivel = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intClip", DbType="Int")]
		public System.Nullable<int> intClip
		{
			get
			{
				return this._intClip;
			}
			set
			{
				if ((this._intClip != value))
				{
					this._intClip = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCantidadRuedaRiel", DbType="Int")]
		public System.Nullable<int> intCantidadRuedaRiel
		{
			get
			{
				return this._intCantidadRuedaRiel;
			}
			set
			{
				if ((this._intCantidadRuedaRiel != value))
				{
					this._intCantidadRuedaRiel = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCantidad", DbType="Int")]
		public System.Nullable<int> intCantidad
		{
			get
			{
				return this._intCantidad;
			}
			set
			{
				if ((this._intCantidad != value))
				{
					this._intCantidad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decCostoPorRuedaUSD", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> decCostoPorRuedaUSD
		{
			get
			{
				return this._decCostoPorRuedaUSD;
			}
			set
			{
				if ((this._decCostoPorRuedaUSD != value))
				{
					this._decCostoPorRuedaUSD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTipoCambio", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> decTipoCambio
		{
			get
			{
				return this._decTipoCambio;
			}
			set
			{
				if ((this._decTipoCambio != value))
				{
					this._decTipoCambio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTotalRielPartida", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> decTotalRielPartida
		{
			get
			{
				return this._decTotalRielPartida;
			}
			set
			{
				if ((this._decTotalRielPartida != value))
				{
					this._decTotalRielPartida = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bitPlastica", DbType="Bit")]
		public System.Nullable<bool> bitPlastica
		{
			get
			{
				return this._bitPlastica;
			}
			set
			{
				if ((this._bitPlastica != value))
				{
					this._bitPlastica = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bitActivo", DbType="Bit")]
		public System.Nullable<bool> bitActivo
		{
			get
			{
				return this._bitActivo;
			}
			set
			{
				if ((this._bitActivo != value))
				{
					this._bitActivo = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
