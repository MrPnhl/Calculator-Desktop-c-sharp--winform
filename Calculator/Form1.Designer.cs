namespace Calculator
{
    partial class frmcalculator
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
            this.btnexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtscreen = new System.Windows.Forms.TextBox();
            this.btnvurma = new System.Windows.Forms.Button();
            this.btncixma = new System.Windows.Forms.Button();
            this.btntoplam = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnberaber = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnbolme = new System.Windows.Forms.Button();
            this.lblresultscreen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.btnexit.Location = new System.Drawing.Point(256, -1);
            this.btnexit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(35, 31);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "x";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mi Calculator";
            // 
            // txtscreen
            // 
            this.txtscreen.Enabled = false;
            this.txtscreen.Font = new System.Drawing.Font("Microsoft PhagsPa", 25.25F);
            this.txtscreen.Location = new System.Drawing.Point(16, 57);
            this.txtscreen.Multiline = true;
            this.txtscreen.Name = "txtscreen";
            this.txtscreen.ReadOnly = true;
            this.txtscreen.Size = new System.Drawing.Size(262, 111);
            this.txtscreen.TabIndex = 30;
            this.txtscreen.Text = "0";
            this.txtscreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnvurma
            // 
            this.btnvurma.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnvurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvurma.Font = new System.Drawing.Font("Corbel", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvurma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnvurma.Location = new System.Drawing.Point(220, 230);
            this.btnvurma.Name = "btnvurma";
            this.btnvurma.Size = new System.Drawing.Size(58, 50);
            this.btnvurma.TabIndex = 7;
            this.btnvurma.Text = "x";
            this.btnvurma.UseVisualStyleBackColor = false;
            this.btnvurma.Click += new System.EventHandler(this.btnvurma_Click);
            // 
            // btncixma
            // 
            this.btncixma.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btncixma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncixma.Font = new System.Drawing.Font("Corbel", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncixma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btncixma.Location = new System.Drawing.Point(220, 286);
            this.btncixma.Name = "btncixma";
            this.btncixma.Size = new System.Drawing.Size(58, 50);
            this.btncixma.TabIndex = 11;
            this.btncixma.Text = "−";
            this.btncixma.UseVisualStyleBackColor = false;
            this.btncixma.Click += new System.EventHandler(this.btncixma_Click);
            // 
            // btntoplam
            // 
            this.btntoplam.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btntoplam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntoplam.Font = new System.Drawing.Font("Corbel", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntoplam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btntoplam.Location = new System.Drawing.Point(220, 342);
            this.btntoplam.Name = "btntoplam";
            this.btntoplam.Size = new System.Drawing.Size(58, 50);
            this.btntoplam.TabIndex = 15;
            this.btntoplam.Text = "+";
            this.btntoplam.UseVisualStyleBackColor = false;
            this.btntoplam.Click += new System.EventHandler(this.btntoplam_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.Font = new System.Drawing.Font("Corbel", 17.25F);
            this.btn0.Location = new System.Drawing.Point(16, 398);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(130, 50);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "⓪";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnberaber
            // 
            this.btnberaber.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnberaber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnberaber.Font = new System.Drawing.Font("Corbel", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnberaber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnberaber.Location = new System.Drawing.Point(220, 398);
            this.btnberaber.Name = "btnberaber";
            this.btnberaber.Size = new System.Drawing.Size(58, 50);
            this.btnberaber.TabIndex = 18;
            this.btnberaber.Text = "=";
            this.btnberaber.UseVisualStyleBackColor = false;
            this.btnberaber.Click += new System.EventHandler(this.btnberaber_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.Font = new System.Drawing.Font("Corbel", 17.25F);
            this.btn7.Location = new System.Drawing.Point(16, 230);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(62, 50);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "⑦";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.Font = new System.Drawing.Font("Corbel", 17.25F);
            this.btn8.Location = new System.Drawing.Point(84, 230);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(62, 50);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "⑧";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.Font = new System.Drawing.Font("Corbel", 17.25F);
            this.btn9.Location = new System.Drawing.Point(152, 230);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(62, 50);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "⑨";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.Font = new System.Drawing.Font("Corbel", 17.25F);
            this.btn4.Location = new System.Drawing.Point(16, 286);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(62, 50);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "④";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Font = new System.Drawing.Font("Corbel", 17.25F);
            this.btn5.Location = new System.Drawing.Point(84, 286);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(62, 50);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "⑤";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.Font = new System.Drawing.Font("Corbel", 17.25F);
            this.btn6.Location = new System.Drawing.Point(152, 286);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(62, 50);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "⑥";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("Corbel", 17.25F);
            this.btn1.Location = new System.Drawing.Point(16, 342);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(62, 50);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "①";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Font = new System.Drawing.Font("Corbel", 17.25F);
            this.btn2.Location = new System.Drawing.Point(84, 342);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(62, 50);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "②";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Font = new System.Drawing.Font("Corbel", 17.25F);
            this.btn3.Location = new System.Drawing.Point(152, 342);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(62, 50);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "③";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btndot
            // 
            this.btndot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btndot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndot.Font = new System.Drawing.Font("Corbel", 17.25F);
            this.btndot.Location = new System.Drawing.Point(152, 398);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(62, 50);
            this.btndot.TabIndex = 17;
            this.btndot.Text = "∙";
            this.btndot.UseVisualStyleBackColor = false;
            this.btndot.Click += new System.EventHandler(this.btndot_Click_1);
            // 
            // btnmod
            // 
            this.btnmod.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnmod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmod.Font = new System.Drawing.Font("Corbel", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnmod.Location = new System.Drawing.Point(152, 174);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(62, 50);
            this.btnmod.TabIndex = 12;
            this.btnmod.Text = "%";
            this.btnmod.UseVisualStyleBackColor = false;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btndel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndel.Font = new System.Drawing.Font("Corbel", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btndel.Location = new System.Drawing.Point(84, 174);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(62, 50);
            this.btndel.TabIndex = 9;
            this.btndel.Text = "←";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnc
            // 
            this.btnc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnc.Font = new System.Drawing.Font("Corbel", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnc.Location = new System.Drawing.Point(16, 174);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(62, 50);
            this.btnc.TabIndex = 8;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = false;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnbolme
            // 
            this.btnbolme.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnbolme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbolme.Font = new System.Drawing.Font("Corbel", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbolme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnbolme.Location = new System.Drawing.Point(220, 174);
            this.btnbolme.Name = "btnbolme";
            this.btnbolme.Size = new System.Drawing.Size(58, 50);
            this.btnbolme.TabIndex = 4;
            this.btnbolme.Text = "∕";
            this.btnbolme.UseVisualStyleBackColor = false;
            this.btnbolme.Click += new System.EventHandler(this.btnbolme_Click);
            // 
            // lblresultscreen
            // 
            this.lblresultscreen.AutoSize = true;
            this.lblresultscreen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblresultscreen.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.25F);
            this.lblresultscreen.Location = new System.Drawing.Point(24, 136);
            this.lblresultscreen.Name = "lblresultscreen";
            this.lblresultscreen.Size = new System.Drawing.Size(0, 23);
            this.lblresultscreen.TabIndex = 31;
            // 
            // frmcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(290, 462);
            this.ControlBox = false;
            this.Controls.Add(this.lblresultscreen);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnbolme);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnberaber);
            this.Controls.Add(this.btntoplam);
            this.Controls.Add(this.btncixma);
            this.Controls.Add(this.btnvurma);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.txtscreen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "frmcalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtscreen;
        private System.Windows.Forms.Button btnvurma;
        private System.Windows.Forms.Button btncixma;
        private System.Windows.Forms.Button btntoplam;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnberaber;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnbolme;
        private System.Windows.Forms.Label lblresultscreen;
    }
}

