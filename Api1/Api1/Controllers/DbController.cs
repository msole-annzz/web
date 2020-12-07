using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;


namespace Api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Documents;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Docs");
            sqlCommand.Connection = sqlConnection;
            DataTable table = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(table);


            // _logger.LogInformation(DateTime.Now.ToShortDateString() + "\r\n" +
            //                        DateTime.Now.ToLongTimeString() + ": Welcome-page is visited");
            return table.Rows[0][1].ToString();
        }
    }
}
