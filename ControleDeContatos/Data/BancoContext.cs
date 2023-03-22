using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ControleDeContatos.Data
{
    public class BancoContext : DbContext // DbContext está recebendo options que é a variável
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
            //DbContextOptions -> parâmetro de entrada que tem como tipo BancoContext e options recebe essa informação e base(options) faz com que o DbContext recebas as informações de options
        }
        public DbSet<ContatoModel> Contatos { get; set; } // DbSet cria tabela, que recebe ContatoModel de informação e tem como nome Contatos
    }
}


