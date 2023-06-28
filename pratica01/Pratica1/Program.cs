
using pilha_calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilha_calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool teste = true;
            Pilha calc = new Pilha(100);



            while (teste == true)
            {
                Console.WriteLine("Digite um numero para empilhar ou uma operação");
                string n = Console.ReadLine();

                if (calc.Cheia())
                {
                    Console.WriteLine("Erro, pilha cheia");
                }
                else
                {

                    if (n == "+" || n == "-" || n == "*" || n == "/")
                    {
                        if (calc.Vazia() == false)
                        {

                            int aux1 = calc.Desempilhar();


                            if (!calc.Vazia())
                            {
                                int aux2 = calc.Desempilhar();
                                if (n == "+")
                                {
                                    Console.WriteLine(aux2 + aux1);
                                    calc.Empilhar(aux2 + aux1);
                                }
                                else if (n == "-")
                                {
                                    Console.WriteLine(aux2 - aux1);
                                    calc.Empilhar(aux2 - aux1);
                                }
                                else if (n == "*")
                                {
                                    Console.WriteLine(aux2 * aux1);
                                    calc.Empilhar(aux2 * aux1);
                                }
                                else if (n == "/")
                                {
                                    Console.WriteLine(aux2 / aux1);
                                    calc.Empilhar(aux2 / aux1);
                                }
                            }
                            else
                            {
                                calc.Empilhar(aux1);
                                Console.WriteLine("Não possui 2 numeros o mais para realizar a operação");
                            }
                        }
                    }
                    else
                    {
                        calc.Empilhar(int.Parse(n));
                    }

                }





            }

        }
    }
}
