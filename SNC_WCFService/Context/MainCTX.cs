using SNC_WCFService.Models;
using System.Data.Entity;

namespace SNC_WCFService.Context
{
    public class MainCTX : DbContext
    {
        public MainCTX()
       : base("SNC_MainDBConnect")
        {
        }
        public DbSet<EmployeeModel> Employees { get; set; }
    }
}