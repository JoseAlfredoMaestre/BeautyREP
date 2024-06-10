﻿namespace GUI.Forms.Users
{
    partial class UpdateUser
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
            this.updateUserButton = new MaterialSkin.Controls.MaterialButton();
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
            this.nameInput.Location = new System.Drawing.Point(25, 91);
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
            this.nameInput.TabIndex = 1;
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
            this.surnamesInput.Location = new System.Drawing.Point(25, 174);
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
            this.surnamesInput.TabIndex = 2;
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
            this.phoneInput.Location = new System.Drawing.Point(435, 91);
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
            this.phoneInput.TabIndex = 3;
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
            this.emailInput.Location = new System.Drawing.Point(435, 174);
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
            this.emailInput.TabIndex = 4;
            this.emailInput.TabStop = false;
            this.emailInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailInput.TrailingIcon = null;
            this.emailInput.UseSystemPasswordChar = false;
            // 
            // updateUserButton
            // 
            this.updateUserButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateUserButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.updateUserButton.Depth = 0;
            this.updateUserButton.HighEmphasis = true;
            this.updateUserButton.Icon = null;
            this.updateUserButton.Location = new System.Drawing.Point(576, 274);
            this.updateUserButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updateUserButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.updateUserButton.Size = new System.Drawing.Size(109, 36);
            this.updateUserButton.TabIndex = 7;
            this.updateUserButton.Text = "Actualizar";
            this.updateUserButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.updateUserButton.UseAccentColor = false;
            this.updateUserButton.UseVisualStyleBackColor = true;
            this.updateUserButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateUserButton);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.surnamesInput);
            this.Controls.Add(this.nameInput);
            this.Name = "UpdateUser";
            this.Text = "Actualizar usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 nameInput;
        private MaterialSkin.Controls.MaterialTextBox2 surnamesInput;
        private MaterialSkin.Controls.MaterialTextBox2 phoneInput;
        private MaterialSkin.Controls.MaterialTextBox2 emailInput;
        private MaterialSkin.Controls.MaterialButton updateUserButton;
    }
}