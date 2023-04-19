namespace oopEventForm
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
            this.sayi1txt = new System.Windows.Forms.TextBox();
            this.sayi2txt = new System.Windows.Forms.TextBox();
            this.hesaplabtn = new System.Windows.Forms.Button();
            this.addradioButton = new System.Windows.Forms.RadioButton();
            this.substractradioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.sonuclbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Sayı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(59, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.Sayı:";
            // 
            // sayi1txt
            // 
            this.sayi1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi1txt.Location = new System.Drawing.Point(150, 48);
            this.sayi1txt.Name = "sayi1txt";
            this.sayi1txt.Size = new System.Drawing.Size(100, 23);
            this.sayi1txt.TabIndex = 2;
            // 
            // sayi2txt
            // 
            this.sayi2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi2txt.Location = new System.Drawing.Point(150, 98);
            this.sayi2txt.Name = "sayi2txt";
            this.sayi2txt.Size = new System.Drawing.Size(100, 23);
            this.sayi2txt.TabIndex = 3;
            // 
            // hesaplabtn
            // 
            this.hesaplabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hesaplabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesaplabtn.Location = new System.Drawing.Point(150, 242);
            this.hesaplabtn.Name = "hesaplabtn";
            this.hesaplabtn.Size = new System.Drawing.Size(100, 33);
            this.hesaplabtn.TabIndex = 4;
            this.hesaplabtn.Text = "Hesapla";
            this.hesaplabtn.UseVisualStyleBackColor = true;
            this.hesaplabtn.Click += new System.EventHandler(this.hesaplabtn_Click);
            // 
            // addradioButton
            // 
            this.addradioButton.AutoSize = true;
            this.addradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addradioButton.Location = new System.Drawing.Point(308, 51);
            this.addradioButton.Name = "addradioButton";
            this.addradioButton.Size = new System.Drawing.Size(95, 24);
            this.addradioButton.TabIndex = 5;
            this.addradioButton.TabStop = true;
            this.addradioButton.Text = "Toplama";
            this.addradioButton.UseVisualStyleBackColor = true;
            // 
            // substractradioButton
            // 
            this.substractradioButton.AutoSize = true;
            this.substractradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.substractradioButton.Location = new System.Drawing.Point(308, 96);
            this.substractradioButton.Name = "substractradioButton";
            this.substractradioButton.Size = new System.Drawing.Size(92, 24);
            this.substractradioButton.TabIndex = 6;
            this.substractradioButton.TabStop = true;
            this.substractradioButton.Text = "Çıkarma";
            this.substractradioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(57, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sonuç:";
            // 
            // sonuclbl
            // 
            this.sonuclbl.AutoSize = true;
            this.sonuclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuclbl.Location = new System.Drawing.Point(167, 163);
            this.sonuclbl.Name = "sonuclbl";
            this.sonuclbl.Size = new System.Drawing.Size(57, 20);
            this.sonuclbl.TabIndex = 8;
            this.sonuclbl.Text = "--------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 353);
            this.Controls.Add(this.sonuclbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.substractradioButton);
            this.Controls.Add(this.addradioButton);
            this.Controls.Add(this.hesaplabtn);
            this.Controls.Add(this.sayi2txt);
            this.Controls.Add(this.sayi1txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sayi1txt;
        private System.Windows.Forms.TextBox sayi2txt;
        private System.Windows.Forms.Button hesaplabtn;
        private System.Windows.Forms.RadioButton addradioButton;
        private System.Windows.Forms.RadioButton substractradioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sonuclbl;
    }
}

