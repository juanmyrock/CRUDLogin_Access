namespace CapaVistas
{
    partial class FormLogin
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
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            textPass = new TextBox();
            labelLog = new Label();
            btnAcceder = new Button();
            linkLblPass = new LinkLabel();
            btnCerrar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 20, 88);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 350);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.FH_Design_Juanma;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 350);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(15, 15, 15);
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Cursor = Cursors.Hand;
            txtUser.Font = new Font("Century Gothic", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = Color.DimGray;
            txtUser.Location = new Point(276, 86);
            txtUser.Name = "txtUser";
            txtUser.PasswordChar = '*';
            txtUser.PlaceholderText = "USUARIO";
            txtUser.Size = new Size(475, 30);
            txtUser.TabIndex = 1;
            txtUser.Enter += txtUser_Enter;
            // 
            // textPass
            // 
            textPass.BackColor = Color.FromArgb(15, 15, 15);
            textPass.BorderStyle = BorderStyle.FixedSingle;
            textPass.Cursor = Cursors.Hand;
            textPass.Font = new Font("Century Gothic", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point);
            textPass.ForeColor = Color.DimGray;
            textPass.Location = new Point(276, 167);
            textPass.Name = "textPass";
            textPass.PlaceholderText = "CONTRASEÑA";
            textPass.Size = new Size(475, 30);
            textPass.TabIndex = 2;
            textPass.Enter += textPass_Enter;
            // 
            // labelLog
            // 
            labelLog.AutoSize = true;
            labelLog.Font = new Font("Century Gothic", 22.2545452F, FontStyle.Bold, GraphicsUnit.Point);
            labelLog.ForeColor = Color.DimGray;
            labelLog.Location = new Point(461, 9);
            labelLog.Name = "labelLog";
            labelLog.Size = new Size(125, 40);
            labelLog.TabIndex = 3;
            labelLog.Text = "LOGIN";
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(40, 40, 40);
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAcceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Century Gothic", 13.7454548F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcceder.ForeColor = Color.LightGray;
            btnAcceder.Location = new Point(376, 234);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(291, 50);
            btnAcceder.TabIndex = 3;
            btnAcceder.Text = "ACCEDER";
            btnAcceder.UseVisualStyleBackColor = false;
            // 
            // linkLblPass
            // 
            linkLblPass.ActiveLinkColor = Color.FromArgb(0, 122, 204);
            linkLblPass.AutoSize = true;
            linkLblPass.LinkColor = Color.DimGray;
            linkLblPass.Location = new Point(461, 287);
            linkLblPass.Name = "linkLblPass";
            linkLblPass.Size = new Size(118, 19);
            linkLblPass.TabIndex = 0;
            linkLblPass.TabStop = true;
            linkLblPass.Text = "Forgot Password?";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.FromArgb(64, 64, 64);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.cerrar_icon;
            btnCerrar.Location = new Point(743, 9);
            btnCerrar.Margin = new Padding(6);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Padding = new Padding(2);
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 1;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 350);
            Controls.Add(btnCerrar);
            Controls.Add(linkLblPass);
            Controls.Add(btnAcceder);
            Controls.Add(labelLog);
            Controls.Add(textPass);
            Controls.Add(txtUser);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Opacity = 0.6D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            MouseDown += FormLogin_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtUser;
        private TextBox textPass;
        private Label labelLog;
        private Button btnAcceder;
        private LinkLabel linkLblPass;
        private PictureBox btnCerrar;
    }
}