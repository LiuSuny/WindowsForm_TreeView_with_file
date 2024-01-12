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
    public partial class Form1 : Form
    {

        DirectoryInfo currentDirectory;
        public Form1()
        {
            new DragDrop().Show();
            new AddMoreFilesDrop().Show();
            InitializeComponent();
            currentDirectory = new DirectoryInfo(@"C://");
        }


        void addNodes(TreeNode node, DirectoryInfo currentDirectory)
        {
            DirectoryInfo[] innerDirectories
                = currentDirectory.GetDirectories();
            foreach (DirectoryInfo innerDir in innerDirectories)
            {
                node.Nodes.Add(
                    new TreeNode(innerDir.Name)
                );
            }
        }

        void addNodes(
            System.Windows.Forms.TreeView node,
            DirectoryInfo currentDirectory
        )
        {
            DirectoryInfo[] innerDirectories
                = currentDirectory.GetDirectories();
            foreach (DirectoryInfo innerDir in innerDirectories)
            {
                node.Nodes.Add(
                    new TreeNode(innerDir.Name)
                );
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addNodes(fileManager, currentDirectory);
        }



        //private void treeView1_NodeMouseClick(object sender,
        //    TreeNodeMouseClickEventArgs e)
        //{
        //    string nodeFullPath = e.Node.FullPath.Replace("\\\\", "//");
        //    DirectoryInfo directory
        //        = new DirectoryInfo($@"C://{nodeFullPath}");


        //    addNodes(e.Node, directory);
        //    e.Node.Toggle();

        //}

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string nodeFullPath = e.Node.FullPath.Replace("\\\\", "//");
            DirectoryInfo directory
                = new DirectoryInfo($@"C://{nodeFullPath}");
            e.Node.Collapse(true);

            addNodes(e.Node, directory);
            e.Node.Toggle();
        }
    }
}
