using System.ComponentModel;

namespace GUI.Forms.admins.Sales;

partial class DeleteSale
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
        this.deleteSaleNoBtn = new MaterialSkin.Controls.MaterialButton();
        this.deleteSaleYesBtn = new MaterialSkin.Controls.MaterialButton();
        this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
        this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
        this.saleIdLbl = new MaterialSkin.Controls.MaterialLabel();
        this.SuspendLayout();
        //
        // deleteSaleNoBtn
        //
        this.deleteSaleNoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.deleteSaleNoBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        this.deleteSaleNoBtn.Depth = 0;
        this.deleteSaleNoBtn.HighEmphasis = true;
        this.deleteSaleNoBtn.Icon = null;
        this.deleteSaleNoBtn.Location = new System.Drawing.Point(244, 192);
        this.deleteSaleNoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.deleteSaleNoBtn.MouseState = MaterialSkin.MouseState.HOVER;
        this.deleteSaleNoBtn.Name = "deleteSaleNoBtn";
        this.deleteSaleNoBtn.NoAccentTextColor = System.Drawing.Color.Empty;
        this.deleteSaleNoBtn.Size = new System.Drawing.Size(64, 36);
        this.deleteSaleNoBtn.TabIndex = 23;
        this.deleteSaleNoBtn.Text = "NO";
        this.deleteSaleNoBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        this.deleteSaleNoBtn.UseAccentColor = false;
        this.deleteSaleNoBtn.UseVisualStyleBackColor = true;
        this.deleteSaleNoBtn.Click += new System.EventHandler(this.deleteSaleNoBtn_Click);
        //
        // deleteSaleYesBtn
        //
        this.deleteSaleYesBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.deleteSaleYesBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        this.deleteSaleYesBtn.Depth = 0;
        this.deleteSaleYesBtn.HighEmphasis = true;
        this.deleteSaleYesBtn.Icon = null;
        this.deleteSaleYesBtn.Location = new System.Drawing.Point(172, 192);
        this.deleteSaleYesBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.deleteSaleYesBtn.MouseState = MaterialSkin.MouseState.HOVER;
        this.deleteSaleYesBtn.Name = "deleteSaleYesBtn";
        this.deleteSaleYesBtn.NoAccentTextColor = System.Drawing.Color.Empty;
        this.deleteSaleYesBtn.Size = new System.Drawing.Size(64, 36);
        this.deleteSaleYesBtn.TabIndex = 22;
        this.deleteSaleYesBtn.Text = "SI";
        this.deleteSaleYesBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        this.deleteSaleYesBtn.UseAccentColor = false;
        this.deleteSaleYesBtn.UseVisualStyleBackColor = true;
        this.deleteSaleYesBtn.Click += new System.EventHandler(this.deleteSaleYesBtn_Click);
        //
        // materialLabel1
        //
        this.materialLabel1.AutoSize = true;
        this.materialLabel1.Depth = 0;
        this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel1.Location = new System.Drawing.Point(46, 79);
        this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel1.Name = "materialLabel1";
        this.materialLabel1.Size = new System.Drawing.Size(295, 19);
        this.materialLabel1.TabIndex = 13;
        this.materialLabel1.Text = "¿Está seguro de borrar la siguiente venta?";
        //
        // materialLabel2
        //
        this.materialLabel2.Depth = 0;
        this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel2.Location = new System.Drawing.Point(118, 125);
        this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel2.Name = "materialLabel2";
        this.materialLabel2.Size = new System.Drawing.Size(100, 23);
        this.materialLabel2.TabIndex = 24;
        this.materialLabel2.Text = "ID:";
        //
        // saleIdLbl
        //
        this.saleIdLbl.Depth = 0;
        this.saleIdLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.saleIdLbl.Location = new System.Drawing.Point(188, 125);
        this.saleIdLbl.MouseState = MaterialSkin.MouseState.HOVER;
        this.saleIdLbl.Name = "saleIdLbl";
        this.saleIdLbl.Size = new System.Drawing.Size(100, 23);
        this.saleIdLbl.TabIndex = 25;
        //
        // DeleteSale
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(496, 282);
        this.Controls.Add(this.saleIdLbl);
        this.Controls.Add(this.materialLabel2);
        this.Controls.Add(this.deleteSaleNoBtn);
        this.Controls.Add(this.deleteSaleYesBtn);
        this.Controls.Add(this.materialLabel1);
        this.Name = "DeleteSale";
        this.Text = "Eliminar Venta";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private MaterialSkin.Controls.MaterialButton deleteSaleNoBtn;
    private MaterialSkin.Controls.MaterialButton deleteSaleYesBtn;
    private MaterialSkin.Controls.MaterialLabel saleIdLbl;
    private MaterialSkin.Controls.MaterialLabel materialLabel2;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;

    #endregion
}