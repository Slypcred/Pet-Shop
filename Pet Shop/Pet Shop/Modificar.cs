using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Shop
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void btn_modificarr_Click(object sender, EventArgs e)
        {
            string connectionsql = "datasource=127.0.0.1;port=3306;username=root;password=;database=petshop;";
            string query = "";

            if (textNombreMod.Text != "")
            {
                query = "UPDATE clientes SET NOMBRE = '" + textNombreMod.Text + "' WHERE ID_CLIENTE = " + textMod.Text;
            }

            if (textApellidoMod.Text != "")
            {
                query = "UPDATE clientes SET APELLIDO = '" + textApellidoMod.Text + "' WHERE ID_CLIENTE = " + textMod.Text;
            }

            if (textDireccionMod.Text != "")
            {
                query = "UPDATE clientes SET DIRECCION = '" + textDireccionMod.Text + "' WHERE ID_CLIENTE = " + textMod.Text;
            }

            MySqlConnection databaseConnection = new MySqlConnection(connectionsql);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();

                MySqlDataReader reader = commandDatabase.ExecuteReader();

                databaseConnection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            this.Close();
        }
    }
}
