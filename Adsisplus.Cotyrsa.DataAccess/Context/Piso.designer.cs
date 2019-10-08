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
	public partial class PisoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public PisoDataContext() : 
				base(global::Adsisplus.Cotyrsa.DataAccess.Properties.Settings.Default.dbTyrsaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PisoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PisoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PisoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PisoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<entSeleccionPiso> entSeleccionPiso
		{
			get
			{
				return this.GetTable<entSeleccionPiso>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosPiso")]
		public ISingleResult<stp_ListarDatosPisoResult> stp_ListarDatosPiso([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatoPisoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intDatoPisoID, intCotizacionID);
			return ((ISingleResult<stp_ListarDatosPisoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setSeleccionPiso")]
		public ISingleResult<stp_setSeleccionPisoResult> stp_setSeleccionPiso([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intSeleccionPisoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatoPisoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decPrecioUnitario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decPrecioTotal, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intSeleccionPisoID, intDatoPisoID, intDetCotizaID, decPrecioUnitario, decPrecioTotal, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setSeleccionPisoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosSeleccionPiso")]
		public ISingleResult<stp_ListarDatosSeleccionPisoResult> stp_ListarDatosSeleccionPiso([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatoPisoID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intDatoPisoID);
			return ((ISingleResult<stp_ListarDatosSeleccionPisoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.fn_getNumeroPiso", IsComposable=true)]
		public System.Nullable<int> fn_getNumeroPiso([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatoPisoID)
		{
			return ((System.Nullable<int>)(this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intDatoPisoID).ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarPisoDriveIn")]
		public ISingleResult<entSeleccionPiso> stp_ListarPisoDriveIn([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidad, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,2)")] System.Nullable<decimal> decLargo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitGalvanizado)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCantidad, decLargo, bitGalvanizado);
			return ((ISingleResult<entSeleccionPiso>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class entSeleccionPiso
	{
		
		private short _sintPisoID;
		
		private decimal _decLongitud;
		
		private string _vchMaterial;
		
		private decimal _decPesoPartida;
		
		private decimal _decPrecioFinal;
		
		public entSeleccionPiso()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintPisoID")]
		public short sintPisoID
		{
			get
			{
				return this._sintPisoID;
			}
			set
			{
				if ((this._sintPisoID != value))
				{
					this._sintPisoID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLongitud")]
		public decimal decLongitud
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchMaterial", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPesoPartida")]
		public decimal decPesoPartida
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioFinal")]
		public decimal decPrecioFinal
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
	
	public partial class stp_ListarDatosPisoResult
	{
		
		private int _intDatoPisoID;
		
		private System.Nullable<int> _intElementoID;
		
		private System.Nullable<int> _intCotizacionID;
		
		private System.Nullable<short> _sintPinturaID;
		
		private System.Nullable<int> _intCantidad;
		
		private System.Nullable<decimal> _decLargoPiso;
		
		private System.Nullable<bool> _bitUsoPatin;
		
		private System.Nullable<bool> _bitActivo;
		
		private System.Nullable<int> _intDetCotizaID;
		
		private System.Nullable<decimal> _decAncho;
		
		private System.Nullable<bool> _bitTipoPisoAbierto;
		
		private System.Nullable<decimal> _decPesoUnitario;
		
		private System.Nullable<decimal> _decPesoTotal;
		
		private System.Nullable<decimal> _decPrecioUnitario;
		
		private System.Nullable<decimal> _decPrecioTotal;
		
		public stp_ListarDatosPisoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intDatoPisoID", DbType="Int NOT NULL")]
		public int intDatoPisoID
		{
			get
			{
				return this._intDatoPisoID;
			}
			set
			{
				if ((this._intDatoPisoID != value))
				{
					this._intDatoPisoID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLargoPiso", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> decLargoPiso
		{
			get
			{
				return this._decLargoPiso;
			}
			set
			{
				if ((this._decLargoPiso != value))
				{
					this._decLargoPiso = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bitUsoPatin", DbType="Bit")]
		public System.Nullable<bool> bitUsoPatin
		{
			get
			{
				return this._bitUsoPatin;
			}
			set
			{
				if ((this._bitUsoPatin != value))
				{
					this._bitUsoPatin = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bitTipoPisoAbierto", DbType="Bit")]
		public System.Nullable<bool> bitTipoPisoAbierto
		{
			get
			{
				return this._bitTipoPisoAbierto;
			}
			set
			{
				if ((this._bitTipoPisoAbierto != value))
				{
					this._bitTipoPisoAbierto = value;
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
	}
	
	public partial class stp_setSeleccionPisoResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setSeleccionPisoResult()
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
	
	public partial class stp_ListarDatosSeleccionPisoResult
	{
		
		private int _intSeleccionPisoID;
		
		private System.Nullable<int> _intDatoPisoID;
		
		private System.Nullable<int> _intDetCotizaID;
		
		private System.Nullable<decimal> _decPrecioUnitario;
		
		private System.Nullable<decimal> _decPrecioTotal;
		
		private System.Nullable<bool> _bitActivo;
		
		public stp_ListarDatosSeleccionPisoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intSeleccionPisoID", DbType="Int NOT NULL")]
		public int intSeleccionPisoID
		{
			get
			{
				return this._intSeleccionPisoID;
			}
			set
			{
				if ((this._intSeleccionPisoID != value))
				{
					this._intSeleccionPisoID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intDatoPisoID", DbType="Int")]
		public System.Nullable<int> intDatoPisoID
		{
			get
			{
				return this._intDatoPisoID;
			}
			set
			{
				if ((this._intDatoPisoID != value))
				{
					this._intDatoPisoID = value;
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
