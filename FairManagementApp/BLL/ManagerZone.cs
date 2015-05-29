using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FairManagementApp.DAL;
using FairManagementApp.Model;
using System.Data;

namespace FairManagementApp.BLL
{
    class ManagerZone
    {
        GatewayZone objGatewayZone = new GatewayZone();
        public string SaveZoneType(Zone objZone)
        {
           int rowAffected= objGatewayZone.SaveZoneType(objZone);
           if (rowAffected > 0)
           {
               return "saved";
           }
           else
           {
               return "save failed";
           }
        }
        public DataTable ShowLIstViewItem()
        {
           return  objGatewayZone.ShowLIstViewItem();
           
        }
        public DataTable GetZoneMember()
        {
           return objGatewayZone.GetZoneMember();
        }
        public DataTable GetVisitorNumber(int ID)
        {
          return  objGatewayZone.GetVisitorNumber(ID);
        }
        public bool CheckZoneType(Zone objZoneType)
        {
            return objGatewayZone.CheckZoneType(objZoneType); 
        }

    }
}
