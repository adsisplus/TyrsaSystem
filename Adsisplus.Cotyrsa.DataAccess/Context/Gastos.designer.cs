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
	public partial class GastosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public GastosDataContext() : 
				base(global::Adsisplus.Cotyrsa.DataAccess.Properties.Settings.Default.dbTyrsaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public GastosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GastosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GastosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GastosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosFlete")]
		public ISingleResult<stp_setDatosFleteResult> stp_setDatosFlete([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatoFleteID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> sintFleteID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidad, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> datFechaCarga, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> datFechaDescarga, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCotizacionID, intDetCotizaID, intDatoFleteID, intElementoID, sintFleteID, intCantidad, datFechaCarga, datFechaDescarga, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosFleteResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosInstalacion")]
		public ISingleResult<stp_setDatosInstalacionResult> stp_setDatosInstalacion([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatosInstalacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintInstalacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidad, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> datFecha, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCotizacionID, intDetCotizaID, intDatosInstalacionID, sintInstalacionID, intElementoID, intCantidad, datFecha, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosInstalacionResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosViatico")]
		public ISingleResult<stp_setDatosViaticoResult> stp_setDatosViatico([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatoViaticoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintViaticoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidad, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> datFecha, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,2)")] System.Nullable<decimal> decCostoGolpe, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCotizacionID, intDetCotizaID, intDatoViaticoID, intElementoID, sintViaticoID, intCantidad, datFecha, decCostoGolpe, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosViaticoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosViatico")]
		public ISingleResult<stp_ListarDatosViaticoResult> stp_ListarDatosViatico([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> sintViaticoID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCotizacionID, sintViaticoID);
			return ((ISingleResult<stp_ListarDatosViaticoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosFlete")]
		public ISingleResult<stp_ListarDatosFleteResult> stp_ListarDatosFlete([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatoFleteID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCotizacionID, intDatoFleteID);
			return ((ISingleResult<stp_ListarDatosFleteResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosInstalacion")]
		public ISingleResult<stp_ListarDatosInstalacionResult> stp_ListarDatosInstalacion([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> sintInstalacionID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCotizacionID, sintInstalacionID);
			return ((ISingleResult<stp_ListarDatosInstalacionResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setCatFlete")]
		public ISingleResult<stp_setCatFleteResult> stp_setCatFlete([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintFleteID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintDestinoFleteID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> sintTipoUnidadFleteID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCosto, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sintFleteID, sintDestinoFleteID, sintTipoUnidadFleteID, intCosto, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setCatFleteResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setCatDestinoFlete")]
		public ISingleResult<stp_setCatDestinoFleteResult> stp_setCatDestinoFlete([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> sintDestinoFleteID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string vchDestinoFlete, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sintDestinoFleteID, vchDestinoFlete, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setCatDestinoFleteResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setCatTipoUnidadFlete")]
		public ISingleResult<stp_setCatTipoUnidadFleteResult> stp_setCatTipoUnidadFlete([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> sintTipoUnidadFleteID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string vchTipoUnidad, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sintTipoUnidadFleteID, vchTipoUnidad, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setCatTipoUnidadFleteResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarFlete")]
		public ISingleResult<stp_ListarFleteResult> stp_ListarFlete()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<stp_ListarFleteResult>)(result.ReturnValue));
		}
	}
	
	public partial class stp_setDatosFleteResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosFleteResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchResultado", DbType="VarChar(30)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(45) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_setDatosInstalacionResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosInstalacionResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchResultado", DbType="VarChar(30)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(45) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_setDatosViaticoResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosViaticoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchResultado", DbType="VarChar(30)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(45) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_ListarDatosViaticoResult
	{
		
		private int _intDatoViaticoID;
		
		private System.Nullable<int> _intCotizacionID;
		
		private System.Nullable<int> _intDetCotizaID;
		
		private System.Nullable<short> _sintViaticoID;
		
		private string _vchDescripcion;
		
		private int _intUnidadMedicionID;
		
		private string _vchUnidadMedicion;
		
		private System.Nullable<int> _intInstalacion;
		
		private System.Nullable<decimal> _decFactor;
		
		private System.Nullable<int> _intCantidad;
		
		private System.Nullable<System.DateTime> _datFecha;
		
		private System.Nullable<decimal> _decCostoGolpe;
		
		private System.Nullable<bool> _bitTieneCosto;
		
		public stp_ListarDatosViaticoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intDatoViaticoID", DbType="Int NOT NULL")]
		public int intDatoViaticoID
		{
			get
			{
				return this._intDatoViaticoID;
			}
			set
			{
				if ((this._intDatoViaticoID != value))
				{
					this._intDatoViaticoID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintViaticoID", DbType="SmallInt")]
		public System.Nullable<short> sintViaticoID
		{
			get
			{
				return this._sintViaticoID;
			}
			set
			{
				if ((this._sintViaticoID != value))
				{
					this._sintViaticoID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(250)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intUnidadMedicionID", DbType="Int NOT NULL")]
		public int intUnidadMedicionID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchUnidadMedicion", DbType="VarChar(25)")]
		public string vchUnidadMedicion
		{
			get
			{
				return this._vchUnidadMedicion;
			}
			set
			{
				if ((this._vchUnidadMedicion != value))
				{
					this._vchUnidadMedicion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intInstalacion", DbType="Int")]
		public System.Nullable<int> intInstalacion
		{
			get
			{
				return this._intInstalacion;
			}
			set
			{
				if ((this._intInstalacion != value))
				{
					this._intInstalacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decFactor", DbType="Decimal(8,2)")]
		public System.Nullable<decimal> decFactor
		{
			get
			{
				return this._decFactor;
			}
			set
			{
				if ((this._decFactor != value))
				{
					this._decFactor = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datFecha", DbType="Date")]
		public System.Nullable<System.DateTime> datFecha
		{
			get
			{
				return this._datFecha;
			}
			set
			{
				if ((this._datFecha != value))
				{
					this._datFecha = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decCostoGolpe", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> decCostoGolpe
		{
			get
			{
				return this._decCostoGolpe;
			}
			set
			{
				if ((this._decCostoGolpe != value))
				{
					this._decCostoGolpe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bitTieneCosto", DbType="Bit")]
		public System.Nullable<bool> bitTieneCosto
		{
			get
			{
				return this._bitTieneCosto;
			}
			set
			{
				if ((this._bitTieneCosto != value))
				{
					this._bitTieneCosto = value;
				}
			}
		}
	}
	
	public partial class stp_ListarDatosFleteResult
	{
		
		private int _intDatoFleteID;
		
		private System.Nullable<int> _intCotizacionID;
		
		private System.Nullable<int> _intDetCotizaID;
		
		private System.Nullable<short> _sintFleteID;
		
		private System.Nullable<short> _sintTipoUnidadFleteID;
		
		private string _vchTipoUnidad;
		
		private System.Nullable<short> _sintDestinoFleteID;
		
		private string _vchDestinoFlete;
		
		private System.Nullable<int> _intElementoID;
		
		private System.Nullable<int> _intCantidad;
		
		private System.Nullable<System.DateTime> _datFechaCarga;
		
		private System.Nullable<System.DateTime> _datFechaDescarga;
		
		public stp_ListarDatosFleteResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intDatoFleteID", DbType="Int NOT NULL")]
		public int intDatoFleteID
		{
			get
			{
				return this._intDatoFleteID;
			}
			set
			{
				if ((this._intDatoFleteID != value))
				{
					this._intDatoFleteID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintFleteID", DbType="SmallInt")]
		public System.Nullable<short> sintFleteID
		{
			get
			{
				return this._sintFleteID;
			}
			set
			{
				if ((this._sintFleteID != value))
				{
					this._sintFleteID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintTipoUnidadFleteID", DbType="SmallInt")]
		public System.Nullable<short> sintTipoUnidadFleteID
		{
			get
			{
				return this._sintTipoUnidadFleteID;
			}
			set
			{
				if ((this._sintTipoUnidadFleteID != value))
				{
					this._sintTipoUnidadFleteID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchTipoUnidad", DbType="VarChar(100)")]
		public string vchTipoUnidad
		{
			get
			{
				return this._vchTipoUnidad;
			}
			set
			{
				if ((this._vchTipoUnidad != value))
				{
					this._vchTipoUnidad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintDestinoFleteID", DbType="SmallInt")]
		public System.Nullable<short> sintDestinoFleteID
		{
			get
			{
				return this._sintDestinoFleteID;
			}
			set
			{
				if ((this._sintDestinoFleteID != value))
				{
					this._sintDestinoFleteID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDestinoFlete", DbType="VarChar(250)")]
		public string vchDestinoFlete
		{
			get
			{
				return this._vchDestinoFlete;
			}
			set
			{
				if ((this._vchDestinoFlete != value))
				{
					this._vchDestinoFlete = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datFechaCarga", DbType="Date")]
		public System.Nullable<System.DateTime> datFechaCarga
		{
			get
			{
				return this._datFechaCarga;
			}
			set
			{
				if ((this._datFechaCarga != value))
				{
					this._datFechaCarga = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datFechaDescarga", DbType="Date")]
		public System.Nullable<System.DateTime> datFechaDescarga
		{
			get
			{
				return this._datFechaDescarga;
			}
			set
			{
				if ((this._datFechaDescarga != value))
				{
					this._datFechaDescarga = value;
				}
			}
		}
	}
	
	public partial class stp_ListarDatosInstalacionResult
	{
		
		private int _intDatosInstalacionID;
		
		private System.Nullable<int> _intCotizacionID;
		
		private System.Nullable<int> _intDetCotizaID;
		
		private System.Nullable<short> _sintInstalacionID;
		
		private string _vchDescripcion;
		
		private System.Nullable<int> _intUnidadMedicionID;
		
		private string _vchUnidadMedicion;
		
		private System.Nullable<int> _intInstalacion;
		
		private System.Nullable<int> _intDesinstalacion;
		
		private System.Nullable<int> _intElementoID;
		
		private System.Nullable<int> _intCantidad;
		
		public stp_ListarDatosInstalacionResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intDatosInstalacionID", DbType="Int NOT NULL")]
		public int intDatosInstalacionID
		{
			get
			{
				return this._intDatosInstalacionID;
			}
			set
			{
				if ((this._intDatosInstalacionID != value))
				{
					this._intDatosInstalacionID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintInstalacionID", DbType="SmallInt")]
		public System.Nullable<short> sintInstalacionID
		{
			get
			{
				return this._sintInstalacionID;
			}
			set
			{
				if ((this._sintInstalacionID != value))
				{
					this._sintInstalacionID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(250)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchUnidadMedicion", DbType="VarChar(25)")]
		public string vchUnidadMedicion
		{
			get
			{
				return this._vchUnidadMedicion;
			}
			set
			{
				if ((this._vchUnidadMedicion != value))
				{
					this._vchUnidadMedicion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intInstalacion", DbType="Int")]
		public System.Nullable<int> intInstalacion
		{
			get
			{
				return this._intInstalacion;
			}
			set
			{
				if ((this._intInstalacion != value))
				{
					this._intInstalacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intDesinstalacion", DbType="Int")]
		public System.Nullable<int> intDesinstalacion
		{
			get
			{
				return this._intDesinstalacion;
			}
			set
			{
				if ((this._intDesinstalacion != value))
				{
					this._intDesinstalacion = value;
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
	}
	
	public partial class stp_setCatFleteResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setCatFleteResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(45) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_setCatDestinoFleteResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setCatDestinoFleteResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(45) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_setCatTipoUnidadFleteResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setCatTipoUnidadFleteResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(45) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_ListarFleteResult
	{
		
		private short _sintFleteID;
		
		private short _sintDestinoFleteID;
		
		private string _vchDestinoFlete;
		
		private short _sintTipoUnidadFleteID;
		
		private string _vchTipoUnidad;
		
		private System.Nullable<int> _intCosto;
		
		private System.Nullable<bool> _bitActivo;
		
		public stp_ListarFleteResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintFleteID", DbType="SmallInt NOT NULL")]
		public short sintFleteID
		{
			get
			{
				return this._sintFleteID;
			}
			set
			{
				if ((this._sintFleteID != value))
				{
					this._sintFleteID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintDestinoFleteID", DbType="SmallInt NOT NULL")]
		public short sintDestinoFleteID
		{
			get
			{
				return this._sintDestinoFleteID;
			}
			set
			{
				if ((this._sintDestinoFleteID != value))
				{
					this._sintDestinoFleteID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDestinoFlete", DbType="VarChar(250)")]
		public string vchDestinoFlete
		{
			get
			{
				return this._vchDestinoFlete;
			}
			set
			{
				if ((this._vchDestinoFlete != value))
				{
					this._vchDestinoFlete = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintTipoUnidadFleteID", DbType="SmallInt NOT NULL")]
		public short sintTipoUnidadFleteID
		{
			get
			{
				return this._sintTipoUnidadFleteID;
			}
			set
			{
				if ((this._sintTipoUnidadFleteID != value))
				{
					this._sintTipoUnidadFleteID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchTipoUnidad", DbType="VarChar(100)")]
		public string vchTipoUnidad
		{
			get
			{
				return this._vchTipoUnidad;
			}
			set
			{
				if ((this._vchTipoUnidad != value))
				{
					this._vchTipoUnidad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCosto", DbType="Int")]
		public System.Nullable<int> intCosto
		{
			get
			{
				return this._intCosto;
			}
			set
			{
				if ((this._intCosto != value))
				{
					this._intCosto = value;
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
