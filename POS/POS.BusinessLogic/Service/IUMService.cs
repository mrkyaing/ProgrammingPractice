using POS.Models;
using POS.Models.ModelCollections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLogic.Service
{
    public interface IUMService
    {
        UMModelCollections getUMList();
        bool SaveUM(UMModel um);
    }

}
