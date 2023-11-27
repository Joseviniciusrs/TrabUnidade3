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
        public class FichaTreinoDaoJdbc : IFichaTreinoDao
        {
            private SqlConnection conn;

            public FichaTreinoDaoJdbc(SqlConnection conn)
            {
                this.conn = conn;
            }

            public void Insert(FichaTreino obj, Aluno aln, Professor prof)
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "INSERT INTO tb_fichatr (id_Aluno, id_Prof) VALUES (@IdAluno, @IdProf); SELECT SCOPE_IDENTITY();";
                    st.Parameters.AddWithValue("@IdAluno", aln.Id);
                    st.Parameters.AddWithValue("@IdProf", prof.Id);

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
                                obj.Id = id;
                            }
                        }
                    }
                    else
                    {
                        throw new DbException("Erro inesperado! Nenhuma inserção ocorreu");
                    }
                }
            }

            public void Update(FichaTreino obj, Aluno aln, Professor prof)
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "UPDATE tb_fichatr SET id_Aluno = @IdAluno, id_Prof = @IdProf WHERE id_Fichatr = @IdFicha";
                    st.Parameters.AddWithValue("@IdAluno", aln.Id);
                    st.Parameters.AddWithValue("@IdProf", prof.Id);
                    st.Parameters.AddWithValue("@IdFicha", obj.Id);

                    conn.Open();
                    st.ExecuteNonQuery();
                    conn.Close();
                }
            }

            public void DeleteById(int id)
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "DELETE FROM tb_fichatr WHERE id_Fichatr = @Id";
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

            public FichaTreino FindById(int id)
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "SELECT * FROM tb_fichatr " +
                        "JOIN tb_aluno ON tb_aluno.id_Aluno = tb_fichatr.id_Aluno " +
                        "JOIN tb_professor ON tb_professor.id_Prof = tb_fichatr.id_Prof " +
                        "WHERE tb_fichatr.id_Fichatr = @Id";
                    st.Parameters.AddWithValue("@Id", id);

                    conn.Open();
                    using (SqlDataReader rs = st.ExecuteReader())
                    {
                        if (rs.Read())
                        {
                            Aluno al = InstanciaAluno(rs);
                            Professor pro = InstanciaProfessor(rs);

                            FichaTreino Ficha = InstanciaFichaTreino(rs, pro, al);
                            conn.Close();
                            return Ficha;
                        }
                    }
                    conn.Close();
                }
                return null;
            }

            public List<FichaTreino> FindAll()
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "SELECT * FROM tb_fichatr " +
                        "JOIN tb_aluno ON tb_aluno.id_Aluno = tb_fichatr.id_Aluno " +
                        "JOIN tb_professor ON tb_professor.id_Prof = tb_fichatr.id_Prof " +
                        "ORDER BY tb_fichatr.id_Fichatr";

                    conn.Open();
                    using (SqlDataReader rs = st.ExecuteReader())
                    {
                        List<FichaTreino> lista = new List<FichaTreino>();
                        Dictionary<int, Aluno> mapAlun = new Dictionary<int, Aluno>();
                        Dictionary<int, Professor> mapProf = new Dictionary<int, Professor>();

                        while (rs.Read())
                        {
                            Aluno al = mapAlun.ContainsKey(Convert.ToInt32(rs["id_Aluno"])) ? mapAlun[Convert.ToInt32(rs["id_Aluno"])] : null;
                            Professor pro = mapProf.ContainsKey(Convert.ToInt32(rs["id_Prof"])) ? mapProf[Convert.ToInt32(rs["id_Prof"])] : null;

                            if (al == null && pro == null)
                            {
                                al = InstanciaAluno(rs);
                                pro = InstanciaProfessor(rs);

                                mapAlun.Add(al.Id, al);
                                mapProf.Add(pro.Id, pro);
                            }

                            FichaTreino Ficha = InstanciaFichaTreino(rs, pro, al);
                            lista.Add(Ficha);
                        }

                        conn.Close();
                        return lista;
                    }
                }
            }

            private Professor InstanciaProfessor(SqlDataReader rs)
            {
                Professor prof = new Professor();
                prof.Id = Convert.ToInt32(rs["id_Prof"]);
                prof.Nome = rs["NomeP"].ToString();
                return prof;
            }

            private Aluno InstanciaAluno(SqlDataReader rs)
            {
                Aluno alun = new Aluno();
                alun.Id = Convert.ToInt32(rs["id_Aluno"]);
                alun.Nome = rs["NomeA"].ToString();
                return alun;
            }

            private FichaTreino InstanciaFichaTreino(SqlDataReader rs, Professor prof, Aluno alun)
            {
                FichaTreino Ficha = new FichaTreino();
                Ficha.Id = Convert.ToInt32(rs["id_Fichatr"]);
                Ficha.Prof = prof;
                Ficha.Aluno = alun;
                return Ficha;
            }
        }
    }

}
