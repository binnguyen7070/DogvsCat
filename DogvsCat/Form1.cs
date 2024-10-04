namespace DogvsCat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal[] animals = new Animal[3];
            animals[0] = new Cat();
            animals[1] = new Dog();
            animals[2] = new Bird();
            foreach (Animal a in animals)

            {
                Ilive b = a as Ilive;
                if (b != null)
                    MessageBox.Show(b.BabyCalled());

            }


        }
    }

}