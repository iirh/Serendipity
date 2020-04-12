namespace Serendipityx
{
    partial class MainF
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainF));
            this.panel_task = new System.Windows.Forms.Panel();
            this.panel_mini = new System.Windows.Forms.Panel();
            this.label_mini = new System.Windows.Forms.Label();
            this.panel_exit = new System.Windows.Forms.Panel();
            this.label_exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_check = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_status = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button_options = new System.Windows.Forms.Button();
            this.checker = new System.Windows.Forms.Timer(this.components);
            this.panel_task.SuspendLayout();
            this.panel_mini.SuspendLayout();
            this.panel_exit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_task
            // 
            this.panel_task.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.panel_task.Controls.Add(this.panel_mini);
            this.panel_task.Controls.Add(this.panel_exit);
            this.panel_task.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_task.Location = new System.Drawing.Point(0, 0);
            this.panel_task.Name = "panel_task";
            this.panel_task.Size = new System.Drawing.Size(332, 17);
            this.panel_task.TabIndex = 0;
            this.panel_task.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_task_MouseDown);
            // 
            // panel_mini
            // 
            this.panel_mini.Controls.Add(this.label_mini);
            this.panel_mini.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_mini.Location = new System.Drawing.Point(280, 0);
            this.panel_mini.Name = "panel_mini";
            this.panel_mini.Size = new System.Drawing.Size(24, 17);
            this.panel_mini.TabIndex = 1;
            this.panel_mini.Click += new System.EventHandler(this.panel_mini_Click);
            this.panel_mini.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_mini_Paint);
            this.panel_mini.MouseLeave += new System.EventHandler(this.panel_mini_MouseLeave);
            this.panel_mini.MouseHover += new System.EventHandler(this.panel_mini_MouseHover);
            // 
            // label_mini
            // 
            this.label_mini.AutoSize = true;
            this.label_mini.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mini.ForeColor = System.Drawing.Color.White;
            this.label_mini.Location = new System.Drawing.Point(5, -4);
            this.label_mini.Name = "label_mini";
            this.label_mini.Size = new System.Drawing.Size(15, 16);
            this.label_mini.TabIndex = 0;
            this.label_mini.Text = "_";
            this.label_mini.Click += new System.EventHandler(this.panel_mini_Click);
            this.label_mini.MouseLeave += new System.EventHandler(this.panel_mini_MouseLeave);
            this.label_mini.MouseHover += new System.EventHandler(this.panel_mini_MouseHover);
            // 
            // panel_exit
            // 
            this.panel_exit.Controls.Add(this.label_exit);
            this.panel_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_exit.Location = new System.Drawing.Point(304, 0);
            this.panel_exit.Name = "panel_exit";
            this.panel_exit.Size = new System.Drawing.Size(28, 17);
            this.panel_exit.TabIndex = 0;
            this.panel_exit.Click += new System.EventHandler(this.panel_exit_Click);
            this.panel_exit.MouseLeave += new System.EventHandler(this.panel_exit_MouseLeave);
            this.panel_exit.MouseHover += new System.EventHandler(this.panel_exit_MouseHover);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.White;
            this.label_exit.Location = new System.Drawing.Point(7, 2);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(14, 14);
            this.label_exit.TabIndex = 0;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.panel_exit_Click);
            this.label_exit.MouseLeave += new System.EventHandler(this.panel_exit_MouseLeave);
            this.label_exit.MouseHover += new System.EventHandler(this.panel_exit_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 1);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 340);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(88)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(331, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 340);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Serendipityx.Properties.Resources.AAAABcOBzhUEny07qD__SHwe7tKgTeP7vwpIfYMYLpC2VsvftF4c9NBdc0M0YN_a1j3gk5azRmEVUfklQyzy7cEjrgViAJMeVcPVlLcO0FdXtg;
            this.pictureBox1.Location = new System.Drawing.Point(1, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button_check
            // 
            this.button_check.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button_check.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.button_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_check.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.button_check.Location = new System.Drawing.Point(46, 111);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(243, 32);
            this.button_check.TabIndex = 1;
            this.button_check.Text = "Connect to Counter-Strike";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_load
            // 
            this.button_load.Enabled = false;
            this.button_load.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button_load.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.button_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_load.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_load.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.button_load.Location = new System.Drawing.Point(46, 154);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(243, 32);
            this.button_load.TabIndex = 2;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_status);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(12, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 100);
            this.panel1.TabIndex = 0;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label_status.Location = new System.Drawing.Point(1, 1);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 13);
            this.label_status.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel8.Location = new System.Drawing.Point(307, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 98);
            this.panel8.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel7.Location = new System.Drawing.Point(0, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 98);
            this.panel7.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel6.Location = new System.Drawing.Point(0, 99);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(308, 1);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(308, 1);
            this.panel5.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(304, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(10, 10);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button_options
            // 
            this.button_options.Enabled = false;
            this.button_options.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button_options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.button_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_options.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_options.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.button_options.Location = new System.Drawing.Point(46, 198);
            this.button_options.Name = "button_options";
            this.button_options.Size = new System.Drawing.Size(243, 32);
            this.button_options.TabIndex = 5;
            this.button_options.Text = "Hide";
            this.button_options.UseVisualStyleBackColor = true;
            this.button_options.Click += new System.EventHandler(this.button_options_Click);
            // 
            // checker
            // 
            this.checker.Interval = 5000;
            this.checker.Tick += new System.EventHandler(this.checker_Tick);
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(332, 358);
            this.Controls.Add(this.button_options);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_task);
            this.Controls.Add(this.button3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainF";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_task.ResumeLayout(false);
            this.panel_mini.ResumeLayout(false);
            this.panel_mini.PerformLayout();
            this.panel_exit.ResumeLayout(false);
            this.panel_exit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_task;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_exit;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Panel panel_mini;
        private System.Windows.Forms.Label label_mini;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_options;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Timer checker;
    }
}

