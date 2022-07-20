using SNC_WCFService.Context;
using SNC_WCFService.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SNC_WCFService.Services
{
    public class EmployeeService : IEmployeeService
    {
        private MainCTX _mainCTX = new MainCTX();

        public Response<string> AddEmpoyee(EmployeeModel employee)
        {
            try
            {
                _mainCTX.Employees.Add(employee);
                _mainCTX.SaveChanges();
                return new Response<string>($"Employee {employee.GetFullName()} is deleted.");
            }
            catch (Exception ex)
            {
                return new Response<string>(ex);
            }
        }

        public Response<string> DeleteEmpoyee(Guid id)
        {
            try
            {
                EmployeeModel employee = _mainCTX.Employees.First((emp) => emp.ID == id);
                _mainCTX.Employees.Remove(employee);
                _mainCTX.SaveChanges();
                return new Response<string>($"Employee {employee.GetFullName()} is deleted.");
            }
            catch (Exception ex)
            {
                return new Response<string>(ex);
            }
        }

        public Response<IEnumerable<EmployeeModel>> GetEmpoyes()
        {
            try
            {
                return new Response<IEnumerable<EmployeeModel>>(_mainCTX.Employees);
            }
            catch (Exception ex)
            {
                return new Response<IEnumerable<EmployeeModel>>(ex);
            }
        }

        public Response<string> UpdateEmpoyee(EmployeeModel employee)
        {
            try
            {
                EmployeeModel toUpdateEmployee = _mainCTX.Employees.First((emp) => emp.ID == employee.ID);

                toUpdateEmployee.FirstName = employee.FirstName;
                toUpdateEmployee.LastName = employee.LastName;
                toUpdateEmployee.Patronymic = employee.Patronymic;
                toUpdateEmployee.DRFO = employee.DRFO;
                toUpdateEmployee.PhoneNumber = employee.PhoneNumber;
                toUpdateEmployee.Email = employee.Email;
                toUpdateEmployee.UpdateDate = DateTime.Now;

                _mainCTX.SaveChanges();
                return new Response<string>($"Employee {toUpdateEmployee.GetFullName()} is updated.");
            }
            catch (Exception ex)
            {
                return new Response<string>(ex);
            }
        }
    }
}
