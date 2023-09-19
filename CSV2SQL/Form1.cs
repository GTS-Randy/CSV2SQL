using System;
using System.Data.SqlClient;

namespace CSV2SQL
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=SRV;Database=master;User Id=UID;Password=PWD;";

        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_CSVFile_Click(object sender, EventArgs e)
        {
            if (ofd_CSVFile.ShowDialog() == DialogResult.OK)
            {
                lbl_CSVFile.Text = ofd_CSVFile.FileName;
            }
        }

        private void Txt_SQLPass_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_SQLServerAddress.Text) && !string.IsNullOrEmpty(txt_SQLUserName.Text) && 
                !string.IsNullOrEmpty(txt_SQLPass.Text))
            {
                // attempt to connect and DB's
                connectionString = connectionString.Replace("SRV", txt_SQLServerAddress.Text);
                connectionString = connectionString.Replace("UID", txt_SQLUserName.Text);
                connectionString = connectionString.Replace("PWD", txt_SQLPass.Text);

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // SQL query to retrieve database names
                        string query = "SELECT name FROM sys.databases WHERE database_id > 4 AND HAS_DBACCESS(name) = 1"; // Filter out system databases

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    if (!cmb_SQLDatabase.Enabled) { cmb_SQLDatabase.Enabled = true; }
                                    string dbName = reader["name"].ToString()!;
                                    cmb_SQLDatabase.Items.Add(dbName);
                                }
                            }
                        }

                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void Cmb_SQLDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmb_SQLDatabase.SelectedItem.ToString()))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // SQL query to retrieve database names
                        string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_CATALOG = @CatalogName";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@CatalogName", cmb_SQLDatabase.SelectedItem.ToString());
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    if (!cmb_SQLTable.Enabled) { cmb_SQLTable.Enabled = true; }
                                    string tableName = reader["TABLE_NAME"].ToString()!;
                                    cmb_SQLTable.Items.Add(tableName);
                                }
                            }
                        }

                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            }
        }


    }
}