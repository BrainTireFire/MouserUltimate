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
    public partial class FormScreenWaker : Form
    {
        int Exception;
        int timeToWork;

        public FormScreenWaker()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tb_TimeToWork.Text, out Exception))
            {
                MessageBox.Show("Please enter a number, Boomer!!");
            }
            else
            {
                timeToWork = int.Parse(tb_TimeToWork.Text);
            }
            CursorMove cursorMove = new CursorMove(timeToWork);
            cursorMove.CursorEvent();
        }

        private void tb_TimeToWork_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void btn_LongTime_Click_Click(object sender, EventArgs e)
        {
            CursorMove cursorMove = new CursorMove(timeToWork);
            cursorMove.CursorEvent2();
        }
    }
}
