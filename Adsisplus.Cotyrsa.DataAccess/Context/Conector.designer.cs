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
	public partial class ConectorDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public ConectorDataContext() : 
				base(global::Adsisplus.Cotyrsa.DataAccess.Properties.Settings.Default.dbTyrsaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ConectorDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConectorDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConectorDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConectorDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<entConector> entConector
		{
			get
			{
				return this.GetTable<entConector>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarConectorCartonFlow")]
		public ISingleResult<entConector> stp_ListarConectorCartonFlow([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> intCalibreAceroID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidad)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCalibreAceroID, intCantidad);
			return ((ISingleResult<entConector>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosConectorCartonFlow")]
		public ISingleResult<stp_ListarDatosConectorCartonFlowResult> stp_ListarDatosConectorCartonFlow([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatosConectorCFID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCotizacionID, intDatosConectorCFID);
			return ((ISingleResult<stp_ListarDatosConectorCartonFlowResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class entConector
	{
		
		private short _sintTipoCartonFlowID;
		
		private short _sintCalibre;
		
		private string _vchTipoCartonFlow;
		
		private decimal _decAncho;
		
		private decimal _decLargo;
		
		private short _sintPesoPieza;
		
		private decimal _decTotalKiloUnitario;
		
		private decimal _decPesoTotal;
		
		private decimal _decPrecioUnitario;
		
		private decimal _decPrecioTotal;
		
		private string _vchLeyenda;
		
		public entConector()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPesoTotal")]
		public decimal decPesoTotal
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioTotal")]
		public decimal decPrecioTotal
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
	
	public partial class stp_ListarDatosConectorCartonFlowResult
	{
		
		private int _intDatosConectorCFID;
		
		private System.Nullable<int> _intCotizacionID;
		
		private System.Nullable<int> _intDetCotizaID;
		
		private System.Nullable<short> _sintTipoCartonFlowID;
		
		private System.Nullable<int> _intCalibreAceroID;
		
		private System.Nullable<decimal> _decAncho;
		
		private System.Nullable<decimal> _decLargo;
		
		private System.Nullable<short> _sintPesoPieza;
		
		private System.Nullable<decimal> _decTotalKiloUnitario;
		
		private System.Nullable<decimal> _decPesoTotal;
		
		private System.Nullable<decimal> _decPrecioUnitario;
		
		private System.Nullable<decimal> _decPrecioTotal;
		
		private string _vchLeyenda;
		
		private System.Nullable<int> _intCantidad;
		
		private System.Nullable<bool> _bitActivo;
		
		public stp_ListarDatosConectorCartonFlowResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intDatosConectorCFID", DbType="Int NOT NULL")]
		public int intDatosConectorCFID
		{
			get
			{
				return this._intDatosConectorCFID;
			}
			set
			{
				if ((this._intDatosConectorCFID != value))
				{
					this._intDatosConectorCFID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTotalKiloUnitario", DbType="Decimal(12,2)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchLeyenda", DbType="VarChar(250)")]
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
	}
}
#pragma warning restore 1591
