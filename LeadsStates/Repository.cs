using LeadsStates.Common;
using LeadsStates.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LeadsStates.Repository
{
    public class Repository
    {
        private string _connectionString = "";
        public Repository()
        {
            _connectionString = "data source=54.236.252.53;initial catalog=Grit_Stg;user id=gritdev;password=Gr1tDev2019;";
        }
        public IEnumerable<LeadsModel> GetBrands(string UserId)
        {
            List<LeadsModel> objList = new List<LeadsModel>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(_connectionString, con))
                {
                    try
                    {
                        if (sqlCommand.Connection.State != System.Data.ConnectionState.Open)
                            sqlCommand.Connection.Open();
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandText = Database.GET_BRANDS;
                        sqlCommand.Parameters.Add(new SqlParameter("UserId", UserId));
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                        while (sqlDataReader.Read())
                        {
                            LeadsModel obj = new LeadsModel();
                            obj.Id = Convert.ToInt32(sqlDataReader["Id"]);
                            obj.Name = sqlDataReader["Name"].ToString();
                            obj.Email = sqlDataReader["Email"].ToString();
                            obj.PrimaryNumber = sqlDataReader["PrimaryNumber"].ToString();
                            obj.SecoundryNumber = sqlDataReader["SecoundryNumber"].ToString();
                            obj.Address = sqlDataReader["Address"].ToString();
                            obj.LeadType = sqlDataReader["LeadType"].ToString();
                            obj.City = sqlDataReader["City"].ToString();
                            obj.Project = sqlDataReader["Project"].ToString();
                            obj.Phase = sqlDataReader["Phase"].ToString();
                            obj.Block = sqlDataReader["Block"].ToString();
                            obj.PropertyType = sqlDataReader["PropertyType"].ToString();
                            obj.HomeType = sqlDataReader["HomeType"].ToString();
                            obj.MinBudget = Convert.ToDecimal( sqlDataReader["MinBudget"]);
                            obj.MaxBudget = Convert.ToDecimal( sqlDataReader["MaxBudget"]);
                            obj.MinArea = Convert.ToDecimal( sqlDataReader["MinArea"]);
                            obj.MaxArea = Convert.ToDecimal( sqlDataReader["MaxArea"]);
                            obj.AreaType = sqlDataReader["AreaType"].ToString();
                            obj.LeadPriority = sqlDataReader["LeadPriority"].ToString();
                            obj.ClientType = sqlDataReader["ClientType"].ToString();
                            obj.AllocatedUser = sqlDataReader["AllocatedUser"].ToString();
                            obj.Beds = Convert.ToInt32(sqlDataReader["Beds"]);
                            obj.Source = sqlDataReader["Source"].ToString();
                            obj.CreatedOn = sqlDataReader["CreatedOn"].ToString();
                            objList.Add(obj);
                        }
                        sqlDataReader.Close();
                        sqlCommand.Dispose();                        
                        return objList;
                    }
                    catch (Exception ex)
                    {
                        return objList;
                    }
                }
            }
        }
        public int RegisterBrand(string UserId, string SellerId, string AuthKey, string SellerEmail)
        {
            int brandId = 0;
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(_connectionString, con))
                {
                    try
                    {
                        if (sqlCommand.Connection.State != System.Data.ConnectionState.Open)
                            sqlCommand.Connection.Open();
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandText = Database.REGISTER_BRAND;
                        sqlCommand.Parameters.Add(new SqlParameter("UserId", UserId));
                        //sqlCommand.Parameters.Add(new SqlParameter("BrandName", BrandName));
                        sqlCommand.Parameters.Add(new SqlParameter("SellerId", SellerId));
                        sqlCommand.Parameters.Add(new SqlParameter("AuthKey", AuthKey));
                        sqlCommand.Parameters.Add(new SqlParameter("SellerEmail", SellerEmail));
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            brandId = Convert.ToInt32(sqlDataReader["BrandId"]);
                        }
                        sqlDataReader.Close();
                        sqlCommand.Dispose();
                        return brandId;

                    }
                    catch (Exception ex)
                    {
                        return 0;
                    }
                }
            }
        }
    }
}