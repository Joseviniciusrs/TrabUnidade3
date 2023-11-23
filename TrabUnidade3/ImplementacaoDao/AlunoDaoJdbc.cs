using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabUnidade3.ImplementacaoDao
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;

    public class AlunoDaoJdbc : IAlunoDao
    {
        private SqlConnection conn;

        public AlunoDaoJdbc(SqlConnection conn)
        {
            this.conn = conn;
        }

        public void Insert(Aluno aluno)
        {
            using (SqlCommand st = conn.CreateCommand())
            {
                st.CommandText = "INSERT INTO tb_aluno (NomeA, Cpf, DDD, Numero, Email) VALUES (@NomeA, @Cpf, @DDD, @Numero, @Email); SELECT SCOPE_IDENTITY()";

                st.Parameters.AddWithValue("@NomeA", aluno.Nome);
                st.Parameters.AddWithValue("@Cpf", aluno.CPF);
                st.Parameters.AddWithValue("@DDD", aluno.DDD);
                st.Parameters.AddWithValue("@Numero", aluno.Numero);
                st.Parameters.AddWithValue("@Email", aluno.Email);

                conn.Open();
                int id = Convert.ToInt32(st.ExecuteScalar());
                conn.Close();

                aluno.Id = id;
            }
        }

        public void Update(Aluno aluno)
        {
            using (SqlCommand st = conn.CreateCommand())
            {
                st.CommandText = "UPDATE tb_aluno SET NomeA = @NomeA, Cpf = @Cpf, DDD = @DDD, Numero = @Numero, Email = @Email WHERE id_Aluno = @Id";
                st.Parameters.AddWithValue("@NomeA", aluno.Nome);
                st.Parameters.AddWithValue("@Cpf", aluno.CPF);
                st.Parameters.AddWithValue("@DDD", aluno.DDD);
                st.Parameters.AddWithValue("@Numero", aluno.Numero);
                st.Parameters.AddWithValue("@Email", aluno.Email);
                st.Parameters.AddWithValue("@Id", aluno.Id);

                conn.Open();
                st.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void DeleteById(int id)
        {
            using (SqlCommand st = conn.CreateCommand())
            {
                st.CommandText = "DELETE FROM tb_aluno WHERE id_Aluno = @Id";
                st.Parameters.AddWithValue("@Id", id);

                conn.Open();
                int rowsAffected = st.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected == 0)
                {
                    throw new DbException("Nenhuma exclusão ocorreu! Id inexistente");
                }
            }
        }

        public Aluno FindById(int id)
        {
            using (SqlCommand st = conn.CreateCommand())
            {
                st.CommandText = "SELECT * FROM tb_aluno WHERE tb_aluno.id_Aluno = @Id";
                st.Parameters.AddWithValue("@Id", id);

                conn.Open();
                using (SqlDataReader rs = st.ExecuteReader())
                {
                    if (rs.Read())
                    {
                        return InstanciaAluno(rs);
                    }
                }
                conn.Close();
            }
            return null;
        }

        public List<Aluno> FindAll()
        {
            using (SqlCommand st = conn.CreateCommand())
            {
                st.CommandText = "SELECT * FROM tb_aluno ORDER BY NomeA";

                conn.Open();
                using (SqlDataReader rs = st.ExecuteReader())
                {
                    List<Aluno> lista = new List<Aluno>();
                    while (rs.Read())
                    {
                        lista.Add(InstanciaAluno(rs));
                    }
                    return lista;
                }
                conn.Close();
            }
        }

        private Aluno InstanciaAluno(SqlDataReader rs)
        {
            Aluno aluno = new Aluno();
            aluno.Id = rs.GetInt32("id_Aluno");
            aluno.Nome = rs.GetString("NomeA");
            aluno.CPF = rs.GetString("Cpf");
            aluno.DDD = rs.GetString("DDD");
            aluno.Numero = rs.GetString("Numero");
            aluno.Email = rs.GetString("Email");
            return aluno;
        }
    }

}
