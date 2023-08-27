namespace Laboratorio1_Ejercicio3_ventana
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtb1 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            txtb2 = new System.Windows.Forms.TextBox();
            txtb3 = new System.Windows.Forms.TextBox();
            txtb4 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtb5 = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            lbl = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(114, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Parciales";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(27, 48);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Parcial 1";
            // 
            // txtb1
            // 
            txtb1.Location = new System.Drawing.Point(83, 48);
            txtb1.Name = "txtb1";
            txtb1.Size = new System.Drawing.Size(161, 23);
            txtb1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(27, 87);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Parcial 2";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(347, 177);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(128, 30);
            button1.TabIndex = 4;
            button1.Text = "calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtb2
            // 
            txtb2.Location = new System.Drawing.Point(83, 84);
            txtb2.Name = "txtb2";
            txtb2.Size = new System.Drawing.Size(161, 23);
            txtb2.TabIndex = 5;
            // 
            // txtb3
            // 
            txtb3.Location = new System.Drawing.Point(83, 124);
            txtb3.Name = "txtb3";
            txtb3.Size = new System.Drawing.Size(161, 23);
            txtb3.TabIndex = 6;
            // 
            // txtb4
            // 
            txtb4.Location = new System.Drawing.Point(27, 239);
            txtb4.Name = "txtb4";
            txtb4.Size = new System.Drawing.Size(166, 23);
            txtb4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(26, 127);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(51, 15);
            label4.TabIndex = 8;
            label4.Text = "Parcial 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(62, 207);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(75, 15);
            label5.TabIndex = 9;
            label5.Text = "Examen final";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(62, 301);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(71, 15);
            label6.TabIndex = 10;
            label6.Text = "Trabajo final";
            // 
            // txtb5
            // 
            txtb5.Location = new System.Drawing.Point(27, 331);
            txtb5.Name = "txtb5";
            txtb5.Size = new System.Drawing.Size(166, 23);
            txtb5.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(362, 101);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(95, 15);
            label7.TabIndex = 13;
            label7.Text = "Calificación final";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl.Location = new System.Drawing.Point(376, 127);
            lbl.Name = "lbl";
            lbl.Size = new System.Drawing.Size(47, 37);
            lbl.TabIndex = 14;
            lbl.Text = "00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(535, 450);
            Controls.Add(lbl);
            Controls.Add(label7);
            Controls.Add(txtb5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtb4);
            Controls.Add(txtb3);
            Controls.Add(txtb2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(txtb1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.TextBox txtb3;
        private System.Windows.Forms.TextBox txtb4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtb5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl;
    }
}
