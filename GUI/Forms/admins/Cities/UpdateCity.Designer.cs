using System.ComponentModel;

namespace GUI.Forms.admins.Cities;

partial class UpdateCity
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.descripcionTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
        this.nameInput = new MaterialSkin.Controls.MaterialTextBox2();
        this.actualizarCiudadBtn = new MaterialSkin.Controls.MaterialButton();
        this.SuspendLayout();
        // 
        // descripcionTextBox
        // 
        this.descripcionTextBox.AnimateReadOnly = false;
        this.descripcionTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.descripcionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.descripcionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
        this.descripcionTextBox.Depth = 0;
        this.descripcionTextBox.HideSelection = true;
        this.descripcionTextBox.Hint = "Descripción";
        this.descripcionTextBox.Location = new System.Drawing.Point(47, 185);
        this.descripcionTextBox.MaxLength = 32767;
        this.descripcionTextBox.MouseState = MaterialSkin.MouseState.OUT;
        this.descripcionTextBox.Name = "descripcionTextBox";
        this.descripcionTextBox.PasswordChar = '\0';
        this.descripcionTextBox.ReadOnly = false;
        this.descripcionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
        this.descripcionTextBox.SelectedText = "";
        this.descripcionTextBox.SelectionLength = 0;
        this.descripcionTextBox.SelectionStart = 0;
        this.descripcionTextBox.ShortcutsEnabled = true;
        this.descripcionTextBox.Size = new System.Drawing.Size(437, 147);
        this.descripcionTextBox.TabIndex = 19;
        this.descripcionTextBox.TabStop = false;
        this.descripcionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.descripcionTextBox.UseSystemPasswordChar = false;
        // 
        // nameInput
        // 
        this.nameInput.AnimateReadOnly = false;
        this.nameInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.nameInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.nameInput.Depth = 0;
        this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.nameInput.HideSelection = true;
        this.nameInput.Hint = "Nombre de la ciudad";
        this.nameInput.LeadingIcon = null;
        this.nameInput.Location = new System.Drawing.Point(47, 107);
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
        this.nameInput.Size = new System.Drawing.Size(437, 48);
        this.nameInput.TabIndex = 18;
        this.nameInput.TabStop = false;
        this.nameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.nameInput.TrailingIcon = null;
        this.nameInput.UseSystemPasswordChar = false;
        // 
        // actualizarCiudadBtn
        // 
        this.actualizarCiudadBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.actualizarCiudadBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        this.actualizarCiudadBtn.Depth = 0;
        this.actualizarCiudadBtn.HighEmphasis = true;
        this.actualizarCiudadBtn.Icon = null;
        this.actualizarCiudadBtn.Location = new System.Drawing.Point(326, 365);
        this.actualizarCiudadBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.actualizarCiudadBtn.MouseState = MaterialSkin.MouseState.HOVER;
        this.actualizarCiudadBtn.Name = "actualizarCiudadBtn";
        this.actualizarCiudadBtn.NoAccentTextColor = System.Drawing.Color.Empty;
        this.actualizarCiudadBtn.Size = new System.Drawing.Size(165, 36);
        this.actualizarCiudadBtn.TabIndex = 20;
        this.actualizarCiudadBtn.Text = "Actualizar ciudad";
        this.actualizarCiudadBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        this.actualizarCiudadBtn.UseAccentColor = false;
        this.actualizarCiudadBtn.UseVisualStyleBackColor = true;
        this.actualizarCiudadBtn.Click += new System.EventHandler(this.actualizarCiudadBtn_Click);
        // 
        // UpdateCity
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(542, 457);
        this.Controls.Add(this.actualizarCiudadBtn);
        this.Controls.Add(this.descripcionTextBox);
        this.Controls.Add(this.nameInput);
        this.Name = "UpdateCity";
        this.Text = "UpdateCity";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private MaterialSkin.Controls.MaterialMultiLineTextBox2 descripcionTextBox;
    private MaterialSkin.Controls.MaterialTextBox2 nameInput;
    private MaterialSkin.Controls.MaterialButton actualizarCiudadBtn;

    #endregion
}