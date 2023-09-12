namespace МасловаПрогМодулиДЗ_1
{
    partial class Task8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task8));
            this.lbTip = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.btPlus = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btPow = new System.Windows.Forms.Button();
            this.tbB = new System.Windows.Forms.TextBox();
            this.btEqual = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.lbsmile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTip
            // 
            this.lbTip.AutoSize = true;
            this.lbTip.Location = new System.Drawing.Point(12, 9);
            this.lbTip.Name = "lbTip";
            this.lbTip.Size = new System.Drawing.Size(152, 33);
            this.lbTip.TabIndex = 0;
            this.lbTip.Text = "Калькулятор";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(19, 53);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(111, 40);
            this.tbA.TabIndex = 1;
            // 
            // btPlus
            // 
            this.btPlus.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btPlus.Location = new System.Drawing.Point(19, 99);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(58, 35);
            this.btPlus.TabIndex = 2;
            this.btPlus.Text = "+";
            this.btPlus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btPlus_MouseClick);
            // 
            // btMinus
            // 
            this.btMinus.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMinus.Location = new System.Drawing.Point(83, 99);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(58, 35);
            this.btMinus.TabIndex = 3;
            this.btMinus.Text = "-";
            this.btMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btMinus_MouseClick);
            // 
            // btMul
            // 
            this.btMul.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMul.Location = new System.Drawing.Point(147, 99);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(58, 35);
            this.btMul.TabIndex = 4;
            this.btMul.Text = "х";
            this.btMul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btMul_MouseClick);
            // 
            // btDiv
            // 
            this.btDiv.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDiv.Location = new System.Drawing.Point(211, 99);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(58, 35);
            this.btDiv.TabIndex = 5;
            this.btDiv.Text = "/";
            this.btDiv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btDiv_MouseClick);
            // 
            // btPow
            // 
            this.btPow.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btPow.Location = new System.Drawing.Point(275, 99);
            this.btPow.Name = "btPow";
            this.btPow.Size = new System.Drawing.Size(58, 35);
            this.btPow.TabIndex = 6;
            this.btPow.Text = "^";
            this.btPow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btPow.UseVisualStyleBackColor = true;
            this.btPow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btPow_MouseClick);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(19, 140);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(111, 40);
            this.tbB.TabIndex = 7;
            // 
            // btEqual
            // 
            this.btEqual.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEqual.Location = new System.Drawing.Point(19, 186);
            this.btEqual.Name = "btEqual";
            this.btEqual.Size = new System.Drawing.Size(58, 35);
            this.btEqual.TabIndex = 8;
            this.btEqual.Text = "=";
            this.btEqual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEqual.UseVisualStyleBackColor = true;
            this.btEqual.Click += new System.EventHandler(this.button6_Click);
            this.btEqual.MouseEnter += new System.EventHandler(this.btEqual_MouseEnter);
            this.btEqual.MouseLeave += new System.EventHandler(this.btEqual_MouseLeave);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(19, 227);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(314, 40);
            this.tbOutput.TabIndex = 9;
            // 
            // lbsmile
            // 
            this.lbsmile.AutoSize = true;
            this.lbsmile.Location = new System.Drawing.Point(96, 186);
            this.lbsmile.Name = "lbsmile";
            this.lbsmile.Size = new System.Drawing.Size(34, 33);
            this.lbsmile.TabIndex = 10;
            this.lbsmile.Text = ": )";
            this.lbsmile.Visible = false;
            // 
            // Task8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(347, 285);
            this.Controls.Add(this.lbsmile);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.btEqual);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.btPow);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.lbTip);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Task8";
            this.Text = "Упражнение 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTip;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btPow;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Button btEqual;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label lbsmile;
    }
}