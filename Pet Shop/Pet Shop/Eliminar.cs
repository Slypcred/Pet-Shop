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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            string connectionsql = "datasource=127.0.0.1;port=3306;username=root;password=;database=petshop;";
            string query = "DELETE FROM clientes WHERE ID_CLIENTE = " + textBorrar.Text;

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
