namespace MonitorWaker_v0._1
{
    partial class FormScreenWaker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Start = new System.Windows.Forms.Button();
            this.tb_TimeToWork = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.btn_LongTime_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelScreenWaker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Start.Location = new System.Drawing.Point(63, 326);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(223, 137);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // tb_TimeToWork
            // 
            this.tb_TimeToWork.Location = new System.Drawing.Point(63, 249);
            this.tb_TimeToWork.Name = "tb_TimeToWork";
            this.tb_TimeToWork.Size = new System.Drawing.Size(143, 20);
            this.tb_TimeToWork.TabIndex = 1;
            this.tb_TimeToWork.TextChanged += new System.EventHandler(this.tb_TimeToWork_TextChanged);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelTime.Location = new System.Drawing.Point(59, 203);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(101, 24);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "Type Time";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // btn_LongTime_Click
            // 
            this.btn_LongTime_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.btn_LongTime_Click.FlatAppearance.BorderSize = 0;
            this.btn_LongTime_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LongTime_Click.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_LongTime_Click.Location = new System.Drawing.Point(412, 326);
            this.btn_LongTime_Click.Name = "btn_LongTime_Click";
            this.btn_LongTime_Click.Size = new System.Drawing.Size(223, 137);
            this.btn_LongTime_Click.TabIndex = 4;
            this.btn_LongTime_Click.Text = "LongTime";
            this.btn_LongTime_Click.UseVisualStyleBackColor = false;
            this.btn_LongTime_Click.Click += new System.EventHandler(this.btn_LongTime_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // labelScreenWaker
            // 
            this.labelScreenWaker.AutoSize = true;
            this.labelScreenWaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScreenWaker.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelScreenWaker.Location = new System.Drawing.Point(32, 33);
            this.labelScreenWaker.Name = "labelScreenWaker";
            this.labelScreenWaker.Size = new System.Drawing.Size(651, 108);
            this.labelScreenWaker.TabIndex = 6;
            this.labelScreenWaker.Text = "Screen Waker";
            // 
            // FormScreenWaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(730, 509);
            this.Controls.Add(this.labelScreenWaker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_LongTime_Click);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.tb_TimeToWork);
            this.Controls.Add(this.btn_Start);
            this.Name = "FormScreenWaker";
            this.Text = "FormScreenWaker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TextBox tb_TimeToWork;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button btn_LongTime_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelScreenWaker;
    }
}