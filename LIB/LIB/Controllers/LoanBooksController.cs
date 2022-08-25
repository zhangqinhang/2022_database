using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace LIB.Controllers
{
    //根据userid，返回其借阅信息：BOOK_NAME,ISBN,BOOK_ID,LOAN_TIME，STATE
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class LoanBooksController : Controller
    {
        [HttpPost]
        public string get_loan_information(string userid)
        {
            string result = "";
            var datatable = DbHelperOra.Query("select * from MY_LOAN_BOOKS where LOAN_PEOPLE="+userid);
            string JsonString = string.Empty;
            JsonString = JsonConvert.SerializeObject(datatable.Tables[0]);
            return JsonString;
        }
    }
}
