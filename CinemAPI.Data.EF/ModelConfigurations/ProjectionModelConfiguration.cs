﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using CinemAPI.Models;

namespace CinemAPI.Data.EF.ModelConfigurations
{
    internal sealed class ProjectionModelConfiguration : IModelConfiguration
    {
        public void Configure(DbModelBuilder modelBuilder)
        {
            EntityTypeConfiguration<Projection> projectionModel = modelBuilder.Entity<Projection>();
            projectionModel.HasKey(model => model);
            projectionModel.Property(model => model.MovieId).IsRequired();
            projectionModel.Property(model => model.RoomId).IsRequired();
            projectionModel.Property(model => model.StartDate).IsRequired();
        }
    }
}
