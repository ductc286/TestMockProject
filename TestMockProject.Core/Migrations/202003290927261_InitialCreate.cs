namespace TestMockProject.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Claims",
                c => new
                    {
                        ClaimId = c.String(nullable: false, maxLength: 128),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ClaimId);
            
            CreateTable(
                "dbo.Project_Staff_RoleProject",
                c => new
                    {
                        Project_Staff_RoleProjectId = c.String(nullable: false, maxLength: 128),
                        ProjectId = c.String(),
                        Staff_RoleProjectId = c.String(),
                    })
                .PrimaryKey(t => t.Project_Staff_RoleProjectId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.String(nullable: false, maxLength: 128),
                        ProjectName = c.String(),
                    })
                .PrimaryKey(t => t.ProjectId);
            
            CreateTable(
                "dbo.Staff_RoleProject",
                c => new
                    {
                        Staff_RoleProjectId = c.String(nullable: false, maxLength: 128),
                        RoleProjectId = c.String(),
                        StaffId = c.String(),
                        Project_Staff_RoleProject_Project_Staff_RoleProjectId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Staff_RoleProjectId)
                .ForeignKey("dbo.Project_Staff_RoleProject", t => t.Project_Staff_RoleProject_Project_Staff_RoleProjectId)
                .Index(t => t.Project_Staff_RoleProject_Project_Staff_RoleProjectId);
            
            CreateTable(
                "dbo.RoleProjects",
                c => new
                    {
                        RoleProjectId = c.String(nullable: false, maxLength: 128),
                        RoleProjectName = c.String(),
                        Staff_RoleProject_Staff_RoleProjectId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.RoleProjectId)
                .ForeignKey("dbo.Staff_RoleProject", t => t.Staff_RoleProject_Staff_RoleProjectId)
                .Index(t => t.Staff_RoleProject_Staff_RoleProjectId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffId = c.String(nullable: false, maxLength: 128),
                        StaffName = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.StaffId);
            
            CreateTable(
                "dbo.ProjectProject_Staff_RoleProject",
                c => new
                    {
                        Project_ProjectId = c.String(nullable: false, maxLength: 128),
                        Project_Staff_RoleProject_Project_Staff_RoleProjectId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Project_ProjectId, t.Project_Staff_RoleProject_Project_Staff_RoleProjectId })
                .ForeignKey("dbo.Projects", t => t.Project_ProjectId, cascadeDelete: true)
                .ForeignKey("dbo.Project_Staff_RoleProject", t => t.Project_Staff_RoleProject_Project_Staff_RoleProjectId, cascadeDelete: true)
                .Index(t => t.Project_ProjectId)
                .Index(t => t.Project_Staff_RoleProject_Project_Staff_RoleProjectId);
            
            CreateTable(
                "dbo.StaffStaff_RoleProject",
                c => new
                    {
                        Staff_StaffId = c.String(nullable: false, maxLength: 128),
                        Staff_RoleProject_Staff_RoleProjectId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Staff_StaffId, t.Staff_RoleProject_Staff_RoleProjectId })
                .ForeignKey("dbo.Staffs", t => t.Staff_StaffId, cascadeDelete: true)
                .ForeignKey("dbo.Staff_RoleProject", t => t.Staff_RoleProject_Staff_RoleProjectId, cascadeDelete: true)
                .Index(t => t.Staff_StaffId)
                .Index(t => t.Staff_RoleProject_Staff_RoleProjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staff_RoleProject", "Project_Staff_RoleProject_Project_Staff_RoleProjectId", "dbo.Project_Staff_RoleProject");
            DropForeignKey("dbo.StaffStaff_RoleProject", "Staff_RoleProject_Staff_RoleProjectId", "dbo.Staff_RoleProject");
            DropForeignKey("dbo.StaffStaff_RoleProject", "Staff_StaffId", "dbo.Staffs");
            DropForeignKey("dbo.RoleProjects", "Staff_RoleProject_Staff_RoleProjectId", "dbo.Staff_RoleProject");
            DropForeignKey("dbo.ProjectProject_Staff_RoleProject", "Project_Staff_RoleProject_Project_Staff_RoleProjectId", "dbo.Project_Staff_RoleProject");
            DropForeignKey("dbo.ProjectProject_Staff_RoleProject", "Project_ProjectId", "dbo.Projects");
            DropIndex("dbo.StaffStaff_RoleProject", new[] { "Staff_RoleProject_Staff_RoleProjectId" });
            DropIndex("dbo.StaffStaff_RoleProject", new[] { "Staff_StaffId" });
            DropIndex("dbo.ProjectProject_Staff_RoleProject", new[] { "Project_Staff_RoleProject_Project_Staff_RoleProjectId" });
            DropIndex("dbo.ProjectProject_Staff_RoleProject", new[] { "Project_ProjectId" });
            DropIndex("dbo.RoleProjects", new[] { "Staff_RoleProject_Staff_RoleProjectId" });
            DropIndex("dbo.Staff_RoleProject", new[] { "Project_Staff_RoleProject_Project_Staff_RoleProjectId" });
            DropTable("dbo.StaffStaff_RoleProject");
            DropTable("dbo.ProjectProject_Staff_RoleProject");
            DropTable("dbo.Staffs");
            DropTable("dbo.RoleProjects");
            DropTable("dbo.Staff_RoleProject");
            DropTable("dbo.Projects");
            DropTable("dbo.Project_Staff_RoleProject");
            DropTable("dbo.Claims");
        }
    }
}
