using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imagenProporcion
{
    public partial class Form1 : Form
    {
        Image img;
        string exten = ".JPEG";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "(*.png,*jpg) |*jpg; *.png;";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFile.FileName);
                txOrigen.Text = openFile.FileName;
                img = Image.FromFile(openFile.FileName);
                int x, y;
                for (x = 0; x < img.Width; x++)
                {
                    lblAncho.Text = "" + img.Width.ToString();
                }
                for (y = 0; y < img.Width; y++)
                {
                    lblAlto.Text = "" + img.Height.ToString();
                }
            }
        }
        new Image Resize(Image imagen, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics grafic = Graphics.FromImage(bmp);
            grafic.DrawImage(imagen, 0, 0, w, h);
            grafic.Dispose();
            return bmp;
        }
        
     
        private void btnDestino_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
                txDestino.Text = folderBrowser.SelectedPath;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int entradaAncho = Convert.ToInt32(txEntrada.Text);
                anchoNuevo.Text = string.Format("" + entradaAncho);

                int alto = Int32.Parse(lblAlto.Text);
                int NuevoAncho = entradaAncho;
                int resultado = (alto * NuevoAncho) / int.Parse(lblAncho.Text);
                altoNuevo.Text = string.Format("" + resultado);

                img = Resize(img, NuevoAncho, resultado);

                int dot = 0, slash = 0;
                for (int j = txOrigen.Text.Length - 1; j >= 0; j--)
                    if (txOrigen.Text[j] == '.') 
                        dot = j;
                    else if (txOrigen.Text[j] == '\\')
                    {
                        slash = j;
                        break;
                    }
                img.Save(txDestino.Text + "\\" + txOrigen.Text.Substring(slash + 1, dot - slash - 1) + exten);
                MessageBox.Show("Imagen Guardada");

            }
            catch (Exception)
            {
                MessageBox.Show("Cargue una Imagen, luego \n ingrese un valor numérico en nueva dimensión");

            }
        }
    }
}
