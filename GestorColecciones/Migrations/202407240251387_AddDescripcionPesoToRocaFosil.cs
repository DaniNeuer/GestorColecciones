namespace GestorColecciones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescripcionPesoToRocaFosil : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fosils", "Peso", c => c.Double(nullable: false));
            AddColumn("dbo.Fosils", "Ubicacion", c => c.String(nullable: false));
            AddColumn("dbo.Fosils", "Descripcion", c => c.String(nullable: false));
            AddColumn("dbo.Rocas", "Peso", c => c.Double(nullable: false));
            AddColumn("dbo.Rocas", "Descripcion", c => c.String(nullable: false));
            AlterColumn("dbo.Fosils", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Fosils", "Especie", c => c.String(nullable: false));
            AlterColumn("dbo.Fosils", "Periodo", c => c.String(nullable: false));
            AlterColumn("dbo.Rocas", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Rocas", "Tipo", c => c.String(nullable: false));
            AlterColumn("dbo.Rocas", "Ubicacion", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rocas", "Ubicacion", c => c.String());
            AlterColumn("dbo.Rocas", "Tipo", c => c.String());
            AlterColumn("dbo.Rocas", "Nombre", c => c.String());
            AlterColumn("dbo.Fosils", "Periodo", c => c.String());
            AlterColumn("dbo.Fosils", "Especie", c => c.String());
            AlterColumn("dbo.Fosils", "Nombre", c => c.String());
            DropColumn("dbo.Rocas", "Descripcion");
            DropColumn("dbo.Rocas", "Peso");
            DropColumn("dbo.Fosils", "Descripcion");
            DropColumn("dbo.Fosils", "Ubicacion");
            DropColumn("dbo.Fosils", "Peso");
        }
    }
}
