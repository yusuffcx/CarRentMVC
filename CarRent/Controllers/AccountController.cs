using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRent.Models;
using CarRent.Models.ViewModels;

namespace CarRent.Controllers
{

    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        // GET: Account
        //[HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        void connectionString()
        {
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\yusuf\\source\\repos\\CarRent\\CarRent\\App_Data\\rental.mdf;Integrated Security=True;Multiple Active Result Sets=True;Application Name=EntityFramework";
        }

        public ActionResult Verify(Account acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Users where Username='"+ acc.Username +"' and password= '"+acc.Password +"'";
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                con.Close();
                return View();
            }
            else
            {
                con.Close();
                return View();
            }
        }
    }
}


