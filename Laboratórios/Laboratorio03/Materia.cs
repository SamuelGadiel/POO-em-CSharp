using System;
namespace alunoMateria
{
    public class Materia
    {
        private String nome;
        private String codigo;

        public Materia()
        {
            nome = "";
            codigo = "";
        }

        public Materia(String _nome, String _codigo) 
        {
            nome = _nome;
            codigo = _codigo;
        }    
         
        public String Nome { get => nome; set => nome = value; }
        public String Codigo { get => codigo; set => codigo = value; }
    }
}
