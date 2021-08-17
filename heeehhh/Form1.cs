using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heeehhh
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OI2JPD3\SQLEXPRESS;Initial Catalog=lakoo;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayData()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {

                    conn.Open();
                }
                string query = "Select * from std_list ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                student_list.Rows.Clear();

                int sn = 0;
                foreach (DataRow dataRow in dt.Rows)
                {
                    sn++;
                    student_list.Rows.Add(dataRow["id"],sn, dataRow["name"], dataRow["address"],"Edit");
                }
            }
            catch (Exception err)
            {
                //MessageBox.Show(err.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                DisplayData();
        }

           
            
        

        private void badaa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string st_name = std_name.Text;
                string st_add = std_address.Text;
                string query = "Insert into std_list (Name, Address) values (@parameter_name, @parameter_address)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@parameter_name", st_name);
                cmd.Parameters.AddWithValue("@parameter_address", st_add);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            DisplayData();
            //student_list.Rows.Add(student_list.Rows.Count+1, name, address);
        }

        private void milaa_Click(object sender, EventArgs e)
        {
            try
            {
                if (student_id != 0)
                {
                    conn.Open();
                    string st_name = std_name.Text;
                    string st_address = std_address.Text;
                   /* string query = "Insert into std(name,address) values ("+ st_name +","+ st_address +")";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();*/
                    //passing paramerter method
                    string query = "Update std_list set Name=@parameter_name, Address=@parameter_address where id=@parameter_id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@parameter_name", st_name);
                    cmd.Parameters.AddWithValue("@parameter_address", st_address);
                    cmd.Parameters.AddWithValue("@parameter_id", student_id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully");

                    std_name.Text = "";
                    std_address.Text = "";
                    
                    student_id = 0;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conn.Close();
            }

            DisplayData();
        }
    

        private void hatta_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (student_list.SelectedRows.Count > 0)
                {
                    //for deleting single rows
                    //student_list.Rows.RemoveAt(student_list.SelectedRows[0].Index);

                    // for deleting multiple rows
                    foreach (DataGridViewRow row in student_list.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["id"].Value);
                        string query = "Delete from std_list where id = @parameter_id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@parameter_id", id);
                        cmd.ExecuteNonQuery();
                        student_list.Rows.RemoveAt(row.Index);
                        MessageBox.Show("Removed Successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Selected the row first");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conn.Close();
            }
            DisplayData();

        }

        private void std_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_click_Click(object sender, EventArgs e)
        {
            std_name.Text = "";
            std_address.Text = "";
            student_id = 0;
        }
        int student_id;
        private void student_list_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == student_list.Columns["Action"].Index)
            {
                string student_name = student_list.CurrentRow.Cells["stdname"].Value.ToString();
                student_id = Convert.ToInt32(student_list.CurrentRow.Cells["id"].Value.ToString());
                string student_address = student_list.CurrentRow.Cells["stdaddress"].Value.ToString(); 
                MessageBox.Show("Id :" + student_id + "\n Name" + student_name);
                std_name.Text = student_name;
                std_address.Text = student_address;
            }
        }
    }
}

