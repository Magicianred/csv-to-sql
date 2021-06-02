using Castle.Core.Logging;
using FakeItEasy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SynelProject.Controllers;
using SynelProject.DataLayer;
using SynelProject.Models;
using SynelProject.ServiceLayer.Employee;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SynelProject.Test
{
    public class EmployeeServiceTest
    {
        [Fact]
        public void CsvToCollection_Test()
        {
            var service = new EmployeeService();

            var dataFile = A.Fake<IFormFile>();

            var employees = service.CsvToCollection(dataFile).ToList();

            Assert.NotNull(employees);
        }

        [Fact]
        public async void SaveFile_Test()
        {
            var service = new EmployeeService();

            var dataFile = A.Fake<IFormFile>();
            var dataPath = A.Fake<string>();

            await service.SaveFileAsync(dataFile, dataPath);

            Stream stream = dataFile.OpenReadStream();
            Assert.NotNull(stream);
        }
    }
}
