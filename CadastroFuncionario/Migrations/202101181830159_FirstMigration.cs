namespace CadastroFuncionario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DadosFuncionarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CPF = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        Sexo = c.String(),
                        RG = c.Int(nullable: false),
                        OrgaoEmissor = c.String(),
                        DataAdmissao = c.DateTime(nullable: false),
                        DataInsert = c.DateTime(nullable: false),
                        DataUpdate = c.DateTime(),
                        Cargo_ID = c.Int(),
                        Endereco_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FuncaoFuncionarios", t => t.Cargo_ID)
                .ForeignKey("dbo.EnderecoFuncionarios", t => t.Endereco_ID)
                .Index(t => t.Cargo_ID)
                .Index(t => t.Endereco_ID);
            
            CreateTable(
                "dbo.FuncaoFuncionarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Funcao = c.String(),
                        DataInsert = c.DateTime(nullable: false),
                        DataUpdate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EnderecoFuncionarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CEP = c.Int(nullable: false),
                        Estado = c.String(),
                        Cidade = c.String(),
                        Bairro = c.String(),
                        Rua = c.String(),
                        Numero = c.Int(),
                        Complemento = c.String(),
                        DataInsert = c.DateTime(nullable: false),
                        DataUpdate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DadosFuncionarios", "Endereco_ID", "dbo.EnderecoFuncionarios");
            DropForeignKey("dbo.DadosFuncionarios", "Cargo_ID", "dbo.FuncaoFuncionarios");
            DropIndex("dbo.DadosFuncionarios", new[] { "Endereco_ID" });
            DropIndex("dbo.DadosFuncionarios", new[] { "Cargo_ID" });
            DropTable("dbo.EnderecoFuncionarios");
            DropTable("dbo.FuncaoFuncionarios");
            DropTable("dbo.DadosFuncionarios");
        }
    }
}
