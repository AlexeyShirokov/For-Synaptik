﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace My_progect
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DeliveryEntities9 : DbContext
    {
        public DeliveryEntities9()
            : base("name=DeliveryEntities9")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Autorization> Autorization { get; set; }
        public virtual DbSet<DrinkSet> DrinkSet { get; set; }
        public virtual DbSet<ProductTraking> ProductTraking { get; set; }
        public virtual DbSet<SaladSet> SaladSet { get; set; }
        public virtual DbSet<SecondCourseSet> SecondCourseSet { get; set; }
        public virtual DbSet<SoupsSet> SoupsSet { get; set; }
        public virtual DbSet<WorkerSet> WorkerSet { get; set; }
    }
}