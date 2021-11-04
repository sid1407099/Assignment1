using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BL;


namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BusinessLayer blObj = new BusinessLayer();
                List<ProductDTO> lstFinalResult = blObj.GetAllDepartments();
                foreach (var prod in lstFinalResult)
                {
                    Console.WriteLine(prod.ProductName );
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong. Our developers are working on it.Please quote the error message before when you contact customer care");
                Console.WriteLine(ex.Message);
            }
        }
    }
}


