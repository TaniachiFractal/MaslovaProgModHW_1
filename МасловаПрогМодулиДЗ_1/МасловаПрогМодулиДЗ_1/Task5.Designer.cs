namespace МасловаПрогМодулиДЗ_1
{
    partial class Task5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task5));
            this.lbenterA = new System.Windows.Forms.Label();
            this.lbenterB = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbenterA
            // 
            this.lbenterA.AutoSize = true;
            this.lbenterA.Location = new System.Drawing.Point(12, 9);
            this.lbenterA.Name = "lbenterA";
            this.lbenterA.Size = new System.Drawing.Size(192, 25);
            this.lbenterA.TabIndex = 0;
            this.lbenterA.Text = "Введите слагаемое А:";
            // 
            // lbenterB
            // 
            this.lbenterB.AutoSize = true;
            this.lbenterB.Location = new System.Drawing.Point(12, 51);
            this.lbenterB.Name = "lbenterB";
            this.lbenterB.Size = new System.Drawing.Size(192, 25);
            this.lbenterB.TabIndex = 1;
            this.lbenterB.Text = "Введите слагаемое B:";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(210, 9);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(118, 33);
            this.tbA.TabIndex = 2;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(210, 48);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(118, 33);
            this.tbB.TabIndex = 3;
            // 
            // btEnter
            // 
            this.btEnter.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEnter.Location = new System.Drawing.Point(17, 87);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(311, 40);
            this.btEnter.TabIndex = 4;
            this.btEnter.Text = "Посчитать среднее арифметическое";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btEnter_MouseClick);
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(12, 140);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(110, 25);
            this.lbOutput.TabIndex = 5;
            this.lbOutput.Text = "(A + B) / 2 = ";
            // 
            // Task5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(340, 181);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.lbenterB);
            this.Controls.Add(this.lbenterA);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Task5";
            this.Text = "Упражнение 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbenterA;
        private System.Windows.Forms.Label lbenterB;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Label lbOutput;
    }
}