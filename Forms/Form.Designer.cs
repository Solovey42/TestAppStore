
namespace Store
{
    partial class Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.npgsqlConnection1 = new Npgsql.NpgsqlConnection();
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
            this.buttonUpdateOrders = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonUpdateOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(666, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // npgsqlConnection1
            // 
            this.npgsqlConnection1.ProvideClientCertificatesCallback = null;
            this.npgsqlConnection1.ProvidePasswordCallback = null;
            this.npgsqlConnection1.UserCertificateValidationCallback = null;
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // npgsqlCommand1
            // 
            this.npgsqlCommand1.AllResultTypesAreUnknown = false;
            this.npgsqlCommand1.Transaction = null;
            this.npgsqlCommand1.UnknownResultTypeList = null;
            // 
            // buttonUpdateOrders
            // 
            this.buttonUpdateOrders.Location = new System.Drawing.Point(8, 182);
            this.buttonUpdateOrders.Name = "buttonUpdateOrders";
            this.buttonUpdateOrders.Size = new System.Drawing.Size(143, 69);
            this.buttonUpdateOrders.TabIndex = 1;
            this.buttonUpdateOrders.Text = "Обновновить заказы";
            this.buttonUpdateOrders.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(690, 297);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.buttonUpdateOrder);
            this.tabPage.Controls.Add(this.buttonDeleteOrder);
            this.tabPage.Controls.Add(this.dataGridView1);
            this.tabPage.Controls.Add(this.buttonUpdateOrders);
            this.tabPage.Location = new System.Drawing.Point(4, 24);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(682, 269);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "Заказы";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Location = new System.Drawing.Point(167, 182);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(144, 69);
            this.buttonDeleteOrder.TabIndex = 2;
            this.buttonDeleteOrder.Text = "Удалить заказ";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(682, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Товары";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(682, 251);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Клиенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateOrder
            // 
            this.buttonUpdateOrder.Location = new System.Drawing.Point(328, 182);
            this.buttonUpdateOrder.Name = "buttonUpdateOrder";
            this.buttonUpdateOrder.Size = new System.Drawing.Size(145, 69);
            this.buttonUpdateOrder.TabIndex = 3;
            this.buttonUpdateOrder.Text = "Обновить заказ";
            this.buttonUpdateOrder.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 297);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form";
            this.Text = "Учет заказов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Npgsql.NpgsqlConnection npgsqlConnection1;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private Npgsql.NpgsqlCommand npgsqlCommand1;
        private System.Windows.Forms.Button buttonUpdateOrders;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Button buttonUpdateOrder;
    }
}

