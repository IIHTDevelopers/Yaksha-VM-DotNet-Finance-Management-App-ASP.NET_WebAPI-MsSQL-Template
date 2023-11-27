

using FinanceManagementApp.DAL.Interrfaces;
using FinanceManagementApp.DAL.Services;
using FinanceManagementApp.DAL.Services.Repository;
using FinanceManagementApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace FinanceManagementApp.Tests.TestCases
{
    public class BoundaryTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IFinanceService  _financeService;
        public readonly Mock<IFinanceRepository> _financeservice = new Mock<IFinanceRepository>();

        private readonly Transaction _transaction;

        private static string type = "Boundary";

        public BoundaryTests(ITestOutputHelper output)
        {
             _financeService = new FinanceService(_financeservice.Object);

            _output = output;

            _transaction = new Transaction
            {
                TransactionId = 1,
                Amount= 50.75m,
                Category= "Groceries",
                Date= DateTime.Now,
                Type= "Expense",
                Notes= "Weekly grocery shopping",
                UserID= 1234
            };
        }

        [Fact]
        public async Task<bool> Testfor_TransactionCategory_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                _financeservice.Setup(repo => repo.AddTransactions(_transaction)).ReturnsAsync(_transaction);
                var result = await  _financeService.AddTransactions(_transaction);
                var actualLength = _transaction.Category.ToString().Length;
                if (result.Category.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_TransactionType_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                _financeservice.Setup(repo => repo.AddTransactions(_transaction)).ReturnsAsync(_transaction);
                var result = await  _financeService.AddTransactions(_transaction);
                var actualLength = _transaction.Type.ToString().Length;
                if (result.Type.ToString().Length == actualLength)
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