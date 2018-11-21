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
	public partial class CotizacionDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public CotizacionDataContext() : 
				base(global::Adsisplus.Cotyrsa.DataAccess.Properties.Settings.Default.dbTyrsaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CotizacionDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CotizacionDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CotizacionDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CotizacionDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarRel_TipoElementoAlmacen_FactorCotizacion")]
		public ISingleResult<stp_ListarRel_TipoElementoAlmacen_FactorCotizacionResult> stp_ListarRel_TipoElementoAlmacen_FactorCotizacion([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intTipoElementoAlmacen_FactorID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intTipoElementoAlmacenID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintFactorID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intTipoElementoAlmacen_FactorID, intTipoElementoAlmacenID, sintFactorID);
			return ((ISingleResult<stp_ListarRel_TipoElementoAlmacen_FactorCotizacionResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDetCotizacion")]
		public ISingleResult<stp_setDetCotizacionResult> stp_setDetCotizacion(
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintMontajeID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intPartida, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidad, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decMedidaFrente, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decMedidaFondo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decAlto, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decPesoKg, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitMontacarga, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intNumeroTarimaPorNivel, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intNumeroNivelSobreViga, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intPosicion, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintVisitas, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(250)")] string vchDimensionMontacarga, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decDolar, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decMonto, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decSubtotal, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decDescuento, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decDescuentoFin, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decIEMPS, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decRetISR, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decRetIVA, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decIVA, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decTotal, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intDetCotizaID, intCotizacionID, sintMontajeID, intPartida, intCantidad, decMedidaFrente, decMedidaFondo, decAlto, decPesoKg, bitMontacarga, intNumeroTarimaPorNivel, intNumeroNivelSobreViga, intPosicion, sintVisitas, vchDimensionMontacarga, decDolar, decMonto, decSubtotal, decDescuento, decDescuentoFin, decIEMPS, decRetISR, decRetIVA, decIVA, decTotal, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDetCotizacionResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setMstCotizacion")]
		public ISingleResult<stp_setMstCotizacionResult> stp_setMstCotizacion([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intEstatusID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPrioridadID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intEmpresaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(250)")] string vchFolio, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> datFechaCotizacion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> datFechaAceptacion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> datFechaRechazo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCotizacionID, intEstatusID, sintPrioridadID, intEmpresaID, vchFolio, datFechaCotizacion, datFechaAceptacion, datFechaRechazo, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setMstCotizacionResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosCotizacion")]
		public ISingleResult<stp_ListarDatosCotizacionResult> stp_ListarDatosCotizacion([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intEstatusID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> sintPrioridadID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intEmpresaID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCotizacionID, intEstatusID, sintPrioridadID, intEmpresaID);
			return ((ISingleResult<stp_ListarDatosCotizacionResult>)(result.ReturnValue));
		}
	}
	
	public partial class stp_ListarRel_TipoElementoAlmacen_FactorCotizacionResult
	{
		
		private int _intTipoElementoAlmacen_FactorID;
		
		private System.Nullable<int> _intTipoElementoAlmacenID;
		
		private System.Nullable<int> _sintFactorID;
		
		private string _vchFactor;
		
		private System.Nullable<decimal> _decFactor;
		
		private System.Nullable<System.DateTime> _datFechaAlta;
		
		private System.Nullable<bool> _bitActivo;
		
		public stp_ListarRel_TipoElementoAlmacen_FactorCotizacionResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intTipoElementoAlmacen_FactorID", DbType="Int NOT NULL")]
		public int intTipoElementoAlmacen_FactorID
		{
			get
			{
				return this._intTipoElementoAlmacen_FactorID;
			}
			set
			{
				if ((this._intTipoElementoAlmacen_FactorID != value))
				{
					this._intTipoElementoAlmacen_FactorID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intTipoElementoAlmacenID", DbType="Int")]
		public System.Nullable<int> intTipoElementoAlmacenID
		{
			get
			{
				return this._intTipoElementoAlmacenID;
			}
			set
			{
				if ((this._intTipoElementoAlmacenID != value))
				{
					this._intTipoElementoAlmacenID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintFactorID", DbType="Int")]
		public System.Nullable<int> sintFactorID
		{
			get
			{
				return this._sintFactorID;
			}
			set
			{
				if ((this._sintFactorID != value))
				{
					this._sintFactorID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchFactor", DbType="VarChar(25)")]
		public string vchFactor
		{
			get
			{
				return this._vchFactor;
			}
			set
			{
				if ((this._vchFactor != value))
				{
					this._vchFactor = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datFechaAlta", DbType="Date")]
		public System.Nullable<System.DateTime> datFechaAlta
		{
			get
			{
				return this._datFechaAlta;
			}
			set
			{
				if ((this._datFechaAlta != value))
				{
					this._datFechaAlta = value;
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
	
	public partial class stp_setDetCotizacionResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDetCotizacionResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(58) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_setMstCotizacionResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setMstCotizacionResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchResultado", DbType="VarChar(263)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_ListarDatosCotizacionResult
	{
		
		private int _intCotizacionID;
		
		private string _vchNombreCliente;
		
		private System.Nullable<int> _intEmpresaID;
		
		private string _vchFolio;
		
		private string _vchEstatus;
		
		private string _vchPrioridad;
		
		private System.Nullable<System.DateTime> _datFechaCotizacion;
		
		private System.Nullable<System.DateTime> _datFechaAceptacion;
		
		private System.Nullable<System.DateTime> _datFechaRechazo;
		
		private System.Nullable<decimal> _decMonto;
		
		private System.Nullable<decimal> _decIVA;
		
		private System.Nullable<decimal> _decTotal;
		
		public stp_ListarDatosCotizacionResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCotizacionID", DbType="Int NOT NULL")]
		public int intCotizacionID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchNombreCliente", DbType="VarChar(250)")]
		public string vchNombreCliente
		{
			get
			{
				return this._vchNombreCliente;
			}
			set
			{
				if ((this._vchNombreCliente != value))
				{
					this._vchNombreCliente = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intEmpresaID", DbType="Int")]
		public System.Nullable<int> intEmpresaID
		{
			get
			{
				return this._intEmpresaID;
			}
			set
			{
				if ((this._intEmpresaID != value))
				{
					this._intEmpresaID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchFolio", DbType="VarChar(250)")]
		public string vchFolio
		{
			get
			{
				return this._vchFolio;
			}
			set
			{
				if ((this._vchFolio != value))
				{
					this._vchFolio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchEstatus", DbType="VarChar(25)")]
		public string vchEstatus
		{
			get
			{
				return this._vchEstatus;
			}
			set
			{
				if ((this._vchEstatus != value))
				{
					this._vchEstatus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchPrioridad", DbType="VarChar(50)")]
		public string vchPrioridad
		{
			get
			{
				return this._vchPrioridad;
			}
			set
			{
				if ((this._vchPrioridad != value))
				{
					this._vchPrioridad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datFechaCotizacion", DbType="DateTime")]
		public System.Nullable<System.DateTime> datFechaCotizacion
		{
			get
			{
				return this._datFechaCotizacion;
			}
			set
			{
				if ((this._datFechaCotizacion != value))
				{
					this._datFechaCotizacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datFechaAceptacion", DbType="DateTime")]
		public System.Nullable<System.DateTime> datFechaAceptacion
		{
			get
			{
				return this._datFechaAceptacion;
			}
			set
			{
				if ((this._datFechaAceptacion != value))
				{
					this._datFechaAceptacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datFechaRechazo", DbType="DateTime")]
		public System.Nullable<System.DateTime> datFechaRechazo
		{
			get
			{
				return this._datFechaRechazo;
			}
			set
			{
				if ((this._datFechaRechazo != value))
				{
					this._datFechaRechazo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decMonto", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> decMonto
		{
			get
			{
				return this._decMonto;
			}
			set
			{
				if ((this._decMonto != value))
				{
					this._decMonto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decIVA", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> decIVA
		{
			get
			{
				return this._decIVA;
			}
			set
			{
				if ((this._decIVA != value))
				{
					this._decIVA = value;
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
	}
}
#pragma warning restore 1591
