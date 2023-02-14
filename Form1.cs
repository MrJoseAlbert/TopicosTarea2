namespace AplicacionGato
{
    public partial class frmcvja : Form
    {
        public frmcvja()
        {
            InitializeComponent();
        }
        int [] pos = {3,3,3,3,3,3,3,3,3,3};
        int turno = 0;
        private void btncvja1_Click(object sender, EventArgs e)
        {
            if (pos[1]==3)
            {
                btncvja1.Text = "O";
                turno = 1;
                pbcvja.Image = Properties.Resources.Equis;
                btncvja1.BackgroundImage = Properties.Resources.Equis;
                btncvja1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                btncvja1.Text="X";
                turno = 0;
                pbcvja.Image = Properties.Resources.circulo;
                btncvja1.BackgroundImage = Properties.Resources.circulo;
                btncvja1.BackgroundImageLayout = ImageLayout.Stretch;
                pos[1] = 1;
            }
        }

        public void Ganar()
        {
            if (pos[1] == pos[2]&& pos[1] == pos[3] || pos[1] == pos[4])
            {

            }
        }

        private void btncvja2_Click(object sender, EventArgs e)
        {

        }

        private void btncvja3_Click(object sender, EventArgs e)
        {

        }

        private void btncvja4_Click(object sender, EventArgs e)
        {

        }

        private void btncvja5_Click(object sender, EventArgs e)
        {

        }

        private void btncvja6_Click(object sender, EventArgs e)
        {

        }

        private void btncvja7_Click(object sender, EventArgs e)
        {

        }

        private void btncvja8_Click(object sender, EventArgs e)
        {

        }

        private void btncvja9_Click(object sender, EventArgs e)
        {

        }
    }
}