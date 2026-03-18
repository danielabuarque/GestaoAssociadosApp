namespace GestaoAssociadosApp.Domain.Entities
{
    public class Equipe
    {
        #region Properties
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public DateTime DataInicioFormacao { get; set; }
        public DateTime DataPrevisaoLancamento { get; set; }
        public DateTime DataEfetivaLancamento { get; set; }
        public string DiaReuniao { get; set; } = string.Empty;
        public string HoraReuniao { get; set; } = string.Empty;
        public string ModeloReuniao { get; set; } = string.Empty;
        public string LocalReuniao { get; set; } = string.Empty;
        public string LinkReuniao { get; set; } = string.Empty;
        public bool Ativo { get; set; } = true;
        public DateTime DataInclusao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
        #endregion

        #region Relationships
        //public ICollection<AssociadoEquipe> AssociadoEquipes { get; set; }
        #endregion

    }

}
