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
	public partial class DistanciadorDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public DistanciadorDataContext() : 
				base(global::Adsisplus.Cotyrsa.DataAccess.Properties.Settings.Default.dbTyrsaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DistanciadorDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DistanciadorDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DistanciadorDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DistanciadorDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosDistanciador")]
		public ISingleResult<stp_ListarDatosDistanciadorResult> stp_ListarDatosDistanciador([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCotizacionID);
			return ((ISingleResult<stp_ListarDatosDistanciadorResult>)(result.ReturnValue));
		}
	}
	
	public partial class stp_ListarDatosDistanciadorResult
	{
		
		private int _intDistanciadorID;
		
		private System.Nullable<int> _intCotizacionID;
		
		private System.Nullable<int> _intDetCotizaID;
		
		private string _vchFolio;
		
		private System.Nullable<int> _intElementoID;
		
		private string _vchElemento;
		
		private System.Nullable<short> _sintPinturaID;
		
		private string _vchPintura;
		
		private System.Nullable<int> _intCantidadDistanciador;
		
		private System.Nullable<decimal> _decLargoDistanciador;
		
		private System.Nullable<bool> _bitActivo;
		
		public stp_ListarDatosDistanciadorResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intDistanciadorID", DbType="Int NOT NULL")]
		public int intDistanciadorID
		{
			get
			{
				return this._intDistanciadorID;
			}
			set
			{
				if ((this._intDistanciadorID != value))
				{
					this._intDistanciadorID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCantidadDistanciador", DbType="Int")]
		public System.Nullable<int> intCantidadDistanciador
		{
			get
			{
				return this._intCantidadDistanciador;
			}
			set
			{
				if ((this._intCantidadDistanciador != value))
				{
					this._intCantidadDistanciador = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLargoDistanciador", DbType="Decimal(20,2)")]
		public System.Nullable<decimal> decLargoDistanciador
		{
			get
			{
				return this._decLargoDistanciador;
			}
			set
			{
				if ((this._decLargoDistanciador != value))
				{
					this._decLargoDistanciador = value;
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
