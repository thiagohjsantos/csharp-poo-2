using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("123456");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("987456");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("74581");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("852963");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonficacao);

}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("852741");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Login = "ingr1d002";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("963741");
    ursula.Nome = "Ursula Alcantara";
    ursula.Login = "ursula#9";
    ursula.Senha = "321";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Login = "caio123";
    caio.Senha = "999";

    sistema.Logar(ingrid, "ingr1d002", "123");
    sistema.Logar(ursula, "ursula#9", "321");
    sistema.Logar(caio, "loginErrado", "999");

}



