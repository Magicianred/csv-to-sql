using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynelProject.ServiceLayer.Employee
{
    public interface IEmployeeService
    {
        Task SaveFileAsync(IFormFile file, string basePath);
        IEnumerable<SynelProject.Models.Employee> CsvToCollection(IFormFile file);
    }
}
