using System;
using System.Collections;
using System.Collections.Generic;


namespace Lixo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho da sua lista: ");
            int tamanho = int.Parse(Console.ReadLine());
            Lista lista = new Lista(tamanho);

            int tempo = 0;
            int pos = 0;
            int opcao = 0;

            while (opcao != 12)
            {

                Console.WriteLine("MENU\n1) Inserir um tempo no início da lista\n2) Inserir um tempo no final da lista\n3) Inserir um tempo numa posição específica da lista\n4) Remover o primeiro tempo da lista(Imprimir o tempo removido)\n5) Remover o último tempo da lista(Imprimir o tempo removido)\n6) Remover um tempo de uma posição específica na lista(O usuário deve informar a posição do tempo a serremovido.Imprimir o tempo removido)\n7) Remover um tempo específico da lista(O usuário deve informar o tempo a ser removido)\n8) Pesquisar quantas vezes um determinado tempo consta na lista(O usuário deve informar o tempo a ser pesquisado)\n9) Mostrar todos os tempos da lista\n10)Encerrar o programa\nDeseje a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o tempo que deseja inserir no inicio da fila: ");

                        tempo = int.Parse(Console.ReadLine());

                        lista.InserirInicio(tempo);
                        break;
                    case 2:
                        Console.WriteLine("Digite o tempo que deseja inserir no fim da fila: ");

                        tempo = int.Parse(Console.ReadLine());
                        lista.InserirFim(tempo);
                        break;
                    case 3:
                        Console.WriteLine("Digite o tempo que deseja inserir: ");

                        tempo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a posição que deseja inseri - lo: ");

                        pos = int.Parse(Console.ReadLine());
                        lista.Inserir(pos, tempo);
                        break;
                    case 4:
                        Console.WriteLine("Primeiro tempo removido: " + lista.RemoverInicio());
                        break;
                    case 5:
                        Console.WriteLine("Ultimo tempo removido: " + lista.RemoverFim());
                        break;
                    case 6:
                        Console.WriteLine("Digite a posição da qual deseja remover o tempo: ");

                        pos = int.Parse(Console.ReadLine());

                        Console.WriteLine("Tempo removido: " + lista.Remover(pos));
                        break;
                    case 7:
                        Console.WriteLine("Digite o tempo que deseja remover: ");

                        tempo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Item removido: " + lista.RemoverItem(tempo));
                        break;
                    case 8:
                        Console.WriteLine("Digite o tempo que deseja pesquisar: ");

                        tempo = int.Parse(Console.ReadLine());
                        Console.WriteLine("O tempo foi registrado " + lista.Contar(tempo) + " vezes");
                        break;
                    case 9:
                        lista.Mostrar();
                        break;
                    case 10:
                        Console.WriteLine("FIM");
                        break;
                    default:
                        Console.WriteLine("Número invalido!");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}