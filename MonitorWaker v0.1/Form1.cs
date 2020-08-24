using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorWaker_v0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelSideMenuAboutMe.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSideMenuAboutMe.Visible == true)
            {
                panelSideMenuAboutMe.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        /*Right panel, ChildForm*/
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_AboutMe_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSideMenuAboutMe);
        }
        #region AboutMeSubMenu
        private void btn_Contact_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        private void btn_ScreenWaker_Click(object sender, EventArgs e)
        {
            openChildForm(new FormScreenWaker());
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
