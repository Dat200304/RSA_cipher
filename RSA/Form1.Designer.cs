using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSA
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
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox6 = new TextBox();
            button3 = new Button();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 314);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Enter text to encrypt...";
            textBox3.Size = new Size(526, 65);
            textBox3.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 508);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Encrypted text will appear here...";
            textBox5.Size = new Size(526, 161);
            textBox5.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 95);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Public Key...";
            textBox1.Size = new Size(526, 108);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 94);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Private Key...";
            textBox2.Size = new Size(526, 108);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 5;
            button1.Text = "Create Keys";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Location = new Point(12, 427);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.TabIndex = 6;
            button2.Text = "Encrypt";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Location = new Point(21, 286);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 9;
            label1.Text = "Input";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Location = new Point(21, 480);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 10;
            label2.Text = "Output";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Location = new Point(12, 67);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 13;
            label5.Text = "Public key";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Location = new Point(22, 66);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 14;
            label6.Text = "Private key";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(22, 507);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Decrypted text will appear here...";
            textBox6.Size = new Size(526, 163);
            textBox6.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDark;
            button3.Location = new Point(22, 426);
            button3.Name = "button3";
            button3.Size = new Size(120, 40);
            button3.TabIndex = 7;
            button3.Text = "Decrypt";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(22, 313);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Enter text to encrypt...";
            textBox4.Size = new Size(526, 65);
            textBox4.TabIndex = 8;
            // 
            // label3
            // 
            label3.Location = new Point(22, 285);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 11;
            label3.Text = "Input";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new Point(22, 479);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 12;
            label4.Text = "Output";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox6);
            panel1.Location = new Point(564, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 749);
            panel1.TabIndex = 15;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(433, 19);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 18;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(302, 19);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 17;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(170, 19);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1124, 741);
            Controls.Add(textBox9);
            Controls.Add(panel1);
            Controls.Add(textBox8);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(textBox7);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Name = "Form1";
            Text = "RSA Encryption App";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        #endregion
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox textBox6;
        private Button button3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
    }
}
