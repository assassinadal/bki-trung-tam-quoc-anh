///************************************************
/// Generated by: Haihd
/// Date: 18/01/2015 01:37:53
/// Goal: Create User Service Class for V_GD_PHIEU_THU
///************************************************
/// <summary>
/// Create User Service Class for V_GD_PHIEU_THU
/// </summary>

using System;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLTTQuocAnh.US{

public class US_V_GD_PHIEU_THU : US_Object
{
	private const string c_TableName = "V_GD_PHIEU_THU";
#region "Public Properties"
	public decimal dcID 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID"] = value;
		}
	}

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
	}

	public decimal dcID_HOC_SINH 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_HOC_SINH", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_HOC_SINH"] = value;
		}
	}

	public bool IsID_HOC_SINHNull()	{
		return pm_objDR.IsNull("ID_HOC_SINH");
	}

	public void SetID_HOC_SINHNull() {
		pm_objDR["ID_HOC_SINH"] = System.Convert.DBNull;
	}

	public string strHO_TEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HO_TEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HO_TEN"] = value;
		}
	}

	public bool IsHO_TENNull() 
	{
		return pm_objDR.IsNull("HO_TEN");
	}

	public void SetHO_TENNull() {
		pm_objDR["HO_TEN"] = System.Convert.DBNull;
	}

	public decimal dcID_NGUOI_THU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_THU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_NGUOI_THU"] = value;
		}
	}

	public bool IsID_NGUOI_THUNull()	{
		return pm_objDR.IsNull("ID_NGUOI_THU");
	}

	public void SetID_NGUOI_THUNull() {
		pm_objDR["ID_NGUOI_THU"] = System.Convert.DBNull;
	}

	public string strNGUOI_THU 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NGUOI_THU", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NGUOI_THU"] = value;
		}
	}

	public bool IsNGUOI_THUNull() 
	{
		return pm_objDR.IsNull("NGUOI_THU");
	}

	public void SetNGUOI_THUNull() {
		pm_objDR["NGUOI_THU"] = System.Convert.DBNull;
	}

	public decimal dcID_NGUOI_NHAP 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_NHAP", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_NGUOI_NHAP"] = value;
		}
	}

	public bool IsID_NGUOI_NHAPNull()	{
		return pm_objDR.IsNull("ID_NGUOI_NHAP");
	}

	public void SetID_NGUOI_NHAPNull() {
		pm_objDR["ID_NGUOI_NHAP"] = System.Convert.DBNull;
	}

	public string strNGUOI_NHAP 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NGUOI_NHAP", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NGUOI_NHAP"] = value;
		}
	}

	public bool IsNGUOI_NHAPNull() 
	{
		return pm_objDR.IsNull("NGUOI_NHAP");
	}

	public void SetNGUOI_NHAPNull() {
		pm_objDR["NGUOI_NHAP"] = System.Convert.DBNull;
	}

	public string strTEN_NGUOI_NOP_TIEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_NGUOI_NOP_TIEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_NGUOI_NOP_TIEN"] = value;
		}
	}

	public bool IsTEN_NGUOI_NOP_TIENNull() 
	{
		return pm_objDR.IsNull("TEN_NGUOI_NOP_TIEN");
	}

	public void SetTEN_NGUOI_NOP_TIENNull() {
		pm_objDR["TEN_NGUOI_NOP_TIEN"] = System.Convert.DBNull;
	}

	public string strNOI_DUNG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NOI_DUNG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NOI_DUNG"] = value;
		}
	}

	public bool IsNOI_DUNGNull() 
	{
		return pm_objDR.IsNull("NOI_DUNG");
	}

	public void SetNOI_DUNGNull() {
		pm_objDR["NOI_DUNG"] = System.Convert.DBNull;
	}

	public decimal dcSO_TIEN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SO_TIEN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SO_TIEN"] = value;
		}
	}

	public bool IsSO_TIENNull()	{
		return pm_objDR.IsNull("SO_TIEN");
	}

	public void SetSO_TIENNull() {
		pm_objDR["SO_TIEN"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_THU
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_THU", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_THU"] = value;
		}
	}

	public bool IsNGAY_THUNull()
	{
		return pm_objDR.IsNull("NGAY_THU");
	}

	public void SetNGAY_THUNull()
	{
		pm_objDR["NGAY_THU"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_NHAP
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_NHAP", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_NHAP"] = value;
		}
	}

	public bool IsNGAY_NHAPNull()
	{
		return pm_objDR.IsNull("NGAY_NHAP");
	}

	public void SetNGAY_NHAPNull()
	{
		pm_objDR["NGAY_NHAP"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_GD_PHIEU_THU() 
	{
		pm_objDS = new DS_V_GD_PHIEU_THU();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_PHIEU_THU(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_PHIEU_THU(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_PHIEU_THU();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion
	}
}
