﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API2.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Diagnoz> Diagnoz { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<history_store> history_store { get; set; }
        public virtual DbSet<Karta> Karta { get; set; }
        public virtual DbSet<Klinika> Klinika { get; set; }
        public virtual DbSet<Lecheniye> Lecheniye { get; set; }
        public virtual DbSet<Obsledovaniye> Obsledovaniye { get; set; }
        public virtual DbSet<Oplata> Oplata { get; set; }
        public virtual DbSet<Pasport> Pasport { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Pol> Pol { get; set; }
        public virtual DbSet<POLIS> POLIS { get; set; }
        public virtual DbSet<Priem> Priem { get; set; }
        public virtual DbSet<Raspisanie> Raspisanie { get; set; }
        public virtual DbSet<Rayon> Rayon { get; set; }
        public virtual DbSet<Slozhnost> Slozhnost { get; set; }
        public virtual DbSet<Smena> Smena { get; set; }
        public virtual DbSet<SNILS> SNILS { get; set; }
        public virtual DbSet<Specialnost> Specialnost { get; set; }
        public virtual DbSet<Strana> Strana { get; set; }
        public virtual DbSet<Summa> Summa { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Uslugi> Uslugi { get; set; }
        public virtual DbSet<Visits> Visits { get; set; }
        public virtual DbSet<Zhaloba> Zhaloba { get; set; }
    }
}
