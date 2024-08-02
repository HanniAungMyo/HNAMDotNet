using HNAMDotNet.HospitalManagementSystem.Common;
using HNAMDotNet.HospitalManagementSystem.Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNAMDotNet.HospitalManagementSystem.DAO
{
    public class MenuDao
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public ResMenuEntity GetAllMenuByRoleId()
        {
            ResMenuEntity resMenu = new ResMenuEntity();
            try
            {
                con = DbConnector.Connect();
                if (con == null) return null;
                cmd = new SqlCommand(ProcedureConstants.SP_GetAllMenuByRoleId, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoleId", CommonFormat.RoleId);
                adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                List<MenuEntity> lst = new List<MenuEntity>();
                foreach (DataRow dr in ds.Tables)
                {
                    lst.Add(new MenuEntity()
                    {
                        MenuId = Convert.ToInt32(dr["MenuId"]),
                        Menu = dr["Menu"].ToString(),
                        Name = dr["Name"].ToString(),
                        IconName = dr["IconName"].ToString(),
                        RoleId = Convert.ToInt32(dr["RoleId"])
                    });
                }

                resMenu.messageEntity.RespCode = CommonResponseMessage.ResSuccessCode;
                resMenu.messageEntity.RespDesc = "Success";
                resMenu.messageEntity.RespType = CommonResponseMessage.ResSuccessType;
                return new ResMenuEntity()
                {
                    messageEntity = resMenu.messageEntity,
                    lstMenu = lst,
                };
            }
            catch (Exception ex)
            {
                resMenu.messageEntity.RespCode = CommonResponseMessage.ResErrorCode;
                resMenu.messageEntity.RespDesc = ex.Message;
                resMenu.messageEntity.RespType = CommonResponseMessage.ResErrorType;

                return new ResMenuEntity()
                {
                    messageEntity = resMenu.messageEntity,
                    lstMenu = null
                };
            }
        }
    }
}
