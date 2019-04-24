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
	public partial class ParrillaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public ParrillaDataContext() : 
				base(global::Adsisplus.Cotyrsa.DataAccess.Properties.Settings.Default.dbTyrsaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ParrillaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ParrillaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ParrillaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ParrillaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosParrilla")]
		public ISingleResult<stp_ListarDatosParrillaResult> stp_ListarDatosParrilla([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCotizacionID);
			return ((ISingleResult<stp_ListarDatosParrillaResult>)(result.ReturnValue));
		}
	}
	
	public partial class stp_ListarDatosParrillaResult
	{
		
		private int _intParrillaID;
		
		private string _vchElemento;
		
		private System.Nullable<short> _sintPinturaID;
		
		private string _vchPintura;
		
		private System.Nullable<int> _intCotizacionID;
		
		private System.Nullable<int> _intDetCotizaID;
		
		private string _vchFolio;
		
		private System.Nullable<decimal> _decFrenteParrilla;
		
		private System.Nullable<decimal> _decFondoParrilla;
		
		private System.Nullable<decimal> _decCostoParrilla;
		
		private System.Nullable<decimal> _decTamanioCuadroParrilla;
		
		private System.Nullable<int> _intCantidadParrilla;
		
		private System.Nullable<decimal> _decPesoParrilla;
		
		private System.Nullable<bool> _bitGalvanizado;
		
		private System.Nullable<bool> _bitPintura;
		
		private System.Nullable<bool> _bitActivo;
		
		public stp_ListarDatosParrillaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intParrillaID", DbType="Int NOT NULL")]
		public int intParrillaID
		{
			get
			{
				return this._intParrillaID;
			}
			set
			{
				if ((this._intParrillaID != value))
				{
					this._intParrillaID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decFrenteParrilla", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> decFrenteParrilla
		{
			get
			{
				return this._decFrenteParrilla;
			}
			set
			{
				if ((this._decFrenteParrilla != value))
				{
					this._decFrenteParrilla = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decFondoParrilla", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> decFondoParrilla
		{
			get
			{
				return this._decFondoParrilla;
			}
			set
			{
				if ((this._decFondoParrilla != value))
				{
					this._decFondoParrilla = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decCostoParrilla", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> decCostoParrilla
		{
			get
			{
				return this._decCostoParrilla;
			}
			set
			{
				if ((this._decCostoParrilla != value))
				{
					this._decCostoParrilla = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTamanioCuadroParrilla", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> decTamanioCuadroParrilla
		{
			get
			{
				return this._decTamanioCuadroParrilla;
			}
			set
			{
				if ((this._decTamanioCuadroParrilla != value))
				{
					this._decTamanioCuadroParrilla = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCantidadParrilla", DbType="Int")]
		public System.Nullable<int> intCantidadParrilla
		{
			get
			{
				return this._intCantidadParrilla;
			}
			set
			{
				if ((this._intCantidadParrilla != value))
				{
					this._intCantidadParrilla = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPesoParrilla", DbType="Decimal(8,5)")]
		public System.Nullable<decimal> decPesoParrilla
		{
			get
			{
				return this._decPesoParrilla;
			}
			set
			{
				if ((this._decPesoParrilla != value))
				{
					this._decPesoParrilla = value;
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
