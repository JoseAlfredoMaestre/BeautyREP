using System.ComponentModel;

namespace GUI.Forms.admins.Products;

partial class CreateProduct
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
        this.createProductBtn = new MaterialSkin.Controls.MaterialButton();
        this.nameInput = new MaterialSkin.Controls.MaterialTextBox2();
        this.descripcionTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
        this.stockInput = new MaterialSkin.Controls.MaterialTextBox2();
        this.discountInput = new MaterialSkin.Controls.MaterialTextBox2();
        this.unitaryCostInput = new MaterialSkin.Controls.MaterialTextBox2();
        this.productImgBtn = new MaterialSkin.Controls.MaterialButton();
        this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
        this.productPictureBox = new System.Windows.Forms.PictureBox();
        this.productFileDialog = new System.Windows.Forms.OpenFileDialog();
        ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
        this.SuspendLayout();
        // 
        // createProductBtn
        // 
        this.createProductBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.createProductBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        this.createProductBtn.Depth = 0;
        this.createProductBtn.HighEmphasis = true;
        this.createProductBtn.Icon = null;
        this.createProductBtn.Location = new System.Drawing.Point(706, 564);
        this.createProductBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.createProductBtn.MouseState = MaterialSkin.MouseState.HOVER;
        this.createProductBtn.Name = "createProductBtn";
        this.createProductBtn.NoAccentTextColor = System.Drawing.Color.Empty;
        this.createProductBtn.Size = new System.Drawing.Size(67, 36);
        this.createProductBtn.TabIndex = 14;
        this.createProductBtn.Text = "CREAR";
        this.createProductBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        this.createProductBtn.UseAccentColor = false;
        this.createProductBtn.UseVisualStyleBackColor = true;
        this.createProductBtn.Click += new System.EventHandler(this.createProductBtn_Click);
        // 
        // nameInput
        // 
        this.nameInput.AnimateReadOnly = false;
        this.nameInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.nameInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.nameInput.Depth = 0;
        this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.nameInput.HideSelection = true;
        this.nameInput.Hint = "Nombre del Producto";
        this.nameInput.LeadingIcon = null;
        this.nameInput.Location = new System.Drawing.Point(30, 171);
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
        this.nameInput.Size = new System.Drawing.Size(339, 48);
        this.nameInput.TabIndex = 15;
        this.nameInput.TabStop = false;
        this.nameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.nameInput.TrailingIcon = null;
        this.nameInput.UseSystemPasswordChar = false;
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
        this.descripcionTextBox.Location = new System.Drawing.Point(30, 249);
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
        this.descripcionTextBox.Size = new System.Drawing.Size(339, 147);
        this.descripcionTextBox.TabIndex = 17;
        this.descripcionTextBox.TabStop = false;
        this.descripcionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.descripcionTextBox.UseSystemPasswordChar = false;
        // 
        // stockInput
        // 
        this.stockInput.AnimateReadOnly = false;
        this.stockInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.stockInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.stockInput.Depth = 0;
        this.stockInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.stockInput.HideSelection = true;
        this.stockInput.Hint = "Stock del Producto";
        this.stockInput.LeadingIcon = null;
        this.stockInput.Location = new System.Drawing.Point(30, 96);
        this.stockInput.MaxLength = 32767;
        this.stockInput.MouseState = MaterialSkin.MouseState.OUT;
        this.stockInput.Name = "stockInput";
        this.stockInput.PasswordChar = '\0';
        this.stockInput.PrefixSuffixText = null;
        this.stockInput.ReadOnly = false;
        this.stockInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.stockInput.SelectedText = "";
        this.stockInput.SelectionLength = 0;
        this.stockInput.SelectionStart = 0;
        this.stockInput.ShortcutsEnabled = true;
        this.stockInput.Size = new System.Drawing.Size(339, 48);
        this.stockInput.TabIndex = 18;
        this.stockInput.TabStop = false;
        this.stockInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.stockInput.TrailingIcon = null;
        this.stockInput.UseSystemPasswordChar = false;
        // 
        // discountInput
        // 
        this.discountInput.AnimateReadOnly = false;
        this.discountInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.discountInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.discountInput.Depth = 0;
        this.discountInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.discountInput.HideSelection = true;
        this.discountInput.Hint = "Descuento";
        this.discountInput.LeadingIcon = null;
        this.discountInput.Location = new System.Drawing.Point(30, 513);
        this.discountInput.MaxLength = 32767;
        this.discountInput.MouseState = MaterialSkin.MouseState.OUT;
        this.discountInput.Name = "discountInput";
        this.discountInput.PasswordChar = '\0';
        this.discountInput.PrefixSuffixText = null;
        this.discountInput.ReadOnly = false;
        this.discountInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.discountInput.SelectedText = "";
        this.discountInput.SelectionLength = 0;
        this.discountInput.SelectionStart = 0;
        this.discountInput.ShortcutsEnabled = true;
        this.discountInput.Size = new System.Drawing.Size(339, 48);
        this.discountInput.TabIndex = 20;
        this.discountInput.TabStop = false;
        this.discountInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.discountInput.TrailingIcon = null;
        this.discountInput.UseSystemPasswordChar = false;
        // 
        // unitaryCostInput
        // 
        this.unitaryCostInput.AnimateReadOnly = false;
        this.unitaryCostInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.unitaryCostInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.unitaryCostInput.Depth = 0;
        this.unitaryCostInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.unitaryCostInput.HideSelection = true;
        this.unitaryCostInput.Hint = "Precio unitario";
        this.unitaryCostInput.LeadingIcon = null;
        this.unitaryCostInput.Location = new System.Drawing.Point(30, 428);
        this.unitaryCostInput.MaxLength = 32767;
        this.unitaryCostInput.MouseState = MaterialSkin.MouseState.OUT;
        this.unitaryCostInput.Name = "unitaryCostInput";
        this.unitaryCostInput.PasswordChar = '\0';
        this.unitaryCostInput.PrefixSuffixText = null;
        this.unitaryCostInput.ReadOnly = false;
        this.unitaryCostInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.unitaryCostInput.SelectedText = "";
        this.unitaryCostInput.SelectionLength = 0;
        this.unitaryCostInput.SelectionStart = 0;
        this.unitaryCostInput.ShortcutsEnabled = true;
        this.unitaryCostInput.Size = new System.Drawing.Size(339, 48);
        this.unitaryCostInput.TabIndex = 19;
        this.unitaryCostInput.TabStop = false;
        this.unitaryCostInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.unitaryCostInput.TrailingIcon = null;
        this.unitaryCostInput.UseSystemPasswordChar = false;
        // 
        // productImgBtn
        // 
        this.productImgBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.productImgBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        this.productImgBtn.Depth = 0;
        this.productImgBtn.HighEmphasis = true;
        this.productImgBtn.Icon = null;
        this.productImgBtn.Location = new System.Drawing.Point(445, 108);
        this.productImgBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.productImgBtn.MouseState = MaterialSkin.MouseState.HOVER;
        this.productImgBtn.Name = "productImgBtn";
        this.productImgBtn.NoAccentTextColor = System.Drawing.Color.Empty;
        this.productImgBtn.Size = new System.Drawing.Size(201, 36);
        this.productImgBtn.TabIndex = 21;
        this.productImgBtn.Text = "SELECCIONE UNA IMAGEN";
        this.productImgBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        this.productImgBtn.UseAccentColor = false;
        this.productImgBtn.UseVisualStyleBackColor = true;
        this.productImgBtn.Click += new System.EventHandler(this.productImgBtn_Click);
        // 
        // materialLabel1
        // 
        this.materialLabel1.Depth = 0;
        this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel1.Location = new System.Drawing.Point(445, 171);
        this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel1.Name = "materialLabel1";
        this.materialLabel1.Size = new System.Drawing.Size(223, 23);
        this.materialLabel1.TabIndex = 22;
        this.materialLabel1.Text = "Imagen del producto";
        // 
        // productPictureBox
        // 
        this.productPictureBox.Location = new System.Drawing.Point(445, 197);
        this.productPictureBox.Name = "productPictureBox";
        this.productPictureBox.Size = new System.Drawing.Size(328, 199);
        this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.productPictureBox.TabIndex = 23;
        this.productPictureBox.TabStop = false;
        // 
        // productFileDialog
        // 
        this.productFileDialog.FileName = "openFileDialog1";
        // 
        // CreateProduct
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(812, 633);
        this.Controls.Add(this.productPictureBox);
        this.Controls.Add(this.materialLabel1);
        this.Controls.Add(this.productImgBtn);
        this.Controls.Add(this.discountInput);
        this.Controls.Add(this.unitaryCostInput);
        this.Controls.Add(this.stockInput);
        this.Controls.Add(this.descripcionTextBox);
        this.Controls.Add(this.nameInput);
        this.Controls.Add(this.createProductBtn);
        this.Name = "CreateProduct";
        this.Text = "Crear Producto";
        ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.OpenFileDialog productFileDialog;

    private System.Windows.Forms.PictureBox productPictureBox;

    private MaterialSkin.Controls.MaterialLabel materialLabel1;

    private MaterialSkin.Controls.MaterialButton productImgBtn;

    private MaterialSkin.Controls.MaterialTextBox2 discountInput;
    private MaterialSkin.Controls.MaterialTextBox2 unitaryCostInput;

    private MaterialSkin.Controls.MaterialTextBox2 stockInput;

    private MaterialSkin.Controls.MaterialMultiLineTextBox2 descripcionTextBox;

    private MaterialSkin.Controls.MaterialTextBox2 cedulaInput;
    private MaterialSkin.Controls.MaterialButton createProductBtn;
    private MaterialSkin.Controls.MaterialTextBox2 nameInput;

    #endregion
}