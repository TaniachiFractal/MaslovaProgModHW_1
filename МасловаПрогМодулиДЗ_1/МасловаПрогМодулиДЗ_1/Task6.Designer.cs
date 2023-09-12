namespace МасловаПрогМодулиДЗ_1
{
    partial class Task6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task6));
            this.field = new System.Windows.Forms.Button();
            this.lbLength = new System.Windows.Forms.Label();
            this.lbWidth = new System.Windows.Forms.Label();
            this.tbWid = new System.Windows.Forms.TextBox();
            this.tbLeng = new System.Windows.Forms.TextBox();
            this.lbP = new System.Windows.Forms.Label();
            this.lbS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // field
            // 
            this.field.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.field.Location = new System.Drawing.Point(203, 12);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(175, 92);
            this.field.TabIndex = 0;
            this.field.Text = "Размеры Вашего Прямоугольника";
            this.field.UseVisualStyleBackColor = false;
            this.field.MouseClick += new System.Windows.Forms.MouseEventHandler(this.field_MouseClick);
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Location = new System.Drawing.Point(165, 113);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(69, 23);
            this.lbLength.TabIndex = 1;
            this.lbLength.Text = "Длина =";
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Location = new System.Drawing.Point(13, 47);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(80, 23);
            this.lbWidth.TabIndex = 2;
            this.lbWidth.Text = "Ширина =";
            // 
            // tbWid
            // 
            this.tbWid.Location = new System.Drawing.Point(99, 44);
            this.tbWid.Name = "tbWid";
            this.tbWid.Size = new System.Drawing.Size(98, 30);
            this.tbWid.TabIndex = 3;
            // 
            // tbLeng
            // 
            this.tbLeng.Location = new System.Drawing.Point(243, 110);
            this.tbLeng.Name = "tbLeng";
            this.tbLeng.Size = new System.Drawing.Size(98, 30);
            this.tbLeng.TabIndex = 4;
            // 
            // lbP
            // 
            this.lbP.AutoSize = true;
            this.lbP.Location = new System.Drawing.Point(13, 158);
            this.lbP.Name = "lbP";
            this.lbP.Size = new System.Drawing.Size(162, 23);
            this.lbP.TabIndex = 5;
            this.lbP.Text = "Его периметр равен ";
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Location = new System.Drawing.Point(13, 193);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(159, 23);
            this.lbS.TabIndex = 6;
            this.lbS.Text = "Его площадь равна ";
            // 
            // Task6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(398, 234);
            this.Controls.Add(this.lbS);
            this.Controls.Add(this.lbP);
            this.Controls.Add(this.tbLeng);
            this.Controls.Add(this.tbWid);
            this.Controls.Add(this.lbWidth);
            this.Controls.Add(this.lbLength);
            this.Controls.Add(this.field);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Task6";
            this.Text = "Упражнение 6";
            this.Load += new System.EventHandler(this.Task6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button field;
        private System.Windows.Forms.Label lbLength;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.TextBox tbWid;
        private System.Windows.Forms.TextBox tbLeng;
        private System.Windows.Forms.Label lbP;
        private System.Windows.Forms.Label lbS;
    }
}