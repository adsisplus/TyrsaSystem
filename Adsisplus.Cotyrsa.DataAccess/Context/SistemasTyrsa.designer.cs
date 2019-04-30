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
		
		public System.Data.Linq.Table<mstTornilleria> mstTornilleria
		{
			get
			{
				return this.GetTable<mstTornilleria>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosViga")]
		public ISingleResult<stp_setDatosVigaResult> stp_setDatosViga([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatosVigaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SKU", DbType="BigInt")] System.Nullable<long> sKU, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPinturaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatoMarcoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(12,2)")] System.Nullable<decimal> decLargo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidad, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intPiezaXLamina, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intPiezaXLaminaCuerpo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intDatosVigaID, intDetCotizaID, sKU, sintPinturaID, intElementoID, intDatoMarcoID, decLargo, intCantidad, intPiezaXLamina, intPiezaXLaminaCuerpo, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosVigaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosMarco")]
		public ISingleResult<stp_setDatosMarcoResult> stp_setDatosMarco([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatoMarcoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intConfiguraMarcoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPinturaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decMedidaFondo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decMedidaAlto, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitDobleMonten, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intNumeroNivelSobreViga, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decAlturaPandeo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decCapacidadxNivel, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintCantidad, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intDatoMarcoID, intConfiguraMarcoID, intCotizacionID, intDetCotizaID, intElementoID, sintPinturaID, decMedidaFondo, decMedidaAlto, bitDobleMonten, intNumeroNivelSobreViga, decAlturaPandeo, decCapacidadxNivel, sintCantidad, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosMarcoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosDistanciador")]
		public ISingleResult<stp_setDatosDistanciadorResult> stp_setDatosDistanciador([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDistanciadorID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> sintPinturaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidadDistanciador, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decLargoDistanciador, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intDistanciadorID, intCotizacionID, intDetCotizaID, intElementoID, sintPinturaID, intCantidadDistanciador, decLargoDistanciador, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosDistanciadorResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosPanel")]
		public ISingleResult<stp_setDatosPanelResult> stp_setDatosPanel([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatosPanelID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatoMarcoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPinturaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decAnchoPanel, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidadPanel, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decCapacidadCargaPanel, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intDatosPanelID, intElementoID, intDatoMarcoID, intDetCotizaID, sintPinturaID, decAnchoPanel, intCantidadPanel, decCapacidadCargaPanel, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosPanelResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosCrossBar")]
		public ISingleResult<stp_setDatosCrossBarResult> stp_setDatosCrossBar([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatosCrossBarID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatoMarcoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decAnchoCrossBar, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitConectorVigaCrossbar, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidadNivelCrossbar, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intDatosCrossBarID, intDetCotizaID, intElementoID, intDatoMarcoID, decAnchoCrossBar, bitConectorVigaCrossbar, intCantidadNivelCrossbar, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosCrossBarResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarTornillosSelectivo")]
		public ISingleResult<mstTornilleria> stp_ListarTornillosSelectivo([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intConfiguraMarcoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitEstructural, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitEsCuadruple)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intConfiguraMarcoID, intCotizacionID, bitEstructural, bitEsCuadruple);
			return ((ISingleResult<mstTornilleria>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_ListarTornillosSelectivoCotizacion")]
		public ISingleResult<stp_ListarTornillosSelectivoCotizacionResult> stp_ListarTornillosSelectivoCotizacion([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intCotizacionID);
			return ((ISingleResult<stp_ListarTornillosSelectivoCotizacionResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosParrilla")]
		public ISingleResult<stp_setDatosParrillaResult> stp_setDatosParrilla(
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intParrillaID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPinturaID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decFrenteParrilla, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decFondoParrilla, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decCostoParrilla, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(20,2)")] System.Nullable<decimal> decTamanioCuadroParrilla, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidadParrilla, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,5)")] System.Nullable<decimal> decPesoParrilla, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitGalvanizado, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitPintura, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPrecioVentaUnitario, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPrecioVentaTotal, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intParrillaID, intElementoID, sintPinturaID, intCotizacionID, intDetCotizaID, decFrenteParrilla, decFondoParrilla, decCostoParrilla, decTamanioCuadroParrilla, intCantidadParrilla, decPesoParrilla, bitGalvanizado, bitPintura, decPrecioVentaUnitario, decPrecioVentaTotal, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosParrillaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosProtectorPoste")]
		public ISingleResult<stp_setDatosProtectorPosteResult> stp_setDatosProtectorPoste([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intProtectorPosteID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPrecioUnitario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPinturaID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidadProtectorPoste, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decAltura, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintLongitudID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPrecioVentaTotal, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPrecioVentaUnitario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intProtectorPosteID, intElementoID, intCotizacionID, intDetCotizaID, decPrecioUnitario, sintPinturaID, intCantidadProtectorPoste, bitActivo, decAltura, sintLongitudID, decPrecioVentaTotal, decPrecioVentaUnitario, tinOpcion);
			return ((ISingleResult<stp_setDatosProtectorPosteResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosVigaTope")]
		public ISingleResult<stp_setDatosVigaTopeResult> stp_setDatosVigaTope(
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intVigaTopeID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDatosVigaID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPinturaID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidad, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPrecioUnitario, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPrecioVentaUnitario, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPrecioVentaTotal, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPeso, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintLongitudID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCalibreID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decLargo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intVigaTopeID, intElementoID, intDatosVigaID, intCotizacionID, intDetCotizaID, sintPinturaID, intCantidad, decPrecioUnitario, decPrecioVentaUnitario, decPrecioVentaTotal, decPeso, sintLongitudID, intCalibreID, decLargo, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosVigaTopeResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_setDatosProtectorBateria")]
		public ISingleResult<stp_setDatosProtectorBateriaResult> stp_setDatosProtectorBateria(
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intProtectorBateriaID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intElementoID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCotizacionID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intDetCotizaID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidadSencilla, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidadDoble, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidadTriple, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intCantidadCuadruple, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPrecioSencilla, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPrecioDoble, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPrecioTriple, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPrecioCuadruple, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decLargoSencilla, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decLargoDoble, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decLargoTriple, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPrecioVentaUnitarioSencilla, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPrecioVentaUnitarioDoble, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPrecioVentaUnitarioTriple, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPrecioVentaTotaloSencilla, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPrecioVentaTotalDoble, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decPrecioVentaTotalTriple, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decAlturaSencilla, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decAlturaDoble, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(8,3)")] System.Nullable<decimal> decAlturaTriple, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPinturaIDSencilla, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPinturaIDDoble, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="SmallInt")] System.Nullable<short> sintPinturaIDTriple, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intBotasSencilla, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intBotasDoble, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intBotasTriple, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intBarrasSencilla, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intBarrasDoble, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> intBarrasTriple, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> bitActivo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> tinOpcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), intProtectorBateriaID, intElementoID, intCotizacionID, intDetCotizaID, intCantidadSencilla, intCantidadDoble, intCantidadTriple, intCantidadCuadruple, decPrecioSencilla, decPrecioDoble, decPrecioTriple, decPrecioCuadruple, decLargoSencilla, decLargoDoble, decLargoTriple, decPrecioVentaUnitarioSencilla, decPrecioVentaUnitarioDoble, decPrecioVentaUnitarioTriple, decPrecioVentaTotaloSencilla, decPrecioVentaTotalDoble, decPrecioVentaTotalTriple, decAlturaSencilla, decAlturaDoble, decAlturaTriple, sintPinturaIDSencilla, sintPinturaIDDoble, sintPinturaIDTriple, intBotasSencilla, intBotasDoble, intBotasTriple, intBarrasSencilla, intBarrasDoble, intBarrasTriple, bitActivo, tinOpcion);
			return ((ISingleResult<stp_setDatosProtectorBateriaResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class mstTornilleria
	{
		
		private int _intDatoTornilleriaID;
		
		private short _sintTornilleriaID;
		
		private int _intElementoID;
		
		private int _intCotizacionID;
		
		private int _intDetCotizaID;
		
		private string _vchSubMenu;
		
		private string _vchDescripcion;
		
		private int _intCantidad;
		
		private decimal _decPrecioUnitario;
		
		private decimal _decTotal;
		
		private bool _bitActivo;
		
		public mstTornilleria()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intDatoTornilleriaID")]
		public int intDatoTornilleriaID
		{
			get
			{
				return this._intDatoTornilleriaID;
			}
			set
			{
				if ((this._intDatoTornilleriaID != value))
				{
					this._intDatoTornilleriaID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintTornilleriaID")]
		public short sintTornilleriaID
		{
			get
			{
				return this._sintTornilleriaID;
			}
			set
			{
				if ((this._sintTornilleriaID != value))
				{
					this._sintTornilleriaID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intElementoID")]
		public int intElementoID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCotizacionID")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intDetCotizaID")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchSubMenu", CanBeNull=false)]
		public string vchSubMenu
		{
			get
			{
				return this._vchSubMenu;
			}
			set
			{
				if ((this._vchSubMenu != value))
				{
					this._vchSubMenu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchDescripcion", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intCantidad")]
		public int intCantidad
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTotal")]
		public decimal decTotal
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bitActivo")]
		public bool bitActivo
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
	
	public partial class stp_setDatosDistanciadorResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosDistanciadorResult()
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
	
	public partial class stp_setDatosPanelResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosPanelResult()
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
	
	public partial class stp_setDatosCrossBarResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosCrossBarResult()
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
	
	public partial class stp_ListarTornillosSelectivoCotizacionResult
	{
		
		private int _intDatoTornilleriaID;
		
		private System.Nullable<short> _sintTornilleriaID;
		
		private System.Nullable<int> _intElementoID;
		
		private System.Nullable<int> _intCotizacionID;
		
		private System.Nullable<int> _intDetCotizaID;
		
		private string _vchSubMenu;
		
		private string _vchDescripcion;
		
		private System.Nullable<int> _intCantidad;
		
		private System.Nullable<decimal> _decPrecioUnitario;
		
		private System.Nullable<decimal> _decTotal;
		
		private System.Nullable<bool> _bitActivo;
		
		public stp_ListarTornillosSelectivoCotizacionResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intDatoTornilleriaID", DbType="Int NOT NULL")]
		public int intDatoTornilleriaID
		{
			get
			{
				return this._intDatoTornilleriaID;
			}
			set
			{
				if ((this._intDatoTornilleriaID != value))
				{
					this._intDatoTornilleriaID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sintTornilleriaID", DbType="SmallInt")]
		public System.Nullable<short> sintTornilleriaID
		{
			get
			{
				return this._sintTornilleriaID;
			}
			set
			{
				if ((this._sintTornilleriaID != value))
				{
					this._sintTornilleriaID = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vchSubMenu", DbType="VarChar(100)")]
		public string vchSubMenu
		{
			get
			{
				return this._vchSubMenu;
			}
			set
			{
				if ((this._vchSubMenu != value))
				{
					this._vchSubMenu = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decPrecioUnitario", DbType="Decimal(8,2)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_decTotal", DbType="Decimal(12,2)")]
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
	
	public partial class stp_setDatosParrillaResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosParrillaResult()
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
	
	public partial class stp_setDatosProtectorPosteResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosProtectorPosteResult()
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
	
	public partial class stp_setDatosVigaTopeResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosVigaTopeResult()
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
	
	public partial class stp_setDatosProtectorBateriaResult
	{
		
		private string _vchResultado;
		
		private string _vchDescripcion;
		
		public stp_setDatosProtectorBateriaResult()
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
}
#pragma warning restore 1591
