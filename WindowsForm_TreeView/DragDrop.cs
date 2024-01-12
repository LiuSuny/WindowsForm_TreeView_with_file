using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_TreeView
{
    public partial class DragDrop : Form
    {
        public DragDrop()
        {
            InitializeComponent();
        }

       
        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            labelName.Text = "Drop file here";

            List<string> path = new List<string>();
            foreach (string file in (string[])e.Data.GetData(DataFormats.FileDrop))
                //File.Delete(file); //if at a point  we want to delete our drag file 
                //  richTextBox1.Text += file + "\n"; //Added file to our treeView
                //Next we try to check inside our file folder if the drag and drop folder contain internal file and if at all such file exist 
                if (Directory.Exists(file))
                    path.AddRange(Directory.GetFiles(file, ".", SearchOption.AllDirectories));                 
                else
                    path.Add(file);
            richTextBox1.Text = string.Join("\r\n", path);
                    
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                labelName.Text = "Release mouse to drop the file";
                e.Effect = DragDropEffects.Copy;
            }
            //else
            //{
            //    e.Effect = DragDropEffects.None;
            //}
        }

        private void treeView1_DragLeave(object sender, EventArgs e)
        {
            labelName.Text = " Drop file here";
        }

       //Another second method of using drag and drop 
        private void labelName_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Enter the file you want to drag and drop";
            file.InitialDirectory = @"C:\User\Admin\Desktop";
            if (file.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = file.FileName;
            }
        }


       
    }
}
