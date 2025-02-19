using Challenge_quero_ser;


while (true)
{
    Console.Clear();
    Console.WriteLine("=== Menu de Sugestões ===");
    Console.WriteLine("1 - Menor distância de dois arrays");
    Console.WriteLine("2 - Livro de ofertas");
    Console.WriteLine("3 - Criptografia na rede do navio");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    string escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
            Console.WriteLine("Você escolheu Menor distância de dois arrays!");            
            Console.WriteLine(MenorDistancia.CalcularMenorDistancia());
            break;
        case "2":
            Console.WriteLine("Você escolheu Livro de ofertas!");           
            LivroOferta.CalcularLivroOferta(); 
            break;
        case "3":
            Console.WriteLine("Você escolheu Criptografia na rede do navio!");           
            RedeNavio.Criptografar();
            break;
        case "0":
            Console.WriteLine("Saindo...");
            return;
        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }

    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
}




