namespace МасловаПрогМодулиДЗ_1
{
    partial class Task3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task3));
            this.lbTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTip
            // 
            this.lbTip.AutoSize = true;
            this.lbTip.Location = new System.Drawing.Point(13, 9);
            this.lbTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTip.Name = "lbTip";
            this.lbTip.Size = new System.Drawing.Size(241, 23);
            this.lbTip.TabIndex = 0;
            this.lbTip.Text = "Я меняю цвет по левому клику";
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(268, 145);
            this.Controls.Add(this.lbTip);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Task3";
            this.Text = "Упражнение 3";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Task3_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Task3_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTip;
    }
}