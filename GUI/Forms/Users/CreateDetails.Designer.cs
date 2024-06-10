using System.ComponentModel;

namespace GUI.Forms.Users;

partial class CreateDetails
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
        this.generateSaleBtn = new MaterialSkin.Controls.MaterialButton();
        this.productFileDialog = new System.Windows.Forms.OpenFileDialog();
        this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
        this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
        this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
        this.productCombo = new MaterialSkin.Controls.MaterialComboBox();
        this.quantityInput = new MaterialSkin.Controls.MaterialTextBox2();
        this.subtotalLbl = new MaterialSkin.Controls.MaterialLabel();
        this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.cantidad = new MaterialSkin.Controls.MaterialLabel();
        this.quantityLbl = new MaterialSkin.Controls.MaterialLabel();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        // 
        // generateSaleBtn
        // 
        this.generateSaleBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.generateSaleBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        this.generateSaleBtn.Depth = 0;
        this.generateSaleBtn.HighEmphasis = true;
        this.generateSaleBtn.Icon = null;
        this.generateSaleBtn.Location = new System.Drawing.Point(393, 487);
        this.generateSaleBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.generateSaleBtn.MouseState = MaterialSkin.MouseState.HOVER;
        this.generateSaleBtn.Name = "generateSaleBtn";
        this.generateSaleBtn.NoAccentTextColor = System.Drawing.Color.Empty;
        this.generateSaleBtn.Size = new System.Drawing.Size(88, 36);
        this.generateSaleBtn.TabIndex = 14;
        this.generateSaleBtn.Text = "Agregar";
        this.generateSaleBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        this.generateSaleBtn.UseAccentColor = false;
        this.generateSaleBtn.UseVisualStyleBackColor = true;
        this.generateSaleBtn.Click += new System.EventHandler(this.generateSaleBtn_Click);
        // 
        // productFileDialog
        // 
        this.productFileDialog.FileName = "openFileDialog1";
        // 
        // materialLabel2
        // 
        this.materialLabel2.Depth = 0;
        this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel2.Location = new System.Drawing.Point(59, 108);
        this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel2.Name = "materialLabel2";
        this.materialLabel2.Size = new System.Drawing.Size(100, 23);
        this.materialLabel2.TabIndex = 16;
        this.materialLabel2.Text = "Producto";
        // 
        // materialLabel3
        // 
        this.materialLabel3.Depth = 0;
        this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel3.Location = new System.Drawing.Point(59, 173);
        this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel3.Name = "materialLabel3";
        this.materialLabel3.Size = new System.Drawing.Size(100, 23);
        this.materialLabel3.TabIndex = 17;
        this.materialLabel3.Text = "Cantidad";
        // 
        // materialLabel6
        // 
        this.materialLabel6.Depth = 0;
        this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel6.Location = new System.Drawing.Point(59, 277);
        this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel6.Name = "materialLabel6";
        this.materialLabel6.Size = new System.Drawing.Size(100, 23);
        this.materialLabel6.TabIndex = 20;
        this.materialLabel6.Text = "Subtotal";
        // 
        // productCombo
        // 
        this.productCombo.AutoResize = false;
        this.productCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.productCombo.Depth = 0;
        this.productCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
        this.productCombo.DropDownHeight = 174;
        this.productCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.productCombo.DropDownWidth = 121;
        this.productCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
        this.productCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        this.productCombo.FormattingEnabled = true;
        this.productCombo.IntegralHeight = false;
        this.productCombo.ItemHeight = 43;
        this.productCombo.Location = new System.Drawing.Point(255, 104);
        this.productCombo.MaxDropDownItems = 4;
        this.productCombo.MouseState = MaterialSkin.MouseState.OUT;
        this.productCombo.Name = "productCombo";
        this.productCombo.Size = new System.Drawing.Size(226, 49);
        this.productCombo.StartIndex = 0;
        this.productCombo.TabIndex = 22;
        this.productCombo.SelectedIndexChanged += new System.EventHandler(this.productCombo_SelectedIndexChanged);
        // 
        // quantityInput
        // 
        this.quantityInput.AnimateReadOnly = false;
        this.quantityInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.quantityInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.quantityInput.Depth = 0;
        this.quantityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.quantityInput.HideSelection = true;
        this.quantityInput.LeadingIcon = null;
        this.quantityInput.Location = new System.Drawing.Point(255, 173);
        this.quantityInput.MaxLength = 32767;
        this.quantityInput.MouseState = MaterialSkin.MouseState.OUT;
        this.quantityInput.Name = "quantityInput";
        this.quantityInput.PasswordChar = '\0';
        this.quantityInput.PrefixSuffixText = null;
        this.quantityInput.ReadOnly = false;
        this.quantityInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.quantityInput.SelectedText = "";
        this.quantityInput.SelectionLength = 0;
        this.quantityInput.SelectionStart = 0;
        this.quantityInput.ShortcutsEnabled = true;
        this.quantityInput.Size = new System.Drawing.Size(226, 48);
        this.quantityInput.TabIndex = 23;
        this.quantityInput.TabStop = false;
        this.quantityInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.quantityInput.TrailingIcon = null;
        this.quantityInput.UseSystemPasswordChar = false;
        this.quantityInput.TextChanged += new System.EventHandler(this.quantityInput_TextChanged);
        // 
        // subtotalLbl
        // 
        this.subtotalLbl.Depth = 0;
        this.subtotalLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.subtotalLbl.Location = new System.Drawing.Point(255, 277);
        this.subtotalLbl.MouseState = MaterialSkin.MouseState.HOVER;
        this.subtotalLbl.Name = "subtotalLbl";
        this.subtotalLbl.Size = new System.Drawing.Size(100, 23);
        this.subtotalLbl.TabIndex = 26;
        this.subtotalLbl.Text = "0";
        // 
        // materialLabel1
        // 
        this.materialLabel1.Depth = 0;
        this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel1.Location = new System.Drawing.Point(59, 344);
        this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel1.Name = "materialLabel1";
        this.materialLabel1.Size = new System.Drawing.Size(156, 23);
        this.materialLabel1.TabIndex = 27;
        this.materialLabel1.Text = "Imagen del Producto";
        // 
        // pictureBox1
        // 
        this.pictureBox1.Location = new System.Drawing.Point(255, 344);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(226, 116);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.pictureBox1.TabIndex = 28;
        this.pictureBox1.TabStop = false;
        // 
        // cantidad
        // 
        this.cantidad.Depth = 0;
        this.cantidad.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.cantidad.Location = new System.Drawing.Point(255, 235);
        this.cantidad.MouseState = MaterialSkin.MouseState.HOVER;
        this.cantidad.Name = "cantidad";
        this.cantidad.Size = new System.Drawing.Size(100, 23);
        this.cantidad.TabIndex = 29;
        this.cantidad.Text = "Cantidad:";
        // 
        // quantityLbl
        // 
        this.quantityLbl.Depth = 0;
        this.quantityLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.quantityLbl.Location = new System.Drawing.Point(361, 235);
        this.quantityLbl.MouseState = MaterialSkin.MouseState.HOVER;
        this.quantityLbl.Name = "quantityLbl";
        this.quantityLbl.Size = new System.Drawing.Size(100, 23);
        this.quantityLbl.TabIndex = 30;
        this.quantityLbl.Text = "0";
        // 
        // CreateDetails
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(575, 551);
        this.Controls.Add(this.quantityLbl);
        this.Controls.Add(this.cantidad);
        this.Controls.Add(this.pictureBox1);
        this.Controls.Add(this.materialLabel1);
        this.Controls.Add(this.subtotalLbl);
        this.Controls.Add(this.quantityInput);
        this.Controls.Add(this.productCombo);
        this.Controls.Add(this.materialLabel6);
        this.Controls.Add(this.materialLabel3);
        this.Controls.Add(this.materialLabel2);
        this.Controls.Add(this.generateSaleBtn);
        this.Name = "CreateDetails";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Agregar al carrito";
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private MaterialSkin.Controls.MaterialLabel cantidad;

    private MaterialSkin.Controls.MaterialLabel quantityLbl;

    private System.Windows.Forms.PictureBox pictureBox1;

    private MaterialSkin.Controls.MaterialComboBox productCombo;
    private MaterialSkin.Controls.MaterialTextBox2 quantityInput;
    private MaterialSkin.Controls.MaterialLabel subtotalLbl;

    private MaterialSkin.Controls.MaterialLabel materialLabel6;

    private MaterialSkin.Controls.MaterialLabel materialLabel3;

    private MaterialSkin.Controls.MaterialLabel materialLabel1;
    private MaterialSkin.Controls.MaterialLabel materialLabel2;

    private System.Windows.Forms.OpenFileDialog productFileDialog;

    private MaterialSkin.Controls.MaterialTextBox2 cedulaInput;
    private MaterialSkin.Controls.MaterialButton generateSaleBtn;

    #endregion
}