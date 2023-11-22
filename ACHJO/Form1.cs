using RetezecUtil;
namespace ACHJO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            text = text.Replace("  ", " ");
            Class1 instance = new Class1();

            if (instance.ObsahujeSlovo(text) == true)
            {
                MessageBox.Show("obsahuje slovo");
            }else
            {
                MessageBox.Show("neobsahuje slovo");
            }

            string neco = instance.nejdelsinejmensi(text);
            MessageBox.Show(neco);
        }
    }
}