namespace WinFormsApp4
{
    partial class Form2
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
            panel1 = new Panel();
            IDTb = new TextBox();
            NameTb = new TextBox();
            AddressTb = new TextBox();
            EmailTb = new TextBox();
            DGV = new DataGridView();
            Insertbtn = new Button();
            Updatebtn = new Button();
            Deletebtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 92);
            panel1.TabIndex = 0;
            // 
            // IDTb
            // 
            IDTb.Location = new Point(219, 135);
            IDTb.Name = "IDTb";
            IDTb.Size = new Size(341, 27);
            IDTb.TabIndex = 0;
            // 
            // NameTb
            // 
            NameTb.Location = new Point(222, 194);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(338, 27);
            NameTb.TabIndex = 1;
            NameTb.TextChanged += NameTb_TextChanged;
            // 
            // AddressTb
            // 
            AddressTb.Location = new Point(222, 257);
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(338, 27);
            AddressTb.TabIndex = 2;
            // 
            // EmailTb
            // 
            EmailTb.Location = new Point(222, 312);
            EmailTb.Name = "EmailTb";
            EmailTb.Size = new Size(338, 27);
            EmailTb.TabIndex = 3;
            EmailTb.TextChanged += EmailTb_TextChanged;
            // 
            // DGV
            // 
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Location = new Point(60, 501);
            DGV.Name = "DGV";
            DGV.RowHeadersWidth = 51;
            DGV.Size = new Size(557, 188);
            DGV.TabIndex = 4;
            // 
            // Insertbtn
            // 
            Insertbtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Insertbtn.Location = new Point(88, 396);
            Insertbtn.Name = "Insertbtn";
            Insertbtn.Size = new Size(139, 55);
            Insertbtn.TabIndex = 5;
            Insertbtn.Text = "Insert";
            Insertbtn.UseVisualStyleBackColor = true;
            Insertbtn.Click += Insertbtn_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Updatebtn.Location = new Point(292, 396);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(125, 55);
            Updatebtn.TabIndex = 6;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Deletebtn.Location = new Point(445, 396);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(139, 55);
            Deletebtn.TabIndex = 7;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(272, 21);
            label1.Name = "label1";
            label1.Size = new Size(181, 54);
            label1.TabIndex = 0;
            label1.Text = "Hospital";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 124);
            label2.Name = "label2";
            label2.Size = new Size(153, 38);
            label2.TabIndex = 8;
            label2.Text = "Hospital ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 183);
            label3.Name = "label3";
            label3.Size = new Size(91, 38);
            label3.TabIndex = 9;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 236);
            label4.Name = "label4";
            label4.Size = new Size(116, 38);
            label4.TabIndex = 10;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(61, 301);
            label5.Name = "label5";
            label5.Size = new Size(83, 38);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 701);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Deletebtn);
            Controls.Add(Updatebtn);
            Controls.Add(Insertbtn);
            Controls.Add(DGV);
            Controls.Add(EmailTb);
            Controls.Add(AddressTb);
            Controls.Add(NameTb);
            Controls.Add(IDTb);
            Controls.Add(panel1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Registration";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox IDTb;
        private TextBox NameTb;
        private TextBox AddressTb;
        private TextBox EmailTb;
        private DataGridView DGV;
        private Button Insertbtn;
        private Button Updatebtn;
        private Button Deletebtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}