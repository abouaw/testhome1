namespace TestHome1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(maxLength: 30),
                        Email = c.String(),
                        DateEmbauche = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
