using Microsoft.EntityFrameworkCore;
using SafeLifeLib.Models;

namespace BD
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {

        }

        public DbSet<AgendaModel> Agendas { get; set; }
        public DbSet<AnexoModel> Anexos { get; set; }
        public DbSet<CirurgiaModel> Cirurgias { get; set; }
        public DbSet<ComentarioModel> Comentarios { get; set; }
        public DbSet<ContatoModel> Contatos { get; set; }
        public DbSet<ConteudoModel> Conteudos { get; set; }
        public DbSet<ConvenioModel> Convenios { get; set; }
        public DbSet<DadosMedicosModel> DadosMedicos { get; set; }
        public DbSet<DiaaDiaModel> DiaaDia { get; set; }
        public DbSet<DiscussaoModel> Discussoes { get; set; }
        public DbSet<ExameModel> Exames { get; set; }
        public DbSet<ForumModel> Foruns { get; set; }
        public DbSet<FuncionarioModel> Funcionarios { get; set; }
        public DbSet<LocalModel> Locais { get; set; }
        public DbSet<MedicamentoModel> Medicamentos { get; set; }
        public DbSet<NotificacaoModel> Notificacoes { get; set; }
        public DbSet<PacienteModel> Pacientes { get; set; }
        public DbSet<PatologiaModel> Patologias { get; set; }
        public DbSet<PesoModel> Pesos { get; set; }
        public DbSet<PessoaModel> Pessoas { get; set; }
        public DbSet<PressaoModel> Pressoes { get; set; }
        public DbSet<ProcedimentoModel> Procedimentos { get; set; }
        public DbSet<ProfissionalModel> Profissionais { get; set; }
        public DbSet<ProntuarioModel> Prontuarios { get; set; }
        public DbSet<ReceitaModel> Receitas { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<VacinaModel> Vacinas { get; set; }



        public void Dispose()
        {

        }
    }
}
