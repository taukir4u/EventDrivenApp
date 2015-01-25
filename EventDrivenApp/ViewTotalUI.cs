using System;
using System.Windows.Forms;

namespace EventDrivenApp
{
    public partial class ViewTotalUI : Form
    {
        private Container aContainer;
        public ViewTotalUI(Container aContainer)
        {
            InitializeComponent();
            this.aContainer = aContainer;
            aContainer.AfterAddedEvent += ShowNumberOfPeople;
            aContainer.AfterRemovedEvent += ShowNumberOfPeople;
            DisplayTotal();
        }

        public void ShowNumberOfPeople(object obj, EventArgs eventArgs)
        {
            DisplayTotal();
        }

        private void DisplayTotal()
        {
            peopleInRepoLabel.Text = aContainer.Count().ToString() + " People";
        }
    }
}
