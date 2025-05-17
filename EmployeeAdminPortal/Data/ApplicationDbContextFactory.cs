using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using EmployeeAdminPortal.Data; // ✔️ adjust if your namespace is different

namespace EmployeeAdminPortal
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // ❗ Use your actual connection string
            optionsBuilder.UseSqlServer("Server=desktop-2tu77vp;Database=EmployeeDb;Trusted_Connection=True;TrustServerCertificate=True;");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
