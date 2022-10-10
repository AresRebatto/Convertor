namespace Convertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1_TextChanged != null)
            {
                long BinContenute = Convert.ToInt32(InputBoxBin.Text);
                long position = 0;
                Console.WriteLine("Valore inserito in Bin");
                long DecValue = 0;
                long basen = 2;

                while (BinContenute > 0)
                {
                    long weight = Math.Pow(Convert.ToDouble(basen, position)); //Errore= Argomento 2; Non è possibile convertire da 'long' a 'System.IFormatProvider?'
                    if (BinContenute%2==1)
                    { 
                        DecValue = DecValue + (weight * 1);
                        Console.WriteLine("La posizione: " + position);
                        position++;
                    }
                    if (BinContenute%2==0)
                    {
                        Console.WriteLine("La posizione: " + position);
                        position++;
                    }
                    Console.WriteLine("Il peso: " + weight);
                    BinContenute /= 10;

                    
                }
                InputBoxDec.Text = Convert.ToString(DecValue);

            }
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}