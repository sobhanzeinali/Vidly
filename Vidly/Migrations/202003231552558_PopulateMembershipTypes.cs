namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.MemberShipTypes(Id,SignUpFree,DurationInMonths,DiscountRate)VALUES(1, 0, 0, 0)");
            Sql("INSERT INTO dbo.MemberShipTypes(Id,SignUpFree,DurationInMonths,DiscountRate)VALUES(2, 50, 20, 20)");
            Sql("INSERT INTO dbo.MemberShipTypes(Id,SignUpFree,DurationInMonths,DiscountRate)VALUES(3, 40, 30, 30)");
        }
        
        public override void Down()
        {
        }
    }
}
