
namespace gumball
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericCoins = new System.Windows.Forms.NumericUpDown();
            this.Cost = new System.Windows.Forms.Label();
            this.mumbel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericCoins)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Жвачек в автомате";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цена жвачки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Монет вставлено";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Получить жвулю";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Всыпать жвачек в автомат";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // numericCoins
            // 
            this.numericCoins.Location = new System.Drawing.Point(203, 144);
            this.numericCoins.Name = "numericCoins";
            this.numericCoins.Size = new System.Drawing.Size(120, 20);
            this.numericCoins.TabIndex = 5;
            this.numericCoins.ValueChanged += new System.EventHandler(this.numericCoins_ValueChanged);
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Location = new System.Drawing.Point(200, 106);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(13, 13);
            this.Cost.TabIndex = 6;
            this.Cost.Text = "5";
            // 
            // mumbel
            // 
            this.mumbel.AutoSize = true;
            this.mumbel.Location = new System.Drawing.Point(203, 65);
            this.mumbel.Name = "mumbel";
            this.mumbel.Size = new System.Drawing.Size(19, 13);
            this.mumbel.TabIndex = 6;
            this.mumbel.Text = "20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 335);
            this.Controls.Add(this.mumbel);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.numericCoins);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericCoins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericCoins;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label mumbel;
    }
}

