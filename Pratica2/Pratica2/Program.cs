using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposAbstratosDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Fila ped = new Fila(100);
            Fila pagto = new Fila(100);
            Fila enc = new Fila(100);
            bool teste = true;
            int cliente = 0;

            while (teste == true)
            {
                {
                    Console.WriteLine("1 - Inserção de cliente na fila de pedidos");
                    Console.WriteLine("2 - Remoção de cliente da fila de pedidos");
                    Console.WriteLine("3 - Remoção de cliente da fila de pagamentos");
                    Console.WriteLine("4 - Remoção de cliente da fila de encomendas");
                    Console.WriteLine("5 - Sair");
                    int menu = int.Parse(Console.ReadLine());

                    Console.Clear();

                    if (menu == 1)
                    {
                        ped.Enfileirar(++cliente);
                        Console.WriteLine("Cliente " + cliente + " entrou na fila de pedidos");
                    }
                    else if (menu == 2)
                    {
                        if (ped.Vazia())
                        {
                            Console.WriteLine("Fila de pedidos vazia");
                        }
                        else
                        {
                            int aux1 = ped.Desenfileirar();
                            pagto.Enfileirar(aux1);
                            Console.WriteLine("Cliente " + aux1 + " foi removido da fila de pedidos e entrou na de pagamentos");
                        }


                    }
                    else if (menu == 3)
                    {
                        if (pagto.Vazia() == true)
                        {
                            Console.WriteLine("Fila de pagamentos vazia");
                        }
                        else
                        {
                            int aux1 = pagto.Desenfileirar();
                            enc.Enfileirar(aux1);
                            Console.WriteLine("Cliente " + aux1 + " foi removido da fila de pagamentos e entrou na de encomendas");
                        }


                    }
                    else if (menu == 4)
                    {
                        if (enc.Vazia() == true)
                        {
                            Console.WriteLine("Fila de encomendas vazia");
                        }
                        else
                        {
                            int aux1 = enc.Desenfileirar();
                            Console.WriteLine("Cliente " + aux1 + " foi removido da fila de encomendas");
                        }


                    }
                    else if (menu == 5)
                    {
                        teste = false;
                    }
                    else
                    {
                        Console.WriteLine("Opção invalida");
                    }
                }
            }
        }
    }
}
