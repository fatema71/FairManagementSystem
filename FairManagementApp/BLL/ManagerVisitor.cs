using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FairManagementApp.DAL;
using FairManagementApp.Model;

namespace FairManagementApp.BLL
{
    class ManagerVisitor
    {
        GatewayVisitor objGatewayVisitor = new GatewayVisitor();
        public string SaveVisitorInformation(Visitor objVisitor)
        {
           int rowAffected= objGatewayVisitor.SaveVisitorInformation(objVisitor);
           if (rowAffected > 0)
           {
               return "saved";
           }
           else
           { return "save fail";
           }
        }
        public string GetVisitorID(string email)
        {
          return  objGatewayVisitor.GetVisitorID(email);
        }
        public string SaveZoneAccessInformation(string visitorID, int zoneID)
        {
            int rowAffected = objGatewayVisitor.SaveZoneAccessInformation(visitorID, zoneID);
            if (rowAffected > 0)
            {
                return "saved successfully";
            }
            else
            {
                return "save failed";
            }
        }
        public bool CheckEmail(Visitor objVisitor)
        {
            return objGatewayVisitor.CheckEmail(objVisitor);
        }
    }
}
