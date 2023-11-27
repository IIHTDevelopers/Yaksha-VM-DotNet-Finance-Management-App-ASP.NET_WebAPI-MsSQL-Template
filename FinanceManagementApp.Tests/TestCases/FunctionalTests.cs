

using FinanceManagementApp.DAL.Interrfaces;
using FinanceManagementApp.DAL.Services;
using FinanceManagementApp.DAL.Services.Repository;
using FinanceManagementApp.Models;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace FinanceManagementApp.Tests.TestCases
{
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IFinanceService  _financeService;
        public readonly Mock<IFinanceRepository> _financeservice = new Mock<IFinanceRepository>();

        private readonly Transaction _transaction;

        private static string type = "Functional";

        public FunctionalTests(ITestOutputHelper output)
        {
             _financeService = new FinanceService(_financeservice.Object);

            _output = output;

            _transaction = new Transaction
            {
                TransactionId = 1,
                Amount = 50.75m,
                Category = "Groceries",
                Date = DateTime.Now,
                Type = "Expense",
                Notes = "Weekly grocery shopping",
                UserID = 1234
            };
        }


        [Fact]
        public async Task<bool> Testfor_Create_Transaction()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                _financeservice.Setup(repos => repos.AddTransactions(_transaction)).ReturnsAsync(_transaction);
                var result = await  _financeService.AddTransactions(_transaction);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        [Fact]
        public async Task<bool> Testfor_Update_Transaction()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                _financeservice.Setup(repos => repos.UpdateFinance(_transaction)).ReturnsAsync(_transaction);
                var result = await  _financeService.UpdateFinance(_transaction);
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");

            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_GetTransactionById()
        {
            //Arrange
            var res = false;
            int id = 1;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                _financeservice.Setup(repos => repos.GetTransactionById(id)).ReturnsAsync(_transaction);
                var result = await  _financeService.GetTransactionById(id);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_DeleteTransactionById()
        {
            //Arrange
            var res = false;
            int id = 1;
            bool response = true;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                _financeservice.Setup(repos => repos.DeleteTransactionById(id)).ReturnsAsync(response);
                var result = await  _financeService.DeleteTransactionById(id);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}