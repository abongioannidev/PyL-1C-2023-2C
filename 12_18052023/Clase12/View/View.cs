namespace View
{
    public partial class View<T> : Form 
        where T : class
    {
        public View()
        {
            InitializeComponent();
            int y = 0;
            foreach (var propiedad in typeof(T).GetProperties())
            {
                Label label = new Label();
                label.Name = propiedad.Name;
                label.Text = propiedad.Name + ":";
                label.Location = new Point(0, y);
                this.Controls.Add(label);
                y += 20;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}