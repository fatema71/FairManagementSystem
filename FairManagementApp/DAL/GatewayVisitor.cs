using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FairManagementApp.Model;
using System.Configuration;
using System.Data.SqlClient;

namespace FairManagementApp.DAL
{
    class GatewayVisitor
    {
        string connectionString = ConfigurationManager.ConnectionStrings["FairDB"].ConnectionString;
        public int SaveVisitorInformation(Visitor objVisitor)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "insert into Visitor_Table values('"+objVisitor.Name+"','"+objVisitor.Email+"','"+objVisitor.ContactNumber+"')";
            connection.Open();
            SqlCommand command = new SqlCommand(query,connection);
            int rowaffected = command.ExecuteNonQuery();
            connection.Close();
            return rowaffected;
        }
        public string GetVisitorID(string email)
        {
            string id = "";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select ID from Visitor_Table  where Email='"+email+"'";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader["ID"].ToString();
            }
            connection.Close();
            return id;
        }
        public int SaveZoneAccessInformation(string visitorID, int zoneID)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "insert into [ZoneAccess_Table] values('" + visitorID + "','" + zoneID + "')";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            int rowaffected = command.ExecuteNonQuery();
            connection.Close();
            return rowaffected;
        }
        public bool CheckEmail(Visitor objVisitor)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "Select * from Visitor_Table where Email='" + objVisitor.Email + "'";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            bool exist = reader.Read();
            connection.Close();
            return exist;
        }
       
    }
}
