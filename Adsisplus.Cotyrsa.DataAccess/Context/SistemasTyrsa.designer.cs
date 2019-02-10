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
	public partial class SistemasTyrsaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public SistemasTyrsaDataContext() : 
				base(global::Adsisplus.Cotyrsa.DataAccess.Properties.Settings.Default.dbTyrsaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SistemasTyrsaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SistemasTyrsaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SistemasTyrsaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SistemasTyrsaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosPanel")]
		public ISingleResult<stp_setDatosPanelResult> stp_setDatosPanel([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatosPanelID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatoMarcoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPinturaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decAnchoPanel, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidadPanel, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decCapacidadCargaPanel, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intDatosPanelID, intElementoID, intDatoMarcoID, sintPinturaID, decAnchoPanel, intCantidadPanel, decCapacidadCargaPanel, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosPanelResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosCrossBar")]
		public ISingleResult<stp_setDatosCrossBarResult> stp_setDatosCrossBar([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatosCrossBarID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatoMarcoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decAnchoCrossBar, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitConectorVigaCrossbar, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidadNivelCrossbar, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intDatosCrossBarID, intElementoID, intDatoMarcoID, decAnchoCrossBar, bitConectorVigaCrossbar, intCantidadNivelCrossbar, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosCrossBarResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosDistanciador")]
		public ISingleResult<stp_setDatosDistanciadorResult> stp_setDatosDistanciador([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDistanciadorID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidadDistanciador, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decLargoDistanciador, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intDistanciadorID, intCotizacionID, intElementoID, intCantidadDistanciador, decLargoDistanciador, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosDistanciadorResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosParrilla")]
		public ISingleResult<stp_setDatosParrillaResult> stp_setDatosParrilla([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intParrillaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPinturaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decFrenteParrilla, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decFondoParrilla, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decCostoParrilla, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decTamanioCuadroParrilla, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidadParrilla, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intParrillaID, intElementoID, sintPinturaID, intCotizacionID, decFrenteParrilla, decFondoParrilla, decCostoParrilla, decTamanioCuadroParrilla, intCantidadParrilla, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosParrillaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosVigaTope")]
		public ISingleResult<stp_setDatosVigaTopeResult> stp_setDatosVigaTope([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intVigaTopeID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidadVigaTope, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatosVigaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPinturaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidad, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intVigaTopeID, intCantidadVigaTope, intElementoID, intDatosVigaID, intCotizacionID, sintPinturaID, intCantidad, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosVigaTopeResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosProtectorPoste")]
		public ISingleResult<stp_setDatosProtectorPosteResult> stp_setDatosProtectorPoste([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intProtectorPosteID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPinturaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidadProtectorPoste, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intProtectorPosteID, intElementoID, intCotizacionID, sintPinturaID, intCantidadProtectorPoste, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosProtectorPosteResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosProtectorBateria")]
		public ISingleResult<stp_setDatosProtectorBateriaResult> stp_setDatosProtectorBateria([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intProtectorBateriaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidadSencilla, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidadDoble, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidadCuadruple, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intProtectorBateriaID, intElementoID, intCotizacionID, intCantidadSencilla, intCantidadDoble, intCantidadCuadruple, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosProtectorBateriaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosViga")]
		public ISingleResult<stp_setDatosVigaResult> stp_setDatosViga([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatosVigaID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SKU", DbType="BigInt")] System.Nullable<long> sKU, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPinturaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatoMarcoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decLargo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidad, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intDatosVigaID, sKU, sintPinturaID, intElementoID, intDatoMarcoID, decLargo, intCantidad, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosVigaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosMarco")]
		public ISingleResult<stp_setDatosMarcoResult> stp_setDatosMarco([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatoMarcoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intConfiguraMarcoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPinturaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decMedidaFondo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decMedidaAlto, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitDobleMonten, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intNumeroNivelSobreViga, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decAlturaPandeo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decCapacidadxNivel, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintCantidad, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intDatoMarcoID, intConfiguraMarcoID, intCotizacionID, intElementoID, sintPinturaID, decMedidaFondo, decMedidaAlto, bitDobleMonten, intNumeroNivelSobreViga, decAlturaPandeo, decCapacidadxNivel, sintCantidad, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosMarcoResult>)(result.ReturnValue));
		}
	}
	
	public partial class stp_setDatosPanelResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosPanelResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchResultado", DbType="VarChar(2) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(48) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_setDatosCrossBarResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosCrossBarResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchResultado", DbType="VarChar(2) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(52) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_setDatosDistanciadorResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosDistanciadorResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchResultado", DbType="VarChar(2) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_setDatosParrillaResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosParrillaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchResultado", DbType="VarChar(2) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(51) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_setDatosVigaTopeResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosVigaTopeResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchResultado", DbType="VarChar(2) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(52) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_setDatosProtectorPosteResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosProtectorPosteResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchResultado", DbType="VarChar(2) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_setDatosProtectorBateriaResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosProtectorBateriaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchResultado", DbType="VarChar(2) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_setDatosVigaResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosVigaResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(47) NOT NULL", CanBeNull=false)]
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
	
	public partial class stp_setDatosMarcoResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosMarcoResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", DbType="VarChar(48) NOT NULL", CanBeNull=false)]
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
}
#pragma warning restore 1591
