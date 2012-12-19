﻿using CavemanTools.Infrastructure.MessagesBus;

namespace SqlFu.Migrations
{
    public interface IRunMigrations
    {
        void Run(params IMigrationTask[] tasks);
        IUnitOfWork StartUnitOfWork();
    }
}