using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{ 

    public partial class Form1 : Form
    {
        List<Image> my_images = new();
        int current_image_index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            my_images.Add(Properties.Resources.image_1);
            my_images.Add(Properties.Resources.image_2);
            my_images.Add(Properties.Resources.image_3);

            pictureBox1.Image = my_images[current_image_index];
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {

            current_image_index--;

            if (current_image_index < 0)
                current_image_index = my_images.Count() - 1;

            pictureBox1.Image = my_images[current_image_index];

            
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            current_image_index++;

            if (current_image_index > my_images.Count() - 1)
                current_image_index = 0;

            pictureBox1.Image = my_images[current_image_index];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open the image from file
                //add image to array
                my_images.Add(Image.FromFile(openFileDialog1.FileName));
            }
        }
    }
}
