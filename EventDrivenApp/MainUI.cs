using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventDrivenApp
{
    public partial class MainUI : Form
    {
        private Container _container = null;
        public MainUI()
        {
            InitializeComponent();
            LayoutMdi(MdiLayout.TileHorizontal);
            InputUI inputUI = new InputUI();
            _container = inputUI.Container;
            inputUI.MdiParent = this;
            inputUI.Show();

            ViewDetailsUI viewDetailsUI = new ViewDetailsUI(_container);
            viewDetailsUI.MdiParent = this;
            viewDetailsUI.Show();

            ViewTotalUI viewTotalUI = new ViewTotalUI(_container);
            viewTotalUI.MdiParent = this;
            viewTotalUI.Show();

            Form[] charr = this.MdiChildren;

            //For each child form set the window state to Maximized 
            //foreach (Form chform in charr)
                //chform.WindowState = FormWindowState.Maximized;
        }
    }
}
