using System;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    class DataAccess
    {
        SqlConnection sqlConObj;
        SqlCommand sqlCmdObj;

        public DataAccess()
        {
            sqlConObj = new SqlConnection();
            sqlCmdObj = new SqlCommand();
        }

        public List<ProductDTO> Fetch()
        {
            try
            {
                sqlConObj.ConnectionString = ConfigurationManager.
                    ConnectionStrings["AdventureWorks"].ConnectionString;

                sqlCmdObj.CommandText = @"SELECT name FROM Production.Product where ListPrice>10";
                sqlCmdObj.Connection = sqlConObj;

                sqlConObj.Open();
                SqlDataReader dataReadObj = sqlCmdObj.ExecuteReader();
                //dataReadObj = sqlCmdObj.ExecuteReader();

                List<ProductDTO> lstDept = new List<ProductDTO>();

                while (dataReadObj.Read())
                {

                    lstDept.Add(new ProductDTO(){
                        ProductName = dataReadObj[0].ToString(),    

                    });
                   
                }
                
                return lstDept;
            }
            catch(Exception e)
            {
                throw e;
            }

            finally
            {

                sqlConObj.Close();
            }
        }
    }

    
}
