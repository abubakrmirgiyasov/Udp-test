namespace FutureTechnologies.Test.Ex2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Send_B = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Length_NUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Log_DGV = new System.Windows.Forms.DataGridView();
            this.Sent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IpAdresses_CB = new System.Windows.Forms.ComboBox();
            this.MACAdresses_CB = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Length_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Log_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel1.Controls.Add(this.Send_B, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Length_NUD, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Log_DGV, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.IpAdresses_CB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.MACAdresses_CB, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(421, 336);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Send_B
            // 
            this.Send_B.BackColor = System.Drawing.Color.DodgerBlue;
            this.Send_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Send_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send_B.ForeColor = System.Drawing.Color.White;
            this.Send_B.Location = new System.Drawing.Point(260, 301);
            this.Send_B.Margin = new System.Windows.Forms.Padding(5);
            this.Send_B.Name = "Send_B";
            this.Send_B.Size = new System.Drawing.Size(156, 30);
            this.Send_B.TabIndex = 2;
            this.Send_B.Text = "Отправит/Получить";
            this.Send_B.UseVisualStyleBackColor = false;
            this.Send_B.Click += new System.EventHandler(this.Send_B_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 3);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(411, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Логи";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(5, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "MAC-адрес";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Length_NUD
            // 
            this.Length_NUD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.Length_NUD, 2);
            this.Length_NUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Length_NUD.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Length_NUD.Location = new System.Drawing.Point(94, 205);
            this.Length_NUD.Margin = new System.Windows.Forms.Padding(5);
            this.Length_NUD.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.Length_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Length_NUD.Name = "Length_NUD";
            this.Length_NUD.Size = new System.Drawing.Size(322, 22);
            this.Length_NUD.TabIndex = 7;
            this.Length_NUD.ThousandsSeparator = true;
            this.Length_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 237);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ip адрес";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(5, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Трафик";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Log_DGV
            // 
            this.Log_DGV.AllowUserToAddRows = false;
            this.Log_DGV.AllowUserToDeleteRows = false;
            this.Log_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Log_DGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Log_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Log_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sent,
            this.Received,
            this.Lost,
            this.Time});
            this.tableLayoutPanel1.SetColumnSpan(this.Log_DGV, 3);
            this.Log_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log_DGV.Location = new System.Drawing.Point(5, 45);
            this.Log_DGV.Margin = new System.Windows.Forms.Padding(5);
            this.Log_DGV.Name = "Log_DGV";
            this.Log_DGV.ReadOnly = true;
            this.Log_DGV.RowHeadersVisible = false;
            this.Log_DGV.Size = new System.Drawing.Size(411, 150);
            this.Log_DGV.TabIndex = 8;
            // 
            // Sent
            // 
            this.Sent.DataPropertyName = "Sent";
            this.Sent.HeaderText = "Отправлено";
            this.Sent.Name = "Sent";
            this.Sent.ReadOnly = true;
            // 
            // Received
            // 
            this.Received.DataPropertyName = "Received";
            this.Received.HeaderText = "Принято";
            this.Received.Name = "Received";
            this.Received.ReadOnly = true;
            // 
            // Lost
            // 
            this.Lost.DataPropertyName = "Lost";
            this.Lost.HeaderText = "Потеряно";
            this.Lost.Name = "Lost";
            this.Lost.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // IpAdresses_CB
            // 
            this.IpAdresses_CB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.IpAdresses_CB, 2);
            this.IpAdresses_CB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IpAdresses_CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IpAdresses_CB.FormattingEnabled = true;
            this.IpAdresses_CB.Location = new System.Drawing.Point(94, 237);
            this.IpAdresses_CB.Margin = new System.Windows.Forms.Padding(5);
            this.IpAdresses_CB.Name = "IpAdresses_CB";
            this.IpAdresses_CB.Size = new System.Drawing.Size(322, 22);
            this.IpAdresses_CB.TabIndex = 11;
            // 
            // MACAdresses_CB
            // 
            this.MACAdresses_CB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.MACAdresses_CB, 2);
            this.MACAdresses_CB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MACAdresses_CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MACAdresses_CB.FormattingEnabled = true;
            this.MACAdresses_CB.Location = new System.Drawing.Point(94, 269);
            this.MACAdresses_CB.Margin = new System.Windows.Forms.Padding(5);
            this.MACAdresses_CB.Name = "MACAdresses_CB";
            this.MACAdresses_CB.Size = new System.Drawing.Size(322, 22);
            this.MACAdresses_CB.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 336);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Length_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Log_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Send_B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Length_NUD;
        private System.Windows.Forms.DataGridView Log_DGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox IpAdresses_CB;
        private System.Windows.Forms.ComboBox MACAdresses_CB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Received;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
    }
}

