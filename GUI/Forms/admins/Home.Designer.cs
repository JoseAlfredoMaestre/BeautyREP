namespace GUI.Forms.admins
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.userIconBtn = new System.Windows.Forms.PictureBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.cleanCartBtn = new MaterialSkin.Controls.MaterialButton();
            this.createSaleBtn = new MaterialSkin.Controls.MaterialButton();
            this.saleDetailsListView = new MaterialSkin.Controls.MaterialListView();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.deleteSaleBtn = new MaterialSkin.Controls.MaterialButton();
            this.createDetailsBtn = new MaterialSkin.Controls.MaterialButton();
            this.salesListView = new MaterialSkin.Controls.MaterialListView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.actualizarUsuarioBtn = new MaterialSkin.Controls.MaterialButton();
            this.eliminarUsuarrioBtn = new MaterialSkin.Controls.MaterialButton();
            this.agregarUsuarioBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.actualizarCiudadBtn = new MaterialSkin.Controls.MaterialButton();
            this.eliminarCiudadBtn = new MaterialSkin.Controls.MaterialButton();
            this.agregarCiudadBtn = new MaterialSkin.Controls.MaterialButton();
            this.ciudadesListView = new MaterialSkin.Controls.MaterialListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.productImgPctrBox = new System.Windows.Forms.PictureBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.actualizarProductoBtn = new MaterialSkin.Controls.MaterialButton();
            this.eliminarProductoBtn = new MaterialSkin.Controls.MaterialButton();
            this.agregarProductoBtn = new MaterialSkin.Controls.MaterialButton();
            this.productosListView = new MaterialSkin.Controls.MaterialListView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIconBtn)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImgPctrBox)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage5);
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
            this.tabPage4.Controls.Add(this.materialButton1);
            this.tabPage4.Controls.Add(this.deleteSaleBtn);
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
            this.userIconBtn.Location = new System.Drawing.Point(1146, 6);
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
            this.createSaleBtn.Location = new System.Drawing.Point(873, 556);
            this.createSaleBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createSaleBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createSaleBtn.Name = "createSaleBtn";
            this.createSaleBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.createSaleBtn.Size = new System.Drawing.Size(139, 36);
            this.createSaleBtn.TabIndex = 16;
            this.createSaleBtn.Text = "Realizar venta";
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
            this.saleDetailsListView.Size = new System.Drawing.Size(507, 474);
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
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(480, 556);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(159, 36);
            this.materialButton1.TabIndex = 13;
            this.materialButton1.Text = "ACTUALIZAR VENTA";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // deleteSaleBtn
            // 
            this.deleteSaleBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteSaleBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteSaleBtn.Depth = 0;
            this.deleteSaleBtn.HighEmphasis = true;
            this.deleteSaleBtn.Icon = null;
            this.deleteSaleBtn.Location = new System.Drawing.Point(250, 556);
            this.deleteSaleBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteSaleBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteSaleBtn.Name = "deleteSaleBtn";
            this.deleteSaleBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteSaleBtn.Size = new System.Drawing.Size(139, 36);
            this.deleteSaleBtn.TabIndex = 12;
            this.deleteSaleBtn.Text = "ELIMINAR VENTA";
            this.deleteSaleBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteSaleBtn.UseAccentColor = false;
            this.deleteSaleBtn.UseVisualStyleBackColor = true;
            this.deleteSaleBtn.Click += new System.EventHandler(this.deleteSaleBtn_Click);
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
            this.createDetailsBtn.Size = new System.Drawing.Size(138, 36);
            this.createDetailsBtn.TabIndex = 11;
            this.createDetailsBtn.Text = "AGREGAR VENTA";
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.actualizarUsuarioBtn);
            this.tabPage1.Controls.Add(this.eliminarUsuarrioBtn);
            this.tabPage1.Controls.Add(this.agregarUsuarioBtn);
            this.tabPage1.Controls.Add(this.materialListView1);
            this.tabPage1.ImageKey = "icons8-customer-50.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1266, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(38, 17);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Usuarios";
            // 
            // actualizarUsuarioBtn
            // 
            this.actualizarUsuarioBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.actualizarUsuarioBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.actualizarUsuarioBtn.Depth = 0;
            this.actualizarUsuarioBtn.HighEmphasis = true;
            this.actualizarUsuarioBtn.Icon = null;
            this.actualizarUsuarioBtn.Location = new System.Drawing.Point(537, 556);
            this.actualizarUsuarioBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.actualizarUsuarioBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.actualizarUsuarioBtn.Name = "actualizarUsuarioBtn";
            this.actualizarUsuarioBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.actualizarUsuarioBtn.Size = new System.Drawing.Size(174, 36);
            this.actualizarUsuarioBtn.TabIndex = 3;
            this.actualizarUsuarioBtn.Text = "ACTUALIZAR USUARIO";
            this.actualizarUsuarioBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.actualizarUsuarioBtn.UseAccentColor = false;
            this.actualizarUsuarioBtn.UseVisualStyleBackColor = true;
            this.actualizarUsuarioBtn.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // eliminarUsuarrioBtn
            // 
            this.eliminarUsuarrioBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminarUsuarrioBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.eliminarUsuarrioBtn.Depth = 0;
            this.eliminarUsuarrioBtn.HighEmphasis = true;
            this.eliminarUsuarrioBtn.Icon = null;
            this.eliminarUsuarrioBtn.Location = new System.Drawing.Point(293, 556);
            this.eliminarUsuarrioBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.eliminarUsuarrioBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.eliminarUsuarrioBtn.Name = "eliminarUsuarrioBtn";
            this.eliminarUsuarrioBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.eliminarUsuarrioBtn.Size = new System.Drawing.Size(153, 36);
            this.eliminarUsuarrioBtn.TabIndex = 2;
            this.eliminarUsuarrioBtn.Text = "ELIMINAR USUARIO";
            this.eliminarUsuarrioBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.eliminarUsuarrioBtn.UseAccentColor = false;
            this.eliminarUsuarrioBtn.UseVisualStyleBackColor = true;
            this.eliminarUsuarrioBtn.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // agregarUsuarioBtn
            // 
            this.agregarUsuarioBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.agregarUsuarioBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.agregarUsuarioBtn.Depth = 0;
            this.agregarUsuarioBtn.HighEmphasis = true;
            this.agregarUsuarioBtn.Icon = null;
            this.agregarUsuarioBtn.Location = new System.Drawing.Point(44, 556);
            this.agregarUsuarioBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.agregarUsuarioBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.agregarUsuarioBtn.Name = "agregarUsuarioBtn";
            this.agregarUsuarioBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.agregarUsuarioBtn.Size = new System.Drawing.Size(153, 36);
            this.agregarUsuarioBtn.TabIndex = 1;
            this.agregarUsuarioBtn.Text = "AGREGAR USUARIO";
            this.agregarUsuarioBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.agregarUsuarioBtn.UseAccentColor = false;
            this.agregarUsuarioBtn.UseVisualStyleBackColor = true;
            this.agregarUsuarioBtn.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(21, 58);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(1191, 468);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Controls.Add(this.actualizarCiudadBtn);
            this.tabPage2.Controls.Add(this.eliminarCiudadBtn);
            this.tabPage2.Controls.Add(this.agregarCiudadBtn);
            this.tabPage2.Controls.Add(this.ciudadesListView);
            this.tabPage2.ImageKey = "icons8-city-buildings-50.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1266, 610);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ciudades";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(35, 19);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(67, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Ciudades";
            // 
            // actualizarCiudadBtn
            // 
            this.actualizarCiudadBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.actualizarCiudadBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.actualizarCiudadBtn.Depth = 0;
            this.actualizarCiudadBtn.HighEmphasis = true;
            this.actualizarCiudadBtn.Icon = null;
            this.actualizarCiudadBtn.Location = new System.Drawing.Point(496, 556);
            this.actualizarCiudadBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.actualizarCiudadBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.actualizarCiudadBtn.Name = "actualizarCiudadBtn";
            this.actualizarCiudadBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.actualizarCiudadBtn.Size = new System.Drawing.Size(165, 36);
            this.actualizarCiudadBtn.TabIndex = 8;
            this.actualizarCiudadBtn.Text = "ACTUALIZAR CIUDAD";
            this.actualizarCiudadBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.actualizarCiudadBtn.UseAccentColor = false;
            this.actualizarCiudadBtn.UseVisualStyleBackColor = true;
            this.actualizarCiudadBtn.Click += new System.EventHandler(this.actualizarCiudadBtn_Click);
            // 
            // eliminarCiudadBtn
            // 
            this.eliminarCiudadBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminarCiudadBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.eliminarCiudadBtn.Depth = 0;
            this.eliminarCiudadBtn.HighEmphasis = true;
            this.eliminarCiudadBtn.Icon = null;
            this.eliminarCiudadBtn.Location = new System.Drawing.Point(257, 556);
            this.eliminarCiudadBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.eliminarCiudadBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.eliminarCiudadBtn.Name = "eliminarCiudadBtn";
            this.eliminarCiudadBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.eliminarCiudadBtn.Size = new System.Drawing.Size(145, 36);
            this.eliminarCiudadBtn.TabIndex = 7;
            this.eliminarCiudadBtn.Text = "ELIMINAR CIUDAD";
            this.eliminarCiudadBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.eliminarCiudadBtn.UseAccentColor = false;
            this.eliminarCiudadBtn.UseVisualStyleBackColor = true;
            this.eliminarCiudadBtn.Click += new System.EventHandler(this.eliminarCiudadBtn_Click);
            // 
            // agregarCiudadBtn
            // 
            this.agregarCiudadBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.agregarCiudadBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.agregarCiudadBtn.Depth = 0;
            this.agregarCiudadBtn.HighEmphasis = true;
            this.agregarCiudadBtn.Icon = null;
            this.agregarCiudadBtn.Location = new System.Drawing.Point(18, 556);
            this.agregarCiudadBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.agregarCiudadBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.agregarCiudadBtn.Name = "agregarCiudadBtn";
            this.agregarCiudadBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.agregarCiudadBtn.Size = new System.Drawing.Size(144, 36);
            this.agregarCiudadBtn.TabIndex = 6;
            this.agregarCiudadBtn.Text = "AGREGAR CIUDAD";
            this.agregarCiudadBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.agregarCiudadBtn.UseAccentColor = false;
            this.agregarCiudadBtn.UseVisualStyleBackColor = true;
            this.agregarCiudadBtn.Click += new System.EventHandler(this.agregarCiudadBtn_Click);
            // 
            // ciudadesListView
            // 
            this.ciudadesListView.AutoSizeTable = false;
            this.ciudadesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ciudadesListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ciudadesListView.Depth = 0;
            this.ciudadesListView.FullRowSelect = true;
            this.ciudadesListView.HideSelection = false;
            this.ciudadesListView.Location = new System.Drawing.Point(18, 60);
            this.ciudadesListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.ciudadesListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ciudadesListView.MouseState = MaterialSkin.MouseState.OUT;
            this.ciudadesListView.Name = "ciudadesListView";
            this.ciudadesListView.OwnerDraw = true;
            this.ciudadesListView.Size = new System.Drawing.Size(1197, 468);
            this.ciudadesListView.TabIndex = 5;
            this.ciudadesListView.UseCompatibleStateImageBehavior = false;
            this.ciudadesListView.View = System.Windows.Forms.View.Details;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialLabel5);
            this.tabPage3.Controls.Add(this.productImgPctrBox);
            this.tabPage3.Controls.Add(this.materialLabel4);
            this.tabPage3.Controls.Add(this.actualizarProductoBtn);
            this.tabPage3.Controls.Add(this.eliminarProductoBtn);
            this.tabPage3.Controls.Add(this.agregarProductoBtn);
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
            // actualizarProductoBtn
            // 
            this.actualizarProductoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.actualizarProductoBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.actualizarProductoBtn.Depth = 0;
            this.actualizarProductoBtn.HighEmphasis = true;
            this.actualizarProductoBtn.Icon = null;
            this.actualizarProductoBtn.Location = new System.Drawing.Point(559, 556);
            this.actualizarProductoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.actualizarProductoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.actualizarProductoBtn.Name = "actualizarProductoBtn";
            this.actualizarProductoBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.actualizarProductoBtn.Size = new System.Drawing.Size(189, 36);
            this.actualizarProductoBtn.TabIndex = 18;
            this.actualizarProductoBtn.Text = "ACTUALIZAR PRODUCTO";
            this.actualizarProductoBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.actualizarProductoBtn.UseAccentColor = false;
            this.actualizarProductoBtn.UseVisualStyleBackColor = true;
            this.actualizarProductoBtn.Click += new System.EventHandler(this.actualizarProductoBtn_Click);
            // 
            // eliminarProductoBtn
            // 
            this.eliminarProductoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminarProductoBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.eliminarProductoBtn.Depth = 0;
            this.eliminarProductoBtn.HighEmphasis = true;
            this.eliminarProductoBtn.Icon = null;
            this.eliminarProductoBtn.Location = new System.Drawing.Point(295, 556);
            this.eliminarProductoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.eliminarProductoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.eliminarProductoBtn.Name = "eliminarProductoBtn";
            this.eliminarProductoBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.eliminarProductoBtn.Size = new System.Drawing.Size(169, 36);
            this.eliminarProductoBtn.TabIndex = 17;
            this.eliminarProductoBtn.Text = "ELIMINAR PRODUCTO";
            this.eliminarProductoBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.eliminarProductoBtn.UseAccentColor = false;
            this.eliminarProductoBtn.UseVisualStyleBackColor = true;
            this.eliminarProductoBtn.Click += new System.EventHandler(this.eliminarProductoBtn_Click);
            // 
            // agregarProductoBtn
            // 
            this.agregarProductoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.agregarProductoBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.agregarProductoBtn.Depth = 0;
            this.agregarProductoBtn.HighEmphasis = true;
            this.agregarProductoBtn.Icon = null;
            this.agregarProductoBtn.Location = new System.Drawing.Point(28, 556);
            this.agregarProductoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.agregarProductoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.agregarProductoBtn.Name = "agregarProductoBtn";
            this.agregarProductoBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.agregarProductoBtn.Size = new System.Drawing.Size(168, 36);
            this.agregarProductoBtn.TabIndex = 16;
            this.agregarProductoBtn.Text = "AGREGAR PRODUCTO";
            this.agregarProductoBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.agregarProductoBtn.UseAccentColor = false;
            this.agregarProductoBtn.UseVisualStyleBackColor = true;
            this.agregarProductoBtn.Click += new System.EventHandler(this.agregarProductoBtn_Click);
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
            this.productosListView.Size = new System.Drawing.Size(720, 468);
            this.productosListView.TabIndex = 15;
            this.productosListView.UseCompatibleStateImageBehavior = false;
            this.productosListView.View = System.Windows.Forms.View.Details;
            this.productosListView.SelectedIndexChanged += new System.EventHandler(this.productosListView_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.ImageKey = "icons8-sales-50.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1266, 610);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Estadisticas";
            this.tabPage5.UseVisualStyleBackColor = true;
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beauty";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIconBtn)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImgPctrBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox userIconBtn;

        private MaterialSkin.Controls.MaterialLabel materialLabel6;

        private MaterialSkin.Controls.MaterialListView saleDetailsListView;
        private MaterialSkin.Controls.MaterialButton createSaleBtn;
        private MaterialSkin.Controls.MaterialButton cleanCartBtn;

        private System.Windows.Forms.TabPage tabPage5;

        private System.Windows.Forms.PictureBox productImgPctrBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;

        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton actualizarProductoBtn;
        private MaterialSkin.Controls.MaterialButton eliminarProductoBtn;
        private MaterialSkin.Controls.MaterialButton agregarProductoBtn;
        private MaterialSkin.Controls.MaterialListView productosListView;

        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton deleteSaleBtn;
        private MaterialSkin.Controls.MaterialButton createDetailsBtn;
        private MaterialSkin.Controls.MaterialListView salesListView;

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton actualizarCiudadBtn;
        private MaterialSkin.Controls.MaterialButton eliminarCiudadBtn;
        private MaterialSkin.Controls.MaterialButton agregarCiudadBtn;
        private MaterialSkin.Controls.MaterialListView ciudadesListView;

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialButton agregarUsuarioBtn;
        private MaterialSkin.Controls.MaterialButton actualizarUsuarioBtn;
        private MaterialSkin.Controls.MaterialButton eliminarUsuarrioBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}