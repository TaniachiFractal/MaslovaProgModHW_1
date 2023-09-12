namespace МасловаПрогМодулиДЗ_1
{
    partial class Task7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task7));
            this.lbR1 = new System.Windows.Forms.Label();
            this.lbR2 = new System.Windows.Forms.Label();
            this.lbTip = new System.Windows.Forms.Label();
            this.lbR12 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.BTposled = new System.Windows.Forms.Button();
            this.BTparallel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbR1
            // 
            this.lbR1.AutoSize = true;
            this.lbR1.Location = new System.Drawing.Point(30, 86);
            this.lbR1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbR1.Name = "lbR1";
            this.lbR1.Size = new System.Drawing.Size(60, 33);
            this.lbR1.TabIndex = 0;
            this.lbR1.Text = "R1 = ";
            // 
            // lbR2
            // 
            this.lbR2.AutoSize = true;
            this.lbR2.Location = new System.Drawing.Point(27, 132);
            this.lbR2.Name = "lbR2";
            this.lbR2.Size = new System.Drawing.Size(64, 33);
            this.lbR2.TabIndex = 1;
            this.lbR2.Text = "R2 = ";
            // 
            // lbTip
            // 
            this.lbTip.AutoSize = true;
            this.lbTip.Location = new System.Drawing.Point(13, 5);
            this.lbTip.Name = "lbTip";
            this.lbTip.Size = new System.Drawing.Size(309, 66);
            this.lbTip.TabIndex = 2;
            this.lbTip.Text = "Посчитать суммарное \r\nсопротивление резисторов ";
            this.lbTip.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbR12
            // 
            this.lbR12.AutoSize = true;
            this.lbR12.Location = new System.Drawing.Point(19, 213);
            this.lbR12.Name = "lbR12";
            this.lbR12.Size = new System.Drawing.Size(72, 33);
            this.lbR12.TabIndex = 3;
            this.lbR12.Text = "R12 = ";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(97, 83);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(156, 40);
            this.tb1.TabIndex = 4;
            this.tb1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(97, 129);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(156, 40);
            this.tb2.TabIndex = 5;
            // 
            // tbOutput
            // 
            this.tbOutput.BackColor = System.Drawing.Color.White;
            this.tbOutput.Location = new System.Drawing.Point(97, 210);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(156, 40);
            this.tbOutput.TabIndex = 6;
            // 
            // BTposled
            // 
            this.BTposled.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTposled.BackgroundImage")));
            this.BTposled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTposled.Location = new System.Drawing.Point(286, 83);
            this.BTposled.Name = "BTposled";
            this.BTposled.Size = new System.Drawing.Size(159, 53);
            this.BTposled.TabIndex = 7;
            this.BTposled.UseVisualStyleBackColor = true;
            this.BTposled.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BTposled_MouseClick);
            // 
            // BTparallel
            // 
            this.BTparallel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTparallel.BackgroundImage")));
            this.BTparallel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTparallel.Location = new System.Drawing.Point(286, 148);
            this.BTparallel.Name = "BTparallel";
            this.BTparallel.Size = new System.Drawing.Size(197, 98);
            this.BTparallel.TabIndex = 8;
            this.BTparallel.UseVisualStyleBackColor = true;
            this.BTparallel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BTparallel_MouseClick);
            // 
            // Task7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(496, 264);
            this.Controls.Add(this.BTparallel);
            this.Controls.Add(this.BTposled);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lbR12);
            this.Controls.Add(this.lbTip);
            this.Controls.Add(this.lbR2);
            this.Controls.Add(this.lbR1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Task7";
            this.Text = "Упражнение 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbR1;
        private System.Windows.Forms.Label lbR2;
        private System.Windows.Forms.Label lbTip;
        private System.Windows.Forms.Label lbR12;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button BTposled;
        private System.Windows.Forms.Button BTparallel;
    }
}