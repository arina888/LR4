namespace LR4
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Subscriber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Город2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subscriber,
            this.Город2,
            this.allcost});
            this.dataGridView1.Location = new System.Drawing.Point(56, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(580, 482);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 511);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Общая стоимость всех звонков";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 542);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 35);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Subscriber
            // 
            this.Subscriber.HeaderText = "Абонент";
            this.Subscriber.MinimumWidth = 6;
            this.Subscriber.Name = "Subscriber";
            this.Subscriber.ReadOnly = true;
            this.Subscriber.Width = 180;
            // 
            // Город2
            // 
            this.Город2.HeaderText = "Город";
            this.Город2.MinimumWidth = 6;
            this.Город2.Name = "Город2";
            this.Город2.ReadOnly = true;
            this.Город2.Width = 180;
            // 
            // allcost
            // 
            this.allcost.HeaderText = "Стоимость всех звонков по тарифу";
            this.allcost.MinimumWidth = 6;
            this.allcost.Name = "allcost";
            this.allcost.ReadOnly = true;
            this.allcost.Width = 180;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 607);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form4";
            this.Text = "Абонентская база";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private DataGridViewTextBoxColumn Subscriber;
        private DataGridViewTextBoxColumn Город2;
        private DataGridViewTextBoxColumn allcost;
    }
}