﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CadenaRestaurantes.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbModels : DbContext
    {
        public DbModels()
            : base("name=DbModels")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<DetalleOrdenes> DetalleOrdenes { get; set; }
        public DbSet<Ordenes> Ordenes { get; set; }
        public DbSet<Platillos> Platillos { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
