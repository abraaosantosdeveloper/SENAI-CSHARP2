namespace NotePad
{
    public partial class Form1 : Form
    {
        string file_name { get; set; }
        bool controlPressed { get; set; } = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog(this);
            file_name = openFileDialog.FileName;
            if (result == DialogResult.OK)
            {
                string text = File.ReadAllText(file_name);
                textBox1.Text = text;
                label1.Text = file_name;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Text = file_name;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(file_name))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = "txt";
                var result = sfd.ShowDialog(this);
                if (result != DialogResult.OK) return;

                file_name = sfd.FileName;
                if (!File.Exists(file_name)) File.Create(file_name).Close();
            }


            File.WriteAllText(file_name, textBox1.Text);
            MessageBox.Show("Arquivo salvo com sucesso!");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control) this.controlPressed = true;
            else if (e.KeyValue == 'S' & this.controlPressed) this.button2_Click_1(this, e);

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.Control) this.controlPressed = false;

        }


        private string encript(string text)
        {
            string result = "";
            foreach (char c in text)
            {
                result += (char)(c + 4);
            }
            return result;

        }
        private string decript(string text)
        {
            string result = "";
            foreach (char c in text)
            {
                result += (char)(c - 4);
            }
            return result;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = encript(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = decript(textBox1.Text);

        }

    }
}
