namespace CadastroFuncionario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _long : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DadosFuncionarios", "Telefone", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DadosFuncionarios", "Telefone", c => c.Int(nullable: false));
        }
    }
}
