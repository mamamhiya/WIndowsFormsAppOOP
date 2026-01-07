namespace WIndowsFormsAppOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextShape triangel = new TextShape();
            triangel.DrawTriangle(9,"X");
            textBox1.Text = triangel.result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextShape rectangle = new TextShape(5,5,"O");
            rectangle.DrawRectangle();
            textBox1.Text = rectangle.result;
        }
    }
}
