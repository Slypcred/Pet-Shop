using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pet_Shop
{
    public partial class Form1 : Form
    {
        static string connectionsql = "datasource=127.0.0.1;port=3306;username=root;password=;database=petshop;";
        static string query = "SELECT * FROM clientes";

        public Form1()
        {
            InitializeComponent();
            Tabladedatos.Columns.Add("id", "ID");
            Tabladedatos.Columns.Add("Nombre", "NOMBRE");
            Tabladedatos.Columns.Add("Apellido", "APELLIDO");
            Tabladedatos.Columns.Add("Direccion", "DIRECCION");
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {

            if (textCliente.Text != "")
            {
                query = "SELECT * FROM clientes WHERE ID_CLIENTE = " + textCliente.Text;
            }
            else
            {
                query = "SELECT * FROM clientes";
            }

            Tabladedatos.Rows.Clear();

            MySqlConnection databaseConnection = new MySqlConnection(connectionsql);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();

                MySqlDataReader reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Tabladedatos.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    }
                }

                databaseConnection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Nuevo nuevo = new Nuevo();
            nuevo.Show();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar();
            eliminar.Show();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Modificar modificar = new Modificar();
            modificar.Show();
        }
    }
}
