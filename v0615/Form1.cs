using System.Runtime.Intrinsics.X86;

namespace v0615
{
    public partial class Form1 : Form
    {
        static int ChrMax => 100;
        static int Speed => 10;
        static Random rand = new Random();
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];
        Label[] labels = new Label[ChrMax];


        public Form1()
        {
            InitializeComponent();

           
            for (int i = 0; i < ChrMax; i++)
            {
                vx[i] = rand.Next(-10, 10);
                vy[i] = rand.Next(-10, 10);

                labels[i] = new Label();
                labels[i].Text = "ž";
                labels[i].AutoSize = true;
                Controls.Add(labels[i]);

                labels[i].Left = rand.Next(ClientSize.Width - labels[i].Width);
                labels[i].Top = rand.Next(ClientSize.Height - labels[i].Height);

                
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < ChrMax; i++)
            {
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];
                if (labels[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                else if (labels[i].Right > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (labels[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                else if (labels[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            for (; a < 10; a++)
            {
                if (a == 2)
                {
                    continue;
                }
                if (a == 5)
                {
                    break;
                }
                MessageBox.Show($"{a}");
            }

            MessageBox.Show($"done {a}");
        }
    }
}