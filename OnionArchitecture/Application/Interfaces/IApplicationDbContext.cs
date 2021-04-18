using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IApplicationDbContext
    {

        DbSet <Product> Product { get; set; }
        Task<int> SaveChangesAsync();
    }
}
