namespace МасловаПрогМодулиДЗ_1
{
    partial class Task4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task4));
            this.lbWhatPassword = new System.Windows.Forms.Label();
            this.TBpassword = new System.Windows.Forms.TextBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.lbCorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWhatPassword
            // 
            this.lbWhatPassword.AutoSize = true;
            this.lbWhatPassword.Location = new System.Drawing.Point(12, 9);
            this.lbWhatPassword.Name = "lbWhatPassword";
            this.lbWhatPassword.Size = new System.Drawing.Size(250, 25);
            this.lbWhatPassword.TabIndex = 0;
            this.lbWhatPassword.Text = "Введите пароль: qwerty2005";
            // 
            // TBpassword
            // 
            this.TBpassword.Location = new System.Drawing.Point(17, 47);
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.Size = new System.Drawing.Size(125, 33);
            this.TBpassword.TabIndex = 1;
            // 
            // btEnter
            // 
            this.btEnter.Location = new System.Drawing.Point(148, 47);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(82, 34);
            this.btEnter.TabIndex = 2;
            this.btEnter.Text = "ВВОД";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btEnter_MouseClick);
            // 
            // lbCorrect
            // 
            this.lbCorrect.AutoSize = true;
            this.lbCorrect.Location = new System.Drawing.Point(13, 94);
            this.lbCorrect.Name = "lbCorrect";
            this.lbCorrect.Size = new System.Drawing.Size(129, 25);
            this.lbCorrect.TabIndex = 3;
            this.lbCorrect.Text = "Ваш пароль - ";
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(275, 135);
            this.Controls.Add(this.lbCorrect);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.TBpassword);
            this.Controls.Add(this.lbWhatPassword);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Task4";
            this.Text = "Упражнение 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWhatPassword;
        private System.Windows.Forms.TextBox TBpassword;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Label lbCorrect;
    }
}