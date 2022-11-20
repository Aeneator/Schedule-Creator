using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Schedule_Creator
{
    public class AfiseazaOrar
    {

        public FlowLayoutPanel GenereazaOrarPopUp()
        {
            MaterialForm formPopup = new MaterialForm();
            formPopup.Size = new Size(1530, 1000);
            
            FlowLayoutPanel mainPanel = new FlowLayoutPanel();
            mainPanel.AutoScroll = true;
            mainPanel.FlowDirection = FlowDirection.TopDown;
            mainPanel.WrapContents = false;
            mainPanel.Dock = DockStyle.Fill;
            
            formPopup.Controls.Add(mainPanel);
            string[,] matrice = new string[8, 5];
       
            return mainPanel;
        }

        public void ComponentOrar(dynamic form ,string numeClasa, string[,] matriceRezultat)
        {
            Panel OrarPanel = new Panel();
            OrarPanel.Size = new Size(1500, 390);
            OrarPanel.Location = new Point(0, 0);
            form.Controls.Add(OrarPanel);

            MaterialLabel lbl = new MaterialLabel();
            lbl.Location = new Point(0, 0);
            lbl.AutoSize = true;
            lbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lbl.Text = numeClasa;
            OrarPanel.Controls.Add(lbl);

            TableLayoutPanel panelProgram = new TableLayoutPanel();
            panelProgram.Size = new Size(OrarPanel.Width, OrarPanel.Height - lbl.Height);
            panelProgram.Location = new Point(0, lbl.Height);
            panelProgram.RowCount = 9;
            panelProgram.ColumnCount = 6;

            Form1.f.tabProfesori.cHeight = panelProgram.Height / panelProgram.RowCount - 10;
            Form1.f.tabProfesori.cWidth = panelProgram.Width / panelProgram.ColumnCount - 11;

            panelProgram.Controls.Add(Form1.f.tabProfesori.ZiSaptamanii("Luni"), 1, 0);
            panelProgram.Controls.Add(Form1.f.tabProfesori.ZiSaptamanii("Marti"), 2, 0);
            panelProgram.Controls.Add(Form1.f.tabProfesori.ZiSaptamanii("Miercuri"), 3, 0);
            panelProgram.Controls.Add(Form1.f.tabProfesori.ZiSaptamanii("Joi"), 4, 0);
            panelProgram.Controls.Add(Form1.f.tabProfesori.ZiSaptamanii("Vineri"), 5, 0);

            for (int i = 1; i <= 8; i++)
                panelProgram.Controls.Add(Form1.f.tabProfesori.Ora(7 + i, 0), 0, i);

            for (int i = 1; i < panelProgram.RowCount; i++)
            {
                for (int j = 1; j < panelProgram.ColumnCount; j++)
                {
                    panelProgram.Controls.Add(LabelProfesor(matriceRezultat[i-1,j-1]), j, i);
                }
            }

            panelProgram.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            OrarPanel.Controls.Add(panelProgram);

        }

        public dynamic LabelProfesor(string nume)
        {
            Panel p = new Panel();
            p.Location = new Point(0, 0);
            p.Size = new Size(250, Form1.f.tabProfesori.cHeight);
            p.Anchor = AnchorStyles.None;
            

            if (nume != "" || nume != null) {
                foreach (CreeazaOrar.Profesor prof in Form1.f.creeazaOrar.Profesori)
                {
                    if (prof.Nume == nume)
                    {
                       p.BackColor =prof.culoareProf;
                    }    
                }
            }
            //p.BackColor = Form1.f.creeazaOrar.Profesori.Where(prof => prof.Nume == nume).FirstOrDefault().culoareProf;

            MaterialLabel lbl = new MaterialLabel();
            lbl.Location = new Point(0, 0);
            lbl.AutoSize = true;
            lbl.Anchor = AnchorStyles.None;
            lbl.Text = nume;
            p.Controls.Add(lbl);

            return p;
        }
    }
}
