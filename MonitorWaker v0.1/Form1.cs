using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FontAwesome.Sharp;
using System.Windows.Forms;

namespace MonitorWaker_v0._1
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            timer1.Start();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 75);
            panelSideMenu.Controls.Add(leftBorderBtn);
        }

        #region ButtonActiveAndHide
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left boarder button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(11, 7, 17);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }
        #endregion

        #region HideSubMenu
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
        #endregion

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

        private void ibtn_ScreenWaker_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            openChildForm(new FormScreenWaker());
            hideSubMenu();
        }

        private void ibtn_Exit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            System.Threading.Thread.Sleep(500);
            Application.Exit();
        }

        /*About Me button*/
        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            showSubMenu(panelSideMenuAboutMe);
        }
        #region AboutMeSubMenu
        private void btn_Contact_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btn_Report_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        private void btnAutoCliker_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            hideSubMenu();
        }

        /*Date and time on Form Main*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.labelTime.Text = dateTime.ToLongTimeString();
            this.labelDate.Text = dateTime.ToLongDateString();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            timer1.Start();
            Reset();
            hideSubMenu();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void ibtn_Makro_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            hideSubMenu();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }
    }
}
