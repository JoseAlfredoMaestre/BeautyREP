using System.ComponentModel;

namespace GUI.Forms.Users;

partial class UserProfile
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
        this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
        this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
        this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
        this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
        this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
        this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
        this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.idNumberTxt = new MaterialSkin.Controls.MaterialTextBox2();
        this.surnamesTxt = new MaterialSkin.Controls.MaterialTextBox2();
        this.namesTxt = new MaterialSkin.Controls.MaterialTextBox2();
        this.phoneNumberTxt = new MaterialSkin.Controls.MaterialTextBox2();
        this.emailNumberTxt = new MaterialSkin.Controls.MaterialTextBox2();
        this.createdAtTxt = new MaterialSkin.Controls.MaterialTextBox2();
        this.usernameTxt = new MaterialSkin.Controls.MaterialTextBox2();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        // 
        // materialLabel2
        // 
        this.materialLabel2.Depth = 0;
        this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel2.Location = new System.Drawing.Point(29, 218);
        this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel2.Name = "materialLabel2";
        this.materialLabel2.Size = new System.Drawing.Size(162, 23);
        this.materialLabel2.TabIndex = 1;
        this.materialLabel2.Text = "Nro de Identificación:";
        // 
        // materialLabel3
        // 
        this.materialLabel3.Depth = 0;
        this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel3.Location = new System.Drawing.Point(29, 272);
        this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel3.Name = "materialLabel3";
        this.materialLabel3.Size = new System.Drawing.Size(162, 23);
        this.materialLabel3.TabIndex = 2;
        this.materialLabel3.Text = "Apellidos";
        // 
        // materialLabel4
        // 
        this.materialLabel4.Depth = 0;
        this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel4.Location = new System.Drawing.Point(29, 328);
        this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel4.Name = "materialLabel4";
        this.materialLabel4.Size = new System.Drawing.Size(162, 23);
        this.materialLabel4.TabIndex = 3;
        this.materialLabel4.Text = "Nombres";
        // 
        // materialLabel5
        // 
        this.materialLabel5.Depth = 0;
        this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel5.Location = new System.Drawing.Point(545, 218);
        this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel5.Name = "materialLabel5";
        this.materialLabel5.Size = new System.Drawing.Size(162, 23);
        this.materialLabel5.TabIndex = 4;
        this.materialLabel5.Text = "Telefono";
        // 
        // materialLabel6
        // 
        this.materialLabel6.Depth = 0;
        this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel6.Location = new System.Drawing.Point(545, 272);
        this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel6.Name = "materialLabel6";
        this.materialLabel6.Size = new System.Drawing.Size(162, 23);
        this.materialLabel6.TabIndex = 5;
        this.materialLabel6.Text = "Email";
        // 
        // materialLabel7
        // 
        this.materialLabel7.Depth = 0;
        this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel7.Location = new System.Drawing.Point(545, 328);
        this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel7.Name = "materialLabel7";
        this.materialLabel7.Size = new System.Drawing.Size(162, 23);
        this.materialLabel7.TabIndex = 6;
        this.materialLabel7.Text = "Fecha de creación";
        // 
        // materialLabel8
        // 
        this.materialLabel8.Depth = 0;
        this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.materialLabel8.Location = new System.Drawing.Point(29, 398);
        this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
        this.materialLabel8.Name = "materialLabel8";
        this.materialLabel8.Size = new System.Drawing.Size(162, 23);
        this.materialLabel8.TabIndex = 7;
        this.materialLabel8.Text = "Nombre de Usuario";
        // 
        // pictureBox1
        // 
        this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        this.pictureBox1.Location = new System.Drawing.Point(425, 87);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(148, 90);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.pictureBox1.TabIndex = 8;
        this.pictureBox1.TabStop = false;
        // 
        // idNumberTxt
        // 
        this.idNumberTxt.AnimateReadOnly = false;
        this.idNumberTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.idNumberTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.idNumberTxt.Depth = 0;
        this.idNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.idNumberTxt.HideSelection = true;
        this.idNumberTxt.LeadingIcon = null;
        this.idNumberTxt.Location = new System.Drawing.Point(229, 193);
        this.idNumberTxt.MaxLength = 32767;
        this.idNumberTxt.MouseState = MaterialSkin.MouseState.OUT;
        this.idNumberTxt.Name = "idNumberTxt";
        this.idNumberTxt.PasswordChar = '\0';
        this.idNumberTxt.PrefixSuffixText = null;
        this.idNumberTxt.ReadOnly = false;
        this.idNumberTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.idNumberTxt.SelectedText = "";
        this.idNumberTxt.SelectionLength = 0;
        this.idNumberTxt.SelectionStart = 0;
        this.idNumberTxt.ShortcutsEnabled = true;
        this.idNumberTxt.Size = new System.Drawing.Size(250, 48);
        this.idNumberTxt.TabIndex = 10;
        this.idNumberTxt.TabStop = false;
        this.idNumberTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.idNumberTxt.TrailingIcon = null;
        this.idNumberTxt.UseSystemPasswordChar = false;
        // 
        // surnamesTxt
        // 
        this.surnamesTxt.AnimateReadOnly = false;
        this.surnamesTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.surnamesTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.surnamesTxt.Depth = 0;
        this.surnamesTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.surnamesTxt.HideSelection = true;
        this.surnamesTxt.LeadingIcon = null;
        this.surnamesTxt.Location = new System.Drawing.Point(229, 247);
        this.surnamesTxt.MaxLength = 32767;
        this.surnamesTxt.MouseState = MaterialSkin.MouseState.OUT;
        this.surnamesTxt.Name = "surnamesTxt";
        this.surnamesTxt.PasswordChar = '\0';
        this.surnamesTxt.PrefixSuffixText = null;
        this.surnamesTxt.ReadOnly = false;
        this.surnamesTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.surnamesTxt.SelectedText = "";
        this.surnamesTxt.SelectionLength = 0;
        this.surnamesTxt.SelectionStart = 0;
        this.surnamesTxt.ShortcutsEnabled = true;
        this.surnamesTxt.Size = new System.Drawing.Size(250, 48);
        this.surnamesTxt.TabIndex = 11;
        this.surnamesTxt.TabStop = false;
        this.surnamesTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.surnamesTxt.TrailingIcon = null;
        this.surnamesTxt.UseSystemPasswordChar = false;
        // 
        // namesTxt
        // 
        this.namesTxt.AnimateReadOnly = false;
        this.namesTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.namesTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.namesTxt.Depth = 0;
        this.namesTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.namesTxt.HideSelection = true;
        this.namesTxt.LeadingIcon = null;
        this.namesTxt.Location = new System.Drawing.Point(229, 303);
        this.namesTxt.MaxLength = 32767;
        this.namesTxt.MouseState = MaterialSkin.MouseState.OUT;
        this.namesTxt.Name = "namesTxt";
        this.namesTxt.PasswordChar = '\0';
        this.namesTxt.PrefixSuffixText = null;
        this.namesTxt.ReadOnly = false;
        this.namesTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.namesTxt.SelectedText = "";
        this.namesTxt.SelectionLength = 0;
        this.namesTxt.SelectionStart = 0;
        this.namesTxt.ShortcutsEnabled = true;
        this.namesTxt.Size = new System.Drawing.Size(250, 48);
        this.namesTxt.TabIndex = 12;
        this.namesTxt.TabStop = false;
        this.namesTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.namesTxt.TrailingIcon = null;
        this.namesTxt.UseSystemPasswordChar = false;
        // 
        // phoneNumberTxt
        // 
        this.phoneNumberTxt.AnimateReadOnly = false;
        this.phoneNumberTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.phoneNumberTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.phoneNumberTxt.Depth = 0;
        this.phoneNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.phoneNumberTxt.HideSelection = true;
        this.phoneNumberTxt.LeadingIcon = null;
        this.phoneNumberTxt.Location = new System.Drawing.Point(745, 193);
        this.phoneNumberTxt.MaxLength = 32767;
        this.phoneNumberTxt.MouseState = MaterialSkin.MouseState.OUT;
        this.phoneNumberTxt.Name = "phoneNumberTxt";
        this.phoneNumberTxt.PasswordChar = '\0';
        this.phoneNumberTxt.PrefixSuffixText = null;
        this.phoneNumberTxt.ReadOnly = false;
        this.phoneNumberTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.phoneNumberTxt.SelectedText = "";
        this.phoneNumberTxt.SelectionLength = 0;
        this.phoneNumberTxt.SelectionStart = 0;
        this.phoneNumberTxt.ShortcutsEnabled = true;
        this.phoneNumberTxt.Size = new System.Drawing.Size(250, 48);
        this.phoneNumberTxt.TabIndex = 13;
        this.phoneNumberTxt.TabStop = false;
        this.phoneNumberTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.phoneNumberTxt.TrailingIcon = null;
        this.phoneNumberTxt.UseSystemPasswordChar = false;
        // 
        // emailNumberTxt
        // 
        this.emailNumberTxt.AnimateReadOnly = false;
        this.emailNumberTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.emailNumberTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.emailNumberTxt.Depth = 0;
        this.emailNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.emailNumberTxt.HideSelection = true;
        this.emailNumberTxt.LeadingIcon = null;
        this.emailNumberTxt.Location = new System.Drawing.Point(745, 247);
        this.emailNumberTxt.MaxLength = 32767;
        this.emailNumberTxt.MouseState = MaterialSkin.MouseState.OUT;
        this.emailNumberTxt.Name = "emailNumberTxt";
        this.emailNumberTxt.PasswordChar = '\0';
        this.emailNumberTxt.PrefixSuffixText = null;
        this.emailNumberTxt.ReadOnly = false;
        this.emailNumberTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.emailNumberTxt.SelectedText = "";
        this.emailNumberTxt.SelectionLength = 0;
        this.emailNumberTxt.SelectionStart = 0;
        this.emailNumberTxt.ShortcutsEnabled = true;
        this.emailNumberTxt.Size = new System.Drawing.Size(250, 48);
        this.emailNumberTxt.TabIndex = 14;
        this.emailNumberTxt.TabStop = false;
        this.emailNumberTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.emailNumberTxt.TrailingIcon = null;
        this.emailNumberTxt.UseSystemPasswordChar = false;
        // 
        // createdAtTxt
        // 
        this.createdAtTxt.AnimateReadOnly = false;
        this.createdAtTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.createdAtTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.createdAtTxt.Depth = 0;
        this.createdAtTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.createdAtTxt.HideSelection = true;
        this.createdAtTxt.LeadingIcon = null;
        this.createdAtTxt.Location = new System.Drawing.Point(745, 303);
        this.createdAtTxt.MaxLength = 32767;
        this.createdAtTxt.MouseState = MaterialSkin.MouseState.OUT;
        this.createdAtTxt.Name = "createdAtTxt";
        this.createdAtTxt.PasswordChar = '\0';
        this.createdAtTxt.PrefixSuffixText = null;
        this.createdAtTxt.ReadOnly = false;
        this.createdAtTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.createdAtTxt.SelectedText = "";
        this.createdAtTxt.SelectionLength = 0;
        this.createdAtTxt.SelectionStart = 0;
        this.createdAtTxt.ShortcutsEnabled = true;
        this.createdAtTxt.Size = new System.Drawing.Size(250, 48);
        this.createdAtTxt.TabIndex = 15;
        this.createdAtTxt.TabStop = false;
        this.createdAtTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.createdAtTxt.TrailingIcon = null;
        this.createdAtTxt.UseSystemPasswordChar = false;
        // 
        // usernameTxt
        // 
        this.usernameTxt.AnimateReadOnly = false;
        this.usernameTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.usernameTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
        this.usernameTxt.Depth = 0;
        this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.usernameTxt.HideSelection = true;
        this.usernameTxt.LeadingIcon = null;
        this.usernameTxt.Location = new System.Drawing.Point(229, 373);
        this.usernameTxt.MaxLength = 32767;
        this.usernameTxt.MouseState = MaterialSkin.MouseState.OUT;
        this.usernameTxt.Name = "usernameTxt";
        this.usernameTxt.PasswordChar = '\0';
        this.usernameTxt.PrefixSuffixText = null;
        this.usernameTxt.ReadOnly = false;
        this.usernameTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.usernameTxt.SelectedText = "";
        this.usernameTxt.SelectionLength = 0;
        this.usernameTxt.SelectionStart = 0;
        this.usernameTxt.ShortcutsEnabled = true;
        this.usernameTxt.Size = new System.Drawing.Size(250, 48);
        this.usernameTxt.TabIndex = 16;
        this.usernameTxt.TabStop = false;
        this.usernameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.usernameTxt.TrailingIcon = null;
        this.usernameTxt.UseSystemPasswordChar = false;
        // 
        // UserProfile
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1033, 522);
        this.Controls.Add(this.usernameTxt);
        this.Controls.Add(this.createdAtTxt);
        this.Controls.Add(this.emailNumberTxt);
        this.Controls.Add(this.phoneNumberTxt);
        this.Controls.Add(this.namesTxt);
        this.Controls.Add(this.surnamesTxt);
        this.Controls.Add(this.idNumberTxt);
        this.Controls.Add(this.pictureBox1);
        this.Controls.Add(this.materialLabel8);
        this.Controls.Add(this.materialLabel7);
        this.Controls.Add(this.materialLabel6);
        this.Controls.Add(this.materialLabel5);
        this.Controls.Add(this.materialLabel4);
        this.Controls.Add(this.materialLabel3);
        this.Controls.Add(this.materialLabel2);
        this.Name = "UserProfile";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Perfil de Usuario";
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.ResumeLayout(false);
    }

    private MaterialSkin.Controls.MaterialTextBox2 idNumberTxt;
    private MaterialSkin.Controls.MaterialTextBox2 surnamesTxt;
    private MaterialSkin.Controls.MaterialTextBox2 namesTxt;
    private MaterialSkin.Controls.MaterialTextBox2 phoneNumberTxt;
    private MaterialSkin.Controls.MaterialTextBox2 emailNumberTxt;
    private MaterialSkin.Controls.MaterialTextBox2 createdAtTxt;
    private MaterialSkin.Controls.MaterialTextBox2 usernameTxt;

    private System.Windows.Forms.PictureBox pictureBox1;

    private MaterialSkin.Controls.MaterialLabel materialLabel8;

    private MaterialSkin.Controls.MaterialLabel materialLabel5;
    private MaterialSkin.Controls.MaterialLabel materialLabel6;
    private MaterialSkin.Controls.MaterialLabel materialLabel7;

    private MaterialSkin.Controls.MaterialLabel materialLabel2;
    private MaterialSkin.Controls.MaterialLabel materialLabel3;
    private MaterialSkin.Controls.MaterialLabel materialLabel4;

    #endregion
}