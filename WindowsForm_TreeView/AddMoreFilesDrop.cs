using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_TreeView
{
    public partial class AddMoreFilesDrop : Form
    {
        public AddMoreFilesDrop()
        {
            InitializeComponent();
        }
        Button button;
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            button = new Button();
            button.Text = e.Node.Name;
            button.Location = e.Location;
            this.Controls.Add(button);
            this.MouseMove += MouseMoveButton;
            this.MouseUp += MouseUpButton;
        }

        private void MouseUpButton(object sender, MouseEventArgs e)
        {
            this.MouseMove -= MouseMoveButton;
            this.MouseUp -= MouseUpButton;
        }
        private void MouseMoveButton(object sender, MouseEventArgs e)
        {                        
            button.Location = e.Location;           
        }
    }
}
