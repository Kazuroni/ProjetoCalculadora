using System;

namespace ProjetoCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            string select, lv;
            try
            {
                do
                {
                    
                    Console.WriteLine("Developet by Kazuroni.");
                    Console.WriteLine("....");
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\n+-=-=-=| Calculadora |=-=-=-+\n");
                    Console.ResetColor();

                    Console.WriteLine("selecione usando os numeros ou simbolos");
                    Console.WriteLine("Operações Disponiveis....:\n");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Adição: + ou 1");
                    
                    Console.WriteLine("Subtração: - ou 2");

                    Console.WriteLine("Divisão: % ou 3");

                    Console.WriteLine("Multiplicação: X ou 4");

                    Console.WriteLine("Potencia: P ou 5");

                    Console.WriteLine("Raiz Quadrada: R ou 6");
                    Console.ResetColor();
                    Console.WriteLine("__________");
                    Console.WriteLine("\nAbout: !\n");


                    Console.Write("===> ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    select = Console.ReadLine().ToUpper();
                    Console.ResetColor();

                    if (select == "+" || select == "1")
                    {
                        adc();
                    }
                    if (select == "-" || select == "2")
                    {
                        rem();
                    }
                    if (select == "%" || select == "3")
                    {
                        div();
                    }
                    if (select == "X" || select == "4")
                    {
                        multi();
                    }
                    if (select == "P" || select == "5")
                    {
                        pote();
                    }
                    if (select == "R" || select == "6")
                    {
                        raiz();
                    }
                    if (select == "!")
                     {
                        About();
                    }
                     
                    Console.Write("Finalizar? S/N: ");
                    
                    lv = Console.ReadLine().ToLower();
                }
                while (lv != "s" && lv != "sim");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\nImpossivel Dividir por 0.");
                Console.WriteLine("Pressione enter para encerrar...");
                Console.ReadKey();
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nDigite Um Numero Valido.");
                Console.WriteLine("Pressione enter para encerrar...");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("\nDigite Um Formato Valido.");
                Console.WriteLine("Pressione enter para encerrar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                Console.WriteLine("Pressione enter para recomeçar...");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("Obrigado por utilizar meu software! ");

        }
        static void adc()
        {

            double v1;
            double v2;

            Console.WriteLine("Calculadora de Soma\n");

            Console.Write("Primeiro valor.: ");
            v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor..: ");
            v2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine();

            double re;
            re = v1 + v2;

            Console.WriteLine($"A Soma De: {v1} + {v2} É {re}\n");
        }

        static void rem()
        {

            double v1; 
            double v2;

            Console.WriteLine("Calculadora de Subtração\n");

            Console.Write("1 Primeiro Valor.: ");
            v1 = double.Parse(Console.ReadLine());

            Console.Write("2 Segundo Valor..: ");
            v2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine();

            double re;

            re = v1 - v2;

            Console.WriteLine($"A Subtração de {v1} - {v2} É {re}\n");
        }

        static void multi()
        {


            double v1; 
            double v2; 

            Console.WriteLine("Calculadora De Multiplicação\n");

            Console.Write("Primeiro Valor..: ");
            v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo Valor...: ");
            v2 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            double re;

            re = v1 * v2;

            Console.WriteLine($"Resposta: {v1} * {v2} = {re}\n");
        }

        static void div()
        {


            double v1; 
            double v2;
            double re;

            Console.WriteLine("Calculadora de Divisão\n");

            Console.Write("Primeiro Valor..: ");
            v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo Valor...: ");
            v2 = double.Parse(Console.ReadLine());

            if (v2 == 0)
            {
                throw new DivideByZeroException("0 não é um numero valido..");
            }

            Console.WriteLine();
            re = v1 / v2;

            Console.WriteLine($"A divisão seria: {v1} / {v2} = {re:N2}\n");
        }

        static void pote()
        {

            double v1; 
            double v2;
            double re;

            Console.WriteLine("Calculadora de Potencia\n");

            Console.Write("Primeiro Valor..: ");
            v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo Valor...: ");
            v2 = double.Parse(Console.ReadLine());

            Console.WriteLine();


            re = v1 * v2 / 100;

            Console.WriteLine($"Resposta: {v1} * {v2} / 100 = {re}%");
        }

        static void raiz()
        {

            double raz;

            Console.WriteLine("Calculadora de Raiz Quadrada\n");

            Console.Write("Digite Seu Valor da Raiz Quadrada: ");
            raz = double.Parse(Console.ReadLine());

            Console.WriteLine();

            double re;
            re = Math.Sqrt(raz);

            Console.WriteLine($"O resultado de {raz} da Raiz é = {re:N2}");
        }
          static void About()
        {
                    Console.Clear();

                    string link;
                    link = "https://github.com/Kazuroni/ProjetoCalculadora";
                    

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine ("ETEC Adolpho Berezin");
                    Console.ResetColor();

                    Console.WriteLine("Curso Tecnico T.I: Etec Adolpho Berezin - Mongaguá");
                    Console.WriteLine("Disciplina: Programação De Compultadores");
                    Console.WriteLine("Aluno: Christyan Kawamura");
                    Console.WriteLine($"\nLink do Programa Online: {link}");
        }
    }
}