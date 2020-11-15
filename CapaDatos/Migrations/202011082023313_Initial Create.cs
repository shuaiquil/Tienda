namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id_Categoria = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id_Categoria);
            
            CreateTable(
                "dbo.Consultas",
                c => new
                    {
                        Id_Consulta = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Correo = c.String(nullable: false, maxLength: 50),
                        Asunto = c.String(nullable: false, maxLength: 20),
                        Mensaje = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id_Consulta);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        Id_Producto = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Precio = c.Single(nullable: false),
                        Url_Imagen = c.String(nullable: false, maxLength: 100),
                        EsOferta = c.Boolean(nullable: false),
                        EsDestacado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Producto);
            
            CreateTable(
                "dbo.SubCategorias",
                c => new
                    {
                        Id_Subcategoria = c.Int(nullable: false, identity: true),
                        FK_Id_Categoria = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id_Subcategoria)
                .ForeignKey("dbo.Categorias", t => t.FK_Id_Categoria, cascadeDelete: false)
                .Index(t => t.FK_Id_Categoria);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubCategorias", "FK_Id_Categoria", "dbo.Categorias");
            DropIndex("dbo.SubCategorias", new[] { "FK_Id_Categoria" });
            DropTable("dbo.SubCategorias");
            DropTable("dbo.Productos");
            DropTable("dbo.Consultas");
            DropTable("dbo.Categorias");
        }
    }
}
