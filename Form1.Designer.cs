
namespace Schedule_Creator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.Clase = new System.Windows.Forms.TabPage();
            this.structuraFinala = new MaterialSkin.Controls.MaterialCard();
            this.layoutClaseFinale = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_text5 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_GeneratClase = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.listViewClasePerGeneratii = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_text4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.enter_NrGeneratii = new MaterialSkin.Controls.MaterialButton();
            this.lbl_text2 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_text3 = new MaterialSkin.Controls.MaterialLabel();
            this.num_ani1 = new System.Windows.Forms.NumericUpDown();
            this.num_ani2 = new System.Windows.Forms.NumericUpDown();
            this.lbl_text1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_text0 = new MaterialSkin.Controls.MaterialLabel();
            this.Profesori = new System.Windows.Forms.TabPage();
            this.btn_genereaza = new MaterialSkin.Controls.MaterialButton();
            this.mainProfesoriCard = new MaterialSkin.Controls.MaterialCard();
            this.layoutProf = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_AdaugaProfesor = new MaterialSkin.Controls.MaterialButton();
            this.inputNumeProfesor = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_text6 = new MaterialSkin.Controls.MaterialLabel();
            this.Setari = new System.Windows.Forms.TabPage();
            this.tabImageList = new System.Windows.Forms.ImageList(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl.SuspendLayout();
            this.Clase.SuspendLayout();
            this.structuraFinala.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_ani1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ani2)).BeginInit();
            this.Profesori.SuspendLayout();
            this.mainProfesoriCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Profesori);
            this.tabControl.Controls.Add(this.Clase);
            this.tabControl.Controls.Add(this.Setari);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.tabImageList;
            this.tabControl.ItemSize = new System.Drawing.Size(60, 60);
            this.tabControl.Location = new System.Drawing.Point(3, 64);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(1503, 875);
            this.tabControl.TabIndex = 0;
            // 
            // Clase
            // 
            this.Clase.BackColor = System.Drawing.Color.White;
            this.Clase.Controls.Add(this.structuraFinala);
            this.Clase.Controls.Add(this.btn_GeneratClase);
            this.Clase.Controls.Add(this.materialCard2);
            this.Clase.Controls.Add(this.lbl_text4);
            this.Clase.Controls.Add(this.materialCard1);
            this.Clase.Controls.Add(this.lbl_text0);
            this.Clase.ImageKey = "Class.png";
            this.Clase.Location = new System.Drawing.Point(4, 64);
            this.Clase.Name = "Clase";
            this.Clase.Padding = new System.Windows.Forms.Padding(3);
            this.Clase.Size = new System.Drawing.Size(1495, 807);
            this.Clase.TabIndex = 0;
            this.Clase.Text = "Clase";
            // 
            // structuraFinala
            // 
            this.structuraFinala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.structuraFinala.Controls.Add(this.layoutClaseFinale);
            this.structuraFinala.Controls.Add(this.lbl_text5);
            this.structuraFinala.Depth = 0;
            this.structuraFinala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.structuraFinala.Location = new System.Drawing.Point(524, 17);
            this.structuraFinala.Margin = new System.Windows.Forms.Padding(14);
            this.structuraFinala.MouseState = MaterialSkin.MouseState.HOVER;
            this.structuraFinala.Name = "structuraFinala";
            this.structuraFinala.Padding = new System.Windows.Forms.Padding(14);
            this.structuraFinala.Size = new System.Drawing.Size(468, 776);
            this.structuraFinala.TabIndex = 10;
            this.structuraFinala.Visible = false;
            // 
            // layoutClaseFinale
            // 
            this.layoutClaseFinale.AutoScroll = true;
            this.layoutClaseFinale.Location = new System.Drawing.Point(17, 47);
            this.layoutClaseFinale.Name = "layoutClaseFinale";
            this.layoutClaseFinale.Size = new System.Drawing.Size(437, 715);
            this.layoutClaseFinale.TabIndex = 12;
            // 
            // lbl_text5
            // 
            this.lbl_text5.AutoSize = true;
            this.lbl_text5.Depth = 0;
            this.lbl_text5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_text5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_text5.Location = new System.Drawing.Point(17, 11);
            this.lbl_text5.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_text5.Name = "lbl_text5";
            this.lbl_text5.Size = new System.Drawing.Size(144, 24);
            this.lbl_text5.TabIndex = 11;
            this.lbl_text5.Text = "Structura finala:";
            // 
            // btn_GeneratClase
            // 
            this.btn_GeneratClase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_GeneratClase.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_GeneratClase.Depth = 0;
            this.btn_GeneratClase.HighEmphasis = true;
            this.btn_GeneratClase.Icon = null;
            this.btn_GeneratClase.Location = new System.Drawing.Point(409, 132);
            this.btn_GeneratClase.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_GeneratClase.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_GeneratClase.Name = "btn_GeneratClase";
            this.btn_GeneratClase.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_GeneratClase.Size = new System.Drawing.Size(67, 36);
            this.btn_GeneratClase.TabIndex = 7;
            this.btn_GeneratClase.Text = "Enter";
            this.btn_GeneratClase.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_GeneratClase.UseAccentColor = false;
            this.btn_GeneratClase.UseVisualStyleBackColor = true;
            this.btn_GeneratClase.Click += new System.EventHandler(this.btn_GeneratClase_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.listViewClasePerGeneratii);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(25, 182);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(469, 611);
            this.materialCard2.TabIndex = 9;
            // 
            // listViewClasePerGeneratii
            // 
            this.listViewClasePerGeneratii.AutoScroll = true;
            this.listViewClasePerGeneratii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewClasePerGeneratii.Location = new System.Drawing.Point(14, 14);
            this.listViewClasePerGeneratii.Name = "listViewClasePerGeneratii";
            this.listViewClasePerGeneratii.Size = new System.Drawing.Size(441, 583);
            this.listViewClasePerGeneratii.TabIndex = 8;
            // 
            // lbl_text4
            // 
            this.lbl_text4.AutoSize = true;
            this.lbl_text4.Depth = 0;
            this.lbl_text4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_text4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_text4.Location = new System.Drawing.Point(21, 144);
            this.lbl_text4.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_text4.Name = "lbl_text4";
            this.lbl_text4.Size = new System.Drawing.Size(347, 24);
            this.lbl_text4.TabIndex = 7;
            this.lbl_text4.Text = "Numarul de grupe pentru fiecare clasa:";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.enter_NrGeneratii);
            this.materialCard1.Controls.Add(this.lbl_text2);
            this.materialCard1.Controls.Add(this.lbl_text3);
            this.materialCard1.Controls.Add(this.num_ani1);
            this.materialCard1.Controls.Add(this.num_ani2);
            this.materialCard1.Controls.Add(this.lbl_text1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(25, 67);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(469, 54);
            this.materialCard1.TabIndex = 6;
            // 
            // enter_NrGeneratii
            // 
            this.enter_NrGeneratii.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enter_NrGeneratii.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.enter_NrGeneratii.Depth = 0;
            this.enter_NrGeneratii.HighEmphasis = true;
            this.enter_NrGeneratii.Icon = null;
            this.enter_NrGeneratii.Location = new System.Drawing.Point(384, 4);
            this.enter_NrGeneratii.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.enter_NrGeneratii.MouseState = MaterialSkin.MouseState.HOVER;
            this.enter_NrGeneratii.Name = "enter_NrGeneratii";
            this.enter_NrGeneratii.NoAccentTextColor = System.Drawing.Color.Empty;
            this.enter_NrGeneratii.Size = new System.Drawing.Size(67, 36);
            this.enter_NrGeneratii.TabIndex = 6;
            this.enter_NrGeneratii.Text = "Enter";
            this.enter_NrGeneratii.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.enter_NrGeneratii.UseAccentColor = false;
            this.enter_NrGeneratii.UseVisualStyleBackColor = true;
            this.enter_NrGeneratii.Click += new System.EventHandler(this.enter_NrGeneratii_Click);
            // 
            // lbl_text2
            // 
            this.lbl_text2.AutoSize = true;
            this.lbl_text2.Depth = 0;
            this.lbl_text2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_text2.Location = new System.Drawing.Point(166, 14);
            this.lbl_text2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_text2.Name = "lbl_text2";
            this.lbl_text2.Size = new System.Drawing.Size(130, 19);
            this.lbl_text2.TabIndex = 4;
            this.lbl_text2.Text = "-a pana la clasa a ";
            // 
            // lbl_text3
            // 
            this.lbl_text3.AutoSize = true;
            this.lbl_text3.Depth = 0;
            this.lbl_text3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_text3.Location = new System.Drawing.Point(353, 14);
            this.lbl_text3.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_text3.Name = "lbl_text3";
            this.lbl_text3.Size = new System.Drawing.Size(18, 19);
            this.lbl_text3.TabIndex = 5;
            this.lbl_text3.Text = "-a.";
            // 
            // num_ani1
            // 
            this.num_ani1.Location = new System.Drawing.Point(115, 14);
            this.num_ani1.Name = "num_ani1";
            this.num_ani1.Size = new System.Drawing.Size(45, 20);
            this.num_ani1.TabIndex = 1;
            // 
            // num_ani2
            // 
            this.num_ani2.Location = new System.Drawing.Point(302, 13);
            this.num_ani2.Name = "num_ani2";
            this.num_ani2.Size = new System.Drawing.Size(45, 20);
            this.num_ani2.TabIndex = 2;
            // 
            // lbl_text1
            // 
            this.lbl_text1.AutoSize = true;
            this.lbl_text1.Depth = 0;
            this.lbl_text1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_text1.Location = new System.Drawing.Point(17, 14);
            this.lbl_text1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_text1.Name = "lbl_text1";
            this.lbl_text1.Size = new System.Drawing.Size(92, 19);
            this.lbl_text1.TabIndex = 3;
            this.lbl_text1.Text = "De la clasa a";
            // 
            // lbl_text0
            // 
            this.lbl_text0.AutoSize = true;
            this.lbl_text0.Depth = 0;
            this.lbl_text0.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_text0.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_text0.Location = new System.Drawing.Point(21, 29);
            this.lbl_text0.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_text0.Name = "lbl_text0";
            this.lbl_text0.Size = new System.Drawing.Size(161, 24);
            this.lbl_text0.TabIndex = 0;
            this.lbl_text0.Text = "Numarul de clase:";
            // 
            // Profesori
            // 
            this.Profesori.BackColor = System.Drawing.Color.White;
            this.Profesori.Controls.Add(this.btn_genereaza);
            this.Profesori.Controls.Add(this.mainProfesoriCard);
            this.Profesori.Controls.Add(this.btn_AdaugaProfesor);
            this.Profesori.Controls.Add(this.inputNumeProfesor);
            this.Profesori.Controls.Add(this.lbl_text6);
            this.Profesori.ImageKey = "people (1).png";
            this.Profesori.Location = new System.Drawing.Point(4, 64);
            this.Profesori.Name = "Profesori";
            this.Profesori.Padding = new System.Windows.Forms.Padding(3);
            this.Profesori.Size = new System.Drawing.Size(1495, 807);
            this.Profesori.TabIndex = 1;
            this.Profesori.Text = "Profesori";
            // 
            // btn_genereaza
            // 
            this.btn_genereaza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_genereaza.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_genereaza.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_genereaza.Depth = 0;
            this.btn_genereaza.HighEmphasis = true;
            this.btn_genereaza.Icon = null;
            this.btn_genereaza.Location = new System.Drawing.Point(1373, 12);
            this.btn_genereaza.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_genereaza.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_genereaza.Name = "btn_genereaza";
            this.btn_genereaza.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_genereaza.Size = new System.Drawing.Size(105, 36);
            this.btn_genereaza.TabIndex = 4;
            this.btn_genereaza.Text = "Genereaza";
            this.btn_genereaza.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_genereaza.UseAccentColor = false;
            this.btn_genereaza.UseVisualStyleBackColor = true;
            this.btn_genereaza.Click += new System.EventHandler(this.btn_genereaza_Click);
            // 
            // mainProfesoriCard
            // 
            this.mainProfesoriCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mainProfesoriCard.Controls.Add(this.layoutProf);
            this.mainProfesoriCard.Depth = 0;
            this.mainProfesoriCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainProfesoriCard.Location = new System.Drawing.Point(14, 68);
            this.mainProfesoriCard.Margin = new System.Windows.Forms.Padding(14);
            this.mainProfesoriCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainProfesoriCard.Name = "mainProfesoriCard";
            this.mainProfesoriCard.Padding = new System.Windows.Forms.Padding(14);
            this.mainProfesoriCard.Size = new System.Drawing.Size(1414, 797);
            this.mainProfesoriCard.TabIndex = 0;
            // 
            // layoutProf
            // 
            this.layoutProf.AutoScroll = true;
            this.layoutProf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutProf.Location = new System.Drawing.Point(14, 14);
            this.layoutProf.Name = "layoutProf";
            this.layoutProf.Size = new System.Drawing.Size(1386, 769);
            this.layoutProf.TabIndex = 0;
            // 
            // btn_AdaugaProfesor
            // 
            this.btn_AdaugaProfesor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_AdaugaProfesor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_AdaugaProfesor.Depth = 0;
            this.btn_AdaugaProfesor.HighEmphasis = true;
            this.btn_AdaugaProfesor.Icon = null;
            this.btn_AdaugaProfesor.Location = new System.Drawing.Point(413, 12);
            this.btn_AdaugaProfesor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_AdaugaProfesor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_AdaugaProfesor.Name = "btn_AdaugaProfesor";
            this.btn_AdaugaProfesor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_AdaugaProfesor.Size = new System.Drawing.Size(80, 36);
            this.btn_AdaugaProfesor.TabIndex = 1;
            this.btn_AdaugaProfesor.Text = "Adauga";
            this.btn_AdaugaProfesor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_AdaugaProfesor.UseAccentColor = false;
            this.btn_AdaugaProfesor.UseVisualStyleBackColor = true;
            this.btn_AdaugaProfesor.Click += new System.EventHandler(this.btn_AdaugaProfesor_Click);
            // 
            // inputNumeProfesor
            // 
            this.inputNumeProfesor.AnimateReadOnly = false;
            this.inputNumeProfesor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputNumeProfesor.Depth = 0;
            this.inputNumeProfesor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputNumeProfesor.LeadingIcon = null;
            this.inputNumeProfesor.Location = new System.Drawing.Point(169, 6);
            this.inputNumeProfesor.MaxLength = 50;
            this.inputNumeProfesor.MouseState = MaterialSkin.MouseState.OUT;
            this.inputNumeProfesor.Multiline = false;
            this.inputNumeProfesor.Name = "inputNumeProfesor";
            this.inputNumeProfesor.Size = new System.Drawing.Size(237, 50);
            this.inputNumeProfesor.TabIndex = 2;
            this.inputNumeProfesor.Text = "";
            this.inputNumeProfesor.TrailingIcon = null;
            // 
            // lbl_text6
            // 
            this.lbl_text6.AutoSize = true;
            this.lbl_text6.Depth = 0;
            this.lbl_text6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_text6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_text6.Location = new System.Drawing.Point(24, 24);
            this.lbl_text6.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_text6.Name = "lbl_text6";
            this.lbl_text6.Size = new System.Drawing.Size(139, 24);
            this.lbl_text6.TabIndex = 3;
            this.lbl_text6.Text = "Nume profesor:";
            // 
            // Setari
            // 
            this.Setari.BackColor = System.Drawing.Color.White;
            this.Setari.ImageKey = "settings.png";
            this.Setari.Location = new System.Drawing.Point(4, 64);
            this.Setari.Name = "Setari";
            this.Setari.Size = new System.Drawing.Size(1495, 807);
            this.Setari.TabIndex = 2;
            this.Setari.Text = "Setari";
            // 
            // tabImageList
            // 
            this.tabImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabImageList.ImageStream")));
            this.tabImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.tabImageList.Images.SetKeyName(0, "Class.png");
            this.tabImageList.Images.SetKeyName(1, "people (1).png");
            this.tabImageList.Images.SetKeyName(2, "settings.png");
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "add.png");
            this.imageList.Images.SetKeyName(1, "customer-support.png");
            this.imageList.Images.SetKeyName(2, "network.png");
            this.imageList.Images.SetKeyName(3, "people (1).png");
            this.imageList.Images.SetKeyName(4, "people.png");
            this.imageList.Images.SetKeyName(5, "setting-lines.png");
            this.imageList.Images.SetKeyName(6, "settings.png");
            this.imageList.Images.SetKeyName(7, "x.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 942);
            this.Controls.Add(this.tabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabControl;
            this.DrawerUseColors = true;
            this.MinimumSize = new System.Drawing.Size(1509, 942);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl.ResumeLayout(false);
            this.Clase.ResumeLayout(false);
            this.Clase.PerformLayout();
            this.structuraFinala.ResumeLayout(false);
            this.structuraFinala.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_ani1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ani2)).EndInit();
            this.Profesori.ResumeLayout(false);
            this.Profesori.PerformLayout();
            this.mainProfesoriCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage Clase;
        private System.Windows.Forms.TabPage Profesori;
        private System.Windows.Forms.TabPage Setari;
        private System.Windows.Forms.ImageList tabImageList;
        private System.Windows.Forms.ImageList imageList;
        private MaterialSkin.Controls.MaterialLabel lbl_text0;
        private MaterialSkin.Controls.MaterialLabel lbl_text3;
        private MaterialSkin.Controls.MaterialLabel lbl_text2;
        private MaterialSkin.Controls.MaterialLabel lbl_text1;
        private System.Windows.Forms.NumericUpDown num_ani2;
        private System.Windows.Forms.NumericUpDown num_ani1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton enter_NrGeneratii;
        private MaterialSkin.Controls.MaterialLabel lbl_text4;
        public System.Windows.Forms.FlowLayoutPanel listViewClasePerGeneratii;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton btn_GeneratClase;
        private MaterialSkin.Controls.MaterialCard structuraFinala;
        private MaterialSkin.Controls.MaterialLabel lbl_text5;
        public System.Windows.Forms.FlowLayoutPanel layoutClaseFinale;
        private MaterialSkin.Controls.MaterialButton btn_AdaugaProfesor;
        private MaterialSkin.Controls.MaterialTextBox inputNumeProfesor;
        private MaterialSkin.Controls.MaterialLabel lbl_text6;
        public System.Windows.Forms.FlowLayoutPanel layoutProf;
        public MaterialSkin.Controls.MaterialCard mainProfesoriCard;
        public MaterialSkin.Controls.MaterialButton btn_genereaza;
    }
}

