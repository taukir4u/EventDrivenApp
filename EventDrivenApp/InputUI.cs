using System;
using System.Windows.Forms;

namespace EventDrivenApp
{
    public partial class InputUI : Form
    {
        public Container Container { set; get; }

        public InputUI()
        {
            InitializeComponent();
            this.Container = new Container();
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            Container.Add(nameTextBox.Text);
            nameTextBox.Text = string.Empty;
        }
    }
}
