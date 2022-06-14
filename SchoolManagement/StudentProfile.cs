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
    public partial class StudentProfile : Form
    {
        public StudentProfile()
        {
            InitializeComponent();
        }
        int idForGrid;
        public StudentProfile(int idNo)
        {
            InitializeComponent();
            idForGrid = idNo;
            loadData(idForGrid);
        }

        public void loadData(int id)
        {
            int s_id = id;
            string cs = ConfigurationManager.ConnectionStrings["DBSM"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", s_id);
                    try
                    {
                        cmd.CommandText = "spStudentProfileQuery";
                       
                        var adapter = new SqlDataAdapter(cmd);

                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);

                        var getId = dataSet.Tables[0].Rows[0][0].ToString();
                        var stdFname = dataSet.Tables[0].Rows[0][1].ToString();
                        var stdLname = dataSet.Tables[0].Rows[0][2].ToString();
                        var gndr = dataSet.Tables[0].Rows[0][3].ToString();
                        var dob = dataSet.Tables[0].Rows[0][4].ToString();
                        var cls = dataSet.Tables[0].Rows[0][5].ToString();
                        var sction = dataSet.Tables[0].Rows[0][6].ToString();
                        var group = dataSet.Tables[0].Rows[0][7].ToString();
                        var addr = dataSet.Tables[0].Rows[0][8].ToString();
                        var ftrName = dataSet.Tables[0].Rows[0][9].ToString();
                        var ftrContact = dataSet.Tables[0].Rows[0][10].ToString();
                        var exm = dataSet.Tables[0].Rows[0][11].ToString();
                        var grade = dataSet.Tables[0].Rows[0][12].ToString();
                        var exmYear = dataSet.Tables[0].Rows[0][13].ToString();
                        var img = dataSet.Tables[0].Rows[0][14].ToString();
                        var ttlFee = dataSet.Tables[0].Rows[0][15].ToString();
                        var ttlPayment = dataSet.Tables[0].Rows[0][16].ToString();
                        var pmntDate = dataSet.Tables[0].Rows[0][17].ToString();
                        string path = Path.Combine(img);

                        placeId.Text = getId;
                        firstName.Text = stdFname;
                        lastName.Text = stdLname;
                        placeClass.Text = cls;
                        placeSection.Text = sction;
                        placeGroup.Text = group;
                        placeBdate.Text = dob;
                        placeAddress.Text = addr;
                        placeGender.Text = gndr;
                        placeFather.Text = ftrName;
                        placeContact.Text = ftrContact;
                        placeExam.Text = exm;
                        placeExmYear.Text = exmYear;
                        placeGpa.Text = grade;
                        picBox.Image = Image.FromFile(path);
                        lblTotalFee.Text = ttlFee;
                        lblTotalPayment.Text = ttlPayment;
                        lblPaymentDate.Text = pmntDate;
                        
                    }
                    catch (IndexOutOfRangeException)
                    {

                        cmd.CommandText = "spStudentProfileAlterQuery";
                        var adapter = new SqlDataAdapter(cmd);

                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);

                        try
                        {
                            var getId = dataSet.Tables[0].Rows[0][0].ToString();
                            var stdFname = dataSet.Tables[0].Rows[0][1].ToString();
                            var stdLname = dataSet.Tables[0].Rows[0][2].ToString();
                            var gndr = dataSet.Tables[0].Rows[0][3].ToString();
                            var dob = dataSet.Tables[0].Rows[0][4].ToString();
                            var cls = dataSet.Tables[0].Rows[0][5].ToString();
                            var sction = dataSet.Tables[0].Rows[0][6].ToString();
                            var group = dataSet.Tables[0].Rows[0][7].ToString();
                            var addr = dataSet.Tables[0].Rows[0][8].ToString();
                            var ftrName = dataSet.Tables[0].Rows[0][9].ToString();
                            var ftrContact = dataSet.Tables[0].Rows[0][10].ToString();
                            var img = dataSet.Tables[0].Rows[0][11].ToString();
                            string path = Path.Combine(img);

                            placeId.Text = getId;
                            firstName.Text = stdFname;
                            lastName.Text = stdLname;
                            placeClass.Text = cls;
                            placeSection.Text = sction;
                            placeGroup.Text = group;
                            placeBdate.Text = dob;
                            placeAddress.Text = addr;
                            placeGender.Text = gndr;
                            placeFather.Text = ftrName;
                            placeContact.Text = ftrContact;
                            picBox.Image = Image.FromFile(path);
                            placeExam.Text = "Not Found";
                            placeExmYear.Text = "Not Found";
                            placeGpa.Text = "Not Found";
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Data not found!");
                        }
                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Data not found!");
                    }

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int s_id = 0;
             int.TryParse(search.Text,out s_id);
            if (s_id > 0)
            {
                loadData(s_id);

            }
            else
            {
                MessageBox.Show("Please input valid ID");
            }
        }

        //-------------------------------------------------------------------------
    }
}
