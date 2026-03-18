namespace GestaoAssociadosApp.Domain.Entities
{
    public class Endereco
    {
        #region Properties
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Rua { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string CEP { get; set; } = string.Empty;
        public bool Ativo { get; set; } = true;
        public DateTime DataInclusao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
        #endregion

        #region Relationships
        public ICollection<Associado> Associados { get; set; }
        public ICollection<Empresa> Empresas { get; set; }
        #endregion
    }
}




