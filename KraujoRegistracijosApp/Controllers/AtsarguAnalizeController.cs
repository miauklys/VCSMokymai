using Microsoft.AspNetCore.Mvc;
using KraujoRegistracijosApp.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KraujoRegistracijosApp.Controllers
{
    public class AtsarguAnalizeController : Controller
    {
//        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;
//Integrated Security=True;Connect Timeout=30;Encrypt=False;
//TrustServerCertificate=False;ApplicationIntent=ReadWrite;
//MultiSubnetFailover=False";
//        public IActionResult Index()
//        {
//            return View();
//        }
//        public List<KraujoAtsarguAnalize> GetAllValuse()
//        {
//            List<KraujoAtsarguAnalize> foundValues = new List<KraujoAtsarguAnalize>();

//            string sqlStatement = "Select * FROM dbo.Values";
//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                SqlCommand command = new SqlCommand(sqlStatement, connection);
//                try
//                {
//                    connection.Open();
//                    SqlDataReader reader = command.ExecuteReader();
//                    while (reader.Read())
//                    {
//                        foundValues.Add(new KraujoAtsarguAnalize());
//                    }
//                }
//                finally
//                {
//                }
//            }

//            return foundValues;
//        }
    }
}
