using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        private void brn_agregar_Click(object sender, EventArgs e)
        {
            string connectionsql = "datasource=127.0.0.1;port=3306;username=root;password=;database=petshop;";
            string query = "INSERT INTO clientes (ID_CLIENTE, NOMBRE, APELLIDO, DIRECCION) VALUES (NULL, '"+textNombre.Text+"', '"+textApellido.Text+"', '"+textDireccion.Text+"')";

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
