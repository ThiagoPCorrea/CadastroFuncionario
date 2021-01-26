namespace CadastroFuncionario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class file : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DadosFuncionarios", "Arquivo", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DadosFuncionarios", "Arquivo");
        }
    }
}
