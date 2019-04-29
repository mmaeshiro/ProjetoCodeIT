namespace ProjetoCodeIT.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class baseinicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Frete",
                c => new
                    {
                        idFrete = c.Int(nullable: false, identity: true),
                        valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tempo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idFrete);
            
            CreateTable(
                "dbo.ItemViagem",
                c => new
                    {
                        idItemViagem = c.Int(nullable: false, identity: true),
                        idFrete = c.Int(nullable: false),
                        idProduto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idItemViagem)
                .ForeignKey("dbo.Frete", t => t.idFrete, cascadeDelete: true)
                .ForeignKey("dbo.Produto", t => t.idProduto, cascadeDelete: true)
                .Index(t => t.idFrete)
                .Index(t => t.idProduto);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        idProduto = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 300),
                    })
                .PrimaryKey(t => t.idProduto);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemViagem", "idProduto", "dbo.Produto");
            DropForeignKey("dbo.ItemViagem", "idFrete", "dbo.Frete");
            DropIndex("dbo.ItemViagem", new[] { "idProduto" });
            DropIndex("dbo.ItemViagem", new[] { "idFrete" });
            DropTable("dbo.Produto");
            DropTable("dbo.ItemViagem");
            DropTable("dbo.Frete");
        }
    }
}
