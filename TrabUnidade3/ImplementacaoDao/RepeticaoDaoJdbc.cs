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
        public class RepeticaoDaoJdbc : RepeticaoDao
        {
            private SqlConnection conn;

            public RepeticaoDaoJdbc(SqlConnection conn)
            {
                this.conn = conn;
            }

            public void Insert(Repeticao repeticao, Equipamento equip, FichaTreino ficha)
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "INSERT INTO tb_repeticao (serie, repeticao, id_Equipamento, id_Fichatr) VALUES (@Serie, @Repeticao, @IdEquipamento, @IdFichatr); SELECT SCOPE_IDENTITY();";
                    st.Parameters.AddWithValue("@Serie", repeticao.Serie);
                    st.Parameters.AddWithValue("@Repeticao", repeticao.Repeticao);
                    st.Parameters.AddWithValue("@IdEquipamento", equip.Id);
                    st.Parameters.AddWithValue("@IdFichatr", ficha.Id);

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
                                repeticao.Id = id;
                            }
                        }
                    }
                    else
                    {
                        throw new DbException("Erro inesperado! Nenhuma inserção ocorreu");
                    }
                }
            }

            public void Update(Repeticao repeticao, Equipamento equip, FichaTreino ficha)
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "UPDATE tb_repeticao SET serie = @Serie, repeticao = @Repeticao, id_Equipamento = @IdEquipamento, id_Fichatr = @IdFichatr WHERE id_Repeticao = @Id";
                    st.Parameters.AddWithValue("@Serie", repeticao.Serie);
                    st.Parameters.AddWithValue("@Repeticao", repeticao.Repeticao);
                    st.Parameters.AddWithValue("@IdEquipamento", equip.Id);
                    st.Parameters.AddWithValue("@IdFichatr", ficha.Id);
                    st.Parameters.AddWithValue("@Id", repeticao.Id);

                    conn.Open();
                    st.ExecuteNonQuery();
                    conn.Close();
                }
            }

            public void DeleteById(int id)
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "DELETE FROM tb_repeticao WHERE id_Repeticao = @Id";
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

            public Repeticao FindById(int id)
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "SELECT * FROM tb_repeticao" +
                        " join tb_equipamento ON tb_equipamento.id_Equipamento = tb_repeticao.id_Equipamento" +
                        " join tb_fichatr ON tb_repeticao.id_Fichatr = tb_fichatr.id_Fichatr" +
                        " join tb_aluno ON tb_aluno.id_Aluno = tb_fichatr.id_Aluno" +
                        " join tb_professor ON tb_professor.id_Prof = tb_fichatr.id_Prof" +
                        " WHERE tb_repeticao.id_Repeticao = @Id";
                    st.Parameters.AddWithValue("@Id", id);

                    conn.Open();
                    using (SqlDataReader rs = st.ExecuteReader())
                    {
                        if (rs.Read())
                        {
                            Aluno al = InstanciaAluno(rs);
                            Professor pro = InstanciaProfessor(rs);
                            Equipamento eq = InstanciaEquipamento(rs);
                            FichaTreino ft = InstanciaFichaTreino(rs, al, pro);

                            Repeticao repeticao = InstanciaRepeticao(rs, eq, ft);
                            conn.Close();
                            return repeticao;
                        }
                    }
                    conn.Close();
                }
                return null;
            }

            public List<Repeticao> FindAll()
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "SELECT * FROM tb_repeticao" +
                        " join tb_equipamento ON tb_equipamento.id_Equipamento = tb_repeticao.id_Equipamento" +
                        " join tb_fichatr ON tb_repeticao.id_Fichatr = tb_fichatr.id_Fichatr" +
                        " join tb_aluno ON tb_aluno.id_Aluno = tb_fichatr.id_Aluno " +
                        "join tb_professor ON tb_professor.id_Prof = tb_fichatr.id_Prof ORDER BY tb_repeticao.id_Repeticao";

                    conn.Open();
                    using (SqlDataReader rs = st.ExecuteReader())
                    {
                        List<Repeticao> lista = new List<Repeticao>();
                        Dictionary<int, Equipamento> mapEquip = new Dictionary<int, Equipamento>();
                        Dictionary<int, FichaTreino> mapFicha = new Dictionary<int, FichaTreino>();
                        Dictionary<int, Aluno> mapAlun = new Dictionary<int, Aluno>();
                        Dictionary<int, Professor> mapProf = new Dictionary<int, Professor>();
                        while (rs.Read())
                        {
                            Equipamento eq = mapEquip.GetValueOrDefault(rs.GetInt32("id_Equipamento"));
                            FichaTreino ft = mapFicha.GetValueOrDefault(rs.GetInt32("id_Fichatr"));
                            Aluno al = mapAlun.GetValueOrDefault(rs.GetInt32("id_Aluno"));
                            Professor pro = mapProf.GetValueOrDefault(rs.GetInt32("id_Prof"));

                            if (eq == null && ft == null && al == null && pro == null)
                            {
                                pro = InstanciaProfessor(rs);
                                al = InstanciaAluno(rs);
                                eq = InstanciaEquipamento(rs);
                                ft = InstanciaFichaTreino(rs, al, pro);

                                mapEquip[eq.Id] = eq;
                                mapFicha[ft.Id] = ft;
                                mapAlun[al.Id] = al;
                                mapProf[pro.Id] = pro;
                            }

                            Repeticao repeticao = InstanciaRepeticao(rs, eq, ft);
                            lista.Add(repeticao);
                        }
                        conn.Close();
                        return lista;
                    }
                }
            }

            private Repeticao InstanciaRepeticao(SqlDataReader rs, Equipamento equip, FichaTreino ficha)
            {
                Repeticao repeticao = new Repeticao();
                repeticao.Id = rs.GetInt32("id_Repeticao");
                repeticao.Serie = rs.GetInt32("serie");
                repeticao.Repeticao = rs.GetInt32("repeticao");
                repeticao.Equip = equip;
                repeticao.FichaTr = ficha;
                return repeticao;
            }

            private Equipamento InstanciaEquipamento(SqlDataReader rs)
            {
                Equipamento equipamento = new Equipamento();
                equipamento.Id = rs.GetInt32("id_Equipamento");
                equipamento.Nome = rs.GetString("NomeEqp");
                return equipamento;
            }

            private FichaTreino InstanciaFichaTreino(SqlDataReader rs)
            {
                FichaTreino ficha = new FichaTreino();
                ficha.Id = rs.GetInt32("id_Fichatr");
                return ficha;
            }

            private FichaTreino InstanciaFichaTreino(SqlDataReader rs, Aluno alun, Professor prof)
            {
                FichaTreino ficha = new FichaTreino();
                ficha.Id = rs.GetInt32("id_Fichatr");
                ficha.Aluno = alun;
                ficha.Prof = prof;
                return ficha;
            }

            private Aluno InstanciaAluno(SqlDataReader rs)
            {
                Aluno alun = new Aluno();
                alun.Id = rs.GetInt32("id_Aluno");
                alun.Nome = rs.GetString("NomeA");
                return alun;
            }

            private Professor InstanciaProfessor(SqlDataReader rs)
            {
                Professor prof = new Professor();
                prof.Id = rs.GetInt32("id_Prof");
                prof.Nome = rs.GetString("NomeP");
                return prof;
            }
        }
    }

}
