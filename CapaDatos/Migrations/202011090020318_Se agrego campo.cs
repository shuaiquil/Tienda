namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seagregocampo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categorias", "Tiene_SubCategoria", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categorias", "Tiene_SubCategoria");
        }
    }
}
