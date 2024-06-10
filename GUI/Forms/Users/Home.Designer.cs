namespace GUI.Forms.Users
{
    partial class UserHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.userIconBtn = new System.Windows.Forms.PictureBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.cleanCartBtn = new MaterialSkin.Controls.MaterialButton();
            this.createSaleBtn = new MaterialSkin.Controls.MaterialButton();
            this.saleDetailsListView = new MaterialSkin.Controls.MaterialListView();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.createDetailsBtn = new MaterialSkin.Controls.MaterialButton();
            this.salesListView = new MaterialSkin.Controls.MaterialListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.productImgPctrBox = new System.Windows.Forms.PictureBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.productosListView = new MaterialSkin.Controls.MaterialListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIconBtn)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImgPctrBox)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1274, 653);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.userIconBtn);
            this.tabPage4.Controls.Add(this.materialLabel6);
            this.tabPage4.Controls.Add(this.cleanCartBtn);
            this.tabPage4.Controls.Add(this.createSaleBtn);
            this.tabPage4.Controls.Add(this.saleDetailsListView);
            this.tabPage4.Controls.Add(this.materialLabel3);
            this.tabPage4.Controls.Add(this.createDetailsBtn);
            this.tabPage4.Controls.Add(this.salesListView);
            this.tabPage4.ImageKey = "icons8-market-square-50.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1266, 610);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ventas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // userIconBtn
            // 
            this.userIconBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userIconBtn.Image = ((System.Drawing.Image)(resources.GetObject("userIconBtn.Image")));
            this.userIconBtn.Location = new System.Drawing.Point(1146, 3);
            this.userIconBtn.Name = "userIconBtn";
            this.userIconBtn.Size = new System.Drawing.Size(46, 48);
            this.userIconBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userIconBtn.TabIndex = 19;
            this.userIconBtn.TabStop = false;
            this.userIconBtn.Click += new System.EventHandler(this.userIconBtn_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(685, 19);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(135, 19);
            this.materialLabel6.TabIndex = 18;
            this.materialLabel6.Text = "Carrito de compras";
            // 
            // cleanCartBtn
            // 
            this.cleanCartBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cleanCartBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cleanCartBtn.Depth = 0;
            this.cleanCartBtn.HighEmphasis = true;
            this.cleanCartBtn.Icon = null;
            this.cleanCartBtn.Location = new System.Drawing.Point(1049, 556);
            this.cleanCartBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cleanCartBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cleanCartBtn.Name = "cleanCartBtn";
            this.cleanCartBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cleanCartBtn.Size = new System.Drawing.Size(143, 36);
            this.cleanCartBtn.TabIndex = 17;
            this.cleanCartBtn.Text = "Limpiar carrito";
            this.cleanCartBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cleanCartBtn.UseAccentColor = false;
            this.cleanCartBtn.UseVisualStyleBackColor = true;
            this.cleanCartBtn.Click += new System.EventHandler(this.cleanCartBtn_Click);
            // 
            // createSaleBtn
            // 
            this.createSaleBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createSaleBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createSaleBtn.Depth = 0;
            this.createSaleBtn.HighEmphasis = true;
            this.createSaleBtn.Icon = null;
            this.createSaleBtn.Location = new System.Drawing.Point(884, 556);
            this.createSaleBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createSaleBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createSaleBtn.Name = "createSaleBtn";
            this.createSaleBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.createSaleBtn.Size = new System.Drawing.Size(139, 36);
            this.createSaleBtn.TabIndex = 16;
            this.createSaleBtn.Text = "Realizar Compra";
            this.createSaleBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createSaleBtn.UseAccentColor = false;
            this.createSaleBtn.UseVisualStyleBackColor = true;
            this.createSaleBtn.Click += new System.EventHandler(this.createSaleBtn_Click);
            // 
            // saleDetailsListView
            // 
            this.saleDetailsListView.AutoSizeTable = false;
            this.saleDetailsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.saleDetailsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saleDetailsListView.Depth = 0;
            this.saleDetailsListView.FullRowSelect = true;
            this.saleDetailsListView.HideSelection = false;
            this.saleDetailsListView.Location = new System.Drawing.Point(685, 60);
            this.saleDetailsListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.saleDetailsListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.saleDetailsListView.MouseState = MaterialSkin.MouseState.OUT;
            this.saleDetailsListView.Name = "saleDetailsListView";
            this.saleDetailsListView.OwnerDraw = true;
            this.saleDetailsListView.Size = new System.Drawing.Size(507, 468);
            this.saleDetailsListView.TabIndex = 15;
            this.saleDetailsListView.UseCompatibleStateImageBehavior = false;
            this.saleDetailsListView.View = System.Windows.Forms.View.Details;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(45, 19);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(50, 19);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Ventas";
            // 
            // createDetailsBtn
            // 
            this.createDetailsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createDetailsBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createDetailsBtn.Depth = 0;
            this.createDetailsBtn.HighEmphasis = true;
            this.createDetailsBtn.Icon = null;
            this.createDetailsBtn.Location = new System.Drawing.Point(28, 556);
            this.createDetailsBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createDetailsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createDetailsBtn.Name = "createDetailsBtn";
            this.createDetailsBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.createDetailsBtn.Size = new System.Drawing.Size(173, 36);
            this.createDetailsBtn.TabIndex = 11;
            this.createDetailsBtn.Text = "AGREGAR AL CARRITO";
            this.createDetailsBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createDetailsBtn.UseAccentColor = false;
            this.createDetailsBtn.UseVisualStyleBackColor = true;
            this.createDetailsBtn.Click += new System.EventHandler(this.createDetailsBtn_Click);
            // 
            // salesListView
            // 
            this.salesListView.AutoSizeTable = false;
            this.salesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.salesListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salesListView.Depth = 0;
            this.salesListView.FullRowSelect = true;
            this.salesListView.HideSelection = false;
            this.salesListView.Location = new System.Drawing.Point(28, 60);
            this.salesListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.salesListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.salesListView.MouseState = MaterialSkin.MouseState.OUT;
            this.salesListView.Name = "salesListView";
            this.salesListView.OwnerDraw = true;
            this.salesListView.Size = new System.Drawing.Size(617, 468);
            this.salesListView.TabIndex = 10;
            this.salesListView.UseCompatibleStateImageBehavior = false;
            this.salesListView.View = System.Windows.Forms.View.Details;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialLabel5);
            this.tabPage3.Controls.Add(this.productImgPctrBox);
            this.tabPage3.Controls.Add(this.materialLabel4);
            this.tabPage3.Controls.Add(this.productosListView);
            this.tabPage3.ImageKey = "icons8-product-50.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1266, 610);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(923, 113);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(205, 23);
            this.materialLabel5.TabIndex = 21;
            this.materialLabel5.Text = "Imagen del Producto";
            // 
            // productImgPctrBox
            // 
            this.productImgPctrBox.Location = new System.Drawing.Point(838, 161);
            this.productImgPctrBox.Name = "productImgPctrBox";
            this.productImgPctrBox.Size = new System.Drawing.Size(321, 311);
            this.productImgPctrBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productImgPctrBox.TabIndex = 20;
            this.productImgPctrBox.TabStop = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(45, 19);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(73, 19);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "Productos";
            // 
            // productosListView
            // 
            this.productosListView.AutoSizeTable = false;
            this.productosListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productosListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productosListView.Depth = 0;
            this.productosListView.FullRowSelect = true;
            this.productosListView.HideSelection = false;
            this.productosListView.Location = new System.Drawing.Point(28, 60);
            this.productosListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.productosListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.productosListView.MouseState = MaterialSkin.MouseState.OUT;
            this.productosListView.Name = "productosListView";
            this.productosListView.OwnerDraw = true;
            this.productosListView.Size = new System.Drawing.Size(720, 524);
            this.productosListView.TabIndex = 15;
            this.productosListView.UseCompatibleStateImageBehavior = false;
            this.productosListView.View = System.Windows.Forms.View.Details;
            this.productosListView.SelectedIndexChanged += new System.EventHandler(this.productosListView_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-customer-50.png");
            this.imageList1.Images.SetKeyName(1, "icons8-city-buildings-50.png");
            this.imageList1.Images.SetKeyName(2, "icons8-product-50.png");
            this.imageList1.Images.SetKeyName(3, "icons8-sales-50.png");
            this.imageList1.Images.SetKeyName(4, "icons8-market-square-50.png");
            this.imageList1.Images.SetKeyName(5, "icons8-contacto-de-negocio-50.png");
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "UserHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beauty";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIconBtn)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImgPctrBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox logOutBtn;

        private System.Windows.Forms.PictureBox userIconBtn;

        private MaterialSkin.Controls.MaterialLabel materialLabel6;

        private MaterialSkin.Controls.MaterialListView saleDetailsListView;
        private MaterialSkin.Controls.MaterialButton createSaleBtn;
        private MaterialSkin.Controls.MaterialButton cleanCartBtn;

        private System.Windows.Forms.PictureBox productImgPctrBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;

        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialListView productosListView;

        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton createDetailsBtn;
        private MaterialSkin.Controls.MaterialListView salesListView;

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}