﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopMag.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PanasenkoMusicShopEntities : DbContext
    {
        public PanasenkoMusicShopEntities()
            : base("name=PanasenkoMusicShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admin { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Discs> Discs { get; set; }
        public virtual DbSet<Executor> Executor { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Song> Song { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}