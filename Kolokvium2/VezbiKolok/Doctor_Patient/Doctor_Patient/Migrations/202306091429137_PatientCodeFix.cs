namespace Doctor_Patient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PatientCodeFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Doctors", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Hospitals", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Patients", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "Name", c => c.String());
            AlterColumn("dbo.Hospitals", "Name", c => c.String());
            AlterColumn("dbo.Doctors", "Name", c => c.String());
        }
    }
}
