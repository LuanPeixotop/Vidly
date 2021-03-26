namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeNames : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes set Name = 'Pague pelo uso' where DurationInMonths = 0");
            Sql("Update MembershipTypes set Name = 'Mensal' where DurationInMonths = 1");
            Sql("Update MembershipTypes set Name = 'Trimestral' where DurationInMonths = 3");
            Sql("Update MembershipTypes set Name = 'Anual' where DurationInMonths = 12");
        }
        
        public override void Down()
        {
        }
    }
}
