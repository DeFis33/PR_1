namespace PR1
{
    partial class Info
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
            this.developer = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.specialization = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.emailLink = new System.Windows.Forms.LinkLabel();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // developer
            // 
            this.developer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.developer.AutoSize = true;
            this.developer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.developer.Location = new System.Drawing.Point(39, 152);
            this.developer.Name = "developer";
            this.developer.Size = new System.Drawing.Size(164, 16);
            this.developer.TabIndex = 0;
            this.developer.Text = "Разработал: Пирогов Д.";
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(92, 68);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(311, 24);
            this.title.TabIndex = 1;
            this.title.Text = "Программа \"Мое приложение\"";
            // 
            // specialization
            // 
            this.specialization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.specialization.AutoSize = true;
            this.specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialization.Location = new System.Drawing.Point(39, 201);
            this.specialization.Name = "specialization";
            this.specialization.Size = new System.Drawing.Size(433, 16);
            this.specialization.TabIndex = 2;
            this.specialization.Text = "Специальность: Информационные системы и программирование";
            // 
            // email
            // 
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.Location = new System.Drawing.Point(59, 245);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(27, 16);
            this.email.TabIndex = 3;
            this.email.Text = "VK:";
            // 
            // emailLink
            // 
            this.emailLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.emailLink.AutoSize = true;
            this.emailLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLink.Location = new System.Drawing.Point(85, 245);
            this.emailLink.Name = "emailLink";
            this.emailLink.Size = new System.Drawing.Size(151, 16);
            this.emailLink.TabIndex = 4;
            this.emailLink.TabStop = true;
            this.emailLink.Text = "https://vk.com/nee_gear";
            this.emailLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.emailLink_LinkClicked);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(110, 334);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(293, 82);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(506, 452);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.emailLink);
            this.Controls.Add(this.email);
            this.Controls.Add(this.specialization);
            this.Controls.Add(this.title);
            this.Controls.Add(this.developer);
            this.MaximumSize = new System.Drawing.Size(522, 491);
            this.MinimumSize = new System.Drawing.Size(522, 491);
            this.Name = "Info";
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label developer;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label specialization;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.LinkLabel emailLink;
        private System.Windows.Forms.Button btnBack;
    }
}