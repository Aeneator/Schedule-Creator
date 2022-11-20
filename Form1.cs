using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Creator
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public static Form1 f;

        public ResizeController resizeController = new ResizeController();
        public TabClase tabClase = new TabClase();
        public TabProfesori tabProfesori = new TabProfesori();
        public AfiseazaOrar afiseazaOrar = new AfiseazaOrar();
        public CreeazaOrar creeazaOrar = new CreeazaOrar();

        public GenereazaVaribileAtStart genereazaStart = new GenereazaVaribileAtStart();

        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

            f = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resizeController.Load();

            genereazaStart.Load();
        }

        private void btn_AdaugaProfesor_Click(object sender, EventArgs e)
        {
            if (inputNumeProfesor.TextLength > 0)
            {
                tabProfesori.CreeazaProfesor(inputNumeProfesor.Text);
                inputNumeProfesor.ResetText();
            }
        }

        private void enter_NrGeneratii_Click(object sender, EventArgs e)
        {
            if ((int)num_ani1.Value <= (int)num_ani2.Value)
            {
                tabClase.CreeazaClasele((int)num_ani1.Value, (int)num_ani2.Value);
                btn_GeneratClase.Visible = true;
            }
        }

        private void btn_GeneratClase_Click(object sender, EventArgs e)
        {
            tabClase.AfiseazaStructuraFinala();
            structuraFinala.Visible = true;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeController.OnResize();
        }

        private void btn_genereaza_Click(object sender, EventArgs e)
        {
            
            FlowLayoutPanel form = afiseazaOrar.GenereazaOrarPopUp();

            creeazaOrar.Start();

            int c = 0;
            for (int i = creeazaOrar.NrPrimaCls; i <= creeazaOrar.NrUltimaCls; i++)
                for (int j = 0; j < creeazaOrar.listGrupePerClasa[i]; j++)
                {
                    afiseazaOrar.ComponentOrar(form, "Clasa a " + i + "-a " + ((char)(j + 'A')).ToString(), creeazaOrar.orare[c].M);
                    c++;
                }

            form.Parent.Show();

            foreach (CreeazaOrar.Profesor prof in creeazaOrar.Profesori)
            {
                tabProfesori.afiseazaProfesor(prof);
            }
        }
      

    }
}
