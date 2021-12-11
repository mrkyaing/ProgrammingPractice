using POS.BusinessLogic.Service;
using POS.DAL;
using POS.Models;
using POS.Models.ModelCollections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLogic
{
    public class UMController : IUMService
    {
        UMDataController uMDataController;
        public UMController()
        {
            uMDataController = new UMDataController();
        }
        public UMModelCollections getUMList()
        {
            return uMDataController.GetUMList();
        }

        public bool SaveUM(UMModel um)
        {
            if(uMDataController.SaveUM(um)) return true;
            else return false;
        }
    }
}
