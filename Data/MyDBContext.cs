using Microsoft.EntityFrameworkCore;
using Assignment_2.Models;
namespace Assignment_2.Data;

public class MyDBContext:DbContext

{
    public MyDBContext(DbContextOptions<MyDBContext> options):base(options)
    {

    }
    public DbSet<CustomerInfo> CustomerInfo { get; set; }
}
