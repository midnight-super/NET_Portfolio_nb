﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Core.Entities;
using Portfolio.Core.Data.Baseline;

namespace Portfolio.Core.Data.Configurations
{
    public class ProjectSkillConfiguration : IEntityTypeConfiguration<ProjectSkill>
    {
        public void Configure(EntityTypeBuilder<ProjectSkill> builder)
        {
            builder.HasData(
                new ProjectSkill { Id = 1, ProjectId = ProjectData.Adsscore.Id, SkillId = SkillData.JavaEE.Id },
                new ProjectSkill { Id = 2, ProjectId = ProjectData.Adsscore.Id, SkillId = SkillData.HTML.Id },
                new ProjectSkill { Id = 3, ProjectId = ProjectData.Adsscore.Id, SkillId = SkillData.CSS.Id },
                new ProjectSkill { Id = 4, ProjectId = ProjectData.Adsscore.Id, SkillId = SkillData.MySQL.Id },
                new ProjectSkill { Id = 5, ProjectId = ProjectData.Adsscore.Id, SkillId = SkillData.GlassFish.Id },
                new ProjectSkill { Id = 6, ProjectId = ProjectData.Adsscore.Id, SkillId = SkillData.Ubuntu.Id },
                new ProjectSkill { Id = 7, ProjectId = ProjectData.Adsscore.Id, SkillId = SkillData.Bash.Id },
                new ProjectSkill { Id = 8, ProjectId = ProjectData.Adsscore.Id, SkillId = SkillData.SSH.Id },
                new ProjectSkill { Id = 9, ProjectId = ProjectData.Adsscore.Id, SkillId = SkillData.JavaScript.Id },
                new ProjectSkill { Id = 10, ProjectId = ProjectData.Adsscore.Id, SkillId = SkillData.AJAX.Id },
                new ProjectSkill { Id = 11, ProjectId = ProjectData.Adsscore.Id, SkillId = SkillData.AtlassianJira.Id },
                new ProjectSkill { Id = 12, ProjectId = ProjectData.Adsscore.Id, SkillId = SkillData.EJB.Id },
                new ProjectSkill { Id = 13, ProjectId = ProjectData.Adsscore.Id, SkillId = SkillData.Git.Id },
                new ProjectSkill { Id = 14, ProjectId = ProjectData.Adsscore.Id, SkillId = SkillData.GitHub.Id },
                new ProjectSkill { Id = 15, ProjectId = ProjectData.Adsscore.Id, SkillId = SkillData.JDBC.Id },
                new ProjectSkill { Id = 16, ProjectId = ProjectData.Adsscore.Id, SkillId = SkillData.JQuery.Id },
                new ProjectSkill { Id = 17, ProjectId = ProjectData.Adsscore.Id, SkillId = SkillData.JSON.Id },
                new ProjectSkill { Id = 18, ProjectId = ProjectData.Adsscore.Id, SkillId = SkillData.SQL.Id },
                new ProjectSkill { Id = 19, ProjectId = ProjectData.AdssetsSysAdmin.Id, SkillId = SkillData.Linux.Id },
                new ProjectSkill { Id = 20, ProjectId = ProjectData.AdssetsSysAdmin.Id, SkillId = SkillData.Ubuntu.Id },
                new ProjectSkill { Id = 21, ProjectId = ProjectData.AdssetsSysAdmin.Id, SkillId = SkillData.MySQL.Id },
                new ProjectSkill { Id = 22, ProjectId = ProjectData.AdssetsSysAdmin.Id, SkillId = SkillData.ShellScript.Id },
                new ProjectSkill { Id = 23, ProjectId = ProjectData.AdssetsSysAdmin.Id, SkillId = SkillData.Bash.Id },
                new ProjectSkill { Id = 24, ProjectId = ProjectData.AdssetsSysAdmin.Id, SkillId = SkillData.Python.Id },
                new ProjectSkill { Id = 25, ProjectId = ProjectData.AdssetsSysAdmin.Id, SkillId = SkillData.GlassFish.Id },
                new ProjectSkill { Id = 26, ProjectId = ProjectData.AdssetsSysAdmin.Id, SkillId = SkillData.NGINX.Id },
                new ProjectSkill { Id = 27, ProjectId = ProjectData.AdssetsSysAdmin.Id, SkillId = SkillData.BackupRestore.Id },
                new ProjectSkill { Id = 28, ProjectId = ProjectData.AdssetsSysAdmin.Id, SkillId = SkillData.Cron.Id },
                new ProjectSkill { Id = 29, ProjectId = ProjectData.AdssetsSysAdmin.Id, SkillId = SkillData.AtlassianJira.Id },
                new ProjectSkill { Id = 30, ProjectId = ProjectData.DataGatherer.Id, SkillId = SkillData.Bash.Id },
                new ProjectSkill { Id = 31, ProjectId = ProjectData.DataGatherer.Id, SkillId = SkillData.EJB.Id },
                new ProjectSkill { Id = 32, ProjectId = ProjectData.DataGatherer.Id, SkillId = SkillData.Git.Id },
                new ProjectSkill { Id = 33, ProjectId = ProjectData.DataGatherer.Id, SkillId = SkillData.GlassFish.Id },
                new ProjectSkill { Id = 34, ProjectId = ProjectData.DataGatherer.Id, SkillId = SkillData.JDBC.Id },
                new ProjectSkill { Id = 35, ProjectId = ProjectData.DataGatherer.Id, SkillId = SkillData.JavaEE.Id },
                new ProjectSkill { Id = 36, ProjectId = ProjectData.DataGatherer.Id, SkillId = SkillData.MySQL.Id },
                new ProjectSkill { Id = 37, ProjectId = ProjectData.DataGatherer.Id, SkillId = SkillData.SQL.Id },
                new ProjectSkill { Id = 38, ProjectId = ProjectData.DataGatherer.Id, SkillId = SkillData.Ubuntu.Id },
                new ProjectSkill { Id = 39, ProjectId = ProjectData.MetroMaze.Id, SkillId = SkillData.DefoldEngine.Id },
                new ProjectSkill { Id = 40, ProjectId = ProjectData.MetroMaze.Id, SkillId = SkillData.Lua.Id },
                new ProjectSkill { Id = 41, ProjectId = ProjectData.MetroMaze.Id, SkillId = SkillData.GameDesign.Id },
                new ProjectSkill { Id = 42, ProjectId = ProjectData.CardsAndLoans.Id, SkillId = SkillData.JUnit.Id },
                new ProjectSkill { Id = 43, ProjectId = ProjectData.CardsAndLoans.Id, SkillId = SkillData.JavaEE.Id },
                new ProjectSkill { Id = 44, ProjectId = ProjectData.CardsAndLoans.Id, SkillId = SkillData.OracleDatabase.Id },
                new ProjectSkill { Id = 45, ProjectId = ProjectData.CardsAndLoans.Id, SkillId = SkillData.SVN.Id },
                new ProjectSkill { Id = 46, ProjectId = ProjectData.CardsAndLoans.Id, SkillId = SkillData.Selenium.Id },
                new ProjectSkill { Id = 47, ProjectId = ProjectData.CardsAndLoans.Id, SkillId = SkillData.Scrum.Id },
                new ProjectSkill { Id = 48, ProjectId = ProjectData.CardsAndLoans.Id, SkillId = SkillData.AutomatedUITesting.Id },
                new ProjectSkill { Id = 49, ProjectId = ProjectData.CardsAndLoans.Id, SkillId = SkillData.Jenkins.Id },
                new ProjectSkill { Id = 50, ProjectId = ProjectData.SvrviveTheDeusHelix.Id, SkillId = SkillData.AgileDevelopment.Id },
                new ProjectSkill { Id = 51, ProjectId = ProjectData.SvrviveTheDeusHelix.Id, SkillId = SkillData.CSharp.Id },
                new ProjectSkill { Id = 52, ProjectId = ProjectData.SvrviveTheDeusHelix.Id, SkillId = SkillData.FMOD.Id },
                new ProjectSkill { Id = 53, ProjectId = ProjectData.SvrviveTheDeusHelix.Id, SkillId = SkillData.GameDesign.Id },
                new ProjectSkill { Id = 54, ProjectId = ProjectData.SvrviveTheDeusHelix.Id, SkillId = SkillData.Git.Id },
                new ProjectSkill { Id = 55, ProjectId = ProjectData.SvrviveTheDeusHelix.Id, SkillId = SkillData.GitLFS.Id },
                new ProjectSkill { Id = 56, ProjectId = ProjectData.SvrviveTheDeusHelix.Id, SkillId = SkillData.GitLab.Id },
                new ProjectSkill { Id = 57, ProjectId = ProjectData.SvrviveTheDeusHelix.Id, SkillId = SkillData.HTCVive.Id },
                new ProjectSkill { Id = 58, ProjectId = ProjectData.SvrviveTheDeusHelix.Id, SkillId = SkillData.NewtonVR.Id },
                new ProjectSkill { Id = 59, ProjectId = ProjectData.SvrviveTheDeusHelix.Id, SkillId = SkillData.OculusRift.Id },
                new ProjectSkill { Id = 60, ProjectId = ProjectData.SvrviveTheDeusHelix.Id, SkillId = SkillData.Prototyping.Id },
                new ProjectSkill { Id = 61, ProjectId = ProjectData.SvrviveTheDeusHelix.Id, SkillId = SkillData.Scrum.Id },
                new ProjectSkill { Id = 62, ProjectId = ProjectData.SvrviveTheDeusHelix.Id, SkillId = SkillData.Sourcetree.Id },
                new ProjectSkill { Id = 63, ProjectId = ProjectData.SvrviveTheDeusHelix.Id, SkillId = SkillData.SteamVR.Id },
                new ProjectSkill { Id = 64, ProjectId = ProjectData.SvrviveTheDeusHelix.Id, SkillId = SkillData.Steamworks.Id },
                new ProjectSkill { Id = 65, ProjectId = ProjectData.SvrviveTheDeusHelix.Id, SkillId = SkillData.Unity3D.Id },
                new ProjectSkill { Id = 66, ProjectId = ProjectData.SvrviveTheDeusHelix.Id, SkillId = SkillData.Viveport.Id },
                new ProjectSkill { Id = 67, ProjectId = ProjectData.SvrviveTheDeusHelix.Id, SkillId = SkillData.VirtualReality.Id },
                new ProjectSkill { Id = 68, ProjectId = ProjectData.ZpazeWavez.Id, SkillId = SkillData.Unity3D.Id },
                new ProjectSkill { Id = 69, ProjectId = ProjectData.ZpazeWavez.Id, SkillId = SkillData.CSharp.Id },
                new ProjectSkill { Id = 70, ProjectId = ProjectData.ZpazeWavez.Id, SkillId = SkillData.FLStudio.Id },
                new ProjectSkill { Id = 71, ProjectId = ProjectData.ZpazeWavez.Id, SkillId = SkillData.FMOD.Id },
                new ProjectSkill { Id = 72, ProjectId = ProjectData.ZpazeWavez.Id, SkillId = SkillData.GameDesign.Id },
                new ProjectSkill { Id = 73, ProjectId = ProjectData.SvrviveClassified1.Id, SkillId = SkillData.CSharp.Id },
                new ProjectSkill { Id = 74, ProjectId = ProjectData.SvrviveClassified1.Id, SkillId = SkillData.GameDesign.Id },
                new ProjectSkill { Id = 75, ProjectId = ProjectData.SvrviveClassified1.Id, SkillId = SkillData.HTCVive.Id },
                new ProjectSkill { Id = 76, ProjectId = ProjectData.SvrviveClassified1.Id, SkillId = SkillData.OculusRift.Id },
                new ProjectSkill { Id = 77, ProjectId = ProjectData.SvrviveClassified1.Id, SkillId = SkillData.ProjectManagement.Id },
                new ProjectSkill { Id = 78, ProjectId = ProjectData.SvrviveClassified1.Id, SkillId = SkillData.Prototyping.Id },
                new ProjectSkill { Id = 79, ProjectId = ProjectData.SvrviveClassified1.Id, SkillId = SkillData.Unity3D.Id },
                new ProjectSkill { Id = 80, ProjectId = ProjectData.SvrviveClassified1.Id, SkillId = SkillData.VRTK.Id },
                new ProjectSkill { Id = 81, ProjectId = ProjectData.SvrviveClassified1.Id, SkillId = SkillData.VirtualReality.Id },
                new ProjectSkill { Id = 82, ProjectId = ProjectData.KartongDeathByCardboard.Id, SkillId = SkillData.AgileDevelopment.Id },
                new ProjectSkill { Id = 83, ProjectId = ProjectData.KartongDeathByCardboard.Id, SkillId = SkillData.AWS.Id },
                new ProjectSkill { Id = 84, ProjectId = ProjectData.KartongDeathByCardboard.Id, SkillId = SkillData.Git.Id },
                new ProjectSkill { Id = 85, ProjectId = ProjectData.KartongDeathByCardboard.Id, SkillId = SkillData.GitLFS.Id },
                new ProjectSkill { Id = 86, ProjectId = ProjectData.KartongDeathByCardboard.Id, SkillId = SkillData.GitLab.Id },
                new ProjectSkill { Id = 87, ProjectId = ProjectData.KartongDeathByCardboard.Id, SkillId = SkillData.RESTAPI.Id },
                new ProjectSkill { Id = 88, ProjectId = ProjectData.KartongDeathByCardboard.Id, SkillId = SkillData.Scrum.Id },
                new ProjectSkill { Id = 89, ProjectId = ProjectData.KartongDeathByCardboard.Id, SkillId = SkillData.Sourcetree.Id },
                new ProjectSkill { Id = 90, ProjectId = ProjectData.KartongDeathByCardboard.Id, SkillId = SkillData.VirtualReality.Id },
                new ProjectSkill { Id = 91, ProjectId = ProjectData.KrystalKartAr.Id, SkillId = SkillData.AWS.Id },
                new ProjectSkill { Id = 92, ProjectId = ProjectData.KrystalKartAr.Id, SkillId = SkillData.UnitTesting.Id },
                new ProjectSkill { Id = 93, ProjectId = ProjectData.KrystalKartAr.Id, SkillId = SkillData.BatchScript.Id },
                new ProjectSkill { Id = 94, ProjectId = ProjectData.KrystalKartAr.Id, SkillId = SkillData.ChaiJS.Id },
                new ProjectSkill { Id = 95, ProjectId = ProjectData.KrystalKartAr.Id, SkillId = SkillData.DatabaseModeling.Id },
                new ProjectSkill { Id = 96, ProjectId = ProjectData.KrystalKartAr.Id, SkillId = SkillData.JSON.Id },
                new ProjectSkill { Id = 97, ProjectId = ProjectData.KrystalKartAr.Id, SkillId = SkillData.Mocha.Id },
                new ProjectSkill { Id = 98, ProjectId = ProjectData.KrystalKartAr.Id, SkillId = SkillData.MySQL.Id },
                new ProjectSkill { Id = 99, ProjectId = ProjectData.KrystalKartAr.Id, SkillId = SkillData.NodeJS.Id },
                new ProjectSkill { Id = 100, ProjectId = ProjectData.KrystalKartAr.Id, SkillId = SkillData.SQL.Id },
                new ProjectSkill { Id = 101, ProjectId = ProjectData.KrystalKartAr.Id, SkillId = SkillData.TDD.Id },
                new ProjectSkill { Id = 102, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.DotNetCore.Id },
                new ProjectSkill { Id = 103, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.AJAX.Id },
                new ProjectSkill { Id = 104, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.AtlassianJira.Id },
                new ProjectSkill { Id = 105, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.AtlassianConfluence.Id },
                new ProjectSkill { Id = 106, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.Bootstrap.Id },
                new ProjectSkill { Id = 107, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.CSharp.Id },
                new ProjectSkill { Id = 108, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.CSS.Id },
                new ProjectSkill { Id = 109, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.UnitTesting.Id },
                new ProjectSkill { Id = 110, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.EF.Id },
                new ProjectSkill { Id = 111, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.FluentAssertions.Id },
                new ProjectSkill { Id = 112, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.Git.Id },
                new ProjectSkill { Id = 113, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.GitExtensions.Id },
                new ProjectSkill { Id = 114, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.HTML.Id },
                new ProjectSkill { Id = 115, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.GulpJS.Id },
                new ProjectSkill { Id = 116, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.JavaScript.Id },
                new ProjectSkill { Id = 117, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.JQuery.Id },
                new ProjectSkill { Id = 118, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.Less.Id },
                new ProjectSkill { Id = 119, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.LINQ.Id },
                new ProjectSkill { Id = 120, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.MicrosoftVisualStudio.Id },
                new ProjectSkill { Id = 121, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.MVC.Id },
                new ProjectSkill { Id = 122, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.Razor.Id },
                new ProjectSkill { Id = 123, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.RegularExpressions.Id },
                new ProjectSkill { Id = 124, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.SQLServer.Id },
                new ProjectSkill { Id = 125, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.TSQL.Id },
                new ProjectSkill { Id = 126, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.UML.Id },
                new ProjectSkill { Id = 127, ProjectId = ProjectData.KammarkollegietsTolkavropstjänst.Id, SkillId = SkillData.XUnit.Id },
                new ProjectSkill { Id = 128, ProjectId = ProjectData.AutonomousStockAnalysisTool.Id, SkillId = SkillData.Stocks.Id },
                new ProjectSkill { Id = 129, ProjectId = ProjectData.AutonomousStockAnalysisTool.Id, SkillId = SkillData.StockAnalysis.Id },
                new ProjectSkill { Id = 130, ProjectId = ProjectData.AutonomousStockAnalysisTool.Id, SkillId = SkillData.Git.Id },
                new ProjectSkill { Id = 131, ProjectId = ProjectData.AutonomousStockAnalysisTool.Id, SkillId = SkillData.GitHub.Id },
                new ProjectSkill { Id = 132, ProjectId = ProjectData.AutonomousStockAnalysisTool.Id, SkillId = SkillData.Linux.Id },
                new ProjectSkill { Id = 133, ProjectId = ProjectData.AutonomousStockAnalysisTool.Id, SkillId = SkillData.Pycharm.Id },
                new ProjectSkill { Id = 134, ProjectId = ProjectData.AutonomousStockAnalysisTool.Id, SkillId = SkillData.Python.Id },
                new ProjectSkill { Id = 135, ProjectId = ProjectData.AutonomousStockAnalysisTool.Id, SkillId = SkillData.RegularExpressions.Id },
                new ProjectSkill { Id = 136, ProjectId = ProjectData.AutonomousStockAnalysisTool.Id, SkillId = SkillData.Selenium.Id },
                new ProjectSkill { Id = 137, ProjectId = ProjectData.AutonomousStockAnalysisTool.Id, SkillId = SkillData.Synology.Id },
                new ProjectSkill { Id = 138, ProjectId = ProjectData.AutonomousStockAnalysisTool.Id, SkillId = SkillData.SynologyDSM.Id },
                new ProjectSkill { Id = 139, ProjectId = ProjectData.AutonomousStockAnalysisTool.Id, SkillId = SkillData.TDD.Id },
                new ProjectSkill { Id = 140, ProjectId = ProjectData.AutonomousStockAnalysisTool.Id, SkillId = SkillData.ValueInvestment.Id },
                new ProjectSkill { Id = 141, ProjectId = ProjectData.AutonomousStockAnalysisTool.Id, SkillId = SkillData.UML.Id },
                new ProjectSkill { Id = 142, ProjectId = ProjectData.AutonomousStockAnalysisTool.Id, SkillId = SkillData.XPath.Id },
                new ProjectSkill { Id = 143, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.DotNetCore.Id },
                new ProjectSkill { Id = 144, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.AWS.Id },
                new ProjectSkill { Id = 145, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.Bash.Id },
                new ProjectSkill { Id = 146, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.CSharp.Id },
                new ProjectSkill { Id = 147, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.UnitTesting.Id },
                new ProjectSkill { Id = 148, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.FakeItEasy.Id },
                new ProjectSkill { Id = 149, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.FluentAssertions.Id },
                new ProjectSkill { Id = 150, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.HashiCorpTerraform.Id },
                new ProjectSkill { Id = 151, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.IaC.Id },
                new ProjectSkill { Id = 152, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.JavaScript.Id },
                new ProjectSkill { Id = 153, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.Linux.Id },
                new ProjectSkill { Id = 154, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.NodeJS.Id },
                new ProjectSkill { Id = 155, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.OSX.Id },
                new ProjectSkill { Id = 156, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.PostgreSQL.Id },
                new ProjectSkill { Id = 157, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.ReactJS.Id },
                new ProjectSkill { Id = 158, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.ShellScript.Id },
                new ProjectSkill { Id = 159, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.Rider.Id },
                new ProjectSkill { Id = 160, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.TeamCity.Id },
                new ProjectSkill { Id = 161, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.TDD.Id },
                new ProjectSkill { Id = 162, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.Ubuntu.Id },
                new ProjectSkill { Id = 163, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.Unity3D.Id },
                new ProjectSkill { Id = 164, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.Unix.Id },
                new ProjectSkill { Id = 165, ProjectId = ProjectData.RovioClassified1.Id, SkillId = SkillData.XUnit.Id },
                new ProjectSkill { Id = 166, ProjectId = ProjectData.Smidas.Id, SkillId = SkillData.DotNetCore.Id },
                new ProjectSkill { Id = 167, ProjectId = ProjectData.Smidas.Id, SkillId = SkillData.Stocks.Id },
                new ProjectSkill { Id = 168, ProjectId = ProjectData.Smidas.Id, SkillId = SkillData.StockAnalysis.Id },
                new ProjectSkill { Id = 169, ProjectId = ProjectData.Smidas.Id, SkillId = SkillData.AzureFunctions.Id },
                new ProjectSkill { Id = 170, ProjectId = ProjectData.Smidas.Id, SkillId = SkillData.Curl.Id },
                new ProjectSkill { Id = 171, ProjectId = ProjectData.Smidas.Id, SkillId = SkillData.Git.Id },
                new ProjectSkill { Id = 172, ProjectId = ProjectData.Smidas.Id, SkillId = SkillData.GitHub.Id },
                new ProjectSkill { Id = 173, ProjectId = ProjectData.Smidas.Id, SkillId = SkillData.MicrosoftExcel.Id },
                new ProjectSkill { Id = 174, ProjectId = ProjectData.Smidas.Id, SkillId = SkillData.RegularExpressions.Id },
                new ProjectSkill { Id = 175, ProjectId = ProjectData.Smidas.Id, SkillId = SkillData.ValueInvestment.Id },
                new ProjectSkill { Id = 176, ProjectId = ProjectData.Smidas.Id, SkillId = SkillData.XPath.Id },
                new ProjectSkill { Id = 177, ProjectId = ProjectData.DentalCareSystems.Id, SkillId = SkillData.DotNetFramework.Id },
                new ProjectSkill { Id = 178, ProjectId = ProjectData.DentalCareSystems.Id, SkillId = SkillData.AzureDevOps.Id },
                new ProjectSkill { Id = 179, ProjectId = ProjectData.DentalCareSystems.Id, SkillId = SkillData.BatchScript.Id },
                new ProjectSkill { Id = 180, ProjectId = ProjectData.DentalCareSystems.Id, SkillId = SkillData.UnitTesting.Id },
                new ProjectSkill { Id = 181, ProjectId = ProjectData.DentalCareSystems.Id, SkillId = SkillData.FakeItEasy.Id },
                new ProjectSkill { Id = 182, ProjectId = ProjectData.DentalCareSystems.Id, SkillId = SkillData.MicrosoftVisualStudio.Id },
                new ProjectSkill { Id = 183, ProjectId = ProjectData.DentalCareSystems.Id, SkillId = SkillData.SQLServer.Id },
                new ProjectSkill { Id = 184, ProjectId = ProjectData.DentalCareSystems.Id, SkillId = SkillData.TSQL.Id },
                new ProjectSkill { Id = 185, ProjectId = ProjectData.DentalCareSystems.Id, SkillId = SkillData.XUnit.Id },
                new ProjectSkill { Id = 186, ProjectId = ProjectData.Libretto2.Id, SkillId = SkillData.DotNetCore.Id },
                new ProjectSkill { Id = 187, ProjectId = ProjectData.Libretto2.Id, SkillId = SkillData.AzureDevOps.Id },
                new ProjectSkill { Id = 188, ProjectId = ProjectData.Libretto2.Id, SkillId = SkillData.CSharp.Id },
                new ProjectSkill { Id = 189, ProjectId = ProjectData.Libretto2.Id, SkillId = SkillData.Git.Id },
                new ProjectSkill { Id = 190, ProjectId = ProjectData.Libretto2.Id, SkillId = SkillData.GitExtensions.Id },
                new ProjectSkill { Id = 191, ProjectId = ProjectData.Libretto2.Id, SkillId = SkillData.ReactHooks.Id },
                new ProjectSkill { Id = 192, ProjectId = ProjectData.Libretto2.Id, SkillId = SkillData.ReactRouter.Id },
                new ProjectSkill { Id = 193, ProjectId = ProjectData.Libretto2.Id, SkillId = SkillData.Scrum.Id },
                new ProjectSkill { Id = 194, ProjectId = ProjectData.Libretto2.Id, SkillId = SkillData.SQLServer.Id },
                new ProjectSkill { Id = 195, ProjectId = ProjectData.Libretto2.Id, SkillId = SkillData.TypeScript.Id },
                new ProjectSkill { Id = 196, ProjectId = ProjectData.Libretto2.Id, SkillId = SkillData.EFCore.Id },
                new ProjectSkill { Id = 197, ProjectId = ProjectData.Libretto2.Id, SkillId = SkillData.TSQL.Id },
                new ProjectSkill { Id = 198, ProjectId = ProjectData.DentalCareSystems.Id, SkillId = SkillData.WebForms.Id },
                new ProjectSkill { Id = 199, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.DotNetCore.Id },
                new ProjectSkill { Id = 200, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.EFCore.Id },
                new ProjectSkill { Id = 201, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.PostgreSQL.Id },
                new ProjectSkill { Id = 202, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.Docker.Id },
                new ProjectSkill { Id = 203, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.DockerCompose.Id },
                new ProjectSkill { Id = 204, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.DockerHub.Id },
                new ProjectSkill { Id = 205, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.DigitalOcean.Id },
                new ProjectSkill { Id = 206, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.AutomatedBuilds.Id },
                new ProjectSkill { Id = 207, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.Blazor.Id },
                new ProjectSkill { Id = 208, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.UnitTesting.Id },
                new ProjectSkill { Id = 209, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.Ubuntu.Id },
                new ProjectSkill { Id = 210, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.ComponentBasedUIDesign.Id },
                new ProjectSkill { Id = 211, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.DomainNameAdministration.Id },
                new ProjectSkill { Id = 212, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.FakeItEasy.Id },
                new ProjectSkill { Id = 213, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.FluentAssertions.Id },
                new ProjectSkill { Id = 214, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.MicrosoftVisualStudio.Id },
                new ProjectSkill { Id = 215, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.Git.Id },
                new ProjectSkill { Id = 216, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.GitExtensions.Id },
                new ProjectSkill { Id = 217, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.GitHub.Id },
                new ProjectSkill { Id = 218, ProjectId = ProjectData.PersonalPortfolio2020.Id, SkillId = SkillData.DatabaseModeling.Id }
            );
        }
    }
}
