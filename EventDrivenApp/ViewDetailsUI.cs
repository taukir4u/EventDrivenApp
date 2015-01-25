using System;
using System.Windows.Forms;

namespace EventDrivenApp
{
    public partial class ViewDetailsUI : Form
    {
        private Container aContainer;
        public ViewDetailsUI(Container aContainer)
        {
            InitializeComponent();
            this.aContainer = aContainer;
            aContainer.AfterAddedEvent += ItemAddedInRepo;
            aContainer.AfterRemovedEvent += ItemAddedInRepo;
        }

        private void ViewDetailsUI_Load(object sender, EventArgs e)
        {
            DisplayItems();
        }

        public void ItemAddedInRepo(object obj, EventArgs eventArgs)
        {
            DisplayItems();
        }

        private void DisplayItems()
        {
            itemListBox.Items.Clear();
            if (aContainer != null)
            {
                foreach (string item in aContainer.GetItems())
                {
                    itemListBox.Items.Add(item);
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            aContainer.Remove(itemListBox.SelectedIndex);
        }
    }
}
