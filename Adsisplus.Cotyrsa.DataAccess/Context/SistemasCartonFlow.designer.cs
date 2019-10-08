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
	public partial class SistemasCartonFlowDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public SistemasCartonFlowDataContext() : 
				base(global::Adsisplus.Cotyrsa.DataAccess.Properties.Settings.Default.dbTyrsaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SistemasCartonFlowDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SistemasCartonFlowDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SistemasCartonFlowDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SistemasCartonFlowDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<entPerfilCartonFlow> entPerfilCartonFlow
		{
			get
			{
				return this.GetTable<entPerfilCartonFlow>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosCartonFlow")]
		public ISingleResult<stp_setDatosCartonFlowResult> stp_setDatosCartonFlow(
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatosCartonFlowID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPinturaID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintTipoCartonFlowID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintMonedaID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> intUnidadMedicionID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decFrente, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decFondo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decAltura, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decLargoPerfil, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintCantidadRiel, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decClip, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intInternacion, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decCostoInternacion, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decTotalInternacion, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intTotalRieles, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intTotalRuedas, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decPrecioRuedas, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decTipoCambio, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decCostoTotalRuedas, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPeso, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decPesoTotal, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intNumCajaNivel, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decPesoNivel, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intNumNivel, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantRefuerzoNivel, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(10,2)")] System.Nullable<decimal> decPrecioUnitario, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(10,2)")] System.Nullable<decimal> decPrecioTotal, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(250)")] string vchLeyenda, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intDatosCartonFlowID, intElementoID, intDetCotizaID, sintPinturaID, sintTipoCartonFlowID, sintMonedaID, intUnidadMedicionID, decFrente, decFondo, decAltura, decLargoPerfil, sintCantidadRiel, decClip, intInternacion, decCostoInternacion, decTotalInternacion, intTotalRieles, intTotalRuedas, decPrecioRuedas, decTipoCambio, decCostoTotalRuedas, decPeso, decPesoTotal, intNumCajaNivel, decPesoNivel, intNumNivel, intCantRefuerzoNivel, decPrecioUnitario, decPrecioTotal, vchLeyenda, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosCartonFlowResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarCatPerfilCartonFlow")]
		public ISingleResult<stp_ListarCatPerfilCartonFlowResult> stp_ListarCatPerfilCartonFlow()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<stp_ListarCatPerfilCartonFlowResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarCatCalibreCartonFlow")]
		public ISingleResult<stp_ListarCatCalibreCartonFlowResult> stp_ListarCatCalibreCartonFlow([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintTipoCartonFlowID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sintTipoCartonFlowID);
			return ((ISingleResult<stp_ListarCatCalibreCartonFlowResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarRielesRuedaMetalicaCartonFlow", IsComposable=true)]
		public object stp_ListarRielesRuedaMetalicaCartonFlow([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintTipoCartonFlowID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> intCalibreAceroID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintCantidadRiel, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intNumNivel, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decLargoPerfil, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintCantidadRuegas, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decPrecioRuedas, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decTipoCambio)
		{
			return ((object)(this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sintTipoCartonFlowID, intCalibreAceroID, sintCantidadRiel, intNumNivel, decLargoPerfil, sintCantidadRuegas, decPrecioRuedas, decTipoCambio).ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarRielesRuedaPlasticaCartonFlow")]
		public ISingleResult<stp_ListarRielesRuedaPlasticaCartonFlowResult> stp_ListarRielesRuedaPlasticaCartonFlow([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintTipoCartonFlowID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> intCalibreAceroID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decAncho, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decLargo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintCantidadRiel, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> decTotalKiloUnitario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intNumNivel, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decLargoPerfil, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintCantidadRuegas, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decPrecioRuedas, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decTipoCambio, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intInternacion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decCostoInternacion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sintTipoCartonFlowID, intCalibreAceroID, decAncho, decLargo, sintCantidadRiel, decTotalKiloUnitario, intNumNivel, decLargoPerfil, sintCantidadRuegas, decPrecioRuedas, decTipoCambio, intInternacion, decCostoInternacion);
			return ((ISingleResult<stp_ListarRielesRuedaPlasticaCartonFlowResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarConectorCartonFlow", IsComposable=true)]
		public object stp_ListarConectorCartonFlow([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintTipoCartonFlowID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> intCalibreAceroID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidad)
		{
			return ((object)(this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sintTipoCartonFlowID, intCalibreAceroID, intCantidad).ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarPerfilCartonFlow")]
		public ISingleResult<entPerfilCartonFlow> stp_ListarPerfilCartonFlow([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintTipoCartonFlowID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> intCalibreAceroID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decLargoPerfil)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sintTipoCartonFlowID, intCalibreAceroID, decLargoPerfil);
			return ((ISingleResult<entPerfilCartonFlow>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class entPerfilCartonFlow
	{
		
		private short _sintTipoCartonFlowID;
		
		private short _sintCalibre;
		
		private string _vchTipoCartonFlow;
		
		private decimal _decAncho;
		
		private decimal _decLargo;
		
		private short _sintPesoPieza;
		
		private decimal _decTotalKiloUnitario;
		
		private decimal _decPrecioUnitario;
		
		private string _vchLeyenda;
		
		public entPerfilCartonFlow()
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
	}
	
	public partial class stp_setDatosCartonFlowResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosCartonFlowResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchResultado", DbType="VarChar(12)")]
		public string vchResultado
		{
			get
			{
				return this._vchResultado;
			}
			set
			{
				if ((this._vchResultado != value))
				{
					this._vchResultado = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(54) NOT NULL", CanBeNull=false)]
		public string vchDescripcion
		{
			get
			{
				return this._vchDescripcion;
			}
			set
			{
				if ((this._vchDescripcion != value))
				{
					this._vchDescripcion = value;
				}
			}
		}
	}
	
	public partial class stp_ListarCatPerfilCartonFlowResult
	{
		
		private short _sintTipoCartonFlowID;
		
		private string _vchTipoCartonFlow;
		
		public stp_ListarCatPerfilCartonFlowResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintTipoCartonFlowID", DbType="SmallInt NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchTipoCartonFlow", DbType="VarChar(250)")]
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
	}
	
	public partial class stp_ListarCatCalibreCartonFlowResult
	{
		
		private int _intCalibreAceroID;
		
		private string _vchCalibreAcero;
		
		public stp_ListarCatCalibreCartonFlowResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCalibreAceroID", DbType="Int NOT NULL")]
		public int intCalibreAceroID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchCalibreAcero", DbType="VarChar(50)")]
		public string vchCalibreAcero
		{
			get
			{
				return this._vchCalibreAcero;
			}
			set
			{
				if ((this._vchCalibreAcero != value))
				{
					this._vchCalibreAcero = value;
				}
			}
		}
	}
	
	public partial class stp_ListarRielesRuedaPlasticaCartonFlowResult
	{
		
		private System.Nullable<short> _sintTipoCartonFlowID;
		
		private int _sintCalibre;
		
		private string _vchTipoCartonFlow;
		
		private System.Nullable<decimal> _decAncho;
		
		private System.Nullable<decimal> _decLargo;
		
		private System.Nullable<int> _intTotalRieles;
		
		private System.Nullable<int> _intTotalRuedas;
		
		private System.Nullable<decimal> _decCostoTotalRuedas;
		
		private System.Nullable<int> _decClip;
		
		private System.Nullable<decimal> _decTotalInternacion;
		
		private System.Nullable<short> _decTotalKiloUnitario;
		
		private System.Nullable<decimal> _decPrecioUnitario;
		
		private string _vchLeyenda;
		
		public stp_ListarRielesRuedaPlasticaCartonFlowResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintTipoCartonFlowID", DbType="SmallInt")]
		public System.Nullable<short> sintTipoCartonFlowID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintCalibre", DbType="Int NOT NULL")]
		public int sintCalibre
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchTipoCartonFlow", DbType="VarChar(39) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decAncho", DbType="Decimal(8,2)")]
		public System.Nullable<decimal> decAncho
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLargo", DbType="Decimal(8,2)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intTotalRieles", DbType="Int")]
		public System.Nullable<int> intTotalRieles
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intTotalRuedas", DbType="Int")]
		public System.Nullable<int> intTotalRuedas
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decCostoTotalRuedas", DbType="Decimal(30,6)")]
		public System.Nullable<decimal> decCostoTotalRuedas
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decClip", DbType="Int")]
		public System.Nullable<int> decClip
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTotalInternacion", DbType="Decimal(32,4)")]
		public System.Nullable<decimal> decTotalInternacion
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTotalKiloUnitario", DbType="SmallInt")]
		public System.Nullable<short> decTotalKiloUnitario
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioUnitario", DbType="Decimal(35,6)")]
		public System.Nullable<decimal> decPrecioUnitario
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchLeyenda", DbType="VarChar(47) NOT NULL", CanBeNull=false)]
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
	}
}
#pragma warning restore 1591
