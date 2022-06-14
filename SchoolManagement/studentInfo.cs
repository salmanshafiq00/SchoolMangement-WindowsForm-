using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class studentInfo : UserControl
    {
        public static studentInfo instance;
        public studentInfo()
        {
            InitializeComponent();
            instance = this;
        }
        public void loadData()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBSM"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "spMasterSrocStudentTable";
                        cmd.Parameters.AddWithValue("@action", "Select");
                        var adapter = new SqlDataAdapter(cmd);

                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);
                        dgvForStuInfo.DataSource = dataSet.Tables[0];
                    }
                    catch (Exception)
                    {

                       
                    }
                   
                }
            }
        }
// ------------------- Select or Load Data from Database --------------------------------------------------
        private void studentInfo_Load(object sender, EventArgs e)
        {
            loadData();
        }
        // -------------------- Delete Data Procedure --------------------------------------------------------------
        private void btnStuDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to delete the row?");
            var id = dgvForStuInfo.SelectedRows[0].Cells[0].Value.ToString();
            if (id == null)
            {
                MessageBox.Show("Select a row for delete");
            }

            string cs = ConfigurationManager.ConnectionStrings["DBSM"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spMasterSrocStudentTable";
                    cmd.Parameters.AddWithValue("@sId", id);
                    cmd.Parameters.AddWithValue("@action", "Delete");
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("'" + id + "' no deleted");
                    loadData();
                }
            }
        }
// -------------------------------- Update Data Procedure -------------------------------------------------
        private void btnStuUpdate_Click(object sender, EventArgs e)
        {
            if (gridViewRow == null)
            {
                MessageBox.Show("Please select a row");
            }
            else
            {
                studentUpdateForm stuUpForm = new studentUpdateForm(gridViewRow);
                stuUpForm.Show();
            }

        }

        DataGridViewRow gridViewRow;
        private void dgvForStuInfo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gridViewRow = dgvForStuInfo.Rows[e.RowIndex];
        }
        public DataGridViewRow GetRow
        {
            get
            {
                return gridViewRow;
            }
        }
        // -------------------- ---------Double click for Student Profile ---------------------

        private void dgvForStuInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(this.dgvForStuInfo.CurrentRow.Cells[0].Value.ToString());
            StudentProfile studentProfile = new StudentProfile(id);
            studentProfile.Show();
        }
    }
}
