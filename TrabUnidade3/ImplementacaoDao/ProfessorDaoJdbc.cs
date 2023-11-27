using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabUnidade3.ImplementacaoDao
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using Entidades;

    namespace ImplementacaoDao
    {
        public class ProfessorDaoJdbc : IProfessorDao
        {
            private SqlConnection conn;

            public ProfessorDaoJdbc(SqlConnection conn)
            {
                this.conn = conn;
            }

            public void Insert(Professor professor)
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "INSERT INTO tb_professor (NomeP, Cnpj, DDD, Numero, Email) VALUES (@Nome, @Cnpj, @DDD, @Numero, @Email); SELECT SCOPE_IDENTITY();";
                    st.Parameters.AddWithValue("@Nome", professor.Nome);
                    st.Parameters.AddWithValue("@Cnpj", professor.Cnpj);
                    st.Parameters.AddWithValue("@DDD", professor.DDD);
                    st.Parameters.AddWithValue("@Numero", professor.Numero);
                    st.Parameters.AddWithValue("@Email", professor.Email);

                    conn.Open();
                    int linhasAfetadas = st.ExecuteNonQuery();
                    conn.Close();

                    if (linhasAfetadas > 0)
                    {
                        using (SqlDataReader rs = st.ExecuteReader())
                        {
                            if (rs.Read())
                            {
                                int id = Convert.ToInt32(rs[0]);
                                professor.Id = id;
                            }
                        }
                    }
                    else
                    {
                        throw new DbException("Erro inesperado! Nenhuma inserção ocorreu");
                    }
                }
            }

            public void Update(Professor professor)
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "UPDATE tb_professor SET NomeP = @Nome, Cnpj = @Cnpj, DDD = @DDD, Numero = @Numero, Email = @Email WHERE id_Prof = @Id";
                    st.Parameters.AddWithValue("@Nome", professor.Nome);
                    st.Parameters.AddWithValue("@Cnpj", professor.Cnpj);
                    st.Parameters.AddWithValue("@DDD", professor.DDD);
                    st.Parameters.AddWithValue("@Numero", professor.Numero);
                    st.Parameters.AddWithValue("@Email", professor.Email);
                    st.Parameters.AddWithValue("@Id", professor.Id);

                    conn.Open();
                    st.ExecuteNonQuery();
                    conn.Close();
                }
            }

            public void DeleteById(int id)
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "DELETE FROM tb_professor WHERE id_Prof = @Id";
                    st.Parameters.AddWithValue("@Id", id);

                    conn.Open();
                    int linhasAfetadas = st.ExecuteNonQuery();
                    conn.Close();

                    if (linhasAfetadas == 0)
                    {
                        throw new DbException("Nenhuma exclusão ocorreu! Id inexistente");
                    }
                }
            }

            public Professor FindById(int id)
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "SELECT * FROM tb_professor WHERE tb_professor.id_Prof = @Id";
                    st.Parameters.AddWithValue("@Id", id);

                    conn.Open();
                    using (SqlDataReader rs = st.ExecuteReader())
                    {
                        if (rs.Read())
                        {
                            Professor professor = InstanciaProfessor(rs);
                            conn.Close();
                            return professor;
                        }
                    }
                    conn.Close();
                }
                return null;
            }

            public List<Professor> FindAll()
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "SELECT * FROM tb_professor ORDER BY NomeP";

                    conn.Open();
                    using (SqlDataReader rs = st.ExecuteReader())
                    {
                        List<Professor> lista = new List<Professor>();

                        while (rs.Read())
                        {
                            Professor professor = InstanciaProfessor(rs);
                            lista.Add(professor);
                        }

                        conn.Close();
                        return lista;
                    }
                }
            }

            private Professor InstanciaProfessor(SqlDataReader rs)
            {
                Professor professor = new Professor();
                professor.Id = Convert.ToInt32(rs["id_Prof"]);
                professor.Nome = rs["NomeP"].ToString();
                professor.Cnpj = rs["Cnpj"].ToString();
                professor.DDD = rs["DDD"].ToString();
                professor.Numero = rs["Numero"].ToString();
                professor.Email = rs["Email"].ToString();
                return professor;
            }
        }
    }

}
