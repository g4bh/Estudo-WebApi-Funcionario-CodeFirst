using Microsoft.EntityFrameworkCore;
using WebApi_Projeto_Funcionarios.Models;

namespace WebApi_Projeto_Funcionarios.DataContext
{
    public class ApplicattionDbContext : DbContext
    {
        public ApplicattionDbContext(DbContextOptions<ApplicattionDbContext> options) : base(options)
        {}

        public DbSet<FuncionarioModel> Funcionarios { get; set; } 
    }
}
