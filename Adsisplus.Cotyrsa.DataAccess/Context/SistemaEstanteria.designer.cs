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
	public partial class SistemaEstanteriaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public SistemaEstanteriaDataContext() : 
				base(global::Adsisplus.Cotyrsa.DataAccess.Properties.Settings.Default.dbTyrsaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SistemaEstanteriaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SistemaEstanteriaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SistemaEstanteriaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SistemaEstanteriaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarEntrepanio")]
		public ISingleResult<stp_ListarEntrepanioResult> stp_ListarEntrepanio([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintRefuerzo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decFrente, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decFondo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCalibreAceroID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitGalvanizado)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sintRefuerzo, decFrente, decFondo, intCalibreAceroID, bitGalvanizado);
			return ((ISingleResult<stp_ListarEntrepanioResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosEntrepanio")]
		public ISingleResult<stp_ListarDatosEntrepanioResult> stp_ListarDatosEntrepanio([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intEntrepanioID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intEntrepanioID, intCotizacionID);
			return ((ISingleResult<stp_ListarDatosEntrepanioResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosEntrepanio")]
		public ISingleResult<stp_setDatosEntrepanioResult> stp_setDatosEntrepanio(
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intEntrepanioID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintTipoEntrepanioID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPinturaID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCalibreAceroID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidad, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitGalvanizado, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitPintura, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> sintRefuerzo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decFrente, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decFondo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decPesoPartida, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,3)")] System.Nullable<decimal> decTotalKiloUnitario, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decPrecioVenta, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decPrecioFinal, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decPesoTotal, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decPrecioTotal, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intSeleccionEntrepanioID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintNumRefuerzo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string vchCalibreAcero, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCapCargaXEntrepanio, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decDesarrollo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decLongitud, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(250)")] string vchMaterial, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intEntrepanioID, sintTipoEntrepanioID, intCotizacionID, intDetCotizaID, intElementoID, sintPinturaID, intCalibreAceroID, intCantidad, bitGalvanizado, bitPintura, sintRefuerzo, decFrente, decFondo, decPesoPartida, decTotalKiloUnitario, decPrecioVenta, decPrecioFinal, decPesoTotal, decPrecioTotal, intSeleccionEntrepanioID, sintNumRefuerzo, vchCalibreAcero, intCapCargaXEntrepanio, decDesarrollo, decLongitud, vchMaterial, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosEntrepanioResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarAnguloRanurado")]
		public ISingleResult<stp_ListarAnguloRanuradoResult> stp_ListarAnguloRanurado([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decCapacidadCarga)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), decCapacidadCarga);
			return ((ISingleResult<stp_ListarAnguloRanuradoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosAnguloRanurado")]
		public ISingleResult<stp_ListarDatosAnguloRanuradoResult> stp_ListarDatosAnguloRanurado([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intAnguloRanuradoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intAnguloRanuradoID, intCotizacionID);
			return ((ISingleResult<stp_ListarDatosAnguloRanuradoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosAnguloRanurado")]
		public ISingleResult<stp_setDatosAnguloRanuradoResult> stp_setDatosAnguloRanurado(
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intAnguloRanuradoID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> sintTipoAnguloRanuradoID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPinturaID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidad, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decLargo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decCapacidadCarga, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intSeleccionAnguloID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decDesarrollo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decLongitud, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decAncho, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(250)")] string vchMaterial, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decPesoUnitario, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decPrecioUnitario, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intAnguloRanuradoID, sintTipoAnguloRanuradoID, intElementoID, intCotizacionID, intDetCotizaID, sintPinturaID, intCantidad, decLargo, decCapacidadCarga, intSeleccionAnguloID, decDesarrollo, decLongitud, decAncho, vchMaterial, decPesoUnitario, decPrecioUnitario, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosAnguloRanuradoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarSeleccionAnguloRanurado")]
		public ISingleResult<stp_ListarSeleccionAnguloRanuradoResult> stp_ListarSeleccionAnguloRanurado([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intAnguloRanuradoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intAnguloRanuradoID, intCotizacionID);
			return ((ISingleResult<stp_ListarSeleccionAnguloRanuradoResult>)(result.ReturnValue));
		}
	}
	
	public partial class stp_ListarEntrepanioResult
	{
		
		private string _vchCalibreAcero;
		
		private System.Nullable<decimal> _decFondo;
		
		private System.Nullable<decimal> _decFrente;
		
		private System.Nullable<short> _sintNumRefuerzo;
		
		private System.Nullable<int> _intCapCargaXEntrepanio;
		
		private System.Nullable<decimal> _decDesarrollo;
		
		private System.Nullable<decimal> _decLongitud;
		
		private string _vchMaterial;
		
		private System.Nullable<decimal> _decTotalKiloUnitario;
		
		private System.Nullable<decimal> _decPrecioFinal;
		
		public stp_ListarEntrepanioResult()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decFondo", DbType="Decimal(8,2)")]
		public System.Nullable<decimal> decFondo
		{
			get
			{
				return this._decFondo;
			}
			set
			{
				if ((this._decFondo != value))
				{
					this._decFondo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decFrente", DbType="Decimal(8,2)")]
		public System.Nullable<decimal> decFrente
		{
			get
			{
				return this._decFrente;
			}
			set
			{
				if ((this._decFrente != value))
				{
					this._decFrente = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintNumRefuerzo", DbType="SmallInt")]
		public System.Nullable<short> sintNumRefuerzo
		{
			get
			{
				return this._sintNumRefuerzo;
			}
			set
			{
				if ((this._sintNumRefuerzo != value))
				{
					this._sintNumRefuerzo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCapCargaXEntrepanio", DbType="Int")]
		public System.Nullable<int> intCapCargaXEntrepanio
		{
			get
			{
				return this._intCapCargaXEntrepanio;
			}
			set
			{
				if ((this._intCapCargaXEntrepanio != value))
				{
					this._intCapCargaXEntrepanio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decDesarrollo", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decDesarrollo
		{
			get
			{
				return this._decDesarrollo;
			}
			set
			{
				if ((this._decDesarrollo != value))
				{
					this._decDesarrollo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLongitud", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decLongitud
		{
			get
			{
				return this._decLongitud;
			}
			set
			{
				if ((this._decLongitud != value))
				{
					this._decLongitud = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchMaterial", DbType="VarChar(250)")]
		public string vchMaterial
		{
			get
			{
				return this._vchMaterial;
			}
			set
			{
				if ((this._vchMaterial != value))
				{
					this._vchMaterial = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTotalKiloUnitario", DbType="Decimal(12,3)")]
		public System.Nullable<decimal> decTotalKiloUnitario
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioFinal", DbType="Decimal(12,2)")]
		public System.Nullable<decimal> decPrecioFinal
		{
			get
			{
				return this._decPrecioFinal;
			}
			set
			{
				if ((this._decPrecioFinal != value))
				{
					this._decPrecioFinal = value;
				}
			}
		}
	}
	
	public partial class stp_ListarDatosEntrepanioResult
	{
		
		private int _intEntrepanioID;
		
		private System.Nullable<short> _sintTipoEntrepanioID;
		
		private System.Nullable<int> _intCotizacionID;
		
		private System.Nullable<int> _intDetCotizaID;
		
		private System.Nullable<int> _intElementoID;
		
		private System.Nullable<short> _sintPinturaID;
		
		private System.Nullable<int> _intCalibreAceroID;
		
		private System.Nullable<int> _intCantidad;
		
		private System.Nullable<bool> _bitGalvanizado;
		
		private System.Nullable<bool> _bitPintura;
		
		private System.Nullable<short> _sintRefuerzo;
		
		private System.Nullable<decimal> _decFrente;
		
		private System.Nullable<decimal> _decFondo;
		
		private System.Nullable<decimal> _decPesoPartida;
		
		private System.Nullable<decimal> _decTotalKiloUnitario;
		
		private System.Nullable<decimal> _decPrecioVenta;
		
		private System.Nullable<decimal> _decPrecioFinal;
		
		private System.Nullable<decimal> _decPesoTotal;
		
		private System.Nullable<decimal> _decPrecioTotal;
		
		private int _intSeleccionEntrepanioID;
		
		private string _vchCalibreAcero;
		
		private System.Nullable<decimal> _decFondoSel;
		
		private System.Nullable<decimal> _decFrenteSel;
		
		private System.Nullable<short> _sintNumRefuerzo;
		
		private System.Nullable<int> _intCapCargaXEntrepanio;
		
		private System.Nullable<decimal> _decDesarrollo;
		
		private System.Nullable<decimal> _decLongitud;
		
		private string _vchMaterial;
		
		private System.Nullable<decimal> _decTotalKiloUnitarioSel;
		
		private System.Nullable<decimal> _decPrecioFinalSel;
		
		public stp_ListarDatosEntrepanioResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intEntrepanioID", DbType="Int NOT NULL")]
		public int intEntrepanioID
		{
			get
			{
				return this._intEntrepanioID;
			}
			set
			{
				if ((this._intEntrepanioID != value))
				{
					this._intEntrepanioID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintTipoEntrepanioID", DbType="SmallInt")]
		public System.Nullable<short> sintTipoEntrepanioID
		{
			get
			{
				return this._sintTipoEntrepanioID;
			}
			set
			{
				if ((this._sintTipoEntrepanioID != value))
				{
					this._sintTipoEntrepanioID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintPinturaID", DbType="SmallInt")]
		public System.Nullable<short> sintPinturaID
		{
			get
			{
				return this._sintPinturaID;
			}
			set
			{
				if ((this._sintPinturaID != value))
				{
					this._sintPinturaID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bitGalvanizado", DbType="Bit")]
		public System.Nullable<bool> bitGalvanizado
		{
			get
			{
				return this._bitGalvanizado;
			}
			set
			{
				if ((this._bitGalvanizado != value))
				{
					this._bitGalvanizado = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bitPintura", DbType="Bit")]
		public System.Nullable<bool> bitPintura
		{
			get
			{
				return this._bitPintura;
			}
			set
			{
				if ((this._bitPintura != value))
				{
					this._bitPintura = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintRefuerzo", DbType="SmallInt")]
		public System.Nullable<short> sintRefuerzo
		{
			get
			{
				return this._sintRefuerzo;
			}
			set
			{
				if ((this._sintRefuerzo != value))
				{
					this._sintRefuerzo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decFrente", DbType="Decimal(8,2)")]
		public System.Nullable<decimal> decFrente
		{
			get
			{
				return this._decFrente;
			}
			set
			{
				if ((this._decFrente != value))
				{
					this._decFrente = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decFondo", DbType="Decimal(8,2)")]
		public System.Nullable<decimal> decFondo
		{
			get
			{
				return this._decFondo;
			}
			set
			{
				if ((this._decFondo != value))
				{
					this._decFondo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPesoPartida", DbType="Decimal(12,2)")]
		public System.Nullable<decimal> decPesoPartida
		{
			get
			{
				return this._decPesoPartida;
			}
			set
			{
				if ((this._decPesoPartida != value))
				{
					this._decPesoPartida = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTotalKiloUnitario", DbType="Decimal(12,3)")]
		public System.Nullable<decimal> decTotalKiloUnitario
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioVenta", DbType="Decimal(12,2)")]
		public System.Nullable<decimal> decPrecioVenta
		{
			get
			{
				return this._decPrecioVenta;
			}
			set
			{
				if ((this._decPrecioVenta != value))
				{
					this._decPrecioVenta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioFinal", DbType="Decimal(12,2)")]
		public System.Nullable<decimal> decPrecioFinal
		{
			get
			{
				return this._decPrecioFinal;
			}
			set
			{
				if ((this._decPrecioFinal != value))
				{
					this._decPrecioFinal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPesoTotal", DbType="Decimal(12,2)")]
		public System.Nullable<decimal> decPesoTotal
		{
			get
			{
				return this._decPesoTotal;
			}
			set
			{
				if ((this._decPesoTotal != value))
				{
					this._decPesoTotal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioTotal", DbType="Decimal(12,2)")]
		public System.Nullable<decimal> decPrecioTotal
		{
			get
			{
				return this._decPrecioTotal;
			}
			set
			{
				if ((this._decPrecioTotal != value))
				{
					this._decPrecioTotal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intSeleccionEntrepanioID", DbType="Int NOT NULL")]
		public int intSeleccionEntrepanioID
		{
			get
			{
				return this._intSeleccionEntrepanioID;
			}
			set
			{
				if ((this._intSeleccionEntrepanioID != value))
				{
					this._intSeleccionEntrepanioID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decFondoSel", DbType="Decimal(8,2)")]
		public System.Nullable<decimal> decFondoSel
		{
			get
			{
				return this._decFondoSel;
			}
			set
			{
				if ((this._decFondoSel != value))
				{
					this._decFondoSel = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decFrenteSel", DbType="Decimal(8,2)")]
		public System.Nullable<decimal> decFrenteSel
		{
			get
			{
				return this._decFrenteSel;
			}
			set
			{
				if ((this._decFrenteSel != value))
				{
					this._decFrenteSel = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintNumRefuerzo", DbType="SmallInt")]
		public System.Nullable<short> sintNumRefuerzo
		{
			get
			{
				return this._sintNumRefuerzo;
			}
			set
			{
				if ((this._sintNumRefuerzo != value))
				{
					this._sintNumRefuerzo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCapCargaXEntrepanio", DbType="Int")]
		public System.Nullable<int> intCapCargaXEntrepanio
		{
			get
			{
				return this._intCapCargaXEntrepanio;
			}
			set
			{
				if ((this._intCapCargaXEntrepanio != value))
				{
					this._intCapCargaXEntrepanio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decDesarrollo", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decDesarrollo
		{
			get
			{
				return this._decDesarrollo;
			}
			set
			{
				if ((this._decDesarrollo != value))
				{
					this._decDesarrollo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLongitud", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decLongitud
		{
			get
			{
				return this._decLongitud;
			}
			set
			{
				if ((this._decLongitud != value))
				{
					this._decLongitud = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchMaterial", DbType="VarChar(250)")]
		public string vchMaterial
		{
			get
			{
				return this._vchMaterial;
			}
			set
			{
				if ((this._vchMaterial != value))
				{
					this._vchMaterial = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTotalKiloUnitarioSel", DbType="Decimal(12,3)")]
		public System.Nullable<decimal> decTotalKiloUnitarioSel
		{
			get
			{
				return this._decTotalKiloUnitarioSel;
			}
			set
			{
				if ((this._decTotalKiloUnitarioSel != value))
				{
					this._decTotalKiloUnitarioSel = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioFinalSel", DbType="Decimal(12,2)")]
		public System.Nullable<decimal> decPrecioFinalSel
		{
			get
			{
				return this._decPrecioFinalSel;
			}
			set
			{
				if ((this._decPrecioFinalSel != value))
				{
					this._decPrecioFinalSel = value;
				}
			}
		}
	}
	
	public partial class stp_setDatosEntrepanioResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosEntrepanioResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(49) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_ListarAnguloRanuradoResult
	{
		
		private short _sintMstAnguloRanuradoID;
		
		private System.Nullable<decimal> _decDesarrollo;
		
		private System.Nullable<decimal> _decLongitud;
		
		private System.Nullable<decimal> _decAncho;
		
		private string _vchMaterial;
		
		private System.Nullable<decimal> _decPesoUnitario;
		
		private System.Nullable<decimal> _decPrecioUnitario;
		
		public stp_ListarAnguloRanuradoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintMstAnguloRanuradoID", DbType="SmallInt NOT NULL")]
		public short sintMstAnguloRanuradoID
		{
			get
			{
				return this._sintMstAnguloRanuradoID;
			}
			set
			{
				if ((this._sintMstAnguloRanuradoID != value))
				{
					this._sintMstAnguloRanuradoID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decDesarrollo", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decDesarrollo
		{
			get
			{
				return this._decDesarrollo;
			}
			set
			{
				if ((this._decDesarrollo != value))
				{
					this._decDesarrollo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLongitud", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decLongitud
		{
			get
			{
				return this._decLongitud;
			}
			set
			{
				if ((this._decLongitud != value))
				{
					this._decLongitud = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decAncho", DbType="Decimal(8,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchMaterial", DbType="VarChar(250)")]
		public string vchMaterial
		{
			get
			{
				return this._vchMaterial;
			}
			set
			{
				if ((this._vchMaterial != value))
				{
					this._vchMaterial = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPesoUnitario", DbType="Decimal(12,2)")]
		public System.Nullable<decimal> decPesoUnitario
		{
			get
			{
				return this._decPesoUnitario;
			}
			set
			{
				if ((this._decPesoUnitario != value))
				{
					this._decPesoUnitario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioUnitario", DbType="Decimal(12,2)")]
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
	}
	
	public partial class stp_ListarDatosAnguloRanuradoResult
	{
		
		private int _intAnguloRanuradoID;
		
		private System.Nullable<int> _sintTipoAnguloRanuradoID;
		
		private System.Nullable<int> _intElementoID;
		
		private System.Nullable<int> _intCotizacionID;
		
		private System.Nullable<short> _sintPinturaID;
		
		private System.Nullable<int> _intCantidad;
		
		private System.Nullable<decimal> _decLargo;
		
		private System.Nullable<decimal> _decCapacidadCarga;
		
		private System.Nullable<bool> _bitActivo;
		
		public stp_ListarDatosAnguloRanuradoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intAnguloRanuradoID", DbType="Int NOT NULL")]
		public int intAnguloRanuradoID
		{
			get
			{
				return this._intAnguloRanuradoID;
			}
			set
			{
				if ((this._intAnguloRanuradoID != value))
				{
					this._intAnguloRanuradoID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintTipoAnguloRanuradoID", DbType="Int")]
		public System.Nullable<int> sintTipoAnguloRanuradoID
		{
			get
			{
				return this._sintTipoAnguloRanuradoID;
			}
			set
			{
				if ((this._sintTipoAnguloRanuradoID != value))
				{
					this._sintTipoAnguloRanuradoID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintPinturaID", DbType="SmallInt")]
		public System.Nullable<short> sintPinturaID
		{
			get
			{
				return this._sintPinturaID;
			}
			set
			{
				if ((this._sintPinturaID != value))
				{
					this._sintPinturaID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decCapacidadCarga", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decCapacidadCarga
		{
			get
			{
				return this._decCapacidadCarga;
			}
			set
			{
				if ((this._decCapacidadCarga != value))
				{
					this._decCapacidadCarga = value;
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
	
	public partial class stp_setDatosAnguloRanuradoResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosAnguloRanuradoResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(55) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_ListarSeleccionAnguloRanuradoResult
	{
		
		private int _intSeleccionAnguloID;
		
		private System.Nullable<int> _intAnguloRanuradoID;
		
		private System.Nullable<short> _sintMstAnguloRanuradoID;
		
		private System.Nullable<decimal> _decDesarrollo;
		
		private System.Nullable<decimal> _decLongitud;
		
		private System.Nullable<decimal> _decAncho;
		
		private string _vchMaterial;
		
		private System.Nullable<decimal> _decPesoUnitario;
		
		private System.Nullable<decimal> _decPrecioUnitario;
		
		private string _bitActivo;
		
		public stp_ListarSeleccionAnguloRanuradoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intSeleccionAnguloID", DbType="Int NOT NULL")]
		public int intSeleccionAnguloID
		{
			get
			{
				return this._intSeleccionAnguloID;
			}
			set
			{
				if ((this._intSeleccionAnguloID != value))
				{
					this._intSeleccionAnguloID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intAnguloRanuradoID", DbType="Int")]
		public System.Nullable<int> intAnguloRanuradoID
		{
			get
			{
				return this._intAnguloRanuradoID;
			}
			set
			{
				if ((this._intAnguloRanuradoID != value))
				{
					this._intAnguloRanuradoID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintMstAnguloRanuradoID", DbType="SmallInt")]
		public System.Nullable<short> sintMstAnguloRanuradoID
		{
			get
			{
				return this._sintMstAnguloRanuradoID;
			}
			set
			{
				if ((this._sintMstAnguloRanuradoID != value))
				{
					this._sintMstAnguloRanuradoID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decDesarrollo", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decDesarrollo
		{
			get
			{
				return this._decDesarrollo;
			}
			set
			{
				if ((this._decDesarrollo != value))
				{
					this._decDesarrollo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLongitud", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decLongitud
		{
			get
			{
				return this._decLongitud;
			}
			set
			{
				if ((this._decLongitud != value))
				{
					this._decLongitud = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decAncho", DbType="Decimal(8,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchMaterial", DbType="VarChar(250)")]
		public string vchMaterial
		{
			get
			{
				return this._vchMaterial;
			}
			set
			{
				if ((this._vchMaterial != value))
				{
					this._vchMaterial = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPesoUnitario", DbType="Decimal(12,2)")]
		public System.Nullable<decimal> decPesoUnitario
		{
			get
			{
				return this._decPesoUnitario;
			}
			set
			{
				if ((this._decPesoUnitario != value))
				{
					this._decPesoUnitario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioUnitario", DbType="Decimal(12,2)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bitActivo", DbType="Char(10)")]
		public string bitActivo
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
