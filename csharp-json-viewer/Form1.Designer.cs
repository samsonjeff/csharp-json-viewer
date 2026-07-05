namespace csharp_json_viewer
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
            activateBtn = new Button();
            loadBtn = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // activateBtn
            // 
            activateBtn.AutoSize = true;
            activateBtn.BackColor = Color.DimGray;
            activateBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            activateBtn.ForeColor = SystemColors.ButtonHighlight;
            activateBtn.Location = new Point(28, 109);
            activateBtn.Name = "activateBtn";
            activateBtn.Size = new Size(94, 33);
            activateBtn.TabIndex = 0;
            activateBtn.Text = "Acivate";
            activateBtn.UseVisualStyleBackColor = false;
            activateBtn.Click += activateBtn_Click;
            // 
            // loadBtn
            // 
            loadBtn.AutoSize = true;
            loadBtn.BackColor = Color.DimGray;
            loadBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadBtn.ForeColor = SystemColors.ButtonHighlight;
            loadBtn.Location = new Point(28, 176);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(94, 33);
            loadBtn.TabIndex = 1;
            loadBtn.Text = "Load";
            loadBtn.UseVisualStyleBackColor = false;
            loadBtn.Click += loadBtn_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 10.2F);
            radioButton1.Location = new Point(655, 54);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(81, 27);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Online";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 10.2F);
            radioButton2.Location = new Point(773, 54);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 27);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Local";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(159, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(684, 316);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveBorder;
            textBox1.Location = new Point(159, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(684, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 83);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 6;
            label1.Text = "Paste URL/SRC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(159, 148);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 7;
            label2.Text = "Json data";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(880, 522);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(loadBtn);
            Controls.Add(activateBtn);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "who is Json?";
            Load += Form1_Load;
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button activateBtn;
        private Button loadBtn;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}
