using System;

class Program
{
    static void Main(string[] args)
    {
        bool ax = false;

        while (!ax)
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Seja bem-vindo, à clinica veterinária Borrapintcher, você está no menu principal!");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("1 - Cadastros");
            Console.WriteLine("2 - Relatórios");
            Console.WriteLine("0 - SAIR");

            Console.Write("Digite a opção desejada: ");
            string menuPrincipal = Console.ReadLine();

            switch (menuPrincipal)
            {
                case "1":
                    bool SairCadastros = false;
                    while (!SairCadastros)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Você está no menu de CADASTROS");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("1 - Médicos");
                        Console.WriteLine("2 - Animais");
                        Console.WriteLine("3 - Atendimentos");
                        Console.WriteLine("4 - Voltar para o Menu Principal");

                        Console.Write("Selecione uma opção para realizar o cadastro: ");
                        string CadastrosMenu = Console.ReadLine();

                        switch (CadastrosMenu)
                        {
                            case "1":
                                Console.WriteLine("----------------------------------------");
                                Console.WriteLine("Você está no cadastros de Médicos");
                                Console.WriteLine("----------------------------------------");
                                Console.WriteLine("Por favor, informe nome do médico a ser cadastrado:");
                                string nomeMedico = Console.ReadLine();
                                Console.WriteLine("Por favor, informe o CPF do médico a ser cadastrado:");
                                string cpfMedico = Console.ReadLine();
                                Console.WriteLine("Por favor, informe o CRM do médico a ser cadastrado:");
                                string CRM = Console.ReadLine();

                                Console.WriteLine($"O médico {nomeMedico}, CPF {cpfMedico} e CRM 0{CRM} foi cadastrado com sucesso!");
                                break;
                            case "2":
                                Console.WriteLine("---------------------------");
                                Console.WriteLine("Cadastro de animais");
                                Console.WriteLine("---------------------------");
                                Console.WriteLine("Selecione o tipo de animal que deseja cadastrar:");
                                Console.WriteLine("1 - Gato");
                                Console.WriteLine("2 - Cachorro");
                                Console.WriteLine("3 - Cavalo");
                                Console.WriteLine("4 - Outro");
                                Console.WriteLine("5 - Voltar para o menu Cadastros");
                                string TipoAnimal = Console.ReadLine();

                                switch (TipoAnimal)
                                {

                                    case "1":

                                        Console.WriteLine("Informe o nome de seu Gato");
                                        string nomeGato = Console.ReadLine();
                                        Console.WriteLine($"Qual o problema com seu Gato {nomeGato}?");
                                        string problemaGato = Console.ReadLine();
                                        Console.WriteLine($"{nomeGato} foi cadastrado em nosso sistema, leve-o à clinica mais próxima!");

                                        break;

                                    case "2":

                                        Console.WriteLine("Informe o nome de seu Cachorro");
                                        string nomeCachorro = Console.ReadLine();
                                        Console.WriteLine($"Qual o problema com seu Cachorro {nomeCachorro}?");
                                        string problemaCachorro = Console.ReadLine();
                                        Console.WriteLine($"{nomeCachorro} foi cadastrado em nosso sistema, leve-o à clinica mais próxima!");

                                        break;

                                    case "3":

                                        Console.WriteLine("Informe o nome de seu Cavalo");
                                        string nomeCavalo = Console.ReadLine();
                                        Console.WriteLine($"Qual o problema com seu Cavalo {nomeCavalo}?");
                                        string problemaCavalo = Console.ReadLine();
                                        Console.WriteLine($"{nomeCavalo} foi cadastrado em nosso sistema, leve-o à clinica mais próxima!");

                                        break;

                                    case "4":
                                        Console.WriteLine("Qual é o seu animal?");
                                        string OutroAnimal = Console.ReadLine();
                                        Console.WriteLine($"Qual é o nome de seu {OutroAnimal}:");
                                        string nomeDiferente = Console.ReadLine();
                                        Console.WriteLine($"Qual o problema com seu pet {nomeDiferente}?");
                                        Console.WriteLine($"Seu {OutroAnimal} {nomeDiferente} foi cadastrado em nosso sistema, leve-o à clinica mais próxima!");
                                        break;

                                    default:
                                        Console.WriteLine("Opção inválida, por favor, Tente novamente.");
                                        break;
                                }
                                break;
                            case "3":
                                Console.WriteLine("-------------------------------------------");
                                Console.WriteLine("Você está no menu de Atendimentos");
                                Console.WriteLine("-------------------------------------------");
                                Console.WriteLine("Por favor, informe a data desejada para o atendimento de seu animal:");
                                string dataAtendimento = Console.ReadLine();
                                Console.WriteLine($"Atendimento agendado para a data {dataAtendimento}, por favor, entre em contato com a nossa clinica para agendarmos o melhor horário!");

                                break;
                            case "4":
                                Console.WriteLine("Voltando para o Menu Principal...");
                                SairCadastros = true;
                                break;
                            default:
                                Console.WriteLine("Opção inválida, por favor, Tente novamente.");
                                break;
                        }

                        Console.WriteLine();
                    }
                    break;
                case "2":
                    bool sairMenuRelatorios = false;
                    while (!sairMenuRelatorios)
                    {
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Você está no menu RELATÓRIOS");
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("1 - Animais");
                        Console.WriteLine("2 - Atendimentos");
                        Console.WriteLine("3 - Voltar para o Menu Principal");

                        Console.Write("Escolha uma opção: ");
                        string menuRelatos = Console.ReadLine();

                        switch (menuRelatos)
                        {
                            case "1":
                                Console.WriteLine("------------------------------------------");
                                Console.WriteLine("você está no menu de Relatório de Animais");
                                Console.WriteLine("------------------------------------------");
                                Console.WriteLine("Por favor, informe o nome do seu pet:");
                                string nomeAnimalRelatorio = Console.ReadLine();

                                Console.WriteLine($"Está tudo bem com o seu pet {nomeAnimalRelatorio}, já pode retirá-lo(a) em nossa clinica.");
                                break;
                            case "2":
                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("você está no menu de Relatório de Atendimentos");
                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("Por favor, informe o nome do seu pet:");
                                string nomeAnimalAtendimento = Console.ReadLine();

                                Console.WriteLine($"Foram aplicadas 2 benzetacil em {nomeAnimalAtendimento}, e ele ficou bem novamente!.");
                                break;
                            case "3":
                                Console.WriteLine("Voltando para o Menu Principal...");
                                sairMenuRelatorios = true;
                                break;
                            default:
                                Console.WriteLine("Opção inválida, por favor, Tente novamente.");
                                break;
                        }

                        Console.WriteLine();
                    }
                    break;
                case "0":
                    Console.WriteLine("Saindo do programa...");
                    ax = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida, por favor, Tente novamente.");
                    break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Programa encerrado.");
    }
};