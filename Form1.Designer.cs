namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.GroundNumber = new System.Windows.Forms.TextBox();
            this.SimpleNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AlicePrivate = new System.Windows.Forms.TextBox();
            this.BobPrivate = new System.Windows.Forms.TextBox();
            this.AlicePublic = new System.Windows.Forms.TextBox();
            this.BobPublic = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lable10 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AliceSecret = new System.Windows.Forms.TextBox();
            this.BobSecret = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Алиса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Боб";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AliceSecret);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.AlicePrivate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 426);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.BobSecret);
            this.panel2.Controls.Add(this.lable10);
            this.panel2.Controls.Add(this.BobPrivate);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(517, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 425);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.BobPublic);
            this.panel3.Controls.Add(this.AlicePublic);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.SimpleNumber);
            this.panel3.Controls.Add(this.GroundNumber);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(298, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 426);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Незащищенная зона";
            // 
            // GroundNumber
            // 
            this.GroundNumber.Location = new System.Drawing.Point(42, 98);
            this.GroundNumber.Name = "GroundNumber";
            this.GroundNumber.Size = new System.Drawing.Size(135, 22);
            this.GroundNumber.TabIndex = 1;
            // 
            // SimpleNumber
            // 
            this.SimpleNumber.Location = new System.Drawing.Point(42, 150);
            this.SimpleNumber.Name = "SimpleNumber";
            this.SimpleNumber.Size = new System.Drawing.Size(135, 22);
            this.SimpleNumber.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "*Общее основание g";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "*Общее простое число p";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Публичный ключ Алисы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "*Приватный ключ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "*Приватный ключ";
            // 
            // AlicePrivate
            // 
            this.AlicePrivate.Location = new System.Drawing.Point(27, 87);
            this.AlicePrivate.Name = "AlicePrivate";
            this.AlicePrivate.Size = new System.Drawing.Size(100, 22);
            this.AlicePrivate.TabIndex = 3;
            // 
            // BobPrivate
            // 
            this.BobPrivate.Location = new System.Drawing.Point(18, 85);
            this.BobPrivate.Name = "BobPrivate";
            this.BobPrivate.Size = new System.Drawing.Size(100, 22);
            this.BobPrivate.TabIndex = 4;
            // 
            // AlicePublic
            // 
            this.AlicePublic.Location = new System.Drawing.Point(42, 209);
            this.AlicePublic.Name = "AlicePublic";
            this.AlicePublic.Size = new System.Drawing.Size(135, 22);
            this.AlicePublic.TabIndex = 5;
            // 
            // BobPublic
            // 
            this.BobPublic.Location = new System.Drawing.Point(42, 269);
            this.BobPublic.Name = "BobPublic";
            this.BobPublic.Size = new System.Drawing.Size(135, 22);
            this.BobPublic.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Публичный ключ Боба";
            // 
            // lable10
            // 
            this.lable10.AutoSize = true;
            this.lable10.Location = new System.Drawing.Point(15, 121);
            this.lable10.Name = "lable10";
            this.lable10.Size = new System.Drawing.Size(46, 16);
            this.lable10.TabIndex = 8;
            this.lable10.Text = "Secret";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Secret";
            // 
            // AliceSecret
            // 
            this.AliceSecret.Location = new System.Drawing.Point(27, 142);
            this.AliceSecret.Name = "AliceSecret";
            this.AliceSecret.Size = new System.Drawing.Size(100, 22);
            this.AliceSecret.TabIndex = 5;
            // 
            // BobSecret
            // 
            this.BobSecret.Location = new System.Drawing.Point(18, 141);
            this.BobSecret.Name = "BobSecret";
            this.BobSecret.Size = new System.Drawing.Size(100, 22);
            this.BobSecret.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 50);
            this.button2.TabIndex = 10;
            this.button2.Text = "ok";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "Рассчитать секрет";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SimpleNumber;
        private System.Windows.Forms.TextBox GroundNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AlicePrivate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BobPrivate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AlicePublic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BobPublic;
        private System.Windows.Forms.TextBox AliceSecret;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox BobSecret;
        private System.Windows.Forms.Label lable10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

