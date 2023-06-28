using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposAbstratosDeDados
{
    class TestaLista
    {
        static void Main(string[] args)
        {
            bool teste = true;
            Lista l = new Lista();
            int c;
            string nome;

            
            while (teste)
            {


                Console.WriteLine("1) Inserir");
                Console.WriteLine("2) Pesquisar");
                Console.WriteLine("3) Imprimir Lista");
                Console.WriteLine("4) Sair");

                Console.WriteLine("Digite a opção desejada: ");
                int posicao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (posicao)
                {
                    case 1:

                        Console.Write("Digite um nº (-1 para sair): ");
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite um nome: ");
                        nome = Console.ReadLine();

                        Console.Clear();

                        while (c != -1)
                        {
                            NoLista e = l.Pesquisar(c);

                            if (e == null)
                            {
                                l.Inserir(new NoLista(c, nome));
                            }
                            else
                            {
                                Console.WriteLine("Numero repetido");
                            }


                            Console.Write("Digite outro nº (-1 para sair): ");
                            c = Convert.ToInt32(Console.ReadLine());
                            if (c != -1 && l.Pesquisar(c) == null)
                            {
                                Console.WriteLine("Digite um nome: ");
                                nome = Console.ReadLine();
                            }
                            Console.Clear();
                        }
                        break;

                    case 2:

                        Console.Write("Digite um nº a ser pesquisado: ");
                        c = Convert.ToInt32(Console.ReadLine());

                        NoLista n = l.Pesquisar(c);

                        if (n == null)
                            Console.WriteLine("Valor não encontrado!");
                        else
                        {
                            Console.WriteLine("a chave " + n.chave + " corresponde ao " + n.nome);
                            Console.WriteLine("Deseja remove-la? \n 1 = sim \n 2 = não ");
                            int remover = int.Parse(Console.ReadLine());

                            if (remover == 1)
                            {
                                l.Remover(c);
                            }
                        }


                        break;

                    case 3:

                        l.Imprimir();
                        break;

                    case 4:
                        teste = false;
                        break;

                    default:
                        Console.WriteLine("Valor invalido");
                        break;
                }
            }


            Console.ReadKey();
        }
    }
}
