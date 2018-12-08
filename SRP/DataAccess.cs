using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciple.SRP
{
    // Data access class is only responsible for data base related 
    public class DataAccess
    {
        public static void ExecuteNonQuery(string sql)
        {
            ILogger logger = new Logger();
            try
            {
                //Execute the sql. 
                //Log the success event
                logger.Log("Command executed successfully");

            }
            catch (Exception ex)
            {
                //Log the exception message
                logger.Log(ex.Message);

            }
        }
    }
}
