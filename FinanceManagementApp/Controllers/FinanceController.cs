using FinanceManagementApp.DAL.Interrfaces;
using FinanceManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FinanceManagementApp.Controllers
{
    public class FinanceController : ApiController
    {
        private readonly IFinanceService _service;
        public FinanceController(IFinanceService service)
        {
            _service = service;
        }
        public FinanceController()
        {
            // Constructor logic, if needed
        }

        [HttpPost]
        [Route("api/Finance/CreateTransaction")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateTransaction([FromBody] Transaction model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("api/Finance/UpdateTransaction")]
        public async Task<IHttpActionResult> UpdateTransaction([FromBody] Transaction model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Finance/DeleteTransaction")]
        public async Task<IHttpActionResult> DeleteTransaction(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Finance/GetTransactionById")]
        public async Task<IHttpActionResult> GetTransactionById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Finance/GetAllTransactions")]
        public async Task<IEnumerable<Transaction>> GetAllTransactions()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
