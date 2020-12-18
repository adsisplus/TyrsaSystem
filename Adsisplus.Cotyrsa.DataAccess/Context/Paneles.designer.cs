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
	public partial class PanelesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public PanelesDataContext() : 
				base(global::Adsisplus.Cotyrsa.DataAccess.Properties.Settings.Default.dbTyrsaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PanelesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PanelesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PanelesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PanelesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosPanel")]
		public ISingleResult<stp_ListarDatosPanelResult> stp_ListarDatosPanel([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatosPanelID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatoMarcoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPinturaID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intDatosPanelID, intElementoID, intDatoMarcoID, sintPinturaID);
			return ((ISingleResult<stp_ListarDatosPanelResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarAnchoPanel")]
		public ISingleResult<stp_ListarAnchoPanelResult> stp_ListarAnchoPanel()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<stp_ListarAnchoPanelResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setSeleccionPanel")]
		public ISingleResult<stp_setSeleccionPanelResult> stp_setSeleccionPanel(
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intSeleccionPanelID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intRackID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intPanelID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitGalvanizado, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitPintado, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decAnchoBus, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decLargo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decCapacidadCarga, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintCantidadPanelNivel, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintSKU, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string vchCalibreAcero, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decAncho, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decFondo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPesoKg, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintCorreccion, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,3)")] System.Nullable<decimal> decTotal, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,3)")] System.Nullable<decimal> decPrecioEfectivoRef, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,3)")] System.Nullable<decimal> decRelPrecioTyrsa, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decKgTyrsa, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decKgReferencia, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intSeleccionPanelID, intRackID, intDetCotizaID, intPanelID, bitGalvanizado, bitPintado, decAnchoBus, decLargo, decCapacidadCarga, sintCantidadPanelNivel, sintSKU, vchCalibreAcero, decAncho, decFondo, decPesoKg, sintCorreccion, decTotal, decPrecioEfectivoRef, decRelPrecioTyrsa, decKgTyrsa, decKgReferencia, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setSeleccionPanelResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setBajaPanel")]
		public ISingleResult<stp_setBajaPanelResult> stp_setBajaPanel([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitRollBack)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intDetCotizaID, bitRollBack);
			return ((ISingleResult<stp_setBajaPanelResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosSeleccionPanel")]
		public ISingleResult<stp_ListarDatosSeleccionPanelResult> stp_ListarDatosSeleccionPanel([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCotizacionID);
			return ((ISingleResult<stp_ListarDatosSeleccionPanelResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosPantallaPanel")]
		public ISingleResult<stp_ListarDatosPantallaPanelResult> stp_ListarDatosPantallaPanel([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intSeleccionPanelID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCotizacionID, intSeleccionPanelID);
			return ((ISingleResult<stp_ListarDatosPantallaPanelResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarSeleccionPanel")]
		public ISingleResult<stp_ListarSeleccionPanelResult> stp_ListarSeleccionPanel([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decAncho, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintCalibre, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decFondo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Sistema", DbType="SmallInt")] System.Nullable<short> sistema, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitGalvanizado)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), decAncho, sintCalibre, decFondo, sistema, bitGalvanizado);
			return ((ISingleResult<stp_ListarSeleccionPanelResult>)(result.ReturnValue));
		}
	}
	
	public partial class stp_ListarDatosPanelResult
	{
		
		private int _intDatosPanelID;
		
		private string _vchElemento;
		
		private System.Nullable<short> _sintCantidadDatoMarco;
		
		private string _vchPintura;
		
		private System.Nullable<decimal> _decAnchoPanel;
		
		private System.Nullable<int> _intCantidadPanel;
		
		private System.Nullable<decimal> _decCapacidadCargaPanel;
		
		private System.Nullable<bool> _bitActivo;
		
		public stp_ListarDatosPanelResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intDatosPanelID", DbType="Int NOT NULL")]
		public int intDatosPanelID
		{
			get
			{
				return this._intDatosPanelID;
			}
			set
			{
				if ((this._intDatosPanelID != value))
				{
					this._intDatosPanelID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchPintura", DbType="VarChar(25)")]
		public string vchPintura
		{
			get
			{
				return this._vchPintura;
			}
			set
			{
				if ((this._vchPintura != value))
				{
					this._vchPintura = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decAnchoPanel", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> decAnchoPanel
		{
			get
			{
				return this._decAnchoPanel;
			}
			set
			{
				if ((this._decAnchoPanel != value))
				{
					this._decAnchoPanel = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCantidadPanel", DbType="Int")]
		public System.Nullable<int> intCantidadPanel
		{
			get
			{
				return this._intCantidadPanel;
			}
			set
			{
				if ((this._intCantidadPanel != value))
				{
					this._intCantidadPanel = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decCapacidadCargaPanel", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> decCapacidadCargaPanel
		{
			get
			{
				return this._decCapacidadCargaPanel;
			}
			set
			{
				if ((this._decCapacidadCargaPanel != value))
				{
					this._decCapacidadCargaPanel = value;
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
	
	public partial class stp_ListarAnchoPanelResult
	{
		
		private System.Nullable<decimal> _decAncho;
		
		public stp_ListarAnchoPanelResult()
		{
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
	}
	
	public partial class stp_setSeleccionPanelResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setSeleccionPanelResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(57) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_setBajaPanelResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setBajaPanelResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(56) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_ListarDatosSeleccionPanelResult
	{
		
		private int _intSeleccionPanelID;
		
		private int _intDetCotizaID;
		
		private System.Nullable<short> _sintSKU;
		
		private string _vchCalibreAcero;
		
		private System.Nullable<decimal> _decAncho;
		
		private System.Nullable<decimal> _decFondo;
		
		private System.Nullable<decimal> _decPesoKg;
		
		private System.Nullable<short> _sintCorreccion;
		
		private System.Nullable<decimal> _decTotal;
		
		private System.Nullable<decimal> _decPrecioEfectivoRef;
		
		private System.Nullable<decimal> _decRelPrecioTyrsa;
		
		private System.Nullable<decimal> _decKgTyrsa;
		
		private System.Nullable<decimal> _decKgReferencia;
		
		private System.Nullable<int> _intCantidad;
		
		private System.Nullable<decimal> _decSubtotal;
		
		private System.Nullable<bool> _bitActivo;
		
		public stp_ListarDatosSeleccionPanelResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intSeleccionPanelID", DbType="Int NOT NULL")]
		public int intSeleccionPanelID
		{
			get
			{
				return this._intSeleccionPanelID;
			}
			set
			{
				if ((this._intSeleccionPanelID != value))
				{
					this._intSeleccionPanelID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intDetCotizaID", DbType="Int NOT NULL")]
		public int intDetCotizaID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintSKU", DbType="SmallInt")]
		public System.Nullable<short> sintSKU
		{
			get
			{
				return this._sintSKU;
			}
			set
			{
				if ((this._sintSKU != value))
				{
					this._sintSKU = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decFondo", DbType="Decimal(8,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPesoKg", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decPesoKg
		{
			get
			{
				return this._decPesoKg;
			}
			set
			{
				if ((this._decPesoKg != value))
				{
					this._decPesoKg = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintCorreccion", DbType="SmallInt")]
		public System.Nullable<short> sintCorreccion
		{
			get
			{
				return this._sintCorreccion;
			}
			set
			{
				if ((this._sintCorreccion != value))
				{
					this._sintCorreccion = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioEfectivoRef", DbType="Decimal(18,3)")]
		public System.Nullable<decimal> decPrecioEfectivoRef
		{
			get
			{
				return this._decPrecioEfectivoRef;
			}
			set
			{
				if ((this._decPrecioEfectivoRef != value))
				{
					this._decPrecioEfectivoRef = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decRelPrecioTyrsa", DbType="Decimal(18,3)")]
		public System.Nullable<decimal> decRelPrecioTyrsa
		{
			get
			{
				return this._decRelPrecioTyrsa;
			}
			set
			{
				if ((this._decRelPrecioTyrsa != value))
				{
					this._decRelPrecioTyrsa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decKgTyrsa", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decKgTyrsa
		{
			get
			{
				return this._decKgTyrsa;
			}
			set
			{
				if ((this._decKgTyrsa != value))
				{
					this._decKgTyrsa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decKgReferencia", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decKgReferencia
		{
			get
			{
				return this._decKgReferencia;
			}
			set
			{
				if ((this._decKgReferencia != value))
				{
					this._decKgReferencia = value;
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
	
	public partial class stp_ListarDatosPantallaPanelResult
	{
		
		private System.Nullable<int> _intDatosPanelID;
		
		private int _intRackID;
		
		private System.Nullable<int> _intDetCotizaID;
		
		private System.Nullable<int> _intCotizacionID;
		
		private System.Nullable<short> _sintPinturaID;
		
		private System.Nullable<decimal> _decAnchoBus;
		
		private System.Nullable<decimal> _decLargo;
		
		private System.Nullable<short> _sintCantidadPanelNivel;
		
		private System.Nullable<int> _intCantidadPanel;
		
		private string _vchCalibre;
		
		private System.Nullable<decimal> _decCapacidadCargaPanel;
		
		private System.Nullable<int> _intSeleccionPanelID;
		
		private System.Nullable<int> _intPanelID;
		
		private System.Nullable<bool> _bitGalvanizado;
		
		private System.Nullable<bool> _bitPintado;
		
		private System.Nullable<short> _sintSKU;
		
		private string _vchCalibreAcero;
		
		private System.Nullable<decimal> _decAncho;
		
		private System.Nullable<decimal> _decFondo;
		
		private System.Nullable<decimal> _decPesoKg;
		
		private System.Nullable<short> _sintCorreccion;
		
		private System.Nullable<decimal> _decTotal;
		
		private System.Nullable<decimal> _decPrecioEfectivoRef;
		
		private System.Nullable<decimal> _decRelPrecioTyrsa;
		
		private System.Nullable<decimal> _decKgTyrsa;
		
		private System.Nullable<decimal> _decKgReferencia;
		
		private System.Nullable<int> _intNiveles;
		
		private System.Nullable<int> _intPanelesTotales;
		
		public stp_ListarDatosPantallaPanelResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intDatosPanelID", DbType="Int")]
		public System.Nullable<int> intDatosPanelID
		{
			get
			{
				return this._intDatosPanelID;
			}
			set
			{
				if ((this._intDatosPanelID != value))
				{
					this._intDatosPanelID = value;
				}
			}
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLargo", DbType="Decimal(8,5)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintCantidadPanelNivel", DbType="SmallInt")]
		public System.Nullable<short> sintCantidadPanelNivel
		{
			get
			{
				return this._sintCantidadPanelNivel;
			}
			set
			{
				if ((this._sintCantidadPanelNivel != value))
				{
					this._sintCantidadPanelNivel = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCantidadPanel", DbType="Int")]
		public System.Nullable<int> intCantidadPanel
		{
			get
			{
				return this._intCantidadPanel;
			}
			set
			{
				if ((this._intCantidadPanel != value))
				{
					this._intCantidadPanel = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchCalibre", DbType="VarChar(2) NOT NULL", CanBeNull=false)]
		public string vchCalibre
		{
			get
			{
				return this._vchCalibre;
			}
			set
			{
				if ((this._vchCalibre != value))
				{
					this._vchCalibre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decCapacidadCargaPanel", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> decCapacidadCargaPanel
		{
			get
			{
				return this._decCapacidadCargaPanel;
			}
			set
			{
				if ((this._decCapacidadCargaPanel != value))
				{
					this._decCapacidadCargaPanel = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intSeleccionPanelID", DbType="Int")]
		public System.Nullable<int> intSeleccionPanelID
		{
			get
			{
				return this._intSeleccionPanelID;
			}
			set
			{
				if ((this._intSeleccionPanelID != value))
				{
					this._intSeleccionPanelID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intPanelID", DbType="Int")]
		public System.Nullable<int> intPanelID
		{
			get
			{
				return this._intPanelID;
			}
			set
			{
				if ((this._intPanelID != value))
				{
					this._intPanelID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bitPintado", DbType="Bit")]
		public System.Nullable<bool> bitPintado
		{
			get
			{
				return this._bitPintado;
			}
			set
			{
				if ((this._bitPintado != value))
				{
					this._bitPintado = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintSKU", DbType="SmallInt")]
		public System.Nullable<short> sintSKU
		{
			get
			{
				return this._sintSKU;
			}
			set
			{
				if ((this._sintSKU != value))
				{
					this._sintSKU = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decFondo", DbType="Decimal(8,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPesoKg", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decPesoKg
		{
			get
			{
				return this._decPesoKg;
			}
			set
			{
				if ((this._decPesoKg != value))
				{
					this._decPesoKg = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintCorreccion", DbType="SmallInt")]
		public System.Nullable<short> sintCorreccion
		{
			get
			{
				return this._sintCorreccion;
			}
			set
			{
				if ((this._sintCorreccion != value))
				{
					this._sintCorreccion = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioEfectivoRef", DbType="Decimal(18,3)")]
		public System.Nullable<decimal> decPrecioEfectivoRef
		{
			get
			{
				return this._decPrecioEfectivoRef;
			}
			set
			{
				if ((this._decPrecioEfectivoRef != value))
				{
					this._decPrecioEfectivoRef = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decRelPrecioTyrsa", DbType="Decimal(18,3)")]
		public System.Nullable<decimal> decRelPrecioTyrsa
		{
			get
			{
				return this._decRelPrecioTyrsa;
			}
			set
			{
				if ((this._decRelPrecioTyrsa != value))
				{
					this._decRelPrecioTyrsa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decKgTyrsa", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decKgTyrsa
		{
			get
			{
				return this._decKgTyrsa;
			}
			set
			{
				if ((this._decKgTyrsa != value))
				{
					this._decKgTyrsa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decKgReferencia", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decKgReferencia
		{
			get
			{
				return this._decKgReferencia;
			}
			set
			{
				if ((this._decKgReferencia != value))
				{
					this._decKgReferencia = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intNiveles", DbType="Int")]
		public System.Nullable<int> intNiveles
		{
			get
			{
				return this._intNiveles;
			}
			set
			{
				if ((this._intNiveles != value))
				{
					this._intNiveles = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intPanelesTotales", DbType="Int")]
		public System.Nullable<int> intPanelesTotales
		{
			get
			{
				return this._intPanelesTotales;
			}
			set
			{
				if ((this._intPanelesTotales != value))
				{
					this._intPanelesTotales = value;
				}
			}
		}
	}
	
	public partial class stp_ListarSeleccionPanelResult
	{
		
		private System.Nullable<int> _intPanelID;
		
		private System.Nullable<short> _sintSKU;
		
		private string _vchCalibreAcero;
		
		private System.Nullable<decimal> _decAncho;
		
		private System.Nullable<decimal> _decFondo;
		
		private System.Nullable<decimal> _decPesoKg;
		
		private System.Nullable<short> _sintCorreccion;
		
		private System.Nullable<decimal> _decTotal;
		
		private System.Nullable<decimal> _decPrecioEfectivoRef;
		
		private System.Nullable<decimal> _decPrecioLista;
		
		private System.Nullable<decimal> _decKgTyrsa;
		
		private System.Nullable<decimal> _decKgReferencia;
		
		private System.Nullable<bool> _bitActivo;
		
		private System.Nullable<decimal> _decCapacidadCarga;
		
		public stp_ListarSeleccionPanelResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intPanelID", DbType="Int")]
		public System.Nullable<int> intPanelID
		{
			get
			{
				return this._intPanelID;
			}
			set
			{
				if ((this._intPanelID != value))
				{
					this._intPanelID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintSKU", DbType="SmallInt")]
		public System.Nullable<short> sintSKU
		{
			get
			{
				return this._sintSKU;
			}
			set
			{
				if ((this._sintSKU != value))
				{
					this._sintSKU = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decFondo", DbType="Decimal(12,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPesoKg", DbType="Decimal(12,3)")]
		public System.Nullable<decimal> decPesoKg
		{
			get
			{
				return this._decPesoKg;
			}
			set
			{
				if ((this._decPesoKg != value))
				{
					this._decPesoKg = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintCorreccion", DbType="SmallInt")]
		public System.Nullable<short> sintCorreccion
		{
			get
			{
				return this._sintCorreccion;
			}
			set
			{
				if ((this._sintCorreccion != value))
				{
					this._sintCorreccion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTotal", DbType="Decimal(12,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioEfectivoRef", DbType="Decimal(12,3)")]
		public System.Nullable<decimal> decPrecioEfectivoRef
		{
			get
			{
				return this._decPrecioEfectivoRef;
			}
			set
			{
				if ((this._decPrecioEfectivoRef != value))
				{
					this._decPrecioEfectivoRef = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioLista", DbType="Decimal(12,3)")]
		public System.Nullable<decimal> decPrecioLista
		{
			get
			{
				return this._decPrecioLista;
			}
			set
			{
				if ((this._decPrecioLista != value))
				{
					this._decPrecioLista = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decKgTyrsa", DbType="Decimal(12,3)")]
		public System.Nullable<decimal> decKgTyrsa
		{
			get
			{
				return this._decKgTyrsa;
			}
			set
			{
				if ((this._decKgTyrsa != value))
				{
					this._decKgTyrsa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decKgReferencia", DbType="Decimal(12,3)")]
		public System.Nullable<decimal> decKgReferencia
		{
			get
			{
				return this._decKgReferencia;
			}
			set
			{
				if ((this._decKgReferencia != value))
				{
					this._decKgReferencia = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decCapacidadCarga", DbType="Decimal(12,3)")]
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
	}
}
#pragma warning restore 1591
