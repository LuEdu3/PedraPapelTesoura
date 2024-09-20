bool repetirjogo = true;
int pontosusuario = 0;
int pontosmaquina = 0;

while (repetirjogo)
{

    Console.WriteLine("\nPEDRA PAPEL E TESOURA");

    Console.WriteLine("Escolha uma opcão: ");
    Console.WriteLine("Pedra");
    Console.WriteLine("Papel");
    Console.WriteLine("Tesoura");
    Console.Write("Escreva: ");
    string EscolhaDoUsuario = Console.ReadLine();

    Random aleat = new Random();
    int escolhamaquina = aleat.Next(1, 4);

    switch (escolhamaquina)
    {
        //empate
        case 1:
            if (EscolhaDoUsuario == "Pedra")
            {
                Console.WriteLine("\nUsuário escolheu pedra");
                Console.WriteLine("Máquina escolheu pedra");
                Console.WriteLine("é um empate");
            }
            else if (EscolhaDoUsuario == "Papel")
            {
                Console.WriteLine("\nUsuário escolheu papel");
                Console.WriteLine("Máquina escolheu pedra");
                Console.WriteLine("Usuário venceu");
                pontosusuario++;
                repetirjogo = false;
            }
            else if (EscolhaDoUsuario == "Tesoura")
            {
                Console.WriteLine("\nUsuário escolheu tesoura");
                Console.WriteLine("Máquina escolheu pedra");
                Console.WriteLine("Máquina venceu");
                pontosmaquina++;
            }
            break;

        case 2:
            if (EscolhaDoUsuario == "Pedra")
            {
                Console.WriteLine("\nUsuário escolheu pedra");
                Console.WriteLine("Máquina escolheu pedra");
                Console.WriteLine("é um empate");
            }
            else if (EscolhaDoUsuario == "Papel")
            {
                Console.WriteLine("\nUsuário escolheu papel");
                Console.WriteLine("Máquina escolheu pedra");
                Console.WriteLine("Usuário venceu");
                pontosusuario++;
                repetirjogo = false;
            }
            else if (EscolhaDoUsuario == "Tesoura")
            {
                Console.WriteLine("\nUsuário escolheu tesoura");
                Console.WriteLine("Máquina escolheu pedra");
                Console.WriteLine("Máquina venceu");
                pontosmaquina++;
            }
            break;
        case 3:
            if (EscolhaDoUsuario == "Pedra")
            {
                Console.WriteLine("\nUsuário escolheu pedra");
                Console.WriteLine("Maquina escolheu tesoura");
                Console.WriteLine("Usuário venceu");
                pontosusuario++;
                repetirjogo = false;
            }
            else if (EscolhaDoUsuario == "Papel")
            {
                Console.WriteLine("\nUsuário escolheu papel");
                Console.WriteLine("Maquina escolheu tesoura");
                Console.WriteLine("Máquina venceu");
                pontosmaquina++;
            }
            else if (EscolhaDoUsuario == "Tesoura")
            {
                Console.WriteLine("\nUsuário escolheu tesoura");
                Console.WriteLine("Máquina escolheu tesoura");
                Console.WriteLine("é um empate");
            }
            break;
    }
    if(repetirjogo == false)
{
    Console.WriteLine($"\nUsuário fez {pontosusuario} pontos");
    Console.WriteLine($"Máquina fez {pontosmaquina} pontos");
    Console.WriteLine("\nQuer jogar novamente?");
    Console.WriteLine("Insira S ou N");
    string jogardnv = Console.ReadLine().ToLower();
    if(jogardnv == "s")
    {
        repetirjogo = true;
        pontosmaquina = 0;
        pontosusuario = 0;
    }
}

}
