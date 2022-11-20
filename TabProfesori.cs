using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;


namespace Schedule_Creator
{
    public class TabProfesori
    {

        public void CreeazaProfesor(string nume)
        {
            CreeazaOrar.Profesor prof = new CreeazaOrar.Profesor();
            prof.Nume = nume;
            prof.Program = new int[8,5];
            prof.NrOrePerClasa = new int[Form1.f.creeazaOrar.NrUltimaCls+1,Form1.f.tabClase.nrMaximDeGrupe];
            prof.O_oraPerClasaPerZi = false;
            Form1.f.creeazaOrar.Profesori.Add(prof);

            MaterialCard card = new MaterialCard();
            card.Size = new Size(Form1.f.layoutProf.Width - 50, 800);
            card.Location = new Point(0, 0);

            MaterialLabel lbl = new MaterialLabel();
            lbl.Text = nume;
            lbl.AutoSize = true;
            lbl.Location = new Point(10, 5);
            lbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            card.Controls.Add(lbl);
            
            MaterialCard cardClase = new MaterialCard();
            cardClase.Size = new Size(card.Width -20, card.Height/3 +20);
            cardClase.Location = new Point(10, 50);
            card.Controls.Add(cardClase);

            FlowLayoutPanel panelClase = new FlowLayoutPanel(); 
            panelClase.Dock = DockStyle.Fill;
            panelClase.AutoScroll = true;
            panelClase.FlowDirection = FlowDirection.LeftToRight;
            panelClase.WrapContents = false;
            cardClase.Controls.Add(panelClase);
            
            optiuniClase(panelClase,nume);

            MaterialLabel lbl_program = new MaterialLabel();
            lbl_program.Text = "Ore indisponibile:";
            lbl_program.AutoSize = true;
            lbl_program.Location = new Point(50, card.Height / 3 + 80);
            lbl_program.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            card.Controls.Add(lbl_program);

            MaterialCard cardProgram = new MaterialCard();
            cardProgram.Size = new Size(card.Width - 20, card.Height / 2 +10);
            cardProgram.Location = new Point(10, card.Height / 3 + 110);
            cardProgram.BackColor = Color.Red;
            card.Controls.Add(cardProgram);


            programDisponibil(cardProgram,nume);
            

            Form1.f.layoutProf.Controls.Add(card);
        }

        public void programDisponibil(MaterialCard cardProgram,string nume)
        {
            TableLayoutPanel panelProgram = new TableLayoutPanel();
            panelProgram.Size = new Size(1000, cardProgram.Height);
            panelProgram.Location = new Point(cardProgram.Width / 2 - panelProgram.Width / 2, 0);
            panelProgram.RowCount = 9;
            panelProgram.ColumnCount = 6;
            
            cHeight = panelProgram.Height / panelProgram.RowCount - 10;
            cWidth = panelProgram.Width / panelProgram.ColumnCount - 11;
            
            panelProgram.Controls.Add(ZiSaptamanii("Luni"), 1, 0);
            panelProgram.Controls.Add(ZiSaptamanii("Marti"), 2, 0);
            panelProgram.Controls.Add(ZiSaptamanii("Miercuri"), 3, 0);
            panelProgram.Controls.Add(ZiSaptamanii("Joi"), 4, 0);
            panelProgram.Controls.Add(ZiSaptamanii("Vineri"), 5, 0);

            for (int i = 1; i <=8; i++)
                panelProgram.Controls.Add(Ora(7+i,0), 0, i);

            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j < panelProgram.ColumnCount; j++)
                {
                    panelProgram.Controls.Add(ButonCalendar(i-1,j-1,nume), j, i);
                }
            }

            panelProgram.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            cardProgram.Controls.Add(panelProgram);

        }

        public int cWidth = 100;
        public int cHeight = 200;

        public Button ButonCalendar(int x, int y,string nume)
        {
            Button card = new Button();
            card.Location = new Point(0, 0);
            card.Size = new Size(cWidth, cHeight);
            card.AutoSize = false;
            card.Anchor = AnchorStyles.None;
            card.Text = x + " " + y;
            card.BackColor = Color.White;
            card.Click += (s, e) => { functieButonCalendar(card,x,y,nume); };
            return card;
        }

        public void functieButonCalendar(Button btn,int x, int y,string nume)
        {
            var i = Form1.f.creeazaOrar.Profesori.FindIndex(c => c.Nume == nume);
            
            if (btn.BackColor.Equals(Color.White))
            {
                btn.BackColor = Color.Pink;
                Form1.f.creeazaOrar.Profesori[i].Program[x,y] = 1;
            }
            else
            {
                btn.BackColor = Color.White;
                Form1.f.creeazaOrar.Profesori[i].Program[x, y] = 0;
            }
            afiseazaProfesor(Form1.f.creeazaOrar.Profesori[i]);
        }

        public void afiseazaProfesor(CreeazaOrar.Profesor prof)
        {
            Console.WriteLine("");
            Console.WriteLine("Nume: " + prof.Nume);
            for (int i = 0; i < 8;i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(prof.Program[i,j] + " ");
                }
                Console.WriteLine("");
            }

            for (int i = Form1.f.creeazaOrar.NrPrimaCls; i <= Form1.f.creeazaOrar.NrUltimaCls ; i++)
            {
                Console.WriteLine("-Clasa: " + i);
                for (int j = 0; j < Form1.f.creeazaOrar.listGrupePerClasa[i]; j++)
                {
                    Console.WriteLine("Grupa: " + func.IntToLetter(j) + "  | Nr Ore: " + prof.NrOrePerClasa[i, j]);
                }
            }
        }

        public MaterialButton ZiSaptamanii(string text)
        {
            MaterialButton card = new MaterialButton();
            card.Location = new Point(0, 0);
            card.Size = new Size(cWidth, cHeight);
            card.AutoSize = false;
            card.Anchor = AnchorStyles.None;
            card.Enabled = false;
            card.Text = text;
            return card;
        }

        public MaterialLabel Ora(int ora, int minut)
        {
            MaterialLabel lbl = new MaterialLabel();
            lbl.Location = new Point(0,0);
            lbl.AutoSize = true;
            lbl.Anchor = AnchorStyles.None;
            lbl.Text = "               " + formatTime(ora) + ":" + formatTime(minut) + "               ";
            return lbl;
        }

        public void optiuniClase(FlowLayoutPanel panelClase,string nume)
        {
            for (int i = Form1.f.creeazaOrar.NrPrimaCls; i <= Form1.f.creeazaOrar.NrUltimaCls; i++)
            {
                MaterialCard card = new MaterialCard();
                card.Size = new Size(200, panelClase.Height -45);
                card.Location = new Point(0, 0);
                panelClase.Controls.Add(card);

                MaterialLabel lbl = new MaterialLabel();
                lbl.Text = "Nr de ore la clasa a " + i + "-a:";
                lbl.AutoSize = true;
                lbl.Location = new Point(card.Width/2 - lbl.Width/2 - 34, 5);
                card.Controls.Add(lbl);
                
                FlowLayoutPanel flowPanel = new FlowLayoutPanel();
                flowPanel.Size = new Size(card.Width, card.Height - lbl.Size.Height-5);
                flowPanel.Location = new Point(0, lbl.Size.Height+5);
                flowPanel.AutoScroll = true;
                flowPanel.FlowDirection = FlowDirection.TopDown;
                flowPanel.WrapContents = false;
                card.Controls.Add(flowPanel);

                for (int j = 0; j < Form1.f.creeazaOrar.listGrupePerClasa[i]; j++)
                {
                    Panel p = new Panel();
                    p.Size = new Size(flowPanel.Width-30, 30);

                    MaterialLabel lbl_text = new MaterialLabel();
                    lbl_text.Text = func.IntToLetter(j);
                    lbl_text.AutoSize = true;
                    lbl_text.Location = new Point(10, 0);
                    p.Controls.Add(lbl_text);

                    int a=i, b=j;
                    NumericUpDown numInput = new NumericUpDown();
                    numInput.Location = new Point(30, 0);
                    numInput.ValueChanged += (s, e) => { functieNrOreGrupa(a,b,(int)numInput.Value,nume); };
                    p.Controls.Add(numInput);
                    

                    flowPanel.Controls.Add(p);
                }
              

            }
        }
        // for loop cu i si j
        //Erori stupide
        void functieNrOreGrupa(int clasa, int grupa,int nrOre,string nume)
        {
            var i = Form1.f.creeazaOrar.Profesori.FindIndex(c => c.Nume == nume);
            Console.WriteLine(i + "  " + Form1.f.creeazaOrar.Profesori.Count);
            Form1.f.creeazaOrar.Profesori[i].NrOrePerClasa[clasa, grupa] = nrOre;

        }

        public string formatTime(int num)
        {
            if (num < 10)
                return ("0" + num.ToString());
            else
                return num.ToString();
        }

    }
}
