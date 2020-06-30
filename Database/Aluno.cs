using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <remarks>Falar sobre SQLInjection e parameters binding.</remarks>

namespace Database
{
    class Aluno
    {
        const string queryList = "SELECT nome,ingresso FROM aluno";
        const string queryInsert = "INSERT INTO aluno(nome,ingresso) VALUES(@nome,@ingresso);";
        string nome;
        int anoIngresso;

        public void Inserir()
        {
            var conn = SingletonDatabase.Connection;
            var cmd = new SQLiteCommand(queryInsert, conn);
            cmd.Parameters.Add(new SQLiteParameter("@nome", nome));
            cmd.Parameters.Add(new SQLiteParameter("@ingresso", anoIngresso));
            var lineCount = cmd.ExecuteNonQuery();
            if(lineCount == 0)
            {
                throw new Exception("Falha ao inserir inscrito.");
            }
        }

        public static List<Aluno> Listar()
        {
            var alunos = new List<Aluno>();
            var conn = SingletonDatabase.Connection;
            var cmd = new SQLiteCommand(queryList, conn);
            var reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                var aluno = new Aluno();
                aluno.Nome = reader.GetString(0);
                aluno.AnoIngresso = reader.GetInt32(1);
                alunos.Add(aluno);
            }
            return alunos;
        }

        public override string ToString()
        {
            return nome;
        }

        #region Properties

        public string Nome {
            get { return nome; }
            set
            {
                if (value.Length > 0)
                    nome = value;
                else
                    throw new Exception("Nome inválido!");
            }
        }
        public int AnoIngresso
        {
            get { return anoIngresso; }
            set {
                // Escola inaugurada no ano 2000.
                if (value >= 2000)
                    anoIngresso = value;
                else
                    throw new Exception("Ano de ingresso inválido!");
            }
        }

        #endregion
    }
}