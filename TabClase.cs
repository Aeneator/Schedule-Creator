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
    public class TabClase
    {

        List<NumericUpDown> ListaNumUpDown = new List<NumericUpDown>();

        // Nr de clase
        //public int NrPrimaCls, NrUltimaCls;
        
        public int nrMaximDeGrupe =0;

        // Nr de Grupe pentru pe care le are fiecare clasa
        //public int[] listGrupePerClasa = new int[1000];  

        public void CreeazaClasele(int start, int end)
        {

            Form1.f.creeazaOrar.NrPrimaCls = start;
            Form1.f.creeazaOrar.NrUltimaCls = end;

            ListaNumUpDown.Clear();
            while (Form1.f.listViewClasePerGeneratii.Controls.Count > 0)
            {
                Form1.f.listViewClasePerGeneratii.Controls[0].Dispose();
            }
            
            for (int i = Form1.f.creeazaOrar.NrPrimaCls; i <= Form1.f.creeazaOrar.NrUltimaCls; i++)
            {
                DisplayClasa(i);
            }
        }

        public void DisplayClasa(int num)
        {
            
            MaterialCard card = new MaterialCard();
            card.Size = new Size(Form1.f.listViewClasePerGeneratii.Width-50, 60);
            card.Location = new Point(0, 0);

            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Dock = DockStyle.Fill;
            card.Controls.Add(panel);

            MaterialLabel lbl = new MaterialLabel();
            lbl.Text = "Clasa a " + num + "-a, numar de grupe:";
            lbl.AutoSize = true;
            panel.Controls.Add(lbl);

            NumericUpDown numInput = new NumericUpDown();
            numInput.Value = 1;
            numInput.Minimum = 1;
            panel.Controls.Add(numInput);
            ListaNumUpDown.Add(numInput);

            Form1.f.listViewClasePerGeneratii.Controls.Add(card);

        }

        public void AfiseazaStructuraFinala()
        {

            int g = Form1.f.creeazaOrar.NrPrimaCls;
            foreach (NumericUpDown e in ListaNumUpDown)
            {
                Form1.f.creeazaOrar.listGrupePerClasa[g++] = (int)e.Value;
                
                if ((int)e.Value > nrMaximDeGrupe)
                    nrMaximDeGrupe = (int)e.Value;
            }

            while (Form1.f.layoutClaseFinale.Controls.Count > 0)
                Form1.f.layoutClaseFinale.Controls[0].Dispose();
            

            for (int i = Form1.f.creeazaOrar.NrPrimaCls; i <= Form1.f.creeazaOrar.NrUltimaCls;i++)
            {
                MaterialCard card = new MaterialCard();
                card.Size = new Size(Form1.f.layoutClaseFinale.Width - 50, 100);
                card.Location = new Point(0, 0);
                card.BackColor = Color.Red;

                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Dock = DockStyle.Fill;
                card.Controls.Add(panel);


                MaterialLabel lbl = new MaterialLabel();
                lbl.Text = "Clasa a " + i + "-a:";
                lbl.Location = new Point(0, 0);
                lbl.AutoSize = true;
                panel.Controls.Add(lbl);

                FlowLayoutPanel miniPanel = new FlowLayoutPanel();
                miniPanel.Location = new Point(0,10);
                miniPanel.Size = new Size(panel.Width,40);
                miniPanel.AutoScroll = true;
                miniPanel.WrapContents = false;
                miniPanel.FlowDirection = FlowDirection.LeftToRight;
                panel.Controls.Add(miniPanel);

                for(int j = 0; j < Form1.f.creeazaOrar.listGrupePerClasa[i]; j++)
                {
                    MaterialLabel groupLbl = new MaterialLabel();
                    groupLbl.Text = ((char)(j + 'A')).ToString();
                    groupLbl.AutoSize = true;
                    miniPanel.Controls.Add(groupLbl);
                }

                Form1.f.layoutClaseFinale.Controls.Add(card);
               
            }
        }


    }
}
