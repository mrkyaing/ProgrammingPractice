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

        public bool DeleteUMById(string Id)
        {
            try
            {
                uMDataController.DeleteUserById(Id);
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public UMModel GetUMById(string Id)
        {
            return uMDataController.GetUMById(Id);
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

        public bool UpdateUM(UMModel um)
        {
            try
            {
                uMDataController.UpdateUM(um);   
                return true;
            }catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
    }
}
