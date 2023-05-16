namespace LAB3_B.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DoctorsHopitalId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Doctors", "hospital_Id", "dbo.Hospitals");
            DropIndex("dbo.Doctors", new[] { "hospital_Id" });
            RenameColumn(table: "dbo.Doctors", name: "hospital_Id", newName: "HospitalId");
            AlterColumn("dbo.Doctors", "HospitalId", c => c.Int(nullable: false));
            CreateIndex("dbo.Doctors", "HospitalId");
            AddForeignKey("dbo.Doctors", "HospitalId", "dbo.Hospitals", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctors", "HospitalId", "dbo.Hospitals");
            DropIndex("dbo.Doctors", new[] { "HospitalId" });
            AlterColumn("dbo.Doctors", "HospitalId", c => c.Int());
            RenameColumn(table: "dbo.Doctors", name: "HospitalId", newName: "hospital_Id");
            CreateIndex("dbo.Doctors", "hospital_Id");
            AddForeignKey("dbo.Doctors", "hospital_Id", "dbo.Hospitals", "Id");
        }
    }
}
