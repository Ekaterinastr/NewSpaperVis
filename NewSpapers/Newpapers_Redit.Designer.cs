
namespace NewSpapers
{
    partial class Newpapers_Redit
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label agentTypeIDLabel;
            System.Windows.Forms.Label directorNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label iNNLabel;
            System.Windows.Forms.Label kPPLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.Label addressLabel;
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.agentTypeIDTextBox = new System.Windows.Forms.TextBox();
            this.directorNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.iNNTextBox = new System.Windows.Forms.TextBox();
            this.kPPTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.attachBtn = new System.Windows.Forms.Button();
            this.wayImageTb = new System.Windows.Forms.TextBox();
            this.imagePic = new System.Windows.Forms.PictureBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            titleLabel = new System.Windows.Forms.Label();
            agentTypeIDLabel = new System.Windows.Forms.Label();
            directorNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            kPPLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).BeginInit();
            this.SuspendLayout();
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataSource = typeof(NewSpapers.Agent);
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            titleLabel.Location = new System.Drawing.Point(43, 48);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(122, 20);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Наименование";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.Location = new System.Drawing.Point(171, 48);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(331, 26);
            this.titleTextBox.TabIndex = 2;
            // 
            // agentTypeIDLabel
            // 
            agentTypeIDLabel.AutoSize = true;
            agentTypeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            agentTypeIDLabel.Location = new System.Drawing.Point(12, 89);
            agentTypeIDLabel.Name = "agentTypeIDLabel";
            agentTypeIDLabel.Size = new System.Drawing.Size(155, 20);
            agentTypeIDLabel.TabIndex = 2;
            agentTypeIDLabel.Text = "Номер типа агента";
            // 
            // agentTypeIDTextBox
            // 
            this.agentTypeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgentTypeID", true));
            this.agentTypeIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentTypeIDTextBox.Location = new System.Drawing.Point(183, 86);
            this.agentTypeIDTextBox.Name = "agentTypeIDTextBox";
            this.agentTypeIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.agentTypeIDTextBox.TabIndex = 3;
            // 
            // directorNameLabel
            // 
            directorNameLabel.AutoSize = true;
            directorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            directorNameLabel.Location = new System.Drawing.Point(12, 212);
            directorNameLabel.Name = "directorNameLabel";
            directorNameLabel.Size = new System.Drawing.Size(126, 20);
            directorNameLabel.TabIndex = 4;
            directorNameLabel.Text = "Имя директора";
            // 
            // directorNameTextBox
            // 
            this.directorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "DirectorName", true));
            this.directorNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorNameTextBox.Location = new System.Drawing.Point(144, 209);
            this.directorNameTextBox.Name = "directorNameTextBox";
            this.directorNameTextBox.Size = new System.Drawing.Size(379, 26);
            this.directorNameTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emailLabel.Location = new System.Drawing.Point(12, 268);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(71, 268);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(175, 26);
            this.emailTextBox.TabIndex = 7;
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iNNLabel.Location = new System.Drawing.Point(12, 146);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(44, 20);
            iNNLabel.TabIndex = 8;
            iNNLabel.Text = "ИНН";
            // 
            // iNNTextBox
            // 
            this.iNNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "INN", true));
            this.iNNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iNNTextBox.Location = new System.Drawing.Point(62, 146);
            this.iNNTextBox.Name = "iNNTextBox";
            this.iNNTextBox.Size = new System.Drawing.Size(190, 26);
            this.iNNTextBox.TabIndex = 9;
            // 
            // kPPLabel
            // 
            kPPLabel.AutoSize = true;
            kPPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kPPLabel.Location = new System.Drawing.Point(308, 176);
            kPPLabel.Name = "kPPLabel";
            kPPLabel.Size = new System.Drawing.Size(43, 20);
            kPPLabel.TabIndex = 10;
            kPPLabel.Text = "КПП";
            // 
            // kPPTextBox
            // 
            this.kPPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "KPP", true));
            this.kPPTextBox.Location = new System.Drawing.Point(373, 178);
            this.kPPTextBox.Name = "kPPTextBox";
            this.kPPTextBox.Size = new System.Drawing.Size(222, 20);
            this.kPPTextBox.TabIndex = 11;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.Location = new System.Drawing.Point(299, 247);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(79, 20);
            phoneLabel.TabIndex = 12;
            phoneLabel.Text = "Телефон";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(389, 247);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(206, 20);
            this.phoneTextBox.TabIndex = 13;
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priorityLabel.Location = new System.Drawing.Point(12, 354);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(93, 20);
            priorityLabel.TabIndex = 14;
            priorityLabel.Text = "Приоритет";
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Priority", true));
            this.priorityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityTextBox.Location = new System.Drawing.Point(111, 354);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(200, 26);
            this.priorityTextBox.TabIndex = 15;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.Location = new System.Drawing.Point(27, 459);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(130, 43);
            this.backBtn.TabIndex = 26;
            this.backBtn.Text = "Отмена";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.Location = new System.Drawing.Point(540, 459);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(130, 43);
            this.SaveBtn.TabIndex = 27;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // attachBtn
            // 
            this.attachBtn.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attachBtn.Location = new System.Drawing.Point(386, 421);
            this.attachBtn.Name = "attachBtn";
            this.attachBtn.Size = new System.Drawing.Size(130, 28);
            this.attachBtn.TabIndex = 31;
            this.attachBtn.Text = "Прикрепить";
            this.attachBtn.UseVisualStyleBackColor = true;
            // 
            // wayImageTb
            // 
            this.wayImageTb.Font = new System.Drawing.Font("Gabriola", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wayImageTb.Location = new System.Drawing.Point(386, 385);
            this.wayImageTb.Name = "wayImageTb";
            this.wayImageTb.Size = new System.Drawing.Size(130, 30);
            this.wayImageTb.TabIndex = 30;
            // 
            // imagePic
            // 
            this.imagePic.Location = new System.Drawing.Point(386, 280);
            this.imagePic.Name = "imagePic";
            this.imagePic.Size = new System.Drawing.Size(130, 99);
            this.imagePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePic.TabIndex = 29;
            this.imagePic.TabStop = false;
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            imageLabel.Location = new System.Drawing.Point(333, 280);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(58, 39);
            imageLabel.TabIndex = 28;
            imageLabel.Text = "Фото:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.Location = new System.Drawing.Point(300, 123);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(57, 20);
            addressLabel.TabIndex = 31;
            addressLabel.Text = "Адрес";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(373, 125);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(297, 20);
            this.addressTextBox.TabIndex = 32;
            // 
            // Newpapers_Redit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 514);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.attachBtn);
            this.Controls.Add(this.wayImageTb);
            this.Controls.Add(this.imagePic);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(priorityLabel);
            this.Controls.Add(this.priorityTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(kPPLabel);
            this.Controls.Add(this.kPPTextBox);
            this.Controls.Add(iNNLabel);
            this.Controls.Add(this.iNNTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(directorNameLabel);
            this.Controls.Add(this.directorNameTextBox);
            this.Controls.Add(agentTypeIDLabel);
            this.Controls.Add(this.agentTypeIDTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Name = "Newpapers_Redit";
            this.Text = "Newpapers_Redit";
            this.Load += new System.EventHandler(this.Newpapers_Redit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox agentTypeIDTextBox;
        private System.Windows.Forms.TextBox directorNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox iNNTextBox;
        private System.Windows.Forms.TextBox kPPTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button attachBtn;
        private System.Windows.Forms.TextBox wayImageTb;
        private System.Windows.Forms.PictureBox imagePic;
        private System.Windows.Forms.TextBox addressTextBox;
    }
}