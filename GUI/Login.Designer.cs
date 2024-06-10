namespace GUI
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usernameInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.passwordInput = new MaterialSkin.Controls.MaterialTextBox();
            this.loginButton = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signUpButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameInput
            // 
            this.usernameInput.AnimateReadOnly = false;
            this.usernameInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usernameInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.usernameInput.Depth = 0;
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameInput.HideSelection = true;
            this.usernameInput.Hint = "Nombre de usuario";
            this.usernameInput.LeadingIcon = null;
            this.usernameInput.Location = new System.Drawing.Point(70, 133);
            this.usernameInput.MaxLength = 32767;
            this.usernameInput.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.PasswordChar = '\0';
            this.usernameInput.PrefixSuffixText = null;
            this.usernameInput.ReadOnly = false;
            this.usernameInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameInput.SelectedText = "";
            this.usernameInput.SelectionLength = 0;
            this.usernameInput.SelectionStart = 0;
            this.usernameInput.ShortcutsEnabled = true;
            this.usernameInput.Size = new System.Drawing.Size(240, 48);
            this.usernameInput.TabIndex = 0;
            this.usernameInput.TabStop = false;
            this.usernameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameInput.TrailingIcon = null;
            this.usernameInput.UseSystemPasswordChar = false;
            // 
            // passwordInput
            // 
            this.passwordInput.AnimateReadOnly = false;
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordInput.Depth = 0;
            this.passwordInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordInput.Hint = "Contraseña";
            this.passwordInput.LeadingIcon = null;
            this.passwordInput.Location = new System.Drawing.Point(70, 224);
            this.passwordInput.MaxLength = 50;
            this.passwordInput.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordInput.Multiline = false;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Password = true;
            this.passwordInput.Size = new System.Drawing.Size(240, 50);
            this.passwordInput.TabIndex = 1;
            this.passwordInput.Text = "";
            this.passwordInput.TrailingIcon = null;
            // 
            // loginButton
            // 
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loginButton.Depth = 0;
            this.loginButton.HighEmphasis = true;
            this.loginButton.Icon = null;
            this.loginButton.Location = new System.Drawing.Point(127, 316);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loginButton.Size = new System.Drawing.Size(128, 36);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Iniciar sesión";
            this.loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loginButton.UseAccentColor = false;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // signUpButton
            // 
            this.signUpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signUpButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.signUpButton.Depth = 0;
            this.signUpButton.HighEmphasis = true;
            this.signUpButton.Icon = null;
            this.signUpButton.Location = new System.Drawing.Point(479, 337);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.signUpButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.signUpButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.signUpButton.Size = new System.Drawing.Size(152, 36);
            this.signUpButton.TabIndex = 4;
            this.signUpButton.Text = "¡Registrate aqui!";
            this.signUpButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.signUpButton.UseAccentColor = false;
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 424);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MaterialSkin.Controls.MaterialButton signUpButton;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 usernameInput;
        private MaterialSkin.Controls.MaterialTextBox passwordInput;
        private MaterialSkin.Controls.MaterialButton loginButton;
    }
}

