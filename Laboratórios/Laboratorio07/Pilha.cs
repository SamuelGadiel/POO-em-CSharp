using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio07
{
    class Pilha : NohPilha
    {
        private NohPilha topo;

        public Pilha()
        {
            topo = null;
        }

        public bool IsEmpty()
        {
            return (topo == null ? true : false);
        }

        public void Push(int insertItem)
        {
            if (IsEmpty() == true)
                topo = new NohPilha(insertItem);
            else
            {
                NohPilha novoNoh = new NohPilha(insertItem, topo);
                topo = novoNoh;
            }
        }

        public int? Pop()
        {
            if (IsEmpty() == true)
            {
                MessageBox.Show("Não é possivel imprimir a pilha.\nPilha Vazia!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                int temp = topo.Data;
                topo = topo.NextNoh;
                return temp;
            }
        }

        public string Print()
        {
            if (IsEmpty() == true)
            {
                MessageBox.Show("Não é possivel imprimir a pilha.\nPilha Vazia!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                NohPilha temp = topo;
                string resultado = "";

                while (temp != null)
                {
                    resultado += temp.Data.ToString() + "\r\n\r\n";
                    temp = temp.NextNoh;
                }
                return resultado;
            }    
        }

        public int? Maior()
        {
            if (IsEmpty() == false)
            {
                NohPilha auxPilha = new NohPilha();
                int? auxData = null;

                auxPilha = topo;
                auxData = auxPilha.Data;

                while (auxPilha != null)
                {
                    Console.WriteLine("auxData: " + auxData);

                    if (auxPilha.Data > auxData)
                    {
                        Console.WriteLine("auxPilha.Data: " + auxPilha.Data + "\n\n");
                        auxData = auxPilha.Data;
                    }

                    auxPilha = auxPilha.NextNoh;
                }
                return auxData;
            }
            else
                MessageBox.Show("Não é possivel imprimir a pilha.\nPilha Vazia!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
        }

        public int? Menor()
        {
            if (IsEmpty() == false)
            {
                NohPilha auxPilha;
                int? auxData = null;

                auxPilha = topo;
                auxData = auxPilha.Data;

                while (auxPilha != null)
                {
                    Console.WriteLine("auxData: " + auxData);

                    if (auxPilha.Data < auxData)
                    {
                        auxData = auxPilha.Data;
                    }

                    auxPilha = auxPilha.NextNoh;
                }
                return auxData;
            }
            else
                MessageBox.Show("Não é possivel imprimir a pilha.\nPilha Vazia!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        public Pilha Inverte()
        {
            if (IsEmpty() == false)
            {
                Pilha auxPilha = new Pilha();
                int? valor;
                
                while(topo != null)
                {
                    valor = Pop();

                    auxPilha.Push((int)valor);
                }
                return auxPilha;
            }
            else
                return this;
        }
    }
}
