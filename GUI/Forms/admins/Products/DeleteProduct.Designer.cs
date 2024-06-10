using System.ComponentModel;

namespace GUI.Forms.admins.Products;

partial class DeleteProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteProduct));
            this.crtCityNoBtn = new MaterialSkin.Controls.MaterialButton();
            this.crtCityYesBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.descriptionMultiLine = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // crtCityNoBtn
            // 
            this.crtCityNoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.crtCityNoBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.crtCityNoBtn.Depth = 0;
            this.crtCityNoBtn.HighEmphasis = true;
            this.crtCityNoBtn.Icon = null;
            this.crtCityNoBtn.Location = new System.Drawing.Point(109, 557);
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
            this.crtCityYesBtn.Location = new System.Drawing.Point(37, 557);
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
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(43, 201);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(88, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "Descripcion:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(46, 79);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(318, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "¿Está seguro de borrar el siguiente producto?";
            // 
            // descriptionMultiLine
            // 
            this.descriptionMultiLine.AnimateReadOnly = false;
            this.descriptionMultiLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.descriptionMultiLine.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.descriptionMultiLine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionMultiLine.Depth = 0;
            this.descriptionMultiLine.HideSelection = true;
            this.descriptionMultiLine.Location = new System.Drawing.Point(244, 201);
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
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(244, 124);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(107, 19);
            this.materialLabel4.TabIndex = 26;
            this.materialLabel4.Text = "materialLabel4";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(43, 124);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(41, 19);
            this.materialLabel5.TabIndex = 25;
            this.materialLabel5.Text = "Stock";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(43, 322);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(58, 19);
            this.materialLabel8.TabIndex = 27;
            this.materialLabel8.Text = "Imagen:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(244, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(43, 163);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(61, 19);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Nombre:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(244, 163);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(107, 19);
            this.materialLabel7.TabIndex = 18;
            this.materialLabel7.Text = "materialLabel7";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(247, 467);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(107, 19);
            this.materialLabel6.TabIndex = 30;
            this.materialLabel6.Text = "materialLabel6";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(46, 467);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(85, 19);
            this.materialLabel9.TabIndex = 29;
            this.materialLabel9.Text = "Precio total:";
            // 
            // DeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 615);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.descriptionMultiLine);
            this.Controls.Add(this.crtCityNoBtn);
            this.Controls.Add(this.crtCityYesBtn);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteProduct";
            this.Text = "Eliminar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private MaterialSkin.Controls.MaterialLabel materialLabel6;
    private MaterialSkin.Controls.MaterialLabel materialLabel9;

    private System.Windows.Forms.PictureBox pictureBox1;

    private MaterialSkin.Controls.MaterialLabel materialLabel8;

    private MaterialSkin.Controls.MaterialLabel materialLabel4;
    private MaterialSkin.Controls.MaterialLabel materialLabel5;

    private MaterialSkin.Controls.MaterialMultiLineTextBox2 descriptionMultiLine;

    private MaterialSkin.Controls.MaterialButton crtCityNoBtn;
    private MaterialSkin.Controls.MaterialButton crtCityYesBtn;
    private MaterialSkin.Controls.MaterialLabel materialLabel7;
    private MaterialSkin.Controls.MaterialLabel materialLabel3;
    private MaterialSkin.Controls.MaterialLabel materialLabel2;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;

    #endregion
}