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
	public partial class ProtectoresDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public ProtectoresDataContext() : 
				base(global::Adsisplus.Cotyrsa.DataAccess.Properties.Settings.Default.dbTyrsaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProtectoresDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProtectoresDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProtectoresDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProtectoresDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarSeleccionProtectorRack")]
		public ISingleResult<stp_ListarSeleccionProtectorRackResult> stp_ListarSeleccionProtectorRack()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<stp_ListarSeleccionProtectorRackResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarSeleccionBateriaSencilla")]
		public ISingleResult<stp_ListarSeleccionBateriaSencillaResult> stp_ListarSeleccionBateriaSencilla()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<stp_ListarSeleccionBateriaSencillaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarSeleccionBateriaDoble")]
		public ISingleResult<stp_ListarSeleccionBateriaDobleResult> stp_ListarSeleccionBateriaDoble()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<stp_ListarSeleccionBateriaDobleResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarSeleccionBateriaCuadruple")]
		public ISingleResult<stp_ListarSeleccionBateriaCuadrupleResult> stp_ListarSeleccionBateriaCuadruple()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<stp_ListarSeleccionBateriaCuadrupleResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosProtectorPoste")]
		public ISingleResult<stp_ListarDatosProtectorPosteResult> stp_ListarDatosProtectorPoste([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCotizacionID);
			return ((ISingleResult<stp_ListarDatosProtectorPosteResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarDatosProtectorBateria")]
		public ISingleResult<stp_ListarDatosProtectorBateriaResult> stp_ListarDatosProtectorBateria([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCotizacionID);
			return ((ISingleResult<stp_ListarDatosProtectorBateriaResult>)(result.ReturnValue));
		}
	}
	
	public partial class stp_ListarSeleccionProtectorRackResult
	{
		
		private string _vchTipoProtector;
		
		private System.Nullable<decimal> _decPrecioFinal;
		
		public stp_ListarSeleccionProtectorRackResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchTipoProtector", DbType="VarChar(100)")]
		public string vchTipoProtector
		{
			get
			{
				return this._vchTipoProtector;
			}
			set
			{
				if ((this._vchTipoProtector != value))
				{
					this._vchTipoProtector = value;
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
	}
	
	public partial class stp_ListarSeleccionBateriaSencillaResult
	{
		
		private long _SKU;
		
		private int _intNumBotas;
		
		private int _intNumBarras;
		
		private System.Nullable<decimal> _TOTAL;
		
		private int _intAltura;
		
		public stp_ListarSeleccionBateriaSencillaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SKU", DbType="BigInt NOT NULL")]
		public long SKU
		{
			get
			{
				return this._SKU;
			}
			set
			{
				if ((this._SKU != value))
				{
					this._SKU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intNumBotas", DbType="Int NOT NULL")]
		public int intNumBotas
		{
			get
			{
				return this._intNumBotas;
			}
			set
			{
				if ((this._intNumBotas != value))
				{
					this._intNumBotas = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intNumBarras", DbType="Int NOT NULL")]
		public int intNumBarras
		{
			get
			{
				return this._intNumBarras;
			}
			set
			{
				if ((this._intNumBarras != value))
				{
					this._intNumBarras = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TOTAL", DbType="Decimal(38,3)")]
		public System.Nullable<decimal> TOTAL
		{
			get
			{
				return this._TOTAL;
			}
			set
			{
				if ((this._TOTAL != value))
				{
					this._TOTAL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intAltura", DbType="Int NOT NULL")]
		public int intAltura
		{
			get
			{
				return this._intAltura;
			}
			set
			{
				if ((this._intAltura != value))
				{
					this._intAltura = value;
				}
			}
		}
	}
	
	public partial class stp_ListarSeleccionBateriaDobleResult
	{
		
		private long _SKU;
		
		private int _intNumBotas;
		
		private int _intNumBarras;
		
		private string _vchMaterial;
		
		private System.Nullable<decimal> _TOTAL;
		
		private int _intAltura;
		
		public stp_ListarSeleccionBateriaDobleResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SKU", DbType="BigInt NOT NULL")]
		public long SKU
		{
			get
			{
				return this._SKU;
			}
			set
			{
				if ((this._SKU != value))
				{
					this._SKU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intNumBotas", DbType="Int NOT NULL")]
		public int intNumBotas
		{
			get
			{
				return this._intNumBotas;
			}
			set
			{
				if ((this._intNumBotas != value))
				{
					this._intNumBotas = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intNumBarras", DbType="Int NOT NULL")]
		public int intNumBarras
		{
			get
			{
				return this._intNumBarras;
			}
			set
			{
				if ((this._intNumBarras != value))
				{
					this._intNumBarras = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchMaterial", DbType="VarChar(17) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TOTAL", DbType="Decimal(38,3)")]
		public System.Nullable<decimal> TOTAL
		{
			get
			{
				return this._TOTAL;
			}
			set
			{
				if ((this._TOTAL != value))
				{
					this._TOTAL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intAltura", DbType="Int NOT NULL")]
		public int intAltura
		{
			get
			{
				return this._intAltura;
			}
			set
			{
				if ((this._intAltura != value))
				{
					this._intAltura = value;
				}
			}
		}
	}
	
	public partial class stp_ListarSeleccionBateriaCuadrupleResult
	{
		
		private long _SKU;
		
		private int _intNumBotas;
		
		private int _intNumBarras;
		
		private string _vchMaterial;
		
		private System.Nullable<decimal> _TOTAL;
		
		private int _intAltura;
		
		public stp_ListarSeleccionBateriaCuadrupleResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SKU", DbType="BigInt NOT NULL")]
		public long SKU
		{
			get
			{
				return this._SKU;
			}
			set
			{
				if ((this._SKU != value))
				{
					this._SKU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intNumBotas", DbType="Int NOT NULL")]
		public int intNumBotas
		{
			get
			{
				return this._intNumBotas;
			}
			set
			{
				if ((this._intNumBotas != value))
				{
					this._intNumBotas = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intNumBarras", DbType="Int NOT NULL")]
		public int intNumBarras
		{
			get
			{
				return this._intNumBarras;
			}
			set
			{
				if ((this._intNumBarras != value))
				{
					this._intNumBarras = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchMaterial", DbType="VarChar(17) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TOTAL", DbType="Decimal(38,3)")]
		public System.Nullable<decimal> TOTAL
		{
			get
			{
				return this._TOTAL;
			}
			set
			{
				if ((this._TOTAL != value))
				{
					this._TOTAL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intAltura", DbType="Int NOT NULL")]
		public int intAltura
		{
			get
			{
				return this._intAltura;
			}
			set
			{
				if ((this._intAltura != value))
				{
					this._intAltura = value;
				}
			}
		}
	}
	
	public partial class stp_ListarDatosProtectorPosteResult
	{
		
		private int _intProtectorPosteID;
		
		private string _vchElemento;
		
		private System.Nullable<int> _intCotizacionID;
		
		private System.Nullable<int> _intDetCotizaID;
		
		private string _vchFolio;
		
		private System.Nullable<short> _sintPinturaID;
		
		private string _vchPintura;
		
		private System.Nullable<int> _intCantidadProtectorPoste;
		
		private System.Nullable<decimal> _decPrecioUnitario;
		
		private System.Nullable<decimal> _decAltura;
		
		private System.Nullable<short> _sintLongitudID;
		
		private string _vchLongitud;
		
		private System.Nullable<decimal> _decPrecioVentaTotal;
		
		private System.Nullable<decimal> _decPrecioVentaUnitario;
		
		private System.Nullable<bool> _bitActivo;
		
		public stp_ListarDatosProtectorPosteResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intProtectorPosteID", DbType="Int NOT NULL")]
		public int intProtectorPosteID
		{
			get
			{
				return this._intProtectorPosteID;
			}
			set
			{
				if ((this._intProtectorPosteID != value))
				{
					this._intProtectorPosteID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCantidadProtectorPoste", DbType="Int")]
		public System.Nullable<int> intCantidadProtectorPoste
		{
			get
			{
				return this._intCantidadProtectorPoste;
			}
			set
			{
				if ((this._intCantidadProtectorPoste != value))
				{
					this._intCantidadProtectorPoste = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioUnitario", DbType="Decimal(18,2)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decAltura", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decAltura
		{
			get
			{
				return this._decAltura;
			}
			set
			{
				if ((this._decAltura != value))
				{
					this._decAltura = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintLongitudID", DbType="SmallInt")]
		public System.Nullable<short> sintLongitudID
		{
			get
			{
				return this._sintLongitudID;
			}
			set
			{
				if ((this._sintLongitudID != value))
				{
					this._sintLongitudID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchLongitud", DbType="VarChar(50)")]
		public string vchLongitud
		{
			get
			{
				return this._vchLongitud;
			}
			set
			{
				if ((this._vchLongitud != value))
				{
					this._vchLongitud = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioVentaTotal", DbType="Decimal(8,3)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioVentaUnitario", DbType="Decimal(8,3)")]
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
	
	public partial class stp_ListarDatosProtectorBateriaResult
	{
		
		private int _intProtectorBateriaID;
		
		private string _vchElemento;
		
		private System.Nullable<int> _intCotizacionID;
		
		private System.Nullable<int> _intDetCotizaID;
		
		private string _vchFolio;
		
		private System.Nullable<int> _intCantidadSencilla;
		
		private System.Nullable<int> _intCantidadDoble;
		
		private System.Nullable<int> _intCantidadTriple;
		
		private System.Nullable<int> _intCantidadCuadruple;
		
		private System.Nullable<decimal> _decPrecioSencilla;
		
		private System.Nullable<decimal> _decPrecioDoble;
		
		private System.Nullable<decimal> _decPrecioTriple;
		
		private System.Nullable<decimal> _decPrecioCuadruple;
		
		private System.Nullable<decimal> _decLargoSencilla;
		
		private System.Nullable<decimal> _decLargoDoble;
		
		private System.Nullable<decimal> _decLargoTriple;
		
		private System.Nullable<bool> _bitActivo;
		
		private System.Nullable<decimal> _decPrecioVentaUnitarioSencilla;
		
		private System.Nullable<decimal> _decPrecioVentaUnitarioDoble;
		
		private System.Nullable<decimal> _decPrecioVentaUnitarioTriple;
		
		private System.Nullable<decimal> _decPrecioVentaTotaloSencilla;
		
		private System.Nullable<decimal> _decPrecioVentaTotalDoble;
		
		private System.Nullable<decimal> _decPrecioVentaTotalTriple;
		
		private System.Nullable<decimal> _decAlturaSencilla;
		
		private System.Nullable<decimal> _decAlturaDoble;
		
		private System.Nullable<decimal> _decAlturaTriple;
		
		private System.Nullable<short> _sintPinturaIDSencilla;
		
		private System.Nullable<short> _sintPinturaIDDoble;
		
		private System.Nullable<short> _sintPinturaIDTriple;
		
		private System.Nullable<int> _intBotasSencilla;
		
		private System.Nullable<int> _intBotasDoble;
		
		private System.Nullable<int> _intBotasTriple;
		
		private System.Nullable<int> _intBarrasSencilla;
		
		private System.Nullable<int> _intBarrasDoble;
		
		private System.Nullable<int> _intBarrasTriple;
		
		public stp_ListarDatosProtectorBateriaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intProtectorBateriaID", DbType="Int NOT NULL")]
		public int intProtectorBateriaID
		{
			get
			{
				return this._intProtectorBateriaID;
			}
			set
			{
				if ((this._intProtectorBateriaID != value))
				{
					this._intProtectorBateriaID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCantidadSencilla", DbType="Int")]
		public System.Nullable<int> intCantidadSencilla
		{
			get
			{
				return this._intCantidadSencilla;
			}
			set
			{
				if ((this._intCantidadSencilla != value))
				{
					this._intCantidadSencilla = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCantidadDoble", DbType="Int")]
		public System.Nullable<int> intCantidadDoble
		{
			get
			{
				return this._intCantidadDoble;
			}
			set
			{
				if ((this._intCantidadDoble != value))
				{
					this._intCantidadDoble = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCantidadTriple", DbType="Int")]
		public System.Nullable<int> intCantidadTriple
		{
			get
			{
				return this._intCantidadTriple;
			}
			set
			{
				if ((this._intCantidadTriple != value))
				{
					this._intCantidadTriple = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCantidadCuadruple", DbType="Int")]
		public System.Nullable<int> intCantidadCuadruple
		{
			get
			{
				return this._intCantidadCuadruple;
			}
			set
			{
				if ((this._intCantidadCuadruple != value))
				{
					this._intCantidadCuadruple = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioSencilla", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> decPrecioSencilla
		{
			get
			{
				return this._decPrecioSencilla;
			}
			set
			{
				if ((this._decPrecioSencilla != value))
				{
					this._decPrecioSencilla = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioDoble", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> decPrecioDoble
		{
			get
			{
				return this._decPrecioDoble;
			}
			set
			{
				if ((this._decPrecioDoble != value))
				{
					this._decPrecioDoble = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioTriple", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> decPrecioTriple
		{
			get
			{
				return this._decPrecioTriple;
			}
			set
			{
				if ((this._decPrecioTriple != value))
				{
					this._decPrecioTriple = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioCuadruple", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> decPrecioCuadruple
		{
			get
			{
				return this._decPrecioCuadruple;
			}
			set
			{
				if ((this._decPrecioCuadruple != value))
				{
					this._decPrecioCuadruple = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLargoSencilla", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decLargoSencilla
		{
			get
			{
				return this._decLargoSencilla;
			}
			set
			{
				if ((this._decLargoSencilla != value))
				{
					this._decLargoSencilla = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLargoDoble", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decLargoDoble
		{
			get
			{
				return this._decLargoDoble;
			}
			set
			{
				if ((this._decLargoDoble != value))
				{
					this._decLargoDoble = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decLargoTriple", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decLargoTriple
		{
			get
			{
				return this._decLargoTriple;
			}
			set
			{
				if ((this._decLargoTriple != value))
				{
					this._decLargoTriple = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioVentaUnitarioSencilla", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decPrecioVentaUnitarioSencilla
		{
			get
			{
				return this._decPrecioVentaUnitarioSencilla;
			}
			set
			{
				if ((this._decPrecioVentaUnitarioSencilla != value))
				{
					this._decPrecioVentaUnitarioSencilla = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioVentaUnitarioDoble", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decPrecioVentaUnitarioDoble
		{
			get
			{
				return this._decPrecioVentaUnitarioDoble;
			}
			set
			{
				if ((this._decPrecioVentaUnitarioDoble != value))
				{
					this._decPrecioVentaUnitarioDoble = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioVentaUnitarioTriple", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decPrecioVentaUnitarioTriple
		{
			get
			{
				return this._decPrecioVentaUnitarioTriple;
			}
			set
			{
				if ((this._decPrecioVentaUnitarioTriple != value))
				{
					this._decPrecioVentaUnitarioTriple = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioVentaTotaloSencilla", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decPrecioVentaTotaloSencilla
		{
			get
			{
				return this._decPrecioVentaTotaloSencilla;
			}
			set
			{
				if ((this._decPrecioVentaTotaloSencilla != value))
				{
					this._decPrecioVentaTotaloSencilla = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioVentaTotalDoble", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decPrecioVentaTotalDoble
		{
			get
			{
				return this._decPrecioVentaTotalDoble;
			}
			set
			{
				if ((this._decPrecioVentaTotalDoble != value))
				{
					this._decPrecioVentaTotalDoble = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioVentaTotalTriple", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decPrecioVentaTotalTriple
		{
			get
			{
				return this._decPrecioVentaTotalTriple;
			}
			set
			{
				if ((this._decPrecioVentaTotalTriple != value))
				{
					this._decPrecioVentaTotalTriple = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decAlturaSencilla", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decAlturaSencilla
		{
			get
			{
				return this._decAlturaSencilla;
			}
			set
			{
				if ((this._decAlturaSencilla != value))
				{
					this._decAlturaSencilla = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decAlturaDoble", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decAlturaDoble
		{
			get
			{
				return this._decAlturaDoble;
			}
			set
			{
				if ((this._decAlturaDoble != value))
				{
					this._decAlturaDoble = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decAlturaTriple", DbType="Decimal(8,3)")]
		public System.Nullable<decimal> decAlturaTriple
		{
			get
			{
				return this._decAlturaTriple;
			}
			set
			{
				if ((this._decAlturaTriple != value))
				{
					this._decAlturaTriple = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintPinturaIDSencilla", DbType="SmallInt")]
		public System.Nullable<short> sintPinturaIDSencilla
		{
			get
			{
				return this._sintPinturaIDSencilla;
			}
			set
			{
				if ((this._sintPinturaIDSencilla != value))
				{
					this._sintPinturaIDSencilla = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintPinturaIDDoble", DbType="SmallInt")]
		public System.Nullable<short> sintPinturaIDDoble
		{
			get
			{
				return this._sintPinturaIDDoble;
			}
			set
			{
				if ((this._sintPinturaIDDoble != value))
				{
					this._sintPinturaIDDoble = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintPinturaIDTriple", DbType="SmallInt")]
		public System.Nullable<short> sintPinturaIDTriple
		{
			get
			{
				return this._sintPinturaIDTriple;
			}
			set
			{
				if ((this._sintPinturaIDTriple != value))
				{
					this._sintPinturaIDTriple = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intBotasSencilla", DbType="Int")]
		public System.Nullable<int> intBotasSencilla
		{
			get
			{
				return this._intBotasSencilla;
			}
			set
			{
				if ((this._intBotasSencilla != value))
				{
					this._intBotasSencilla = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intBotasDoble", DbType="Int")]
		public System.Nullable<int> intBotasDoble
		{
			get
			{
				return this._intBotasDoble;
			}
			set
			{
				if ((this._intBotasDoble != value))
				{
					this._intBotasDoble = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intBotasTriple", DbType="Int")]
		public System.Nullable<int> intBotasTriple
		{
			get
			{
				return this._intBotasTriple;
			}
			set
			{
				if ((this._intBotasTriple != value))
				{
					this._intBotasTriple = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intBarrasSencilla", DbType="Int")]
		public System.Nullable<int> intBarrasSencilla
		{
			get
			{
				return this._intBarrasSencilla;
			}
			set
			{
				if ((this._intBarrasSencilla != value))
				{
					this._intBarrasSencilla = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intBarrasDoble", DbType="Int")]
		public System.Nullable<int> intBarrasDoble
		{
			get
			{
				return this._intBarrasDoble;
			}
			set
			{
				if ((this._intBarrasDoble != value))
				{
					this._intBarrasDoble = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intBarrasTriple", DbType="Int")]
		public System.Nullable<int> intBarrasTriple
		{
			get
			{
				return this._intBarrasTriple;
			}
			set
			{
				if ((this._intBarrasTriple != value))
				{
					this._intBarrasTriple = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
