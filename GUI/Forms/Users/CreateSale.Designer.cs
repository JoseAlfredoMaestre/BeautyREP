using System.ComponentModel;

namespace GUI.Forms.Users;

partial class CreateSale
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
        this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
        this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
        this.cityCombo = new MaterialSkin.Controls.MaterialComboBox();
        this.addressMultilineInput = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
        this.SuspendLayout();
        //
        // generateSaleBtn
        //
        this.generateSaleBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.generateSaleBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        this.generateSaleBtn.Depth = 0;
        this.generateSaleBtn.HighEmphasis = true;
        this.generateSaleBtn.Icon = null;
        this.generateSaleBtn.Location = new System.Drawing.Point(433, 339);
        this.generateSaleBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.generateSaleBtn.MouseState = MaterialSkin.MouseState.HOVER;
        this.generateSaleBtn.Name = "generateSaleBtn";
        this.generateSaleBtn.NoAccentTextColor = System.Drawing.Color.Empty;
        this.generateSaleBtn.Size = new System.Drawing.Size(67, 36);
        this.generateSaleBtn.TabIndex = 14;
        this.generateSaleBtn.Text = "CREAR";
        this.generateSaleBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        this.generateSaleBtn.UseAccentColor = false;
        this.generateSaleBtn.UseVisualStyleBackColor = true;
        this.generateSaleBtn.Click += new System.EventHandler(this.generateSaleBtn_Click);
        //
        // productFileDialog
        //
        this.productFileDialog.FileName = "openFileDialog1";
        //
        // materialLabel4
        //
        this.materialLabel4.Depth = 0;
        this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel4.Location = new System.Drawing.Point(54, 101);
        this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel4.Name = "materialLabel4";
        this.materialLabel4.Size = new System.Drawing.Size(100, 23);
        this.materialLabel4.TabIndex = 18;
        this.materialLabel4.Text = "Ciudad";
        //
        // materialLabel5
        //
        this.materialLabel5.Depth = 0;
        this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel5.Location = new System.Drawing.Point(54, 191);
        this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel5.Name = "materialLabel5";
        this.materialLabel5.Size = new System.Drawing.Size(100, 23);
        this.materialLabel5.TabIndex = 19;
        this.materialLabel5.Text = "Dirección";
        //
        // cityCombo
        //
        this.cityCombo.AutoResize = false;
        this.cityCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.cityCombo.Depth = 0;
        this.cityCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
        this.cityCombo.DropDownHeight = 174;
        this.cityCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cityCombo.DropDownWidth = 121;
        this.cityCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
        this.cityCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        this.cityCombo.FormattingEnabled = true;
        this.cityCombo.IntegralHeight = false;
        this.cityCombo.ItemHeight = 43;
        this.cityCombo.Location = new System.Drawing.Point(250, 97);
        this.cityCombo.MaxDropDownItems = 4;
        this.cityCombo.MouseState = MaterialSkin.MouseState.OUT;
        this.cityCombo.Name = "cityCombo";
        this.cityCombo.Size = new System.Drawing.Size(250, 49);
        this.cityCombo.StartIndex = 0;
        this.cityCombo.TabIndex = 24;
        //
        // addressMultilineInput
        //
        this.addressMultilineInput.AnimateReadOnly = false;
        this.addressMultilineInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.addressMultilineInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.addressMultilineInput.Cursor = System.Windows.Forms.Cursors.IBeam;
        this.addressMultilineInput.Depth = 0;
        this.addressMultilineInput.HideSelection = true;
        this.addressMultilineInput.Location = new System.Drawing.Point(250, 191);
        this.addressMultilineInput.MaxLength = 32767;
        this.addressMultilineInput.MouseState = MaterialSkin.MouseState.OUT;
        this.addressMultilineInput.Name = "addressMultilineInput";
        this.addressMultilineInput.PasswordChar = '\0';
        this.addressMultilineInput.ReadOnly = false;
        this.addressMultilineInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
        this.addressMultilineInput.SelectedText = "";
        this.addressMultilineInput.SelectionLength = 0;
        this.addressMultilineInput.SelectionStart = 0;
        this.addressMultilineInput.ShortcutsEnabled = true;
        this.addressMultilineInput.Size = new System.Drawing.Size(250, 100);
        this.addressMultilineInput.TabIndex = 25;
        this.addressMultilineInput.TabStop = false;
        this.addressMultilineInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.addressMultilineInput.UseSystemPasswordChar = false;
        //
        // CreateSale
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(541, 405);
        this.Controls.Add(this.addressMultilineInput);
        this.Controls.Add(this.cityCombo);
        this.Controls.Add(this.materialLabel5);
        this.Controls.Add(this.materialLabel4);
        this.Controls.Add(this.generateSaleBtn);
        this.Name = "CreateSale";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Generar Venta";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private MaterialSkin.Controls.MaterialComboBox cityCombo;
    private MaterialSkin.Controls.MaterialMultiLineTextBox2 addressMultilineInput;

    private MaterialSkin.Controls.MaterialLabel materialLabel4;
    private MaterialSkin.Controls.MaterialLabel materialLabel5;

    private System.Windows.Forms.OpenFileDialog productFileDialog;

    private MaterialSkin.Controls.MaterialTextBox2 cedulaInput;
    private MaterialSkin.Controls.MaterialButton generateSaleBtn;

    #endregion
}