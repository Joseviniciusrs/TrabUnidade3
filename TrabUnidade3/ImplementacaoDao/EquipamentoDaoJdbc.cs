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

    namespace ImplementacaoDao
    {
        public class EquipamentoDaoJdbc : IEquipamentoDao
        {
            private SqlConnection conn;

            public EquipamentoDaoJdbc(SqlConnection conn)
            {
                this.conn = conn;
            }

            public void Insert(Equipamento obj)
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "INSERT INTO tb_equipamento (NomeEqp) VALUES (@NomeEqp); SELECT SCOPE_IDENTITY();";
                    st.Parameters.AddWithValue("@NomeEqp", obj.Nome);

                    conn.Open();
                    int id = Convert.ToInt32(st.ExecuteScalar());
                    conn.Close();

                    obj.Id = id;
                }
            }

            public void Update(Equipamento obj)
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "UPDATE tb_equipamento SET NomeEqp = @NomeEqp WHERE id_Equipamento = @Id";
                    st.Parameters.AddWithValue("@NomeEqp", obj.Nome);
                    st.Parameters.AddWithValue("@Id", obj.Id);

                    conn.Open();
                    st.ExecuteNonQuery();
                    conn.Close();
                }
            }

            public void DeleteById(int id)
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "DELETE FROM tb_equipamento WHERE id_Equipamento = @Id";
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

            public Equipamento FindById(int id)
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "SELECT * FROM tb_equipamento WHERE tb_equipamento.id_Equipamento = @Id";
                    st.Parameters.AddWithValue("@Id", id);

                    conn.Open();
                    using (SqlDataReader rs = st.ExecuteReader())
                    {
                        if (rs.Read())
                        {
                            Equipamento equip = InstanciaEquipamento(rs);
                            conn.Close();
                            return equip;
                        }
                    }
                    conn.Close();
                }
                return null;
            }

            public List<Equipamento> FindAll()
            {
                using (SqlCommand st = conn.CreateCommand())
                {
                    st.CommandText = "SELECT * FROM tb_equipamento ORDER BY NomeEqp";

                    conn.Open();
                    using (SqlDataReader rs = st.ExecuteReader())
                    {
                        List<Equipamento> lista = new List<Equipamento>();

                        while (rs.Read())
                        {
                            Equipamento equip = InstanciaEquipamento(rs);
                            lista.Add(equip);
                        }

                        conn.Close();
                        return lista;
                    }
                }
            }

            private Equipamento InstanciaEquipamento(SqlDataReader rs)
            {
                Equipamento equip = new Equipamento();
                equip.Id = Convert.ToInt32(rs["id_Equipamento"]);
                equip.Nome = rs["NomeEqp"].ToString();
                return equip;
            }
        }
    }

}
