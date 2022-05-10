using System;
using System.Threading;


class Jokenpo
{

    static void Main(string[] args)
    {

        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("                                       --------------------------");
        Console.WriteLine("                                       Bem vindos ao Jogo Jokenpô");
        Console.WriteLine("                                       --------------------------");
        Console.WriteLine("                                       *                        *");
        Console.WriteLine("                                       *                        *");
        Console.WriteLine("                                       *                        *");
        Console.WriteLine("                                       *                        *");
        Console.WriteLine("                                       *                        *");
        Console.WriteLine("                                   *****                        *****");
        Console.WriteLine("                                   *                                *");
        Console.WriteLine("                                   *     Digite 1 para Iniciar      *");
        Console.WriteLine("                                   *                                *");
        Console.WriteLine("                                   *     Digite 2 para Instruções   *");
        Console.WriteLine("                                   *                                *");
        Console.WriteLine("                                   *     Digite 0 para Sair         *");
        Console.WriteLine("                                   *                                *");
        Console.WriteLine("                                   **********************************");

        

        int resposta = int.Parse(Console.ReadLine());

        switch(resposta)
        {
            case 1: MenuJogar(); break;
            case 2: Instrucoes();  break;
            case 0: System.Environment.Exit(0);break;
           
          
            default:Menu();break;

        }

        static void Instrucoes()
        {
            Console.Clear();
            Console.WriteLine("                 xxxxxxxxxxxxxxxxxxx -   Historia  - xxxxxxxxxxxxx");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("                No Japão, Pedra, papel, tesoura é chamado simplesmente de Janken .");
            Console.WriteLine("                Acredita-se que Janken basea-se em dois jogos Ken mais antigos, .");
            Console.WriteLine("                Suu Ken e San Sukumi Ken. O San Sukumi Ken existiu no Japão desde tempos antigos,");
            Console.WriteLine("                e o Suu Ken foi importado da China no fim do século XVII. Os jogos Ken começaram a aumentar em popularidade em meados do século XIX.");
            Console.WriteLine("                Acredita-se que Janken foi inventado no fim do século XIX, julgando fontes textuais da época sobre jogos Ken");    
            Console.WriteLine("");
            Console.ReadKey();
            Console.WriteLine("                 xxxxxxxxxxxxxxxxxxx -   Como Jogar  - xxxxxxxxxxxxx");
            Console.WriteLine("                                                                     ");
            Menu();

        }
        

        static void MenuJogar ()
        
        {
            Console.Clear ();
            Console.WriteLine("                                   **********************************");
            Console.WriteLine("                                   *                                *");
            Console.WriteLine("                                   *     Digite 1 para Batalha      *");
            Console.WriteLine("                                   *                                *");
            Console.WriteLine("                                   *     Digite 2 para Guerra       *");
            Console.WriteLine("                                   *                                *");
            Console.WriteLine("                                   *     Digite 3 Voltar            *");
            Console.WriteLine("                                   *                                *");
            Console.WriteLine("                                   *     Digite 0 para Sair         *");
            Console.WriteLine("                                   *                                *");
            Console.WriteLine("                                   **********************************");

            int resposta = int.Parse(Console.ReadLine ());  

            switch (resposta)
            {
                case 1: Amistoso();  break;
                case 2: Campeonato();break;
                case 3: Menu(); break;
                case 0: System.Environment.Exit(0);break;            
                     
                                 
            }



            static void Amistoso ()
            {
                Console.Clear();
                Console.WriteLine("                                   **********************************");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   *      Qual é o seu nome ?       *");                
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   **********************************");
                string nome = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("                                   **********************************");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   *     Olá Menu nome é Goku.      *");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   *  Serei o seu desafiante hoje.  *");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine($"                                  *    {nome} Vamos Batalhar ?     *");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   **********************************");
                Console.Clear();
                Console.WriteLine("                                   **********************************");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   * Quantos Round é essa Batalha ? *");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   *                                *");
                Console.WriteLine("                                   **********************************");

                
                int partida  = int.Parse( Console.ReadLine());


                int usuario = 0;
                int goku1 =0 ;
                int empate = 0;
                

                //int iten = usuario + goku1;

                for (int i = 1; i <= partida;i++)

                {
                     
                    

                    Console.Clear();

                    Console.WriteLine("                                   **********************************");
                    Console.WriteLine("                                   *       Resultado Parcial        *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine($"                                  *          Partida {i -1}        *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine($"                                  *   {nome} Vitorias = {usuario}  *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine($"                                  *   Goku Vitorias = {goku1}      *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine($"                                  *    Empates = {empate}          *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine("                                   **********************************");
                    Console.ReadKey();


                    Console.Clear();
                

                    Console.WriteLine("                                   **********************************");
                    Console.WriteLine($"                                  *         Esta Pronto?           *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine($"                                  *   Digite 1 Para Pedra?         *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine($"                                  *   Digite 2 Para Papel?         *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine($"                                  *   Digite 3 Tesoura?            *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine("                                   *   Digite 0 Para Sair           *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine("                                   **********************************");
                    

                    int resposta = int.Parse(Console.ReadLine());
                    switch (resposta)
                    {
                        case 0: System.Environment.Exit(0); break;
                       

                    }


                    Random rnd = new Random();

                    int goku = rnd.Next(1, 4);                    


                    if (goku == resposta)
                    {   
                        if(goku == 1)
                        {
                            Console.WriteLine($"{nome}  - Pedra X Pedra - Goku");
                            Console.WriteLine("");
                            Console.WriteLine("Empate");
                            empate = empate + 1;
                            Console.ReadKey();
                        }
                        if (goku == 2)
                        {
                            Console.WriteLine($"{nome}   - Papel X Papel - Goku");
                            Console.WriteLine("");
                            Console.WriteLine("Empate");
                            empate = empate + 1;
                            Console.ReadKey();
                        }
                        if (goku == 3)
                        {
                            Console.WriteLine($"{nome}   - Tesoura X Tesoura - Goku");
                            Console.WriteLine("");
                            Console.WriteLine("Empate");
                            empate = empate + 1;
                            Console.ReadKey();
                        }

                    }

                    else if (resposta == 1 && goku == 2) //Pedra x Papel
                    {
                        Console.WriteLine($"{nome}  -  Pedra x  Papel - Goku ");
                        Console.WriteLine($" 1 Ponto para Goku");
                        goku1 = goku1 + 1;
                        //Console.WriteLine($"{nome} {usuario} X Goku {goku1}");
                        Console.WriteLine("");
                        Console.WriteLine("Placar");
                        Console.WriteLine("");
                        Console.WriteLine($"{nome}  {usuario} X Goku {goku1}");
                        Console.ReadKey();
                        


                    }
                    else if (resposta == 1 && goku == 3) //Pedra x Tesoura
                    {
                        Console.WriteLine($"{nome}  - Pedra x Tesoura - Goku ");
                        Console.WriteLine($" 1 Ponto para {nome}");
                        usuario = usuario + 1;
                        //Console.WriteLine($"{nome} {usuario} X Goku {goku1}");
                        Console.WriteLine("");
                        Console.WriteLine("Placar");
                        Console.WriteLine("");
                        Console.WriteLine($"{nome}  {usuario} X Goku {goku1}");
                        Console.ReadKey();
                        


                    }
                    else if (resposta == 2 && goku == 1) //Tesoura x Papel
                    {
                        Console.WriteLine($"{nome} - Tesoura x Papel -  Goku ");
                        Console.WriteLine($" 1 Ponto para {nome}");
                        usuario = usuario + 1;
                        //Console.WriteLine($"{nome} {usuario} X Goku {goku1}");
                        Console.WriteLine("");
                        Console.WriteLine("Placar");
                        Console.WriteLine("");
                        Console.WriteLine($"Jogador {usuario} X Goku {goku1}");
                        Console.ReadKey();
                        


                    }
                    else if (resposta == 2 && goku == 3) //Tesoura x Pedra
                    {
                        Console.WriteLine($"{nome} - Tesoura x Pedra - Goku ");
                        Console.WriteLine($" 1 Ponto para Goku");
                        goku1 = goku1 + 1;
                        //Console.WriteLine($"{nome} {usuario} X Goku {goku1}");
                        Console.WriteLine("");
                        Console.WriteLine("Placar");
                        Console.WriteLine("");
                        Console.WriteLine($"{nome} {usuario} X Goku {goku1}");
                        Console.ReadKey();
                        

                    }

                    else if (resposta == 3 && goku == 2) //Papel x Tesoura
                    {
                        Console.WriteLine($"{nome} - Papel x Tesoura - Goku ");
                        Console.WriteLine($" 1 Ponto para Goku");
                        goku1 = goku1 + 1;
                        //Console.WriteLine($"{nome} {usuario} X Goku {goku1}");
                        Console.WriteLine("");
                        Console.WriteLine("Placar");
                        Console.WriteLine("");
                        Console.WriteLine($"{nome} {usuario} X Goku {goku1}");
                        Console.ReadKey();
                        
                    }
                    else if (resposta == 1 && goku == 3) //Papel x Pedra
                    {
                        Console.WriteLine($"{nome} - Papel x Pedra - Goku ");
                        Console.WriteLine($" 1 Ponto para {nome}");
                        usuario = usuario + 1;
                        //Console.WriteLine($"{nome} {usuario} X Goku {goku1}");
                        Console.WriteLine("");
                        Console.WriteLine("Placar");
                        Console.WriteLine("");
                        Console.WriteLine($"Jogador {usuario} X Goku {goku1}");
                        Console.ReadKey();
                        


                    }
                    Console.ReadKey();
                    Console.Clear();







                }
                if ( usuario > goku1)
                {
                    Console.WriteLine("                                   **********************************");
                    Console.WriteLine($"                                  *        Resultado final         *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine($"                                  *   {nome} Vitorias = {usuario}  *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine($"                                  *   Goku Vitorias = {goku1}      *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine($"                                  *    Empates = {empate}          *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine("                                   **********************************");

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                                   **********************************");
                    Console.WriteLine("                                   *     Parabens você venceu.      *");
                    Console.WriteLine("                                   **********************************");
                }
                else if ( goku1> usuario)
                {
                    Console.WriteLine("                                   **********************************");
                    Console.WriteLine($"                                  *        Resultado final         *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine($"                                  *   {nome} Vitorias = {usuario}  *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine($"                                  *   Goku Vitorias = {goku1}      *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine($"                                  *    Empates = {empate}          *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine("                                   **********************************");

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                                   **********************************");
                    Console.WriteLine("                                   *          Você Perdeu           *");
                    Console.WriteLine("                                   **********************************");
                }

                else
                {
                    Console.WriteLine("                                   **********************************");
                    Console.WriteLine($"                                  *        Resultado final         *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine($"                                  *   {nome} Vitorias = {usuario}  *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine($"                                  *   Goku Vitorias = {goku1}      *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine($"                                  *    Empates = {empate}          *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine("                                   *                                *");
                    Console.WriteLine("                                   **********************************");

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                                   **********************************");
                    Console.WriteLine("                                   *            Empatou             *");
                    Console.WriteLine("                                   **********************************");
                }

                Console.ReadKey();
                Menu();



            }

                static void Campeonato()
                {


                }





        }
            


    }
}       