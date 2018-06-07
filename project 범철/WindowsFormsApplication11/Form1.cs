using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;


namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /*
            //
            // Create a VideoDrawing.
            //      
            MediaPlayer player = new MediaPlayer();

            player.Open(new Uri(@"mcdonald.mp4", UriKind.Relative));

            VideoDrawing aVideoDrawing = new VideoDrawing();

            aVideoDrawing.Rect = new Rect(0, 0, 100, 100);

            aVideoDrawing.Player = player;

            // Play the video once.
            player.Play();
            */
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog(this);
        }


        private void 범철s25_Click(object sender, EventArgs e)
        {

        }
    }
}
