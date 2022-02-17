namespace udaljenosttocka._1._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new udaljenosttocka._1._2.Class1(this.components);
            this.button2 = new udaljenosttocka._1._2.Class1(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textkorx1 = new System.Windows.Forms.TextBox();
            this.kor_x1 = new System.Windows.Forms.Label();
            this.textkorx2 = new System.Windows.Forms.TextBox();
            this.kor_x2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "X1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "X2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(683, 411);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 27);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Udaljenost:";
            // 
            // textkorx1
            // 
            this.textkorx1.Location = new System.Drawing.Point(124, 374);
            this.textkorx1.Name = "textkorx1";
            this.textkorx1.Size = new System.Drawing.Size(105, 27);
            this.textkorx1.TabIndex = 6;
            // 
            // kor_x1
            // 
            this.kor_x1.AutoSize = true;
            this.kor_x1.Location = new System.Drawing.Point(11, 374);
            this.kor_x1.Name = "kor_x1";
            this.kor_x1.Size = new System.Drawing.Size(107, 20);
            this.kor_x1.TabIndex = 7;
            this.kor_x1.Text = "Koordinate X1:";
            // 
            // textkorx2
            // 
            this.textkorx2.Location = new System.Drawing.Point(124, 414);
            this.textkorx2.Name = "textkorx2";
            this.textkorx2.Size = new System.Drawing.Size(105, 27);
            this.textkorx2.TabIndex = 8;
            // 
            // kor_x2
            // 
            this.kor_x2.AutoSize = true;
            this.kor_x2.Location = new System.Drawing.Point(11, 414);
            this.kor_x2.Name = "kor_x2";
            this.kor_x2.Size = new System.Drawing.Size(107, 20);
            this.kor_x2.TabIndex = 9;
            this.kor_x2.Text = "Koordinate X2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kor_x2);
            this.Controls.Add(this.textkorx2);
            this.Controls.Add(this.kor_x1);
            this.Controls.Add(this.textkorx1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "udaljenost izmedu tocaka X--->X";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnButton_MouseUp(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnButton_MouseDown(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private Class1 button1;
        private Class1 button2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textkorx1;
        private Label kor_x1;
        private TextBox textkorx2;
        private Label kor_x2;
    }
}