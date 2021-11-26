
namespace NewSpapers
{
    partial class Newpapers
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AgentTypeId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.changeProdBtn = new System.Windows.Forms.Button();
            this.deleteProdBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filtrCmb = new System.Windows.Forms.ComboBox();
            this.sortCmb = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageProdPic = new System.Windows.Forms.PictureBox();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kPPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageProdPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.AgentTypeId,
            this.addressDataGridViewTextBoxColumn,
            this.iNNDataGridViewTextBoxColumn,
            this.kPPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.agentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // AgentTypeId
            // 
            this.AgentTypeId.DataPropertyName = "AgentTypeID";
            this.AgentTypeId.DataSource = this.agentTypeBindingSource;
            this.AgentTypeId.DisplayMember = "Title";
            this.AgentTypeId.HeaderText = "AgentType";
            this.AgentTypeId.Name = "AgentTypeId";
            this.AgentTypeId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AgentTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AgentTypeId.ValueMember = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(867, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Картинка:";
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(781, 452);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(185, 41);
            this.addProductBtn.TabIndex = 16;
            this.addProductBtn.Text = "Добавить агента";
            this.addProductBtn.UseVisualStyleBackColor = true;
            // 
            // changeProdBtn
            // 
            this.changeProdBtn.Location = new System.Drawing.Point(408, 452);
            this.changeProdBtn.Name = "changeProdBtn";
            this.changeProdBtn.Size = new System.Drawing.Size(179, 41);
            this.changeProdBtn.TabIndex = 17;
            this.changeProdBtn.Text = "Изменить агента";
            this.changeProdBtn.UseVisualStyleBackColor = true;
            this.changeProdBtn.Click += new System.EventHandler(this.changeProdBtn_Click);
            // 
            // deleteProdBtn
            // 
            this.deleteProdBtn.Location = new System.Drawing.Point(87, 452);
            this.deleteProdBtn.Name = "deleteProdBtn";
            this.deleteProdBtn.Size = new System.Drawing.Size(174, 41);
            this.deleteProdBtn.TabIndex = 18;
            this.deleteProdBtn.Text = "Удалить агента";
            this.deleteProdBtn.UseVisualStyleBackColor = true;
            this.deleteProdBtn.Click += new System.EventHandler(this.deleteProdBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(547, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Фильтрация:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(302, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Сортировка:";
            // 
            // filtrCmb
            // 
            this.filtrCmb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgentType.ID", true));
            this.filtrCmb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filtrCmb.FormattingEnabled = true;
            this.filtrCmb.Location = new System.Drawing.Point(531, 49);
            this.filtrCmb.Name = "filtrCmb";
            this.filtrCmb.Size = new System.Drawing.Size(233, 31);
            this.filtrCmb.TabIndex = 20;
            // 
            // sortCmb
            // 
            this.sortCmb.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortCmb.FormattingEnabled = true;
            this.sortCmb.Items.AddRange(new object[] {
            "Возраст. Тип",
            "Убыв. Тип",
            "Возраст. Приоритет",
            "Убыв. Приоритет",
            "Исходная таблица"});
            this.sortCmb.Location = new System.Drawing.Point(290, 50);
            this.sortCmb.Name = "sortCmb";
            this.sortCmb.Size = new System.Drawing.Size(233, 37);
            this.sortCmb.TabIndex = 19;
            this.sortCmb.SelectionChangeCommitted += new System.EventHandler(this.sortCmb_SelectionChangeCommitted);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AgentType";
            this.dataGridViewTextBoxColumn1.HeaderText = "AgentType";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "AgentType";
            this.dataGridViewComboBoxColumn1.HeaderText = "AgentType";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataSource = typeof(NewSpapers.Agent);
            // 
            // imageProdPic
            // 
            this.imageProdPic.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.agentBindingSource, "Logo", true));
            this.imageProdPic.Location = new System.Drawing.Point(866, 161);
            this.imageProdPic.Name = "imageProdPic";
            this.imageProdPic.Size = new System.Drawing.Size(100, 120);
            this.imageProdPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageProdPic.TabIndex = 11;
            this.imageProdPic.TabStop = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // agentTypeBindingSource
            // 
            this.agentTypeBindingSource.DataSource = typeof(NewSpapers.AgentType);
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // iNNDataGridViewTextBoxColumn
            // 
            this.iNNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
            this.iNNDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
            // 
            // kPPDataGridViewTextBoxColumn
            // 
            this.kPPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kPPDataGridViewTextBoxColumn.DataPropertyName = "KPP";
            this.kPPDataGridViewTextBoxColumn.HeaderText = "КПП";
            this.kPPDataGridViewTextBoxColumn.Name = "kPPDataGridViewTextBoxColumn";
            // 
            // Newpapers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 505);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filtrCmb);
            this.Controls.Add(this.sortCmb);
            this.Controls.Add(this.deleteProdBtn);
            this.Controls.Add(this.changeProdBtn);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imageProdPic);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Newpapers";
            this.Text = "Newpapers_agent";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageProdPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.PictureBox imageProdPic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button changeProdBtn;
        private System.Windows.Forms.Button deleteProdBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filtrCmb;
        private System.Windows.Forms.ComboBox sortCmb;
        private System.Windows.Forms.BindingSource agentTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn AgentTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kPPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
    }
}

