namespace WinForms
{
    partial class RegistrationForms
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
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.confirmPassText = new System.Windows.Forms.TextBox();
            this.informationText = new System.Windows.Forms.Label();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(419, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(36, 36);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 147);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginText
            // 
            this.loginText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginText.Location = new System.Drawing.Point(164, 189);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(201, 22);
            this.loginText.TabIndex = 2;
            this.loginText.Enter += new System.EventHandler(this.loginText_Enter);
            this.loginText.Leave += new System.EventHandler(this.loginText_Leave);
            this.loginText.MouseEnter += new System.EventHandler(this.loginText_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.confirmPassText);
            this.panel1.Controls.Add(this.informationText);
            this.panel1.Controls.Add(this.buttonRegistration);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.passwordText);
            this.panel1.Controls.Add(this.loginText);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 457);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::WinForms.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(117, 274);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // confirmPassText
            // 
            this.confirmPassText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmPassText.Location = new System.Drawing.Point(164, 284);
            this.confirmPassText.Name = "confirmPassText";
            this.confirmPassText.Size = new System.Drawing.Size(201, 22);
            this.confirmPassText.TabIndex = 6;
            this.confirmPassText.UseSystemPasswordChar = true;
            this.confirmPassText.MouseEnter += new System.EventHandler(this.confirmPassText_MouseEnter);
            // 
            // informationText
            // 
            this.informationText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.informationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.informationText.Location = new System.Drawing.Point(0, 413);
            this.informationText.Name = "informationText";
            this.informationText.Size = new System.Drawing.Size(455, 44);
            this.informationText.TabIndex = 2;
            this.informationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistration.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRegistration.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistration.Location = new System.Drawing.Point(95, 340);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(270, 56);
            this.buttonRegistration.TabIndex = 5;
            this.buttonRegistration.Text = "Registration";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::WinForms.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(117, 226);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // passwordText
            // 
            this.passwordText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordText.Location = new System.Drawing.Point(164, 233);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(201, 22);
            this.passwordText.TabIndex = 3;
            this.passwordText.UseSystemPasswordChar = true;
            this.passwordText.MouseEnter += new System.EventHandler(this.passwordText_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WinForms.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(117, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 147);
            this.panel2.TabIndex = 0;
            // 
            // RegistrationForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 457);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForms";
            this.Text = "RegistrationForms";
            this.Load += new System.EventHandler(this.RegistrationForms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label informationText;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox confirmPassText;
    }
}