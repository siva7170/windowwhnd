namespace Whnd
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHwnd = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.chkEna = new System.Windows.Forms.CheckBox();
            this.buttonEna = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.buttonSetFore = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtMoveH = new System.Windows.Forms.TextBox();
            this.txtMoveW = new System.Windows.Forms.TextBox();
            this.txtMoveY = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.txtMoveX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSetText = new System.Windows.Forms.Button();
            this.txtSetText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get window\'s hWnd";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtY);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.txtX);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(406, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 111);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "by location";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(107, 19);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(61, 20);
            this.txtY.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(108, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Get";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(26, 19);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(61, 20);
            this.txtX.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:                        Y:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txtClass);
            this.groupBox3.Location = new System.Drawing.Point(206, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 111);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "by class name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Get";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(6, 19);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(182, 20);
            this.txtClass.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 111);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "by title text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(6, 19);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(182, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "hWnd";
            // 
            // txtHwnd
            // 
            this.txtHwnd.Location = new System.Drawing.Point(54, 159);
            this.txtHwnd.Name = "txtHwnd";
            this.txtHwnd.Size = new System.Drawing.Size(158, 20);
            this.txtHwnd.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox9);
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(12, 194);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(589, 156);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Interaction with window";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.chkEna);
            this.groupBox9.Controls.Add(this.buttonEna);
            this.groupBox9.Location = new System.Drawing.Point(206, 102);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(194, 48);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "EnableWindow()";
            // 
            // chkEna
            // 
            this.chkEna.AutoSize = true;
            this.chkEna.Location = new System.Drawing.Point(9, 23);
            this.chkEna.Name = "chkEna";
            this.chkEna.Size = new System.Drawing.Size(65, 17);
            this.chkEna.TabIndex = 3;
            this.chkEna.Text = "Enabled";
            this.chkEna.UseVisualStyleBackColor = true;
            // 
            // buttonEna
            // 
            this.buttonEna.Location = new System.Drawing.Point(126, 19);
            this.buttonEna.Name = "buttonEna";
            this.buttonEna.Size = new System.Drawing.Size(62, 23);
            this.buttonEna.TabIndex = 2;
            this.buttonEna.Text = "Call";
            this.buttonEna.UseVisualStyleBackColor = true;
            this.buttonEna.Click += new System.EventHandler(this.buttonEna_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.buttonSetFore);
            this.groupBox8.Location = new System.Drawing.Point(6, 102);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(194, 48);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "SetForegroundWindow()";
            // 
            // buttonSetFore
            // 
            this.buttonSetFore.Location = new System.Drawing.Point(126, 19);
            this.buttonSetFore.Name = "buttonSetFore";
            this.buttonSetFore.Size = new System.Drawing.Size(62, 23);
            this.buttonSetFore.TabIndex = 2;
            this.buttonSetFore.Text = "Call";
            this.buttonSetFore.UseVisualStyleBackColor = true;
            this.buttonSetFore.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtMoveH);
            this.groupBox7.Controls.Add(this.txtMoveW);
            this.groupBox7.Controls.Add(this.txtMoveY);
            this.groupBox7.Controls.Add(this.btnMove);
            this.groupBox7.Controls.Add(this.txtMoveX);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Location = new System.Drawing.Point(206, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(194, 77);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "MoveWindow()";
            // 
            // txtMoveH
            // 
            this.txtMoveH.Location = new System.Drawing.Point(160, 22);
            this.txtMoveH.Name = "txtMoveH";
            this.txtMoveH.Size = new System.Drawing.Size(28, 20);
            this.txtMoveH.TabIndex = 5;
            this.txtMoveH.Text = "400";
            // 
            // txtMoveW
            // 
            this.txtMoveW.Location = new System.Drawing.Point(108, 22);
            this.txtMoveW.Name = "txtMoveW";
            this.txtMoveW.Size = new System.Drawing.Size(28, 20);
            this.txtMoveW.TabIndex = 4;
            this.txtMoveW.Text = "300";
            // 
            // txtMoveY
            // 
            this.txtMoveY.Location = new System.Drawing.Point(61, 22);
            this.txtMoveY.Name = "txtMoveY";
            this.txtMoveY.Size = new System.Drawing.Size(28, 20);
            this.txtMoveY.TabIndex = 3;
            this.txtMoveY.Text = "200";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(126, 48);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(62, 23);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Call";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // txtMoveX
            // 
            this.txtMoveX.Location = new System.Drawing.Point(18, 22);
            this.txtMoveX.Name = "txtMoveX";
            this.txtMoveX.Size = new System.Drawing.Size(28, 20);
            this.txtMoveX.TabIndex = 1;
            this.txtMoveX.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "X:           Y:           W:           H:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSetText);
            this.groupBox6.Controls.Add(this.txtSetText);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Location = new System.Drawing.Point(6, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(194, 77);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SetWindowText()";
            // 
            // btnSetText
            // 
            this.btnSetText.Location = new System.Drawing.Point(126, 48);
            this.btnSetText.Name = "btnSetText";
            this.btnSetText.Size = new System.Drawing.Size(62, 23);
            this.btnSetText.TabIndex = 2;
            this.btnSetText.Text = "Call";
            this.btnSetText.UseVisualStyleBackColor = true;
            this.btnSetText.Click += new System.EventHandler(this.btnSetText_Click);
            // 
            // txtSetText
            // 
            this.txtSetText.Location = new System.Drawing.Point(36, 22);
            this.txtSetText.Name = "txtSetText";
            this.txtSetText.Size = new System.Drawing.Size(152, 20);
            this.txtSetText.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Text:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 524);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txtHwnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtHwnd;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSetText;
        private System.Windows.Forms.TextBox txtSetText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtMoveH;
        private System.Windows.Forms.TextBox txtMoveW;
        private System.Windows.Forms.TextBox txtMoveY;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.TextBox txtMoveX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button buttonSetFore;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button buttonEna;
        private System.Windows.Forms.CheckBox chkEna;

    }
}

