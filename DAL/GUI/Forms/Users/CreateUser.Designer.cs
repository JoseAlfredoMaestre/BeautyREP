namespace GUI.Forms.Users
{
    partial class CreateUser
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
            this.nameInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.surnamesInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.phoneInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.emailInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.usernameInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.passwordInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.createUserButton = new MaterialSkin.Controls.MaterialButton();
            this.cedulaInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.AnimateReadOnly = false;
            this.nameInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nameInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameInput.Depth = 0;
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameInput.HideSelection = true;
            this.nameInput.Hint = "Nombres";
            this.nameInput.LeadingIcon = null;
            this.nameInput.Location = new System.Drawing.Point(46, 189);
            this.nameInput.MaxLength = 32767;
            this.nameInput.MouseState = MaterialSkin.MouseState.OUT;
            this.nameInput.Name = "nameInput";
            this.nameInput.PasswordChar = '\0';
            this.nameInput.PrefixSuffixText = null;
            this.nameInput.ReadOnly = false;
            this.nameInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameInput.SelectedText = "";
            this.nameInput.SelectionLength = 0;
            this.nameInput.SelectionStart = 0;
            this.nameInput.ShortcutsEnabled = true;
            this.nameInput.Size = new System.Drawing.Size(250, 48);
            this.nameInput.TabIndex = 0;
            this.nameInput.TabStop = false;
            this.nameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameInput.TrailingIcon = null;
            this.nameInput.UseSystemPasswordChar = false;
            // 
            // surnamesInput
            // 
            this.surnamesInput.AnimateReadOnly = false;
            this.surnamesInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.surnamesInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.surnamesInput.Depth = 0;
            this.surnamesInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.surnamesInput.HideSelection = true;
            this.surnamesInput.Hint = "Apellidos";
            this.surnamesInput.LeadingIcon = null;
            this.surnamesInput.Location = new System.Drawing.Point(46, 273);
            this.surnamesInput.MaxLength = 32767;
            this.surnamesInput.MouseState = MaterialSkin.MouseState.OUT;
            this.surnamesInput.Name = "surnamesInput";
            this.surnamesInput.PasswordChar = '\0';
            this.surnamesInput.PrefixSuffixText = null;
            this.surnamesInput.ReadOnly = false;
            this.surnamesInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.surnamesInput.SelectedText = "";
            this.surnamesInput.SelectionLength = 0;
            this.surnamesInput.SelectionStart = 0;
            this.surnamesInput.ShortcutsEnabled = true;
            this.surnamesInput.Size = new System.Drawing.Size(250, 48);
            this.surnamesInput.TabIndex = 1;
            this.surnamesInput.TabStop = false;
            this.surnamesInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.surnamesInput.TrailingIcon = null;
            this.surnamesInput.UseSystemPasswordChar = false;
            // 
            // phoneInput
            // 
            this.phoneInput.AnimateReadOnly = false;
            this.phoneInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.phoneInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.phoneInput.Depth = 0;
            this.phoneInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.phoneInput.HideSelection = true;
            this.phoneInput.Hint = "Telefono";
            this.phoneInput.LeadingIcon = null;
            this.phoneInput.Location = new System.Drawing.Point(46, 357);
            this.phoneInput.MaxLength = 32767;
            this.phoneInput.MouseState = MaterialSkin.MouseState.OUT;
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.PasswordChar = '\0';
            this.phoneInput.PrefixSuffixText = null;
            this.phoneInput.ReadOnly = false;
            this.phoneInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.phoneInput.SelectedText = "";
            this.phoneInput.SelectionLength = 0;
            this.phoneInput.SelectionStart = 0;
            this.phoneInput.ShortcutsEnabled = true;
            this.phoneInput.Size = new System.Drawing.Size(250, 48);
            this.phoneInput.TabIndex = 2;
            this.phoneInput.TabStop = false;
            this.phoneInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phoneInput.TrailingIcon = null;
            this.phoneInput.UseSystemPasswordChar = false;
            // 
            // emailInput
            // 
            this.emailInput.AnimateReadOnly = false;
            this.emailInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.emailInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.emailInput.Depth = 0;
            this.emailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emailInput.HideSelection = true;
            this.emailInput.Hint = "Correo";
            this.emailInput.LeadingIcon = null;
            this.emailInput.Location = new System.Drawing.Point(452, 98);
            this.emailInput.MaxLength = 32767;
            this.emailInput.MouseState = MaterialSkin.MouseState.OUT;
            this.emailInput.Name = "emailInput";
            this.emailInput.PasswordChar = '\0';
            this.emailInput.PrefixSuffixText = null;
            this.emailInput.ReadOnly = false;
            this.emailInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.emailInput.SelectedText = "";
            this.emailInput.SelectionLength = 0;
            this.emailInput.SelectionStart = 0;
            this.emailInput.ShortcutsEnabled = true;
            this.emailInput.Size = new System.Drawing.Size(250, 48);
            this.emailInput.TabIndex = 3;
            this.emailInput.TabStop = false;
            this.emailInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailInput.TrailingIcon = null;
            this.emailInput.UseSystemPasswordChar = false;
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
            this.usernameInput.Location = new System.Drawing.Point(452, 189);
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
            this.usernameInput.Size = new System.Drawing.Size(250, 48);
            this.usernameInput.TabIndex = 4;
            this.usernameInput.TabStop = false;
            this.usernameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameInput.TrailingIcon = null;
            this.usernameInput.UseSystemPasswordChar = false;
            // 
            // passwordInput
            // 
            this.passwordInput.AnimateReadOnly = false;
            this.passwordInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordInput.Depth = 0;
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordInput.HideSelection = true;
            this.passwordInput.Hint = "Contraseña";
            this.passwordInput.LeadingIcon = null;
            this.passwordInput.Location = new System.Drawing.Point(452, 273);
            this.passwordInput.MaxLength = 32767;
            this.passwordInput.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '\0';
            this.passwordInput.PrefixSuffixText = null;
            this.passwordInput.ReadOnly = false;
            this.passwordInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordInput.SelectedText = "";
            this.passwordInput.SelectionLength = 0;
            this.passwordInput.SelectionStart = 0;
            this.passwordInput.ShortcutsEnabled = true;
            this.passwordInput.Size = new System.Drawing.Size(250, 48);
            this.passwordInput.TabIndex = 5;
            this.passwordInput.TabStop = false;
            this.passwordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordInput.TrailingIcon = null;
            this.passwordInput.UseSystemPasswordChar = false;
            // 
            // createUserButton
            // 
            this.createUserButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createUserButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createUserButton.Depth = 0;
            this.createUserButton.HighEmphasis = true;
            this.createUserButton.Icon = null;
            this.createUserButton.Location = new System.Drawing.Point(635, 369);
            this.createUserButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createUserButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.createUserButton.Size = new System.Drawing.Size(67, 36);
            this.createUserButton.TabIndex = 6;
            this.createUserButton.Text = "CREAR";
            this.createUserButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createUserButton.UseAccentColor = false;
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // cedulaInput
            // 
            this.cedulaInput.AnimateReadOnly = false;
            this.cedulaInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cedulaInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cedulaInput.Depth = 0;
            this.cedulaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cedulaInput.HideSelection = true;
            this.cedulaInput.Hint = "Cedula";
            this.cedulaInput.LeadingIcon = null;
            this.cedulaInput.Location = new System.Drawing.Point(46, 98);
            this.cedulaInput.MaxLength = 32767;
            this.cedulaInput.MouseState = MaterialSkin.MouseState.OUT;
            this.cedulaInput.Name = "cedulaInput";
            this.cedulaInput.PasswordChar = '\0';
            this.cedulaInput.PrefixSuffixText = null;
            this.cedulaInput.ReadOnly = false;
            this.cedulaInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cedulaInput.SelectedText = "";
            this.cedulaInput.SelectionLength = 0;
            this.cedulaInput.SelectionStart = 0;
            this.cedulaInput.ShortcutsEnabled = true;
            this.cedulaInput.Size = new System.Drawing.Size(250, 48);
            this.cedulaInput.TabIndex = 7;
            this.cedulaInput.TabStop = false;
            this.cedulaInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cedulaInput.TrailingIcon = null;
            this.cedulaInput.UseSystemPasswordChar = false;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cedulaInput);
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.surnamesInput);
            this.Controls.Add(this.nameInput);
            this.Name = "CreateUser";
            this.Text = "Crear Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private MaterialSkin.Controls.MaterialTextBox2 cedulaInput;

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 nameInput;
        private MaterialSkin.Controls.MaterialTextBox2 surnamesInput;
        private MaterialSkin.Controls.MaterialTextBox2 phoneInput;
        private MaterialSkin.Controls.MaterialTextBox2 emailInput;
        private MaterialSkin.Controls.MaterialTextBox2 usernameInput;
        private MaterialSkin.Controls.MaterialTextBox2 passwordInput;
        private MaterialSkin.Controls.MaterialButton createUserButton;
    }
}