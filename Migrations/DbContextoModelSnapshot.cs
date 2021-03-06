// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using jobs_net.Servicos;

namespace jobs_net.Migrations
{
    [DbContext(typeof(DbContexto))]
    partial class DbContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("jobs_net.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar(9)")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("cidade");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("logradouro");

                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasColumnName("numero");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("pais");

                    b.HasKey("Id");

                    b.ToTable("enderecos");
                });

            modelBuilder.Entity("jobs_net.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("email");

                    b.Property<string>("EstadoCivil")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("estadoCivil");

                    b.Property<string>("Genero")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("genero");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nome");

                    b.Property<string>("Profissao")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("profissao");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("rg");

                    b.Property<string>("Telefone")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("telefone");

                    b.Property<string>("Telefone2")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("telefone2");

                    b.HasKey("Id");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("jobs_net.Models.Vaga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nome");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.HasKey("Id");

                    b.ToTable("vagas");
                });
#pragma warning restore 612, 618
        }
    }
}
