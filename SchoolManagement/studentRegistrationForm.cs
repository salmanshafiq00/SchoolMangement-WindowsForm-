using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SchoolManagement
{
    public partial class studentRegistrationForm : UserControl
    {
        public studentRegistrationForm()
        {
            InitializeComponent();
        }
        public static string photopath;
        byte[] binaryPhoto;
        private void btnUpload_Click(object sender, EventArgs e)
        { 
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "png|*.png|jpg|*.jpg|Gif|*.Gif|jpegs|*.jpegs|bitmaps|*.bitmaps";
            file.Title = "Please Select an Image";
            if (file.ShowDialog() == DialogResult.OK)
            {
                studentProfile.Image = new Bitmap(file.OpenFile());
                photopath = file.FileName;
                FileStream fs = new FileStream(photopath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                binaryPhoto = br.ReadBytes((int)fs.Length);
                fs.Close();
            }
        }
        
        // function for clear the input
        private void clearInputData()
        {
            txtS_fName.Text="";
            txtS_lName.Text = "";
            rdMale.Checked = false;
            rdFemale.Checked = false;
            bDate.Value = DateTime.Today;
            cbClass.Text = "";
            cbSection.Text = "";
            cbGroup.Text = "";
            txtAddress.Text = "";
            txtFName.Text = "";
            txtFContact.Text = "";
            studentProfile.Image = null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string location = @"F:\IDB\Projects\1264688(Final)\SchoolManagement\Images";
            //string path = Path.Combine(Environment.CurrentDirectory, "images", txtS_fName.Text+".jpg" );
            string path = Path.Combine(location, txtS_fName.Text + ".jpg");
            if (txtS_fName.Text == "")
            {
                MessageBox.Show("Please Enter First Name");
                txtS_fName.Focus();
                return;
            }
            if (txtS_lName.Text == "")
            {
                MessageBox.Show("Please Enter Last Name");
                txtS_lName.Focus();
                return;
            }          
            if (rdMale.Checked == false && rdFemale.Checked == false)
            {
                MessageBox.Show("Plase Select Your Gender");
                return;
            }
            if (bDate.Text == "")
            {
                MessageBox.Show("Please Enter Date of Birth");
                bDate.Focus();
                return;
            }
            if (cbClass.Text == "")
            {
                MessageBox.Show("Please Select Class");
                cbClass.Focus();
                return;
            }
            if (cbSection.Text == "")
            {
                MessageBox.Show("Please Select Section");
                cbSection.Focus();
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Enter Student Address");
                txtAddress.Focus();
                return;
            }
            if (txtFName.Text == "")
            {
                MessageBox.Show("Please Enter Father Name");
                txtFName.Focus();
                return;
            }
            if (txtFContact.Text == "")
            {
                MessageBox.Show("Please Enter Father's Contact Number");
                txtFContact.Focus();
                return;
            }
            if (studentProfile.Image == null)
            {
                MessageBox.Show("Please Upload Student Profile Picture");
                btnUpload.Focus();
                return;
            }
            else
            {
                String cs = ConfigurationManager.ConnectionStrings["DBSM"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "spMasterSrocStudentTable";
                        cmd.Parameters.AddWithValue("@s_fname", txtS_fName.Text);
                        cmd.Parameters.AddWithValue("@s_lname", txtS_lName.Text);
                        cmd.Parameters.AddWithValue("@s_gender", rdMale.Checked ? rdMale.Text : rdFemale.Text);
                        cmd.Parameters.AddWithValue("@s_dob", bDate.Value);
                        cmd.Parameters.AddWithValue("@s_class", selectedIndex+1);
                        cmd.Parameters.AddWithValue("@s_section", cbSection.Text);
                        cmd.Parameters.AddWithValue("@s_group", cbGroup.Text);
                        cmd.Parameters.AddWithValue("@s_address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@s_faName", txtFName.Text);
                        cmd.Parameters.AddWithValue("@s_faContact", txtFContact.Text);
                        cmd.Parameters.AddWithValue("@s_photo", path);
                        cmd.Parameters.AddWithValue("@action", "Insert");
                        Image img = studentProfile.Image;
                        cmd.ExecuteNonQuery();
                        img.Save(path);

                        MessageBox.Show("New Student Registered Successfully");
                        clearInputData();
                        
                    }               
                }
            }
        }
// --------------------------- clear input data when click on clear button -----------------------
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInputData();
        }

// ---------------------------- Fill ComboBox From Database ---------------------------------------
        private void fillClassCombo()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBSM"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select class_Name from ClassTable";
                    var adapter = new SqlDataAdapter(cmd);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        cbClass.Items.Add(dr["class_Name"]).ToString();
                    }
                }
            }
        }
// ----------------------- Load ComboBox when page load --------------------------------------------
        private void studentRegistrationForm_Load(object sender, EventArgs e)
        {
            fillClassCombo();
        }
// ------------------------ receive the selected index value from comboBox -------------------------
        int selectedIndex;
        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            selectedIndex = cmb.SelectedIndex;
            //int selectedValue = (int)cmb.SelectedValue;
        }

        private void studentProfile_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //PictureBox pictureBox = sender as PictureBox;
            //if (pictureBox != null)
            //{
            //    openFileDialog.Filter = "png|*.png|jpg|*.jpg|Gif|*.Gif|jpegs|*.jpegs|bitmaps|*.bitmaps";
            //    if (openFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            //    }
            //}

        }
    }
}
