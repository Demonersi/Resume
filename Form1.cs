namespace Resume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Form1 form1 = new Form1();
        }

        private void bReady_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.textBox1.Text) && 
                !String.IsNullOrEmpty(this.textBox2.Text) && 
                !String.IsNullOrEmpty(this.textBox3.Text) &&
                 rbMan.Checked||rbWoman.Checked)
            {
                if (!this.lbItog.Items.Contains(this.textBox1.Text) &&
                    !this.lbItog.Items.Contains(this.textBox2.Text) &&
                    !this.lbItog.Items.Contains(this.textBox3.Text))
                {
                    this.lbItog.Items.Add(this.textBox1.Text);
                    this.lbItog.Items.Add(this.textBox2.Text);
                    this.lbItog.Items.Add(this.textBox3.Text);
                    this.lbItog.Items.Add(this.numericUpDown1.Value);
                    if(rbMan.Checked)
                    {
                        this.lbItog.Items.Add(this.rbMan.Text);
                    }
                    else if(rbWoman.Checked)
                    {
                        this.lbItog.Items.Add(this.rbWoman.Text);
                    }
                }
                
                else
                    MessageBox.Show("Вы уже заполнили форму, нажмите \"Очистить\" чтобы ввести заного");
            }
            else
                MessageBox.Show("Вы не до конца всё заполнили!");
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            if (this.lbItog.Items.Contains(this.textBox1.Text) &&
                this.lbItog.Items.Contains(this.textBox2.Text) &&
                this.lbItog.Items.Contains(this.textBox3.Text) &&
                this.lbItog.Items.Contains(this.numericUpDown1.Text) &&
                this.lbItog.Items.Contains(this.rbMan.Text) ||
                this.lbItog.Items.Contains(this.rbWoman.Text))
            {
                MessageBox.Show("В форме нет данных!");
            }
            else
                this.lbItog.Items.Clear();
        }
    }
}