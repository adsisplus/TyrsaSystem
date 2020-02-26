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
	public partial class BrazoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public BrazoDataContext() : 
				base(global::Adsisplus.Cotyrsa.DataAccess.Properties.Settings.Default.dbTyrsaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BrazoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BrazoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BrazoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BrazoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tmp_BrazoDriveIn> tmp_BrazoDriveIn
		{
			get
			{
				return this.GetTable<tmp_BrazoDriveIn>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosBrazo")]
		public ISingleResult<stp_ListarDatosBrazoResult> stp_ListarDatosBrazo([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intBrazoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intBrazoID, intCotizacionID);
			return ((ISingleResult<stp_ListarDatosBrazoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarSeleccionBrazo")]
		public ISingleResult<stp_ListarSeleccionBrazoResult> stp_ListarSeleccionBrazo([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCotizacionID);
			return ((ISingleResult<stp_ListarSeleccionBrazoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDriveInBrazo")]
		public ISingleResult<tmp_BrazoDriveIn> stp_ListarDriveInBrazo([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitEsEstructural, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintEstructural)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), bitEsEstructural, sintEstructural);
			return ((ISingleResult<tmp_BrazoDriveIn>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class tmp_BrazoDriveIn
	{
		
		private short _sintDriveInID;
		
		private decimal _decLargo;
		
		private decimal _decLongitud;
		
		private decimal _decAncho;
		
		private decimal _decTotalKiloUnitario;
		
		private decimal _decPrecioFinal;
		
		public tmp_BrazoDriveIn()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintDriveInID")]
		public short sintDriveInID
		{
			get
			{
				return this._sintDriveInID;
			}
			set
			{
				if ((this._sintDriveInID != value))
				{
					this._sintDriveInID = value;
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
	
	public partial class stp_ListarDatosBrazoResult
	{
		
		private int _intBrazoID;
		
		private System.Nullable<int> _intElementoID;
		
		private System.Nullable<int> _intCotizacionID;
		
		private System.Nullable<short> _sintPinturaID;
		
		private System.Nullable<int> _intCantidad;
		
		private System.Nullable<bool> _bitActivo;
		
		private System.Nullable<short> _sintLargoBrazoID;
		
		private System.Nullable<int> _intDetCotizaID;
		
		private System.Nullable<decimal> _decLargo;
		
		private System.Nullable<decimal> _decPrecioVentaUnitario;
		
		private System.Nullable<decimal> _decPrecioVentaTotal;
		
		private System.Nullable<decimal> _decPesoUnitario;
		
		private System.Nullable<decimal> _decPesoTotal;
		
		private int _intSeleccionBrazoID;
		
		private System.Nullable<short> _sintDriveInID;
		
		private System.Nullable<decimal> _decLargo1;
		
		private System.Nullable<decimal> _decLongitud;
		
		private System.Nullable<decimal> _decAncho;
		
		private System.Nullable<decimal> _decTotalKiloUnitario;
		
		private System.Nullable<decimal> _decPrecioFinal;
		
		public stp_ListarDatosBrazoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intBrazoID", DbType="Int NOT NULL")]
		public int intBrazoID
		{
			get
			{
				return this._intBrazoID;
			}
			set
			{
				if ((this._intBrazoID != value))
				{
					this._intBrazoID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintLargoBrazoID", DbType="SmallInt")]
		public System.Nullable<short> sintLargoBrazoID
		{
			get
			{
				return this._sintLargoBrazoID;
			}
			set
			{
				if ((this._sintLargoBrazoID != value))
				{
					this._sintLargoBrazoID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioVentaUnitario", DbType="Decimal(18,3)")]
		public System.Nullable<decimal> decPrecioVentaUnitario
		{
			get
			{
				return this._decPrecioVentaUnitario;
			}
			set
			{
				if ((this._decPrecioVentaUnitario != value))
				{
					this._decPrecioVentaUnitario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioVentaTotal", DbType="Decimal(18,3)")]
		public System.Nullable<decimal> decPrecioVentaTotal
		{
			get
			{
				return this._decPrecioVentaTotal;
			}
			set
			{
				if ((this._decPrecioVentaTotal != value))
				{
					this._decPrecioVentaTotal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPesoUnitario", DbType="Decimal(20,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPesoTotal", DbType="Decimal(8,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intSeleccionBrazoID", DbType="Int NOT NULL")]
		public int intSeleccionBrazoID
		{
			get
			{
				return this._intSeleccionBrazoID;
			}
			set
			{
				if ((this._intSeleccionBrazoID != value))
				{
					this._intSeleccionBrazoID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintDriveInID", DbType="SmallInt")]
		public System.Nullable<short> sintDriveInID
		{
			get
			{
				return this._sintDriveInID;
			}
			set
			{
				if ((this._sintDriveInID != value))
				{
					this._sintDriveInID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLargo1", DbType="Decimal(8,2)")]
		public System.Nullable<decimal> decLargo1
		{
			get
			{
				return this._decLargo1;
			}
			set
			{
				if ((this._decLargo1 != value))
				{
					this._decLargo1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLongitud", DbType="Decimal(8,2)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTotalKiloUnitario", DbType="Decimal(8,2)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioFinal", DbType="Decimal(8,2)")]
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
	
	public partial class stp_ListarSeleccionBrazoResult
	{
		
		private int _intSeleccionBrazoID;
		
		private System.Nullable<int> _intBrazoID;
		
		private System.Nullable<int> _intDetCotizaID;
		
		private System.Nullable<decimal> _decLargo;
		
		private System.Nullable<decimal> _decLongitud;
		
		private System.Nullable<decimal> _decAncho;
		
		private System.Nullable<decimal> _decTotalKiloUnitario;
		
		private System.Nullable<decimal> _decPrecioFinal;
		
		private System.Nullable<decimal> _decPesoUnitario;
		
		private System.Nullable<decimal> _decPrecioVentaUnitario;
		
		public stp_ListarSeleccionBrazoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intSeleccionBrazoID", DbType="Int NOT NULL")]
		public int intSeleccionBrazoID
		{
			get
			{
				return this._intSeleccionBrazoID;
			}
			set
			{
				if ((this._intSeleccionBrazoID != value))
				{
					this._intSeleccionBrazoID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intBrazoID", DbType="Int")]
		public System.Nullable<int> intBrazoID
		{
			get
			{
				return this._intBrazoID;
			}
			set
			{
				if ((this._intBrazoID != value))
				{
					this._intBrazoID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLongitud", DbType="Decimal(8,2)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTotalKiloUnitario", DbType="Decimal(8,2)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioFinal", DbType="Decimal(8,2)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPesoUnitario", DbType="Decimal(20,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioVentaUnitario", DbType="Decimal(18,3)")]
		public System.Nullable<decimal> decPrecioVentaUnitario
		{
			get
			{
				return this._decPrecioVentaUnitario;
			}
			set
			{
				if ((this._decPrecioVentaUnitario != value))
				{
					this._decPrecioVentaUnitario = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
