using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Collections;
using System.IO;
using System.Drawing.Imaging;

namespace WindowsFormsApplication30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        
        public void converticon(Image img, string file, int sizee)
        {
            Icon icon;
            MemoryStream msImg = new MemoryStream();
            MemoryStream msIco = new MemoryStream();
            BinaryWriter bw;
            FileStream fs;
            
            Bitmap b = new Bitmap(img, new Size(sizee, sizee));
            Rectangle rec = new Rectangle(0, 0, b.Width, b.Height);
            Graphics g = Graphics.FromImage(b);
            b.Save(msImg, ImageFormat.Png);
           
            bw = new BinaryWriter(msIco);
            bw.Write((short)0);           //0-1 reserved
            bw.Write((short)1);           //2-3 image type, 1 = icon, 2 = cursor
            bw.Write((short)1);           //4-5 number of images
            bw.Write((byte)sizee);         //6 image width
            bw.Write((byte)sizee);         //7 image height
            bw.Write((byte)0);            //8 number of colors
            bw.Write((byte)0);            //9 reserved
            bw.Write((short)0);           //10-11 color planes
            bw.Write((short)32);          //12-13 bits per pixel
            bw.Write((int)msImg.Length);  //14-17 size of image data
            bw.Write(6+16);                 //18-21 offset of image data
            bw.Write(msImg.ToArray());    // write image data
            bw.Flush();
            bw.Seek(0, SeekOrigin.Begin);
            icon = new Icon(msIco);
            
            fs = new FileStream(file, FileMode.Create, FileAccess.Write);
            icon.Save(fs);
            fs.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "PNG|*.png";
            if (o.ShowDialog() == DialogResult.OK) { textBox1.Text = o.FileName; }
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "ICON|*.ico";
            if (s.ShowDialog() == DialogResult.OK)
            {
                converticon(Image.FromFile(textBox1.Text),  s.FileName, int.Parse(comboBox1.Text));
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
