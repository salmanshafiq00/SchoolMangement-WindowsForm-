using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class schoolManagement : Form
    {
        public schoolManagement()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            regSubMenuPanel.Visible = false;
            infoSubPanel.Visible = false;
            studentPerformanceForm.Visible = false;
        }
        private void hideSubMenu()
        {
            if (regSubMenuPanel.Visible)
            {
                regSubMenuPanel.Visible = false;
                
            }
            if (infoSubPanel.Visible)
            {
                infoSubPanel.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                ////hideSubMenu();
                subMenu.Visible = false;
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            showSubMenu(regSubMenuPanel);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            studentPerformanceForm.Visible = false;
            teacherRegistrationForm.Visible = false;
            studentRegistrationForm.Visible = false;
            studentInfo.Visible = false;
            hideSubMenu();
        }
        private void btnRegStu_Click(object sender, EventArgs e)
        {
            studentPerformanceForm.Visible = false;
            teacherRegistrationForm.Visible = false;
            studentRegistrationForm.Visible = true;
            studentInfo.Visible = false;
            hideSubMenu();
        }

        private void btnRegTea_Click(object sender, EventArgs e)
        {
            studentPerformanceForm.Visible = false;
            studentRegistrationForm.Visible = false;
            teacherRegistrationForm.Visible = true;
            studentInfo.Visible = false;
            hideSubMenu();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

            showSubMenu(infoSubPanel);

        }

        private void schoolManagement_Load_1(object sender, EventArgs e)
        {
            studentPerformanceForm.Visible = false;
            studentRegistrationForm.Visible = false;
            teacherRegistrationForm.Visible = false;
            studentInfo.Visible = false;
        }

        private void btnStuInfo_Click(object sender, EventArgs e)
        {
            studentPerformanceForm.Visible = false;
            studentRegistrationForm.Visible = false;
            teacherRegistrationForm.Visible = false;

            studentInfo.loadData();
            studentInfo.Visible = true;
            hideSubMenu();
        }

        private void btnTeaInfo_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnStuProfile_Click(object sender, EventArgs e)
        {
            StudentProfile sp = new StudentProfile();
            sp.Show();
            hideSubMenu();
        }

        private void btnStuPerform_Click(object sender, EventArgs e)
        {
            studentRegistrationForm.Visible = false;
            teacherRegistrationForm.Visible = false;
            studentInfo.Visible = false;
            studentPerformanceForm.Visible = true;
            hideSubMenu();
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maxApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maxApp.Visible = false;
            restoreApp.Location = maxApp.Location;
            restoreApp.Visible = true;
        }

        private void minimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void restoreApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restoreApp.Visible = false;
            maxApp.Visible = true;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            reportFormSchoolManagement rform = new reportFormSchoolManagement();
            rform.Show();
        }
    }
}
