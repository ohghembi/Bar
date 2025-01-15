namespace Bar
{
    public partial class Form1 : Form
    {
        private Bar bar;
        public Form1()
        {
            InitializeComponent();
            bar = new Bar(12);
        }

        private void ComunicaAssunzione()
        {
            foreach (Barman barman in bar.Barmans)
            {
                barman.Assumi(bar);
            }
        }
    }
}