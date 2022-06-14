using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class studentUpdateForm : Form
    {
        DataGridViewRow _gridViewRow;
        public studentUpdateForm(DataGridViewRow gridViewRow)
        {
            _gridViewRow = gridViewRow;
            InitializeComponent();
        }
        string id;
        // ------------------------ Load Data from DataSet to Update Form -------------------------------------
        private void studentUpdateForm_Load(object sender, EventArgs e)
        {
            id = _gridViewRow.Cells[0].Value.ToString();
            txtS_fName.Text = _gridViewRow.Cells[1].Value.ToString();
            txtS_lName.Text = _gridViewRow.Cells[2].Value.ToString();
            if (_gridViewRow.Cells[3].ToString() == "Male")
            {
                rdMale.Checked = true;
            }
            else
            {
                rdFemale.Checked = true;
            }
            bDate.Text = _gridViewRow.Cells[4].Value.ToString();
            cbClass.Text = _gridViewRow.Cells[5].Value.ToString();
            cbSection.Text = _gridViewRow.Cells[6].Value.ToString();
            cbGroup.Text = _gridViewRow.Cells[7].Value.ToString();
            txtAddress.Text = _gridViewRow.Cells[8].Value.ToString();
            txtFName.Text = _gridViewRow.Cells[9].Value.ToString();
            txtFContact.Text = _gridViewRow.Cells[10].Value.ToString();
            string pathFromServer = Path.Combine(_gridViewRow.Cells[11].Value.ToString());
            //studentProfile.Image = Image.FromFile(@"D:\me\project\project\SchoolManagement\images\ppppppp.jpg");
            studentProfile.Image = Image.FromFile(pathFromServer);

        }
        // -------------------------- Upload image procedure ----------------------------------------------
        string photopath;
        byte[] binaryPhoto;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            studentProfile.Image = null; 
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
        // --------------------------------- Clear Inputed Data -------------------------------------------
        private void clearInputData()
        {
            txtS_fName.Text = "";
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

        // ---------------------------- Update Edited Data to Database ----------------------------------------

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string location = @"E:\IDB\Module 5\ADO.NET\project\1264688\images";
            string path = Path.Combine(location, txtS_fName.Text+".jpg");

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
                        cmd.Parameters.AddWithValue("@sId", id);
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
                        cmd.Parameters.AddWithValue("@action", "Update");
                        Image img = studentProfile.Image;
                        var bitImage = new Bitmap(img);
                        cmd.ExecuteNonQuery();
                        if (!File.Exists(path))
                        {
                        img.Save(path);

                        }
                        MessageBox.Show("Student ID: " + id + " Updated Successfully");
                        clearInputData();
                        this.Close();
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInputData();
        }
        int selectedIndex;
        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            selectedIndex = cmb.SelectedIndex;
        }
    }
}
