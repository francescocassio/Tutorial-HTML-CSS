using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.UI;

    public class Auto
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public string Targa { get; set; }
    }

    public partial class AutoList : System.Web.UI.Page
    {
        public int a;
        public List<Auto> ListaAuto = new List<Auto>();

        protected void Page_Load(object sender, EventArgs e)
        {
            CaricaAutoDalDB(); // carica SEMPRE
        }

        private void CaricaAutoDalDB()
        {
            // ⚠️ Sostituisci con la tua connection string reale
            string connStr = "your_connection_string_here";
            string query = "SELECT Marca, Modello, Targa FROM Automobili";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                ListaAuto = new List<Auto>(); // reinizializza sempre

                while (reader.Read())
                {
                    ListaAuto.Add(new Auto
                    {
                        Marca = reader["Marca"].ToString(),
                        Modello = reader["Modello"].ToString(),
                        Targa = reader["Targa"].ToString()
                    });
                }

                conn.Close();
            }
        }
    }
