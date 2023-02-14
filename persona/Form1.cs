using Microsoft.VisualBasic;
namespace persona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        persona persona1 = new persona();
        contacto contacto1 = new contacto();
        
        private void button1_Click(object sender, EventArgs e)
        {
            persona1 = new persona();
            persona1.Name = textBox1.Text;
            persona1.App = textBox2.Text;
            persona1.Apm = textBox3.Text;
            persona1.Fech = dateTimePicker1.Value;
            MessageBox.Show(persona1.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            textBox5.Visible = true;
            
            label6.Visible = false; 
            label7.Visible = false;
            textBox6.Visible = false;
            textBox7 .Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            textBox5.Visible = false;

            label6.Visible = true;
            label7.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contacto1.Name = textBox1.Text;
            contacto1.App = textBox2.Text;
            contacto1.Apm = textBox3.Text;
            contacto1.Fech = dateTimePicker1.Value;
            contacto1.Correo = textBox6.Text;
            contacto1.Numtel = textBox7.Text;


        }
    }
}