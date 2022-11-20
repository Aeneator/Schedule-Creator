using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Schedule_Creator
{
    public class ResizeController
    {
        private Form1 f;

        private Rectangle OriginalFormSize;
        private Rectangle OriginalProfesoriMainCard;
        //private Rectangle OriginalImageViewSize;
        //private Rectangle OriginalCategoryButtonsPanelSize;

        public void Load()
        {
            f = Form1.f;

            OriginalFormSize = new Rectangle(f.Location.X, f.Location.Y, f.Size.Width, f.Size.Height);
            OriginalProfesoriMainCard = new Rectangle(f.mainProfesoriCard.Location.X, f.mainProfesoriCard.Location.Y, f.mainProfesoriCard.Size.Width, f.mainProfesoriCard.Size.Height);
            //OriginalImageViewSize = new Rectangle(F.ImageView.Location.X, F.ImageView.Location.Y, F.ImageView.Size.Width, F.ImageView.Size.Height);
            //OriginalCategoryButtonsPanelSize = new Rectangle(F.CategoryButtonsPanel.Location.X, F.CategoryButtonsPanel.Location.Y, F.CategoryButtonsPanel.Size.Width, F.CategoryButtonsPanel.Size.Height);

            OnResize();
        }

        public void OnResize()
        {
            ResizeControl(OriginalProfesoriMainCard, f.mainProfesoriCard);
            //ResizeImageView(OriginalImageViewSize, F.ImageView);
            //ResizeCategoryPanel(OriginalCategoryButtonsPanelSize, F.CategoryButtonsPanel);
        }

        private void ResizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(f.Width) / (float)(OriginalFormSize.Width);
            float yRatio = (float)(f.Height) / (float)(OriginalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        /*
        private void ResizeImageView(Rectangle r, Control c)
        {
            int padding = 10;

            float xRatio = (float)(F.Width) / (float)(OriginalFormSize.Width);
            float yRatio = (float)(F.Height) / (float)(OriginalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio) + padding;
            int newY = Form1.f.TopBar.Height;

            int newWidth = F.Width - F.RightPanel.Width - padding * 4;
            int newHeight = F.Height - Form1.f.TopBar.Height - padding * 5;

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void ResizeCategoryPanel(Rectangle r, Control c)
        {
            int padding = 10;

            float xRatio = (float)(F.Width) / (float)(OriginalFormSize.Width);

            int newX = (int)(r.Location.X * xRatio) + padding;

            int newHeight = F.RightPanel.Height - F.TopRightPanel.Height - Form1.f.TopBar.Height - padding;

            c.Location = new Point(newX, c.Location.Y);
            c.Size = new Size(c.Width, newHeight);
        }
        */


    }
}
