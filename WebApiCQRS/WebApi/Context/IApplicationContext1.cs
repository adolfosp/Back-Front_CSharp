using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApi.Model;

namespace WebApi.Context
{
    public interface IApplicationContext1
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChanges();
    }
}