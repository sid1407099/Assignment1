using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BL
{
    class BusinessLayer
    {
        public List<ProductDTO> GetAllDepartments()
        {
            try
            {
                DataAccess dalObj = new DataAccess();
                List<ProductDTO> results = dalObj.Fetch();
                return results;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
