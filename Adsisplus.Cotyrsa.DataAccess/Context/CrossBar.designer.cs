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
	public partial class CrossBarDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public CrossBarDataContext() : 
				base(global::Adsisplus.Cotyrsa.DataAccess.Properties.Settings.Default.dbTyrsaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CrossBarDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CrossBarDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CrossBarDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CrossBarDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosCrossBar")]
		public ISingleResult<stp_ListarDatosCrossBarResult> stp_ListarDatosCrossBar([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatosCrossBarID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatoMarcoID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intDatosCrossBarID, intElementoID, intDatoMarcoID);
			return ((ISingleResult<stp_ListarDatosCrossBarResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarAnchoCrossBar")]
		public ISingleResult<stp_ListarAnchoCrossBarResult> stp_ListarAnchoCrossBar()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<stp_ListarAnchoCrossBarResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarSeleccionCrossBar")]
		public ISingleResult<stp_ListarSeleccionCrossBarResult> stp_ListarSeleccionCrossBar([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decAncho)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), decAncho);
			return ((ISingleResult<stp_ListarSeleccionCrossBarResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosPantallaCrossBar")]
		public ISingleResult<stp_ListarDatosPantallaCrossBarResult> stp_ListarDatosPantallaCrossBar([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intSeleccionCrossBarID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intSeleccionCrossBarID, intCotizacionID);
			return ((ISingleResult<stp_ListarDatosPantallaCrossBarResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setSeleccionCrossBar")]
		public ISingleResult<stp_setSeleccionCrossBarResult> stp_setSeleccionCrossBar(
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intSeleccionCrossBarID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intRackID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decAnchoBus, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decLargoBus, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitConectorViga, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintCrossBarID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string vchTipoCrossBar, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,3)")] System.Nullable<decimal> decPrecioFinal, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintFactorCrossBarID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintNumPieza, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decDesarrollo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decLongitud, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string vchMaterial, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decAncho, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decLargo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intPiezaLamina, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intNumPiezas, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPesoPieza, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPesoPartida, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,3)")] System.Nullable<decimal> decPrecioAcero, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,3)")] System.Nullable<decimal> decTotal, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,3)")] System.Nullable<decimal> decTotalKiloUnitario, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decAreaPintura, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintCara, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intSeleccionCrossBarID, intRackID, intDetCotizaID, decAnchoBus, decLargoBus, bitConectorViga, sintCrossBarID, vchTipoCrossBar, decPrecioFinal, sintFactorCrossBarID, sintNumPieza, decDesarrollo, decLongitud, vchMaterial, decAncho, decLargo, intPiezaLamina, intNumPiezas, sintPesoPieza, decPesoPartida, decPrecioAcero, decTotal, decTotalKiloUnitario, decAreaPintura, sintCara, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setSeleccionCrossBarResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosSeleccionCrossBar")]
		public ISingleResult<stp_ListarDatosSeleccionCrossBarResult> stp_ListarDatosSeleccionCrossBar([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCotizacionID);
			return ((ISingleResult<stp_ListarDatosSeleccionCrossBarResult>)(result.ReturnValue));
		}
	}
	
	public partial class stp_ListarDatosCrossBarResult
	{
		
		private int _intDatosCrossBarID;
		
		private string _vchElemento;
		
		private System.Nullable<short> _sintCantidadDatoMarco;
		
		private System.Nullable<decimal> _decAnchoCrossBar;
		
		private System.Nullable<bool> _bitConectorVigaCrossbar;
		
		private System.Nullable<int> _intCantidadNivelCrossbar;
		
		private System.Nullable<bool> _bitActivo;
		
		public stp_ListarDatosCrossBarResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intDatosCrossBarID", DbType="Int NOT NULL")]
		public int intDatosCrossBarID
		{
			get
			{
				return this._intDatosCrossBarID;
			}
			set
			{
				if ((this._intDatosCrossBarID != value))
				{
					this._intDatosCrossBarID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchElemento", DbType="VarChar(25)")]
		public string vchElemento
		{
			get
			{
				return this._vchElemento;
			}
			set
			{
				if ((this._vchElemento != value))
				{
					this._vchElemento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintCantidadDatoMarco", DbType="SmallInt")]
		public System.Nullable<short> sintCantidadDatoMarco
		{
			get
			{
				return this._sintCantidadDatoMarco;
			}
			set
			{
				if ((this._sintCantidadDatoMarco != value))
				{
					this._sintCantidadDatoMarco = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decAnchoCrossBar", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> decAnchoCrossBar
		{
			get
			{
				return this._decAnchoCrossBar;
			}
			set
			{
				if ((this._decAnchoCrossBar != value))
				{
					this._decAnchoCrossBar = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bitConectorVigaCrossbar", DbType="Bit")]
		public System.Nullable<bool> bitConectorVigaCrossbar
		{
			get
			{
				return this._bitConectorVigaCrossbar;
			}
			set
			{
				if ((this._bitConectorVigaCrossbar != value))
				{
					this._bitConectorVigaCrossbar = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCantidadNivelCrossbar", DbType="Int")]
		public System.Nullable<int> intCantidadNivelCrossbar
		{
			get
			{
				return this._intCantidadNivelCrossbar;
			}
			set
			{
				if ((this._intCantidadNivelCrossbar != value))
				{
					this._intCantidadNivelCrossbar = value;
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
	
	public partial class stp_ListarAnchoCrossBarResult
	{
		
		private System.Nullable<decimal> _decAncho;
		
		public stp_ListarAnchoCrossBarResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decAncho", DbType="Decimal(12,3)")]
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
	}
	
	public partial class stp_ListarSeleccionCrossBarResult
	{
		
		private short _sintCrossBarID;
		
		private string _vchTipoCrossBar;
		
		private System.Nullable<decimal> _decPrecioFinal;
		
		private System.Nullable<short> _sintFactorCrossBarID;
		
		private System.Nullable<short> _sintNumPieza;
		
		private System.Nullable<decimal> _decDesarrollo;
		
		private System.Nullable<decimal> _decLongitud;
		
		private string _vchMaterial;
		
		private System.Nullable<decimal> _decAncho;
		
		private System.Nullable<decimal> _decLargo;
		
		private System.Nullable<int> _intPiezaLamina;
		
		private System.Nullable<int> _intNumPiezas;
		
		private System.Nullable<short> _sintPesoPieza;
		
		private System.Nullable<decimal> _decPesoPartida;
		
		private System.Nullable<decimal> _decPrecioAcero;
		
		private System.Nullable<decimal> _decTotal;
		
		private System.Nullable<decimal> _decTotalKiloUnitario;
		
		private System.Nullable<decimal> _decAreaPintura;
		
		private System.Nullable<short> _sintCara;
		
		private System.Nullable<bool> _bitActivo;
		
		public stp_ListarSeleccionCrossBarResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintCrossBarID", DbType="SmallInt NOT NULL")]
		public short sintCrossBarID
		{
			get
			{
				return this._sintCrossBarID;
			}
			set
			{
				if ((this._sintCrossBarID != value))
				{
					this._sintCrossBarID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchTipoCrossBar", DbType="VarChar(100)")]
		public string vchTipoCrossBar
		{
			get
			{
				return this._vchTipoCrossBar;
			}
			set
			{
				if ((this._vchTipoCrossBar != value))
				{
					this._vchTipoCrossBar = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintFactorCrossBarID", DbType="SmallInt")]
		public System.Nullable<short> sintFactorCrossBarID
		{
			get
			{
				return this._sintFactorCrossBarID;
			}
			set
			{
				if ((this._sintFactorCrossBarID != value))
				{
					this._sintFactorCrossBarID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintNumPieza", DbType="SmallInt")]
		public System.Nullable<short> sintNumPieza
		{
			get
			{
				return this._sintNumPieza;
			}
			set
			{
				if ((this._sintNumPieza != value))
				{
					this._sintNumPieza = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchMaterial", DbType="VarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decAncho", DbType="Decimal(12,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLargo", DbType="Decimal(12,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intPiezaLamina", DbType="Int")]
		public System.Nullable<int> intPiezaLamina
		{
			get
			{
				return this._intPiezaLamina;
			}
			set
			{
				if ((this._intPiezaLamina != value))
				{
					this._intPiezaLamina = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intNumPiezas", DbType="Int")]
		public System.Nullable<int> intNumPiezas
		{
			get
			{
				return this._intNumPiezas;
			}
			set
			{
				if ((this._intNumPiezas != value))
				{
					this._intNumPiezas = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintPesoPieza", DbType="SmallInt")]
		public System.Nullable<short> sintPesoPieza
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioAcero", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> decPrecioAcero
		{
			get
			{
				return this._decPrecioAcero;
			}
			set
			{
				if ((this._decPrecioAcero != value))
				{
					this._decPrecioAcero = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTotal", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> decTotal
		{
			get
			{
				return this._decTotal;
			}
			set
			{
				if ((this._decTotal != value))
				{
					this._decTotal = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decAreaPintura", DbType="Decimal(12,3)")]
		public System.Nullable<decimal> decAreaPintura
		{
			get
			{
				return this._decAreaPintura;
			}
			set
			{
				if ((this._decAreaPintura != value))
				{
					this._decAreaPintura = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintCara", DbType="SmallInt")]
		public System.Nullable<short> sintCara
		{
			get
			{
				return this._sintCara;
			}
			set
			{
				if ((this._sintCara != value))
				{
					this._sintCara = value;
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
	
	public partial class stp_ListarDatosPantallaCrossBarResult
	{
		
		private int _intRackID;
		
		private System.Nullable<int> _intDetCotizaID;
		
		private System.Nullable<int> _intCotizacionID;
		
		private System.Nullable<int> _intCantidadNivelCrossbar;
		
		private System.Nullable<int> _intCantidad;
		
		private System.Nullable<bool> _bitActivo;
		
		private System.Nullable<bool> _bitConectorViga;
		
		private System.Nullable<decimal> _decAncho;
		
		private System.Nullable<decimal> _decAnchoBus;
		
		private System.Nullable<decimal> _decAreaPintura;
		
		private System.Nullable<decimal> _decDesarrollo;
		
		private System.Nullable<decimal> _decLargo;
		
		private System.Nullable<decimal> _decLargoBus;
		
		private System.Nullable<decimal> _decLongitud;
		
		private System.Nullable<decimal> _decPesoPartida;
		
		private System.Nullable<decimal> _decPrecioAcero;
		
		private System.Nullable<decimal> _decPrecioFinal;
		
		private System.Nullable<decimal> _decTotal;
		
		private System.Nullable<decimal> _decTotalKiloUnitario;
		
		private System.Nullable<int> _intDetCotizaID1;
		
		private System.Nullable<int> _intNumPiezas;
		
		private System.Nullable<int> _intPiezaLamina;
		
		private System.Nullable<int> _intSeleccionCrossBarID;
		
		private System.Nullable<short> _sintCara;
		
		private System.Nullable<short> _sintCrossBarID;
		
		private System.Nullable<short> _sintFactorCrossBarID;
		
		private System.Nullable<short> _sintNumPieza;
		
		private System.Nullable<short> _sintPesoPieza;
		
		private string _vchMaterial;
		
		private string _vchTipoCrossBar;
		
		public stp_ListarDatosPantallaCrossBarResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intRackID", DbType="Int NOT NULL")]
		public int intRackID
		{
			get
			{
				return this._intRackID;
			}
			set
			{
				if ((this._intRackID != value))
				{
					this._intRackID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCantidadNivelCrossbar", DbType="Int")]
		public System.Nullable<int> intCantidadNivelCrossbar
		{
			get
			{
				return this._intCantidadNivelCrossbar;
			}
			set
			{
				if ((this._intCantidadNivelCrossbar != value))
				{
					this._intCantidadNivelCrossbar = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bitConectorViga", DbType="Bit")]
		public System.Nullable<bool> bitConectorViga
		{
			get
			{
				return this._bitConectorViga;
			}
			set
			{
				if ((this._bitConectorViga != value))
				{
					this._bitConectorViga = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decAnchoBus", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decAnchoBus
		{
			get
			{
				return this._decAnchoBus;
			}
			set
			{
				if ((this._decAnchoBus != value))
				{
					this._decAnchoBus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decAreaPintura", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decAreaPintura
		{
			get
			{
				return this._decAreaPintura;
			}
			set
			{
				if ((this._decAreaPintura != value))
				{
					this._decAreaPintura = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLargo", DbType="Decimal(8,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLargoBus", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decLargoBus
		{
			get
			{
				return this._decLargoBus;
			}
			set
			{
				if ((this._decLargoBus != value))
				{
					this._decLargoBus = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPesoPartida", DbType="Decimal(8,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioAcero", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decPrecioAcero
		{
			get
			{
				return this._decPrecioAcero;
			}
			set
			{
				if ((this._decPrecioAcero != value))
				{
					this._decPrecioAcero = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioFinal", DbType="Decimal(8,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTotal", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decTotal
		{
			get
			{
				return this._decTotal;
			}
			set
			{
				if ((this._decTotal != value))
				{
					this._decTotal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTotalKiloUnitario", DbType="Decimal(8,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intDetCotizaID1", DbType="Int")]
		public System.Nullable<int> intDetCotizaID1
		{
			get
			{
				return this._intDetCotizaID1;
			}
			set
			{
				if ((this._intDetCotizaID1 != value))
				{
					this._intDetCotizaID1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intNumPiezas", DbType="Int")]
		public System.Nullable<int> intNumPiezas
		{
			get
			{
				return this._intNumPiezas;
			}
			set
			{
				if ((this._intNumPiezas != value))
				{
					this._intNumPiezas = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intPiezaLamina", DbType="Int")]
		public System.Nullable<int> intPiezaLamina
		{
			get
			{
				return this._intPiezaLamina;
			}
			set
			{
				if ((this._intPiezaLamina != value))
				{
					this._intPiezaLamina = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intSeleccionCrossBarID", DbType="Int")]
		public System.Nullable<int> intSeleccionCrossBarID
		{
			get
			{
				return this._intSeleccionCrossBarID;
			}
			set
			{
				if ((this._intSeleccionCrossBarID != value))
				{
					this._intSeleccionCrossBarID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintCara", DbType="SmallInt")]
		public System.Nullable<short> sintCara
		{
			get
			{
				return this._sintCara;
			}
			set
			{
				if ((this._sintCara != value))
				{
					this._sintCara = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintCrossBarID", DbType="SmallInt")]
		public System.Nullable<short> sintCrossBarID
		{
			get
			{
				return this._sintCrossBarID;
			}
			set
			{
				if ((this._sintCrossBarID != value))
				{
					this._sintCrossBarID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintFactorCrossBarID", DbType="SmallInt")]
		public System.Nullable<short> sintFactorCrossBarID
		{
			get
			{
				return this._sintFactorCrossBarID;
			}
			set
			{
				if ((this._sintFactorCrossBarID != value))
				{
					this._sintFactorCrossBarID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintNumPieza", DbType="SmallInt")]
		public System.Nullable<short> sintNumPieza
		{
			get
			{
				return this._sintNumPieza;
			}
			set
			{
				if ((this._sintNumPieza != value))
				{
					this._sintNumPieza = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintPesoPieza", DbType="SmallInt")]
		public System.Nullable<short> sintPesoPieza
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchMaterial", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchTipoCrossBar", DbType="VarChar(50)")]
		public string vchTipoCrossBar
		{
			get
			{
				return this._vchTipoCrossBar;
			}
			set
			{
				if ((this._vchTipoCrossBar != value))
				{
					this._vchTipoCrossBar = value;
				}
			}
		}
	}
	
	public partial class stp_setSeleccionCrossBarResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setSeleccionCrossBarResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(60) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_ListarDatosSeleccionCrossBarResult
	{
		
		private int _intSeleccionCrossBarID;
		
		private System.Nullable<short> _sintCrossBarID;
		
		private string _vchTipoCrossBar;
		
		private System.Nullable<decimal> _decPrecioFinal;
		
		private System.Nullable<short> _sintFactorCrossBarID;
		
		private System.Nullable<short> _sintNumPieza;
		
		private System.Nullable<decimal> _decDesarrollo;
		
		private System.Nullable<decimal> _decLongitud;
		
		private string _vchMaterial;
		
		private System.Nullable<decimal> _decAncho;
		
		private System.Nullable<decimal> _decLargo;
		
		private System.Nullable<int> _intPiezaLamina;
		
		private System.Nullable<int> _intNumPiezas;
		
		private System.Nullable<short> _sintPesoPieza;
		
		private System.Nullable<decimal> _decPesoPartida;
		
		private System.Nullable<decimal> _decPrecioAcero;
		
		private System.Nullable<decimal> _decTotal;
		
		private System.Nullable<decimal> _decTotalKiloUnitario;
		
		private System.Nullable<decimal> _decAreaPintura;
		
		private System.Nullable<short> _sintCara;
		
		private System.Nullable<int> _intCantidad;
		
		private System.Nullable<decimal> _decSubtotal;
		
		private System.Nullable<bool> _bitActivo;
		
		public stp_ListarDatosSeleccionCrossBarResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intSeleccionCrossBarID", DbType="Int NOT NULL")]
		public int intSeleccionCrossBarID
		{
			get
			{
				return this._intSeleccionCrossBarID;
			}
			set
			{
				if ((this._intSeleccionCrossBarID != value))
				{
					this._intSeleccionCrossBarID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintCrossBarID", DbType="SmallInt")]
		public System.Nullable<short> sintCrossBarID
		{
			get
			{
				return this._sintCrossBarID;
			}
			set
			{
				if ((this._sintCrossBarID != value))
				{
					this._sintCrossBarID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchTipoCrossBar", DbType="VarChar(50)")]
		public string vchTipoCrossBar
		{
			get
			{
				return this._vchTipoCrossBar;
			}
			set
			{
				if ((this._vchTipoCrossBar != value))
				{
					this._vchTipoCrossBar = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioFinal", DbType="Decimal(18,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintFactorCrossBarID", DbType="SmallInt")]
		public System.Nullable<short> sintFactorCrossBarID
		{
			get
			{
				return this._sintFactorCrossBarID;
			}
			set
			{
				if ((this._sintFactorCrossBarID != value))
				{
					this._sintFactorCrossBarID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintNumPieza", DbType="SmallInt")]
		public System.Nullable<short> sintNumPieza
		{
			get
			{
				return this._sintNumPieza;
			}
			set
			{
				if ((this._sintNumPieza != value))
				{
					this._sintNumPieza = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchMaterial", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLargo", DbType="Decimal(8,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intPiezaLamina", DbType="Int")]
		public System.Nullable<int> intPiezaLamina
		{
			get
			{
				return this._intPiezaLamina;
			}
			set
			{
				if ((this._intPiezaLamina != value))
				{
					this._intPiezaLamina = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intNumPiezas", DbType="Int")]
		public System.Nullable<int> intNumPiezas
		{
			get
			{
				return this._intNumPiezas;
			}
			set
			{
				if ((this._intNumPiezas != value))
				{
					this._intNumPiezas = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintPesoPieza", DbType="SmallInt")]
		public System.Nullable<short> sintPesoPieza
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPesoPartida", DbType="Decimal(8,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioAcero", DbType="Decimal(18,3)")]
		public System.Nullable<decimal> decPrecioAcero
		{
			get
			{
				return this._decPrecioAcero;
			}
			set
			{
				if ((this._decPrecioAcero != value))
				{
					this._decPrecioAcero = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTotal", DbType="Decimal(18,3)")]
		public System.Nullable<decimal> decTotal
		{
			get
			{
				return this._decTotal;
			}
			set
			{
				if ((this._decTotal != value))
				{
					this._decTotal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTotalKiloUnitario", DbType="Decimal(18,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decAreaPintura", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decAreaPintura
		{
			get
			{
				return this._decAreaPintura;
			}
			set
			{
				if ((this._decAreaPintura != value))
				{
					this._decAreaPintura = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintCara", DbType="SmallInt")]
		public System.Nullable<short> sintCara
		{
			get
			{
				return this._sintCara;
			}
			set
			{
				if ((this._sintCara != value))
				{
					this._sintCara = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decSubtotal", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> decSubtotal
		{
			get
			{
				return this._decSubtotal;
			}
			set
			{
				if ((this._decSubtotal != value))
				{
					this._decSubtotal = value;
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
