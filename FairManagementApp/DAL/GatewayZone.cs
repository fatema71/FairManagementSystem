using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FairManagementApp.Model;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace FairManagementApp.DAL
{
    class GatewayZone
    {
        string connectionString = ConfigurationManager.ConnectionStrings["FairDB"].ConnectionString;
        public int SaveZoneType(Zone objZone)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "insert into Zone_Table values('" + objZone.ZoneType + "')";
            connection.Open();
            SqlCommand command = new SqlCommand(query,connection);
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;

        }
        public DataTable ShowLIstViewItem()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from Zone_Table ";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;


 
        }
        public DataTable GetZoneMember()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query =  @"Select a.zone_id,a.visitor_id,b.Name,b.Email,b.Contact_Number
                            from ZoneAccess_Table a,
                            Visitor_Table b where b.ID=a.visitor_id
                            order by a.zone_id,a.visitor_id asc";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public DataTable GetVisitorNumber(int ID)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select COUNT(visitor_id)total from ZoneAccess_Table where zone_id=" + ID + "";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data; 
        }
        public bool CheckZoneType(Zone objZoneType)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "Select * from Zone_Table where Zone_Type='" + objZoneType.ZoneType + "'";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            bool exist = reader.Read();
            connection.Close();
            return exist;
        }
    }
}
