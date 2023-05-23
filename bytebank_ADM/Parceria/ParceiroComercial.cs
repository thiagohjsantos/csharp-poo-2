using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Parceria
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Autenticar(string login, string senha)
        {
            return this.Senha == senha && this.Login == login;
        }

    }
}
