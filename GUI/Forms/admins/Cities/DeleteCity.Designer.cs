using System.ComponentModel;

namespace GUI.Forms.admins.Cities;

partial class DeleteCity
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
        this.crtCityNoBtn = new MaterialSkin.Controls.MaterialButton();
        this.crtCityYesBtn = new MaterialSkin.Controls.MaterialButton();
        this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
        this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
        this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
        this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
        this.descriptionMultiLine = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
        this.SuspendLayout();
        // 
        // crtCityNoBtn
        // 
        this.crtCityNoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.crtCityNoBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        this.crtCityNoBtn.Depth = 0;
        this.crtCityNoBtn.HighEmphasis = true;
        this.crtCityNoBtn.Icon = null;
        this.crtCityNoBtn.Location = new System.Drawing.Point(118, 226);
        this.crtCityNoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.crtCityNoBtn.MouseState = MaterialSkin.MouseState.HOVER;
        this.crtCityNoBtn.Name = "crtCityNoBtn";
        this.crtCityNoBtn.NoAccentTextColor = System.Drawing.Color.Empty;
        this.crtCityNoBtn.Size = new System.Drawing.Size(64, 36);
        this.crtCityNoBtn.TabIndex = 23;
        this.crtCityNoBtn.Text = "NO";
        this.crtCityNoBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        this.crtCityNoBtn.UseAccentColor = false;
        this.crtCityNoBtn.UseVisualStyleBackColor = true;
        this.crtCityNoBtn.Click += new System.EventHandler(this.crtCityNoBtn_Click);
        // 
        // crtCityYesBtn
        // 
        this.crtCityYesBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.crtCityYesBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        this.crtCityYesBtn.Depth = 0;
        this.crtCityYesBtn.HighEmphasis = true;
        this.crtCityYesBtn.Icon = null;
        this.crtCityYesBtn.Location = new System.Drawing.Point(46, 226);
        this.crtCityYesBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.crtCityYesBtn.MouseState = MaterialSkin.MouseState.HOVER;
        this.crtCityYesBtn.Name = "crtCityYesBtn";
        this.crtCityYesBtn.NoAccentTextColor = System.Drawing.Color.Empty;
        this.crtCityYesBtn.Size = new System.Drawing.Size(64, 36);
        this.crtCityYesBtn.TabIndex = 22;
        this.crtCityYesBtn.Text = "SI";
        this.crtCityYesBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        this.crtCityYesBtn.UseAccentColor = false;
        this.crtCityYesBtn.UseVisualStyleBackColor = true;
        this.crtCityYesBtn.Click += new System.EventHandler(this.crtCityYesBtn_Click);
        // 
        // materialLabel7
        // 
        this.materialLabel7.AutoSize = true;
        this.materialLabel7.Depth = 0;
        this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel7.Location = new System.Drawing.Point(247, 124);
        this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel7.Name = "materialLabel7";
        this.materialLabel7.Size = new System.Drawing.Size(107, 19);
        this.materialLabel7.TabIndex = 18;
        this.materialLabel7.Text = "materialLabel7";
        // 
        // materialLabel3
        // 
        this.materialLabel3.AutoSize = true;
        this.materialLabel3.Depth = 0;
        this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel3.Location = new System.Drawing.Point(46, 162);
        this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel3.Name = "materialLabel3";
        this.materialLabel3.Size = new System.Drawing.Size(88, 19);
        this.materialLabel3.TabIndex = 15;
        this.materialLabel3.Text = "Descripcion:";
        // 
        // materialLabel2
        // 
        this.materialLabel2.AutoSize = true;
        this.materialLabel2.Depth = 0;
        this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel2.Location = new System.Drawing.Point(46, 124);
        this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel2.Name = "materialLabel2";
        this.materialLabel2.Size = new System.Drawing.Size(61, 19);
        this.materialLabel2.TabIndex = 14;
        this.materialLabel2.Text = "Nombre:";
        // 
        // materialLabel1
        // 
        this.materialLabel1.AutoSize = true;
        this.materialLabel1.Depth = 0;
        this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel1.Location = new System.Drawing.Point(46, 79);
        this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel1.Name = "materialLabel1";
        this.materialLabel1.Size = new System.Drawing.Size(308, 19);
        this.materialLabel1.TabIndex = 13;
        this.materialLabel1.Text = "¿Está seguro de borrar el siguiente usuario?";
        // 
        // descriptionMultiLine
        // 
        this.descriptionMultiLine.AnimateReadOnly = false;
        this.descriptionMultiLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.descriptionMultiLine.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.descriptionMultiLine.Cursor = System.Windows.Forms.Cursors.IBeam;
        this.descriptionMultiLine.Depth = 0;
        this.descriptionMultiLine.HideSelection = true;
        this.descriptionMultiLine.Location = new System.Drawing.Point(247, 162);
        this.descriptionMultiLine.MaxLength = 32767;
        this.descriptionMultiLine.MouseState = MaterialSkin.MouseState.OUT;
        this.descriptionMultiLine.Name = "descriptionMultiLine";
        this.descriptionMultiLine.PasswordChar = '\0';
        this.descriptionMultiLine.ReadOnly = false;
        this.descriptionMultiLine.ScrollBars = System.Windows.Forms.ScrollBars.None;
        this.descriptionMultiLine.SelectedText = "";
        this.descriptionMultiLine.SelectionLength = 0;
        this.descriptionMultiLine.SelectionStart = 0;
        this.descriptionMultiLine.ShortcutsEnabled = true;
        this.descriptionMultiLine.Size = new System.Drawing.Size(250, 100);
        this.descriptionMultiLine.TabIndex = 24;
        this.descriptionMultiLine.TabStop = false;
        this.descriptionMultiLine.Text = "materialMultiLineTextBox21";
        this.descriptionMultiLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.descriptionMultiLine.UseSystemPasswordChar = false;
        // 
        // DeleteCity
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(533, 314);
        this.Controls.Add(this.descriptionMultiLine);
        this.Controls.Add(this.crtCityNoBtn);
        this.Controls.Add(this.crtCityYesBtn);
        this.Controls.Add(this.materialLabel7);
        this.Controls.Add(this.materialLabel3);
        this.Controls.Add(this.materialLabel2);
        this.Controls.Add(this.materialLabel1);
        this.Name = "DeleteCity";
        this.Text = "Eliminar Ciudad";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private MaterialSkin.Controls.MaterialMultiLineTextBox2 descriptionMultiLine;

    private MaterialSkin.Controls.MaterialButton crtCityNoBtn;
    private MaterialSkin.Controls.MaterialButton crtCityYesBtn;
    private MaterialSkin.Controls.MaterialLabel materialLabel7;
    private MaterialSkin.Controls.MaterialLabel materialLabel3;
    private MaterialSkin.Controls.MaterialLabel materialLabel2;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;

    #endregion
}