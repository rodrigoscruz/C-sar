using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            //Variáveis 
            string palavra = "";   //comporta a mensagem
            string encrypt = "";   //comporta a mensagem criptografada, ou descriptografada
            string result = "";	   //recebe a variável "palavra" no "case 1 e 2"
            string resul = ""; 	   //recebe a variável "encrypt" no "case 1"
            int chave = 0;         //comporta a chave da senha 
            int chav = 0;	   //soma chave do caso anterior, com a nova chave, dada pelo usuário

            //Pergunta para o usuário o que ele deseja que seja executado
            Console.Write("|---------------------------------|\n");
            Console.Write("| 1 - Criptografar um mensagem    |\n");
            Console.Write("| 2 - Descriptografar uma mensagem|\n");
            Console.Write("| 0 - Sair                        |\n");
            Console.Write("|---------------------------------|\n");
            Console.Write("Escolha a opção: ");
            

            //Converte para "opção" para inteiro
            int opcao = int.Parse(Console.ReadLine());

            do
            {

                encrypt = "";
                
                //depois da conversão o switch verifica a opcao digitada
                switch (opcao)

                {

                    //caso a opção seja 1
                    case 1:

                        Console.Write("Entre com a chave: ");
                        chave = int.Parse(Console.ReadLine());

                        Console.Write("Escreva a mensagem: ");

                        //palavra é a variavel que o usuario vai digitar
                        //O método .ToLower() transforma qualquer letra maiúscula em minúscula
                        palavra = Console.ReadLine().ToLower();

                        result = palavra;

                        //enquanto a palavra for menor que i
                        for (int i = 0; i < palavra.Length; i++)

                        {

                            //Devolve o codigo ASCII da letra
                            int ASCII = (int)palavra[i];


                            //Coloca a variável chave adicionando posições no numero da tabela ASCII
                            int ASCIIC = ASCII + chave;

                            //Quando passar da letra 'z' volta ao inicio do alfabeto 
                            if (ASCIIC > 122)
                            {
                                ASCIIC = ASCIIC - 26;
                            }

                            //Concatena o texto e o coloca na variável
                            encrypt += Char.ConvertFromUtf32(ASCIIC);
                            //"resul" recebe "encrypt", para possivel decodificação
                            resul = encrypt;
                        }

                        
                        //Mostra o resultado final, concatenando a variável em que está o texto cifrado
                        Console.WriteLine("Resultado: " + encrypt);

                        Console.WriteLine("\nAperte enter para continuar.");
                        //Aguarda o usuário pressionar uma tecla para sair
                        Console.ReadKey();

                        Console.Write("\n|------------------------------------------|\n");
                        Console.Write("| 1 - Criptografar uma nova mesagem        |\n");
                        Console.Write("| 2 - Descriptofragar uma nova mensagem    |\n");
                        Console.Write("| 3 - Criptografar novamente essa mensagem |\n");
                        Console.Write("| 4 - Descriptografar o resultado          |\n");
                        Console.Write("| 0 - Sair                                 |\n");
                        Console.Write("|------------------------------------------|\n");
                        Console.Write("Escolha a opção: ");

                        //Converte para "opção" para inteiro
                        opcao = int.Parse(Console.ReadLine());

                        //representa o final do case 1
                        break;


                    //caso a opção escolhida for 2
                    case 2:

                        Console.Write("Entre com a chave: ");
                        chave = int.Parse(Console.ReadLine());

                        Console.Write("Escreva a mensagem: ");

                        palavra = Console.ReadLine().ToLower();

                        result = palavra;

                        for (int i = 0; i < palavra.Length; i++)

                        {

                            int ASCII = (int)palavra[i];

                            //Coloca a variável chave subtraindo posições no numero da tabela ASCII
                            int ASCIIC = ASCII - chave;

                            //Quando passar da letra 'z' volta ao inicio do alfabeto 
                            if (ASCIIC < 97)
                            {
                                ASCIIC = ASCIIC + 26;
                            }

                            encrypt += Char.ConvertFromUtf32(ASCIIC);
                            
                        }

                        //Mostra o resultado da descriptografia da mensagem 
                        Console.WriteLine("Resultado: " + encrypt);

                        Console.WriteLine("\nAperte enter para continuar.");
                        //Aguarda o usuário pressionar uma tecla para sair
                        Console.ReadKey();

                        Console.Write("\n|------------------------------------------|\n");
                        Console.Write("| 1 - Criptografar uma nova mesagem        |\n");
                        Console.Write("| 2 - Descriptofragar uma nova mensagem    |\n");
                        Console.Write("| 0 - Sair                                 |\n");
                        Console.Write("|------------------------------------------|\n");
                        Console.Write("Escolha a opção: ");

                        //Converte para "opção" para inteiro
                        opcao = int.Parse(Console.ReadLine());

                        break;
                        

                    //caso a opção seja 3
                    case 3:

                        Console.Write("Entre com a nova chave: ");
                        chav = int.Parse(Console.ReadLine());

                        //Soma chave do caso anterior, com a nova chave, dada pelo usuário
                        chave = chave + chav;
                        
                        for (int i = 0; i < result.Length; i++)

                        {
                            
                            int ASCII = (int)result[i];

                            int ASCIIC = ASCII + chave;
                            
                            if (ASCIIC > 122)
                            {
                                ASCIIC = ASCIIC - 26;
                            }

                            encrypt += Char.ConvertFromUtf32(ASCIIC);
                        }

                        //Mostra o resultado da criptografia anterior somada com a nova chave
                        Console.WriteLine("Resultado: " + encrypt);

                        Console.WriteLine("\nAperte enter para continuar.");
                        //Aguarda o usuário pressionar uma tecla para sair
                        Console.ReadKey();

                        Console.Write("\n|------------------------------------------|\n");
                        Console.Write("| 1 - Criptografar uma nova mesagem        |\n");
                        Console.Write("| 2 - Descriptofragar uma nova mensagem    |\n");
                        Console.Write("| 3 - Criptografar novamente essa mensagem |\n");
                        Console.Write("| 0 - Sair                                 |\n");
                        Console.Write("|------------------------------------------|\n");
                        Console.Write("Escolha a opção: ");

                        //Converte para "opção" para inteiro
                        opcao = int.Parse(Console.ReadLine());

                        //representa o final do case 1
                        break;


                    //caso a opção escolhida for 4
                    case 4:

                        Console.Write("Entre com a chave: ");
                        chave = int.Parse(Console.ReadLine());
                        

                        for (int i = 0; i < resul.Length; i++)

                        {

                            int ASCII = (int)resul[i];

                            //Coloca a variável chave subtraindo posições no numero da tabela ASCII
                            int ASCIIC = ASCII - chave;

                            //Quando passar da letra 'z' volta ao inicio do alfabeto 
                            if (ASCIIC < 97)
                            {
                                ASCIIC = ASCIIC + 26;
                            }

                            encrypt += Char.ConvertFromUtf32(ASCIIC);

                        }

                        //Mostra a mensagem decodificação da mensagem anterior
                        Console.WriteLine("Resultado: " + encrypt);

                        Console.WriteLine("\nAperte enter para continuar.");
                        //Aguarda o usuário pressionar uma tecla para sair
                        Console.ReadKey();

                        Console.Write("\n|------------------------------------------|\n");
                        Console.Write("| 1 - Criptografar uma nova mesagem        |\n");
                        Console.Write("| 2 - Descriptofragar uma nova mensagem    |\n");
                        Console.Write("| 0 - Sair                                 |\n");
                        Console.Write("|------------------------------------------|\n");
                        Console.Write("Escolha a opção: ");

                        //Converte para "opção" para inteiro
                        opcao = int.Parse(Console.ReadLine());

                        break;
                }
               
            } while (opcao > 0);

            //Aguarda o usuário pressionar uma tecla para sair
            Console.ReadKey();
        }
    }
}
