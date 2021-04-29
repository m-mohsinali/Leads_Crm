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
            //_connectionString = "data source=devprogramersdataserver.database.windows.net;initial catalog=LeadsstatesDB;user id=devdbuser;password=As090078601@;";
            //_connectionString = "Data Source=Mohsin-PC;Initial Catalog=Leads_CRM;Integrated Security=True";
            //_connectionString = "Data Source=SG2NWPLS14SQL-v06.shr.prod.sin2.secureserver.net;Initial Catalog=LEADS_ERM;User ID=Testmohsin;Password=As090078601@";
            _connectionString = "Data Source=SQL5104.site4now.net;Initial Catalog=db_a731a7_leadscrm;User ID=db_a731a7_leadscrm_admin;Password=As090078601@; TrustServerCertificate=True";
        }
        public IEnumerable<LeadsModel> GetAllLeads()
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
                        sqlCommand.CommandText = Database.GET_ALL_LEADS;
                        //sqlCommand.Parameters.Add(new SqlParameter("UserId", UserId));
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
                            obj.City = sqlDataReader["CityName"].ToString();
                            obj.Project = sqlDataReader["ProjectName"].ToString();
                            obj.Phase = sqlDataReader["PhaseName"].ToString();
                            obj.Block = sqlDataReader["BlockName"].ToString();
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
                            obj.Status = sqlDataReader["Status"].ToString();
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
        public IEnumerable<LeadsModel> GetAssignedLeads(string UserId)
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
                        sqlCommand.CommandText = Database.Get_Assigned_Leads;
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
                            obj.City = sqlDataReader["CityName"].ToString();
                            obj.Project = sqlDataReader["ProjectName"].ToString();
                            obj.Phase = sqlDataReader["PhaseName"].ToString();
                            obj.Block = sqlDataReader["BlockName"].ToString();
                            obj.PropertyType = sqlDataReader["PropertyType"].ToString();
                            obj.HomeType = sqlDataReader["HomeType"].ToString();
                            obj.MinBudget = Convert.ToDecimal(sqlDataReader["MinBudget"]);
                            obj.MaxBudget = Convert.ToDecimal(sqlDataReader["MaxBudget"]);
                            obj.MinArea = Convert.ToDecimal(sqlDataReader["MinArea"]);
                            obj.MaxArea = Convert.ToDecimal(sqlDataReader["MaxArea"]);
                            obj.AreaType = sqlDataReader["AreaType"].ToString();
                            obj.LeadPriority = sqlDataReader["LeadPriority"].ToString();
                            obj.ClientType = sqlDataReader["ClientType"].ToString();
                            obj.AllocatedUser = sqlDataReader["AllocatedUser"].ToString();
                            obj.Beds = Convert.ToInt32(sqlDataReader["Beds"]);
                            obj.Source = sqlDataReader["Source"].ToString();
                            obj.Status = sqlDataReader["Status"].ToString();
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
        public IEnumerable<UserModel> GetAllUsers()
        {
            List<UserModel> objList = new List<UserModel>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(_connectionString, con))
                {
                    try
                    {
                        if (sqlCommand.Connection.State != System.Data.ConnectionState.Open)
                            sqlCommand.Connection.Open();
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandText = Database.GET_ALL_USERS;
                        //sqlCommand.Parameters.Add(new SqlParameter("UserId", UserId));
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                        while (sqlDataReader.Read())
                        {
                            UserModel obj = new UserModel();
                            obj.Id = sqlDataReader["Id"].ToString();
                            obj.FirstName = sqlDataReader["FirstName"].ToString() +" " + sqlDataReader["LastName"].ToString();
                            obj.LastName = sqlDataReader["LastName"].ToString();
                            obj.Email = sqlDataReader["Email"].ToString();
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
        public LeadsModel GETLeadById(int LeadId)
        {
            LeadsModel obj = new LeadsModel();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(_connectionString, con))
                {
                    try
                    {
                        if (sqlCommand.Connection.State != System.Data.ConnectionState.Open)
                            sqlCommand.Connection.Open();
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandText = Database.GET_LEAD_BY_ID;
                        sqlCommand.Parameters.Add(new SqlParameter("Id", LeadId));
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                        while (sqlDataReader.Read())
                        {
                            //LeadsModel obj = new LeadsModel();
                            obj.Id = Convert.ToInt32(sqlDataReader["Id"]);
                            obj.Name = sqlDataReader["Name"].ToString();
                            obj.Email = sqlDataReader["Email"].ToString();
                            obj.PrimaryNumber = sqlDataReader["PrimaryNumber"].ToString();
                            obj.SecoundryNumber = sqlDataReader["SecoundryNumber"].ToString();
                            obj.Address = sqlDataReader["Address"].ToString();
                            obj.LeadType = sqlDataReader["LeadType"].ToString();
                            obj.City = sqlDataReader["CityName"].ToString();
                            obj.Project = sqlDataReader["ProjectName"].ToString();
                            obj.Phase = sqlDataReader["PhaseName"].ToString();
                            obj.Block = sqlDataReader["BlockName"].ToString();
                            obj.PropertyType = sqlDataReader["PropertyType"].ToString();
                            obj.HomeType = sqlDataReader["HomeType"].ToString();
                            obj.MinBudget = Convert.ToDecimal(sqlDataReader["MinBudget"]);
                            obj.MaxBudget = Convert.ToDecimal(sqlDataReader["MaxBudget"]);
                            obj.MinArea = Convert.ToDecimal(sqlDataReader["MinArea"]);
                            obj.MaxArea = Convert.ToDecimal(sqlDataReader["MaxArea"]);
                            obj.AreaType = sqlDataReader["AreaType"].ToString();
                            obj.LeadPriority = sqlDataReader["LeadPriority"].ToString();
                            obj.ClientType = sqlDataReader["ClientType"].ToString();
                            obj.AllocatedUser = sqlDataReader["AllocatedUser"].ToString();
                            obj.Beds = Convert.ToInt32(sqlDataReader["Beds"]);
                            obj.Source = sqlDataReader["Source"].ToString();
                            obj.Status = sqlDataReader["Status"].ToString();
                            obj.CreatedOn = sqlDataReader["CreatedOn"].ToString();
                            //objList.Add(obj);
                        }
                        sqlDataReader.Close();
                        sqlCommand.Dispose();
                        return obj;
                    }
                    catch (Exception ex)
                    {
                        return new LeadsModel();
                    }
                }
            }
        }
        public int CreateLead(string PrimaryNumber)
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
                        sqlCommand.CommandText = Database.CREATE_LEADE;
                        sqlCommand.Parameters.Add(new SqlParameter("PrimaryNumber", PrimaryNumber));                        
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            brandId = Convert.ToInt32(sqlDataReader["Id"]);
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
        public int UpdateLead(LeadsModel leadsModel)
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
                        sqlCommand.CommandText = Database.UPDATE_LEAD;
                        sqlCommand.Parameters.Add(new SqlParameter("Id", leadsModel.Id));
                        sqlCommand.Parameters.Add(new SqlParameter("Name", leadsModel.Name));
                        sqlCommand.Parameters.Add(new SqlParameter("Email", leadsModel.Email));
                        sqlCommand.Parameters.Add(new SqlParameter("PrimaryNumber", leadsModel.PrimaryNumber));
                        sqlCommand.Parameters.Add(new SqlParameter("SecoundryNumber", leadsModel.SecoundryNumber));
                        sqlCommand.Parameters.Add(new SqlParameter("Address", leadsModel.Address));
                        sqlCommand.Parameters.Add(new SqlParameter("LeadType", leadsModel.LeadType));
                        sqlCommand.Parameters.Add(new SqlParameter("CityId", leadsModel.City));
                        sqlCommand.Parameters.Add(new SqlParameter("ProjectId", leadsModel.Project));
                        sqlCommand.Parameters.Add(new SqlParameter("PhaseId", 1));
                        sqlCommand.Parameters.Add(new SqlParameter("BlockId", leadsModel.Block));
                        sqlCommand.Parameters.Add(new SqlParameter("PropertyType", leadsModel.PropertyType));
                        sqlCommand.Parameters.Add(new SqlParameter("HomeType", leadsModel.HomeType));
                        sqlCommand.Parameters.Add(new SqlParameter("MinBudget", leadsModel.MinBudget));
                        sqlCommand.Parameters.Add(new SqlParameter("MaxBudget", leadsModel.MaxBudget));
                        sqlCommand.Parameters.Add(new SqlParameter("AreaType", leadsModel.AreaType));
                        sqlCommand.Parameters.Add(new SqlParameter("MinArea", leadsModel.MinArea));
                        sqlCommand.Parameters.Add(new SqlParameter("MaxArea", leadsModel.MaxArea));
                        sqlCommand.Parameters.Add(new SqlParameter("LeadPriority", leadsModel.LeadPriority));
                        sqlCommand.Parameters.Add(new SqlParameter("ClientType", leadsModel.ClientType));
                        sqlCommand.Parameters.Add(new SqlParameter("AllocatedUser", leadsModel.AllocatedUser));
                        sqlCommand.Parameters.Add(new SqlParameter("Beds", leadsModel.Beds));
                        sqlCommand.Parameters.Add(new SqlParameter("Status", leadsModel.Status));
                        sqlCommand.Parameters.Add(new SqlParameter("Source", leadsModel.Source));
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            brandId = Convert.ToInt32(sqlDataReader["Id"]);
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
        public bool UpdateLeadStatus(int leadId , string Status)
        {            
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(_connectionString, con))
                {
                    try
                    {
                        if (sqlCommand.Connection.State != System.Data.ConnectionState.Open)
                            sqlCommand.Connection.Open();
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandText = Database.UPDATE_LEAD_STATUS;
                        sqlCommand.Parameters.Add(new SqlParameter("LeadId", leadId));
                        sqlCommand.Parameters.Add(new SqlParameter("Status", Status));
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Dispose();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }
        public bool SahreLead(int leadId, string UserId)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(_connectionString, con))
                {
                    try
                    {
                        if (sqlCommand.Connection.State != System.Data.ConnectionState.Open)
                            sqlCommand.Connection.Open();
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandText = Database.SAHRE_LEAD;
                        sqlCommand.Parameters.Add(new SqlParameter("LeadId", leadId));
                        sqlCommand.Parameters.Add(new SqlParameter("UserId", UserId));
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.Dispose();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }

    }
}