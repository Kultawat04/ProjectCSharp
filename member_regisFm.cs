using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using System.Security;
using System.Data.Odbc;
using System.Net.Http.Headers;
using System.Windows.Forms.VisualStyles;

namespace ProjectCSharp
{
    public partial class member_regisFm : Form
    {
        DataTableCollection tables;

        public member_regisFm()
        {
            InitializeComponent();

        }

        private void member_regisFm_Load(object sender, EventArgs e)
        {

        }

        public void refresh_dv()
        {
            OdbcConnection con = new OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;");
            string query = "SELECT * FROM MemberRegTb";
            OdbcDataAdapter da = new OdbcDataAdapter(query, con);
            DataSet ds = new DataSet();

            con.Open();

            da.Fill(ds);
            DataGridView1.DataSource = ds.Tables[0];

            con.Close();

        }

        public void textDT()
        {
            
            
        }

        public void clear_member()
        {
            employeeTb.Text = "";
            nameTb.Text = "";
            surnameTb.Text = "";
            sexCb.Text = "";
            statusCb.Text = "";
            commentTb.Text = "";
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            clear_member();
        }

        private void searchBt_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;");
            string query = "SELECT * FROM MemberRegTB WHERE Member_No = '" + employeeTb.Text +"'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();

            da.Fill(dt);
            if (dt.Rows.Count > 0)
                {
                employeeTb.Text = dt.Rows[0]["Member_No"].ToString();
                nameTb.Text = dt.Rows[0]["Member_Name"].ToString();
                surnameTb.Text = dt.Rows[0]["Member_Surname"].ToString();
                sexCb.Text = dt.Rows[0]["Member_Sex"].ToString();
                sectionCb.Text = dt.Rows[0]["Member_Section"].ToString();
                statusCb.Text = dt.Rows[0]["Member_Status"].ToString();
                commentTb.Text = dt.Rows[0]["Member_Comment"].ToString();
                }
            else
                {
                MessageBox.Show("Employee No. does not exist. Please check again.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            con.Close();


        }

        private void addBt_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection con = new OdbcConnection("Dsn = Cooper_odbc;uid=sa;pwd=sa");
                string query = @"INSERT INTO MemberRegTb VALUES 
                                '" + employeeTb.Text +"', '" + nameTb.Text + "', '" + surnameTb.Text + "'" +
                                ", '" + sexCb.Text + "', '" + sectionCb.Text + "', '" + statusCb.Text + "'" +
                                ", '" + commentTb.Text + "'";
                OdbcCommand cmd = new OdbcCommand(query, con);

                con.Open();

                if (employeeTb.Text == "")
                {
                    MessageBox.Show("Employee No. must be not blank.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (MessageBox.Show("Do you want to Add?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd.Parameters.AddWithValue("Member_No", employeeTb.Text);
                        cmd.Parameters.AddWithValue("Member_Name", nameTb.Text);
                        cmd.Parameters.AddWithValue("Member_Surname", surnameTb.Text);
                        cmd.Parameters.AddWithValue("Member_Sex", sexCb.Text);
                        cmd.Parameters.AddWithValue("Member_Section", sectionCb.Text);
                        cmd.Parameters.AddWithValue("Member_Comment", commentTb.Text);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        MessageBox.Show("Successfully Added", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.None);
                        clear_member();
                    }
                }

                con.Close();

            }
                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;");
            string query = @"UPDATE MemberRegTb SET Member_Name = '" + nameTb.Text + "', " +
                "Member_Surname = '" + surnameTb.Text + "', Member_Sex = '" + sexCb.Text + "', " +
                "Member_Section = '" + sectionCb.Text + "', Member_Status = '" + statusCb.Text + "', " +
                "Member_Comment = '" + commentTb.Text + "' WHERE Member_No = '" + employeeTb.Text + "'";
            OdbcCommand cmd = new OdbcCommand(query, con);         
            
            con.Open();

            if (employeeTb.Text == "")
            {
                MessageBox.Show("Employee No. must be not blank.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (MessageBox.Show("Do you want to Update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.Parameters.AddWithValue("Member_No", employeeTb.Text);
                    cmd.Parameters.AddWithValue("Member_Name", nameTb.Text);
                    cmd.Parameters.AddWithValue("Member_Surname", surnameTb.Text);
                    cmd.Parameters.AddWithValue("Member_Sex", sexCb.Text);
                    cmd.Parameters.AddWithValue("Member_Section", sectionCb.Text);
                    cmd.Parameters.AddWithValue("Member_Comment", commentTb.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    MessageBox.Show("Successfully Updated", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.None);
                    clear_member();
                }
            }


            con.Close();
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;");
            string query = "DELETE FROM MemberRegTb WHERE Member_No = '" + employeeTb.Text + "'";
            OdbcCommand cmd = new OdbcCommand(query, con);

            con.Open();

            if (employeeTb.Text == "")
            {
                MessageBox.Show("Employee No. must be not blank.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (MessageBox.Show("Do you want to Update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   cmd.Parameters.AddWithValue("Member_No", employeeTb.Text);
                   cmd.ExecuteNonQuery();
                   cmd.Parameters.Clear();
                   MessageBox.Show("Successfully Deleted", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.None);
                   clear_member();
                }

            }

            con.Close();

        }

        private void refreshBt_Click(object sender, EventArgs e)
        {
            refresh_dv();
        }

        private void clearBt_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void downloaddataBt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filenameTb.Text = ofd.FileName;
                var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);
                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = _ => new ExcelDataTableConfiguration
                    {
                        UseHeaderRow = true
                    }
                });

                tables = result.Tables;
                sheetCb.Items.Clear();
                foreach (DataTable table in tables)
                {
                    sheetCb.Items.Add(table.TableName);
                }

                
            }
        }

        private void sheetCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tables[sheetCb.SelectedItem.ToString()];
            if (dt != null)
            {
                List<MemberClass> list = new List<MemberClass>();
                for (int i = 0; i<dt.Rows.Count - 1;)
                {
                    var member = new MemberClass();
                    member.Member_No = dt.Rows[i][0].ToString();
                    member.Member_Name = dt.Rows[i][1].ToString();
                    member.Member_Surname = dt.Rows[i][2].ToString();
                    member.Member_Sex = dt.Rows[i][3].ToString();
                    member.Member_Section = dt.Rows[i][4].ToString();
                    member.Member_Status = dt.Rows[i][5].ToString();
                    member.Member_Comment = dt.Rows[i][6].ToString();

                }
                
                DataGridView1.DataSource = dt;

            }
        }

        private void importBt_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new OdbcConnection("Dsn=Cooper_odbc;uid=sa;pwd=sa;");
            OdbcCommand cmd = new OdbcCommand();

            if (filenameTb.Text == "" || sheetCb.Text == "")
            {
                MessageBox.Show("Please download excel data.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                cmd.Connection = con;
                for (int i = 0; i<DataGridView1.RowCount - 1;)
                {
                    cmd.CommandText = @"INSERT INTO MemberRegTb VALUES '" + DataGridView1.Rows[i].Cells[0].Value + "', " +
                        "'" + DataGridView1.Rows[i].Cells[1].Value + "', " +
                        "'" + DataGridView1.Rows[i].Cells[2].Value + "', " +
                        "'" + DataGridView1.Rows[i].Cells[3].Value + "', " +
                        "'" + DataGridView1.Rows[i].Cells[4].Value + "', " +
                        "'" + DataGridView1.Rows[i].Cells[5].Value + "', " +
                        "'" + DataGridView1.Rows[i].Cells[6].Value + "', ";
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Succesfully Imported", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            cmd.Dispose();
            con.Close();
            con.Dispose();
        }
    }
}
