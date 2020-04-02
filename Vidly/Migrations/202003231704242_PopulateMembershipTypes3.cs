namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes3 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.MemberShipTypes(Id,Name,SignUpFree,DurationInMonths,DiscountRate)VALUES(4,N'Iran', 0, 0, 0)");
            Sql("INSERT INTO dbo.MemberShipTypes(Id,Name,SignUpFree,DurationInMonths,DiscountRate)VALUES(5,N'Iraq', 50, 20, 20)");
            Sql("INSERT INTO dbo.MemberShipTypes(Id,Name,SignUpFree,DurationInMonths,DiscountRate)VALUES(6, N'German',40, 30, 30)");
        }
        
        public override void Down()
        {
        }
    }
}
