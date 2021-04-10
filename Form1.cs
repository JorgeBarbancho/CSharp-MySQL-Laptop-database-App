using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace EAC2Ex3
{
    public partial class laptopViewer : Form
    {
        private static readonly String HOST = "localhost";
        private static readonly String BD = "m07eac2";
        private static readonly String USER = "jorge";
        private static readonly String PASSWORD = "jorge";
        private static readonly String connectionString = "Server=" + HOST + ";Database=" + BD + ";Uid=" + USER + ";Pwd=" + PASSWORD + ";";
        MySqlConnection conn = new MySqlConnection(connectionString);

        private int index = 1;
        private int limit;
        

        public laptopViewer()
        {
            InitializeComponent();
            GetLimit();
            SelectData();
            favList.Visible = false;
            imageBox.Visible = true;
            imageButton.Checked = true;
            charsBox.Visible = false;
            charsButton.Checked = false;
        }

        private void GetLimit()
        {
            string sql = "SELECT COUNT(*) FROM manuals";
            
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    conn.Open();
                    limit = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void SelectData() 
        { 
            string sql = "SELECT * FROM manuals WHERE id=@id";
           
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", index));
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nameLabel.Text = (string)reader[1];
                            priceLabel.Text = (double)reader[2]+"€";
                            charsBox.Text = (string)reader[3];
                            imageBox.Load((string)reader[4]);
                        }                            
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CheckFavorite();
            
        }        

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (index > 1)
            {
                index--;
                SelectData();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (index < limit)
            {
                index++;
                SelectData();
            }
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            index = limit;
            SelectData();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            index = 1;
            SelectData();
        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            if (charsBox.Visible)
            {
                charsBox.Visible = false;
                imageBox.Visible = true;
                charsButton.Checked = false;
            }
        }

        private void CheckFavorite()
        {
            string sql = "SELECT is_favorite FROM manuals WHERE id=@id";
            bool result = false;
           
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", index));
                    result = (bool)cmd.ExecuteScalar();                    
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            if (!result)
            {
                starBox.Load("..\\..\\Resources\\whiteStar.png");
                favButton.Text = "añadir a favoritos";
            }
            else
            {
                starBox.Load("..\\..\\Resources\\goldStar.png");
                favButton.Text = "eliminar de favoritos";
            }
        }

        private void CharsButton_Click(object sender, EventArgs e)
        {
            if (imageBox.Visible)
            {
                charsBox.Visible = true;
                imageBox.Visible = false;
                imageButton.Checked = false;
            }
        }

        private void ToggleFavorite()
        {
            string sql = "UPDATE manuals SET is_favorite = NOT is_favorite WHERE id = @id; ";

            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", index));
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CheckFavorite();
        }

        private void showFavList()
        {
            string sql = "SELECT * FROM manuals WHERE is_favorite IS TRUE ORDER BY name ASC; ";
            object[] buffer = new object[5];
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", index));
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            buffer[0] = (string)reader[1];
                            buffer[1] = (double)reader[2];
                            rows.Add(new DataGridViewRow());
                            rows[rows.Count - 1].CreateCells(favList, buffer);
                        }                        
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            favList.Rows.Clear();
            favList.Rows.AddRange(rows.ToArray());
        }

        private void FavButton_Click(object sender, EventArgs e)
        {
            ToggleFavorite();  
        }

        private void starButton_Click(object sender, EventArgs e)
        {
            ToggleFavorite();
        }

        private void favListButton_Click(object sender, EventArgs e)
        {
            favList.Visible = !favList.Visible;
            starBox.Visible = !starBox.Visible;
            priceLabel.Visible = !priceLabel.Visible;
            firstButton.Enabled = !firstButton.Enabled;
            backButton.Enabled = !backButton.Enabled;
            nextButton.Enabled = !nextButton.Enabled;
            lastButton.Enabled = !lastButton.Enabled;
            imageButton.Enabled = !imageButton.Enabled;
            charsButton.Enabled = !charsButton.Enabled;
            favButton.Enabled = !favButton.Enabled;
            charsButton.Checked = false;
            imageButton.Checked = false;

            if (favList.Visible)           
            {
                showFavList();
                favListButton.Text = "ver todos";
                nameLabel.Text = "lista de favoritos";

            }
            else
            {
                favListButton.Text = "ver favoritos";
                SelectData();
            }
            
        }       
        
    }   
}
