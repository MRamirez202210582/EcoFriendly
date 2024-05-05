using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string conexion = "Data Source=WINDOWS10SLQ\\SQLEXPRESS;Initial Catalog=\"Ecp Friendly Solutions\";Integrated Security=True;Trust Server Certificate=True";

        private void btninsertar_Click(object sender, EventArgs e)
        {

            using (SqlConnection cn = new SqlConnection(conexion))
            {

                SqlCommand cmd = new SqlCommand("insert into Products(ProductID,ProductName, Description, Price, StockQuantity, SustainabilityScore) values (" + txtidenticador.Text + ",'" + txtdato1.Text + "','" + txtdato2.Text + "','" + txtdato3.Text + "','" + txtdato4.Text + "','" + txtdato5.Text + "')", cn);
                cmd.CommandType = CommandType.Text;

                cn.Open();
                cmd.ExecuteNonQuery();

            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {

                SqlCommand cmd = new SqlCommand("update info set ProductName = '" + txtdato1.Text + "' , Description = '" + txtdato2.Text + "' , Price = '" + txtdato3.Text + "' , StockQuantity = '" + txtdato4.Text + "' , SustainabilityScore = '" + txtdato5.Text + "' where ProductID = " + txtidenticador.Text + "", cn);
                cmd.CommandType = CommandType.Text;

                cn.Open();
                cmd.ExecuteNonQuery();

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {

                SqlCommand cmd = new SqlCommand("delete from info where Products = " + txtidenticador.Text, cn);
                cmd.CommandType = CommandType.Text;

                cn.Open();
                cmd.ExecuteNonQuery();

            }

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Products", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }
        }

       
    }
}