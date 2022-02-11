using Microsoft.EntityFrameworkCore;
using Provedor2.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Provedor2.WebAPI.Context
{
    public class Provedor2Context : DbContext
    {
        public Provedor2Context(DbContextOptions<Provedor2Context> options):base(options)
        {

        }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }


    }
}
