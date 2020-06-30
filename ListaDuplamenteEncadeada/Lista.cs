using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaDuplamenteEncadeada
{
    class Lista
    {
        NohLista INICIO;
        NohLista FIM;

        public Lista()
        {
            INICIO = null;
            FIM = null;
        }
        
        public bool estaVazia()
        {
            return INICIO == null && FIM == null ? true : false;
        }

        public NohLista encontraNoh(int valor)
        {
            if (INICIO.Data == valor)
                return INICIO;
            else if (FIM.Data == valor)
                return FIM;
            else
            {
                NohLista temp = INICIO.Next;
                while(temp.Data != valor)
                {
                    temp = temp.Next;
                    if(temp == FIM)
                    {
                        Console.WriteLine("Não existe na Lista");
                        Console.ReadLine();
                        return null;
                    }
                }
                return temp;
            }
        }

        public void insereInicio(int valor)
        {
            NohLista newNoh = new NohLista(valor);

            if (estaVazia() == true)
            {
                INICIO = newNoh;
                FIM = newNoh;
            }
            else
            {
                INICIO.Previo = newNoh;
                newNoh.Next = INICIO;
                INICIO = newNoh;
            }
        }

        public void insereAntes(int valor)
        {
            if(estaVazia() == true)
            {
                Console.WriteLine("Lista Vazia! O valor " + valor +" será o primeiro da lista");
            }
            else
            {
                int elemento;
                NohLista noh = new NohLista(valor);
                NohLista aux;

                Console.WriteLine("O valor " + valor + "deve ser inserido ANTES de qual elemento?");
                imprimeED();
                elemento = Convert.ToInt32(Console.ReadLine());

                aux = encontraNoh(elemento);

                noh.Previo = aux.Previo;
                noh.Next = aux;
                aux.Previo.Next = noh;
                aux.Previo = noh;
                
            }
        }

        public void insereApos(int valor)
        {
            if (estaVazia() == true)
            {
                Console.WriteLine("Lista Vazia! O valor " + valor + " será o primeiro da lista");
            }
            else
            {
                int elemento;
                NohLista noh = new NohLista(valor);
                NohLista aux;

                Console.WriteLine("O valor " + valor + " deve ser inserido APÓS qual elemento?");
                imprimeED();
                elemento = Convert.ToInt32(Console.ReadLine());

                aux = encontraNoh(elemento);

                noh.Previo = aux;
                noh.Next = aux.Next;
                aux.Next.Previo = noh;
                aux.Next = noh;
            }
        }

        public void insereFim(int valor)
        {
            NohLista noh = new NohLista(valor);
            if(estaVazia() == true)
            {
                INICIO = noh;
                FIM = noh;
            }
            else
            {
                FIM.Next = noh;
                noh.Previo = FIM;
                FIM = noh;
            }
        }

        public void remove(int valor)
        {
            if(estaVazia() == true)
            {
                Console.WriteLine("Lista Vazia!");
            }
            else
            {
                NohLista noh = encontraNoh(valor);
                if(noh != null)
                {
                    if (noh == INICIO)
                    {
                        INICIO = INICIO.Next;
                        INICIO.Previo = null;
                    }
                    else if (noh == FIM)
                    {
                        FIM = FIM.Previo;
                        FIM.Next = null;
                    }
                    else
                    {
                        noh.Previo.Next = noh.Next;
                        noh.Next.Previo = noh.Previo;
                    }
                }
            }
        }

        public void imprimeED()
        {
            if(estaVazia() == true)
            {
                Console.WriteLine("Lista Vazia!");
            }
            else
            {
                NohLista temp = INICIO;

                while (true)
                {
                    
                    Console.Write(temp.Data + " ");

                    if (temp == FIM)
                        break;

                    temp = temp.Next;
                }
                Console.Write("\n");
            }
            
        }

        public void imprimeDE()
        {
            if (estaVazia() == true)
            {
                Console.WriteLine("Lista Vazia!");
            }
            else
            {
                NohLista temp = FIM;

                while (true)
                {
                    Console.Write(temp.Data + " ");

                    if (temp == INICIO)
                        break;

                    temp = temp.Previo;
                }
                Console.Write("\n");
            }

        }

    }
}
