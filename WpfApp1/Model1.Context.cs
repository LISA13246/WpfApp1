﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ppEntities : DbContext
    {
        public ppEntities()
            : base("name=ppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Award> Awards { get; set; }
        public virtual DbSet<AwardsOfParticipant> AwardsOfParticipants { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<MilitaryRank> MilitaryRanks { get; set; }
        public virtual DbSet<ParticipantsOfTheWar> ParticipantsOfTheWars { get; set; }
        public virtual DbSet<ParticipantsWork> ParticipantsWorks { get; set; }
        public virtual DbSet<PlaceOfWork> PlaceOfWorks { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}