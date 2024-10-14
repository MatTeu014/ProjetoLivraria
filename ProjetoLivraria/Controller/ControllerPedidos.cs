using ProjetoLivraria.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Controller
{
    internal class ControllerPedidos
    {
        public void CadastrarPedidos()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_PedidosCadastrar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoItensPedFK", Pedidos.CodigoItensPedFK);
                cmd.Parameters.AddWithValue("@dataPed", Pedidos.DataPed);
                cmd.Parameters.AddWithValue("@valorTotalPed", Pedidos.ValorTotalPed);
                cmd.Parameters.AddWithValue("@codigoCliFK", Pedidos.CodigoCliFK);
                cmd.Parameters.AddWithValue("@codigoFunFK", Pedidos.CodigoFunFK);
                cmd.Parameters.AddWithValue("@situacaoPed", Pedidos.SituacaoPed);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros inseridos com sucesso.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AlterarPedidos()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_PedidosAlterar", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoItensPedFK", Pedidos.CodigoItensPedFK);
                cmd.Parameters.AddWithValue("@dataPed", Pedidos.DataPed);
                cmd.Parameters.AddWithValue("@valorTotalPed", Pedidos.ValorTotalPed);
                cmd.Parameters.AddWithValue("@codigoCliFK", Pedidos.CodigoCliFK);
                cmd.Parameters.AddWithValue("@codigoFunFK", Pedidos.CodigoFunFK);
                cmd.Parameters.AddWithValue("@situacaoPed", Pedidos.SituacaoPed);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros alterados com sucesso.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void VisualizarPedidosCodigo()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_PedidosVisualizarCodigo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoPed", Pedidos.CodigoPed);
                cn.Open();
                cmd.ExecuteNonQuery();

                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Pedidos.CodigoPed = Convert.ToInt16(dr["codigoPed"]);
                    Pedidos.CodigoItensPedFK = Convert.ToInt16(dr["codigoItensPedFK"]);
                    Pedidos.DataPed = Convert.ToDateTime(dr["dataPed"]);
                    Pedidos.ValorTotalPed = Convert.ToDecimal(dr["valorTotalPed"]);
                    Pedidos.CodigoCliFK = Convert.ToInt16(dr["codigoCliFK"]);
                    Pedidos.CodigoFunFK = Convert.ToInt16(dr["codigoFunFK"]);
                    Pedidos.SituacaoPed = Convert.ToInt16(dr["situacaoPed"]);
                }
                else
                {
                    Pedidos.CodigoPed = 0;
                    Pedidos.CodigoItensPedFK = 0;              
                    Pedidos.ValorTotalPed = 0;
                    Pedidos.CodigoCliFK = 0;
                    Pedidos.CodigoFunFK = 0;
                    Pedidos.SituacaoPed = 0;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static BindingSource VisualizarPedidosNome()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_PedidosVisualizarNome", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codigoPed", Pedidos.CodigoPed);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;

        }
    }
}
