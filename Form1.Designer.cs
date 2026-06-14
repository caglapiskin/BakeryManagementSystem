namespace FirinMatikPro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            txtBarkod = new TextBox();
            txtFiy = new TextBox();
            txtUrunAdi = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Fiyatı (TL):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 2;
            label3.Text = "Barkod:";
            // 
            // button1
            // 
            button1.Location = new Point(98, 159);
            button1.Name = "button1";
            button1.Size = new Size(189, 29);
            button1.TabIndex = 3;
            button1.Text = "Ürünü Fırına Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(106, 92);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(125, 27);
            txtBarkod.TabIndex = 4;
            // 
            // txtFiy
            // 
            txtFiy.Location = new Point(106, 69);
            txtFiy.Name = "txtFiy";
            txtFiy.Size = new Size(125, 27);
            txtFiy.TabIndex = 5;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(106, 45);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(125, 27);
            txtUrunAdi.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(640, 222);
            dataGridView1.TabIndex = 7;
            
            // 
            // button2
            // 
            button2.Location = new Point(293, 159);
            button2.Name = "button2";
            button2.Size = new Size(137, 29);
            button2.TabIndex = 8;
            button2.Text = "Seçili Ürünü Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(436, 159);
            button3.Name = "button3";
            button3.Size = new Size(128, 29);
            button3.TabIndex = 9;
            button3.Text = "Fiyatı Güncelle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(txtUrunAdi);
            Controls.Add(txtFiy);
            Controls.Add(txtBarkod);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox txtBarkod;
        private TextBox txtFiy;
        private TextBox txtUrunAdi;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
    }
}
