using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class MemeMaker : Form
    {
        int currentPictureCount = 0;
        Font font;
        StringFormat strFormat = new StringFormat();

        public MemeMaker()
        {
            InitializeComponent();
        }

        private void btn_change_font_Click(object sender, EventArgs e)
        {
            if (font_dialog_box.ShowDialog() == DialogResult.OK){
               font = font_dialog_box.Font;
               drawText();
            }
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            //load previous picture
            currentPictureCount--;
            if (currentPictureCount < 0)
                currentPictureCount = imageList1.Images.Count-1;
            pictureBox1.Image=imageList1.Images[currentPictureCount];
            drawText();
        }
        
        private void MemeMaker_Load(object sender, EventArgs e)
        {
            font = new Font("Microsoft Sans Serif", 16.25f);
            pictureBox1.Image = imageList1.Images[currentPictureCount];
            strFormat.Alignment = StringAlignment.Center;
            strFormat.LineAlignment = StringAlignment.Center;
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            currentPictureCount++;
            if (currentPictureCount > imageList1.Images.Count-1) {
                currentPictureCount = 0;
            }
            pictureBox1.Image = imageList1.Images[currentPictureCount];
            drawText();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imageList1.Images.Add(new Bitmap(openFileDialog1.FileName));
                //Image hi = openFileDialog1.;
                pictureBox1.Load(openFileDialog1.FileName);
                currentPictureCount = imageList1.Images.Count-1;
                drawText();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            drawText();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            drawText();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.CheckPathExists = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void btn_clr_text_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        private void drawText()
        {
            Bitmap bmp = new Bitmap(imageList1.Images[currentPictureCount]);
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawString(textBox1.Text, font, Brushes.White, new PointF((pictureBox1.Width / 2 - 31), pictureBox1.Top + 4), strFormat);
            gr.DrawString(textBox2.Text, font, Brushes.White, new PointF((pictureBox1.Width / 2 - 31), pictureBox1.Bottom - 85), strFormat);
            pictureBox1.Image = bmp;
        }
    }
}
