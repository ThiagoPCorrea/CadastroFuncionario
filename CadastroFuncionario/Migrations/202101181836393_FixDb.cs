namespace CadastroFuncionario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DadosFuncionarios", "Telefone", c => c.Int(nullable: false));
            AddColumn("dbo.DadosFuncionarios", "CTPS", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DadosFuncionarios", "CTPS");
            DropColumn("dbo.DadosFuncionarios", "Telefone");
        }
    }
}
