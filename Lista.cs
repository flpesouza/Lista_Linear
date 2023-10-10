using System;
class Lista
{
    private int[] array;
    private int n;
    /**
    * Construtor da classe.
*/
    public Lista(int tamanho)
    {
        array = new int[tamanho];
        n = 0;
    }
    /**
    * Insere um elemento na primeira posicao da lista e move os demais
    * elementos para o fim da lista.
*/
    public void InserirInicio(int x)
    {
        if (n >= array.Length)
        {
            throw new Exception("Erro ao inserir!");
        }
        for (int i = n; i > 0; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = x;
        n++;
    }
    /**
    * Insere um elemento na ultima posicao da lista.
*/
    public void InserirFim(int x)
    {
        if (n >= array.Length)
        {
            throw new Exception("Erro ao inserir!");
        }
        array[n] = x;
        n++;
    }
    /**
    * Insere um elemento em uma posicao especifica e move os demais
    * elementos para o fim da lista.
*/
    public void Inserir(int x, int pos)
    {
        if (n >= array.Length || pos < 0 || pos > n)
        {
            throw new Exception("Erro ao inserir!");
        }
        for (int i = n; i > pos; i--)
        {
            array[i] = array[i - 1];
        }
        array[pos] = x;
        n++;
    }
    /**
    * Remove um elemento da primeira posicao da lista e movimenta
    * os demais elementos para o inicio da mesma.
*/
    public int RemoverInicio()
    {
        if (n == 0)
        {
            throw new Exception("Erro ao remover!");
        }
        int resp = array[0];
        n--;
        for (int i = 0; i < n; i++)
        {
            array[i] = array[i + 1];
        }
        return resp;
    }
    /**
    * Remove um elemento da ultima posicao da lista.
*/
    public int RemoverFim()
    {
        if (n == 0)
        {
            throw new Exception("Erro ao remover!");
        }
        n--;
        return array[n];
    }

    public int RemoverItem(int x)
    {
        int resp = 0;
        int pos = 0;
        if (n == 0)
        {
            throw new Exception("Erro ao remover!");
        }
        for (int i = 0; i < n; i++)
        {
            if(x == array[i])
            {
                resp = x;
                pos = i;
                n--;
            }
        }
        for (int i = pos; i < n; i++)
        {
            array[i] = array[i + 1];
        }
        return resp;
    }

    public int Contar(int x)
    {
        int cont = 0;
        if (n == 0)
        {
            throw new Exception("Erro ao remover!");
        }
        for (int i = 0; i < n; i++)
        {
            if (x == array[i])
            {
                cont++;
            }
        }
        return cont;
    }
    /**
    * Remove um elemento de uma posicao especifica da lista e
    * movimenta os demais elementos para o inicio da mesma.
*/
    public int Remover(int pos)
    {
        if (n == 0 || pos < 0 || pos >= n)
        {
            throw new Exception("Erro ao remover!");
        }
        int resp = array[pos];
        n--;
        for (int i = pos; i < n; i++)
        {
            array[i] = array[i + 1];
        }
        return resp;
    }
    /**
    * Mostra os elementos da lista separados por espacos.
*/
    public void Mostrar()
    {
        Console.Write("[ ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("]");
    }

   
}