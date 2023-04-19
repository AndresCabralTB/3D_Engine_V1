using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3D_3ngine_V1
{
    public partial class Form1: Form
    {
        Mtx val;


        private float z = 2f;

        private float rotateY = 0.0f;
        private float rotateX = 0.0f;
        private float rotateZ = 0.0f;

        private float translateX = 50.0f;
        private float translateY = 0.0f;
        private float translateZ = 0.0f;

        //public List<float[]> Vertices { get; private set; }
        //public List<int[]> Faces { get; private set; }

        string filename;
        Vertex rotation;
        public Form1()
        {
            InitializeComponent();
            // Init();
        }
        private void Init()
        {

            ObjParser objectPar = new ObjParser(filename);

            List<float[]> verticesList = objectPar.Vertices.Select(vertex => new float[] { vertex[0], vertex[1], vertex[2] }).ToList();
            List<int[]> facesList = objectPar.Faces.Select(face => new int[] { face[0], face[1], face[2] }).ToList();
            List<int[]> triangles = objectPar.Faces.Select(face => new int[] { face[0], face[1], face[2] }).ToList();




            /*
            textYrot = Convert.ToInt32(textBox2.Text); 
            textZrot = Convert.ToInt32(textBox3.Text);

            textXtras = Convert.ToInt32(textBox4.Text);
            textYtras = Convert.ToInt32(textBox5.Text);
            textZtras = Convert.ToInt32(textBox6.Text); 
            */

            //tras = new Vertex(textXtras, textYtras, textZtras);

            //val = Mtx.Rotate(rotation);

            //Rasterization raster = new Rasterization(PCT_CANVAS.Size, verticesList, triangles, translateX, translateY, translateZ, z);
            Rasterization raster = new Rasterization(PCT_CANVAS.Size, verticesList, triangles, rotateX, rotateY, rotateZ, translateX, translateY, translateZ, z);


            PCT_CANVAS.Image = raster.Canvas;

            PCT_CANVAS.Invalidate();
        }

        public void OBJ_BTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog newFile = new OpenFileDialog();
            newFile.Filter = "OBJ files (*.obj)|*.obj";

            if (newFile.ShowDialog() == DialogResult.OK)
            {
                filename = newFile.FileName;
                Init();
            }
        }

        public void BTN_EXE_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(filename))
            {
                MessageBox.Show("No file has been selected. Please choose a file");
                OBJ_BTN_Click(sender, e);
            }
            else
            {
                PCT_CANVAS.Invalidate();
                Init();
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            rotateY = trackBar1.Value;
        }


        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            z = trackBar4.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            rotateX = trackBar2.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            rotateZ = trackBar3.Value;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void trackBarTrY_Scroll(object sender, EventArgs e)
        {
            translateY = trackBarTrY.Value;
        }

        private void trackBarTrX_Scroll(object sender, EventArgs e)
        {
            translateX = trackBarTrX.Value;
        }

        private void trackBarTrZ_Scroll(object sender, EventArgs e)
        {
            translateZ = trackBarTrZ.Value;
        }
    }
}