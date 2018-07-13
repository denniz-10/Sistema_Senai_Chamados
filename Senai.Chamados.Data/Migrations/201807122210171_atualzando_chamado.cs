namespace Senai.Chamados.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atualzando_chamado : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chamados",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Titulo = c.String(),
                        Descricao = c.String(),
                        Setor = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        IdUsuario = c.Guid(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.IdUsuario, cascadeDelete: true)
                .Index(t => t.IdUsuario);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Telefone = c.String(),
                        Cpf = c.String(maxLength: 11),
                        Senha = c.String(nullable: false, maxLength: 150),
                        TipoUsuario = c.Int(nullable: false),
                        Sexo = c.Int(nullable: false),
                        Cep = c.String(maxLength: 8),
                        Logradouro = c.String(),
                        Numero = c.String(),
                        Complemento = c.String(),
                        Bairro = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Chamados", "IdUsuario", "dbo.Usuarios");
            DropIndex("dbo.Chamados", new[] { "IdUsuario" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Chamados");
        }
    }
}
