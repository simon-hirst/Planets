using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Planets.Data.Repositories
{
    public class SetupTaskWriteRepository : ISetupTaskWriteRepository
    {
        private readonly PlanetsContext _dbContext;

        public SetupTaskWriteRepository(PlanetsContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task SeedAsync()
        {
            var setupTableSql = @"USE [AzureStorageEmulatorDb510]
                IF object_id('dbo.PlanetsDb') is not null    
                DROP TABLE [dbo].[PlanetsDb];
            CREATE TABLE [dbo].[PlanetsDb](
                [Id] [uniqueidentifier] NOT NULL,
                [Name] [varchar](50) NULL,
                [Image] [varchar](50) NULL,
                [DistanceFromSun] [varchar](50) NULL,
                [Mass] [varchar](50) NULL,
                [Diameter] [varchar](50) NULL
                ) ON [PRIMARY]
            INSERT [dbo].[PlanetsDb] ([Id], [Name], [Image], [DistanceFromSun], [Mass], [Diameter]) VALUES (N'1a38d4c4-f387-450d-9030-111fadd7b528', N'Jupiter', N'jupiter.png', N'5.20', N'1898x10^24', N'142984')
            INSERT [dbo].[PlanetsDb] ([Id], [Name], [Image], [DistanceFromSun], [Mass], [Diameter]) VALUES (N'dee3fc49-91c0-4df2-adf2-29f600e4c84b', N'Neptune', N'neptune.png', N'30.1', N'102x10^24', N'4879')
            INSERT [dbo].[PlanetsDb] ([Id], [Name], [Image], [DistanceFromSun], [Mass], [Diameter]) VALUES (N'854fbe65-0afc-4b14-aa92-84bae7cdab4e', N'Uranus', N'uranus.png', N'19.2', N'86.8x10^24', N'12104')
            INSERT [dbo].[PlanetsDb] ([Id], [Name], [Image], [DistanceFromSun], [Mass], [Diameter]) VALUES (N'27e179a8-40c8-4cac-aad9-755edf4577f4', N'Saturn', N'saturn.png', N'9.58', N'569x10^24', N'120536')
            INSERT [dbo].[PlanetsDb] ([Id], [Name], [Image], [DistanceFromSun], [Mass], [Diameter]) VALUES (N'4602bba3-67a0-425e-a3e0-d49957ba478f', N'Mars', N'mars.png', N'1.52', N'0.642x10^24', N'6779')
            INSERT [dbo].[PlanetsDb] ([Id], [Name], [Image], [DistanceFromSun], [Mass], [Diameter]) VALUES (N'095c519f-d61a-4393-a536-2011bcf124a3', N'Earth', N'earth.png', N'1', N'5.97x10^24', N'12756')
            INSERT [dbo].[PlanetsDb] ([Id], [Name], [Image], [DistanceFromSun], [Mass], [Diameter]) VALUES (N'953d1a33-3a40-446a-a102-e6ab8e98d41c', N'Venus', N'venus.png', N'.722', N'4.87x10^24', N'12104')
            INSERT [dbo].[PlanetsDb] ([Id], [Name], [Image], [DistanceFromSun], [Mass], [Diameter]) VALUES (N'318f8a32-5168-4f36-a570-febf5c13e0a4', N'Mercury', N'mercury.png', N'.387', N'0.330x10^24', N'4879')
            ";
            await _dbContext.Database.ExecuteSqlRawAsync(setupTableSql);
        }
    }
}