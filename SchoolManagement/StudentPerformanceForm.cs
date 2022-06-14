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
    public partial class StudentPerformanceForm : UserControl
    {
        public StudentPerformanceForm()
        {
            InitializeComponent();
        }

        private void std_id_TextChanged(object sender, EventArgs e)
        {

            string s_id = std_id.Text;
            if (s_id != "0" && s_id != null)
            {
            loadData(s_id);

            }
            else
            {
                MessageBox.Show("Please input valid ID");
            }

        }

        public void loadData(string id)
        {
            string s_id = id;
            string cs = ConfigurationManager.ConnectionStrings["DBSM"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "Select StudentID, FirstName, LastName, ct.class_Name from dbo.StudentTable st join dbo.ClassTable ct ON st.sClass = ct.class_ID where StudentID = @id";
                    cmd.Parameters.AddWithValue("@id", s_id);
                    var adapter = new SqlDataAdapter(cmd);

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    try
                    {
                        var getId = dataSet.Tables[0].Rows[0][0].ToString();
                        var firstName = dataSet.Tables[0].Rows[0][1].ToString();
                        var lastName = dataSet.Tables[0].Rows[0][2].ToString();
                        var cls = dataSet.Tables[0].Rows[0][3].ToString();

                        std_name.Text = firstName.ToString() + " " + lastName.ToString();
                        std_class.Text = cls.ToString();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Data not found!");
                    }
                    
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String cs = ConfigurationManager.ConnectionStrings["DBSM"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    var sId = std_id.Text;
                    var ttlFee = txtTotalFee.Text;
                    var ttlPayment = txtPaymentFee.Text;
                    var pmntDate = dPaymentDate.Value;
                    var exm = cbExam.Text.ToString();
                    var gpa = cbGrade.Text.ToString();
                    var exmYear = dExamYear.Value.ToString();


                    cmd.CommandText = "Insert into StudentResult Values(@s_id,@fee, @payment,@paymentDate, @xm, @gp, @xYear)";
                    cmd.Parameters.AddWithValue("@s_id", sId);
                    cmd.Parameters.AddWithValue("@fee", ttlFee);
                    cmd.Parameters.AddWithValue("@payment", ttlPayment);
                    cmd.Parameters.AddWithValue("@paymentDate", pmntDate);
                    cmd.Parameters.AddWithValue("@xm", exm);
                    cmd.Parameters.AddWithValue("@gp", gpa);
                    cmd.Parameters.AddWithValue("@xYear", exmYear);
                   
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Result Updated Successfully");
                    clearData();
                }
            }
        }

        private void clearData()
        {
            std_id.Clear();
            std_name.Clear();
            std_class.Clear();
            cbExam.Text = "";
            cbGrade.Text = "";
            dExamYear.Value = DateTime.Today;
        }
    }
}
