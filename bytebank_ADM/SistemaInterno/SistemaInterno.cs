namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string login, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(login, senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas vindas ao nosso sistema.");
                return true;
            }
            else
            {
                Console.WriteLine("Senha ou login incorreto!");
                return false;
            }
        }


    }
}
