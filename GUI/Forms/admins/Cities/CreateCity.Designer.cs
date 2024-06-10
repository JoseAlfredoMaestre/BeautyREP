using System.ComponentModel;

namespace GUI.Forms.admins.Cities;

partial class CreateCity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCity));
            this.nameInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.createCityBtn = new MaterialSkin.Controls.MaterialButton();
            this.descripcionTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
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
            this.nameInput.Hint = "Nombre de la ciudad";
            this.nameInput.LeadingIcon = null;
            this.nameInput.Location = new System.Drawing.Point(31, 92);
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
            this.nameInput.TabIndex = 15;
            this.nameInput.TabStop = false;
            this.nameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameInput.TrailingIcon = null;
            this.nameInput.UseSystemPasswordChar = false;
            // 
            // createCityBtn
            // 
            this.createCityBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createCityBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createCityBtn.Depth = 0;
            this.createCityBtn.HighEmphasis = true;
            this.createCityBtn.Icon = null;
            this.createCityBtn.Location = new System.Drawing.Point(401, 354);
            this.createCityBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createCityBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createCityBtn.Name = "createCityBtn";
            this.createCityBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.createCityBtn.Size = new System.Drawing.Size(67, 36);
            this.createCityBtn.TabIndex = 14;
            this.createCityBtn.Text = "CREAR";
            this.createCityBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createCityBtn.UseAccentColor = false;
            this.createCityBtn.UseVisualStyleBackColor = true;
            this.createCityBtn.Click += new System.EventHandler(this.createCityBtn_Click);
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
            this.descripcionTextBox.Location = new System.Drawing.Point(31, 170);
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
            this.descripcionTextBox.TabIndex = 17;
            this.descripcionTextBox.TabStop = false;
            this.descripcionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.descripcionTextBox.UseSystemPasswordChar = false;
            // 
            // CreateCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.createCityBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateCity";
            this.Text = "Crear Ciudad";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private MaterialSkin.Controls.MaterialMultiLineTextBox2 descripcionTextBox;

    private MaterialSkin.Controls.MaterialTextBox2 cedulaInput;
    private MaterialSkin.Controls.MaterialButton createCityBtn;
    private MaterialSkin.Controls.MaterialTextBox2 nameInput;

    #endregion
}