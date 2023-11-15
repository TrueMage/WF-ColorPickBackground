using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WF_ColorPickBackground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();


            if (cd.ShowDialog() == DialogResult.OK)
                BackColor = cd.Color;
        }
    }
}