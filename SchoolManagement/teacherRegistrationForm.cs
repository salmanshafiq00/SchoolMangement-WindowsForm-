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
    public partial class teacherRegistrationForm : UserControl
    {
        public teacherRegistrationForm()
        {
            InitializeComponent();
            
        }

        private void teacherRegistrationForm_Load(object sender, EventArgs e)
        {
            fillClassCombo();
            
        }
// -------------------------- Fill the group comboBox  -------------------------------------
        private void fillClassCombo()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBSM"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    try
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "Select GroupName from GroupTable";
                        var adapter = new SqlDataAdapter(cmd);

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        foreach (DataRow dr in dataTable.Rows)
                        {
                            cbGroup.Items.Add(dr["GroupName"]).ToString();
                        }
                    }
                    catch (Exception)
                    {

                       
                    }
                   
                }
            }
        }
        int selectedIndex;
        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
 
                ComboBox cmb = (ComboBox)sender;
                selectedIndex = cmb.SelectedIndex;
                fillRelationSubject();
        }

        // ------------------------ Fill Relation subject ComboBox ----------------------------

        private void fillRelationSubject()
        {
            cbSubject.Items.Clear();
            string cs = ConfigurationManager.ConnectionStrings["DBSM"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spRelationalSubject";
                    cmd.Parameters.AddWithValue("@gId", selectedIndex+1);
                    var adapter = new SqlDataAdapter(cmd);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        cbSubject.Items.Add(dr["SubjectName"]).ToString();
                    }
                }
            }
        }
    }
}
