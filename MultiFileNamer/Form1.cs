using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MultiFileNamer
{
    public partial class SelectorForm : Form
    {
        public SelectorForm()
        {
            InitializeComponent();
            //Populate the File Tree
            PopulateTreeView();
        }


        /// <summary>
        /// Populate the File Tree
        /// </summary>
        private void PopulateTreeView()
        {
            ///For each Drive!
            ///
            string[] drives = Environment.GetLogicalDrives();
            foreach (var drive in drives)
            {


                TreeNode rootNode;

                DirectoryInfo info = new DirectoryInfo(@drive);
                if (info.Exists)
                {
                    rootNode = new TreeNode(info.Name);
                    rootNode.Tag = info;

                    ///Catch errors where a drive is not authorized to be viewed
                    try { 
                        AddDirectoriesSubNodes(info.GetDirectories(), rootNode);
                        FileTreeView.Nodes.Add(rootNode);
                    }
                    catch(System.UnauthorizedAccessException)
                    {


                    }
                }
            }
        }

        /// <summary>
        /// Get The list of directories, output to the array
        /// </summary>
        /// <param name="subDirs">The SubDirectory information from a DirectoryInfo Class's .GetDirectories() call.</param>
        /// <param name="nodeToAddTo">The Node to add a layer to in the tree</param>
        private void AddDirectoriesSubNodes(DirectoryInfo[] subDirs,
   TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            //DirectoryInfo[] subSubDirs;
            ///For each subdirectory, add a node.
            foreach (DirectoryInfo subDir in subDirs)
            {
                try
                {
                    ///Make sure that we don't allow windows folder to be traversed. don't want any naming in there. same with recycle.
                    if (subDir.Name != "Windows")
                    {
                        aNode = new TreeNode(subDir.Name, 0, 0);
                        aNode.Tag = subDir;
                        
                        
                            aNode.ImageKey = "folder.gif";
                            
                        
                        nodeToAddTo.Nodes.Add(aNode);
                    }
                    
                }
                catch (UnauthorizedAccessException)
                {
                    ///Do nothing if unauthorized.
                }
            }
        }
        /// <summary>
        /// Before FileTreeView expands, load the files!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs eSelectedNode)
        {
            Boolean RunDirectory = false;
            foreach(TreeNode childNode in eSelectedNode.Node.Nodes) {
                if (childNode.Nodes.Count == 0) {
                    RunDirectory = true;
                    break;
                }
            }

          

            ///If We need to refresh directories, as (or run for first time)

            if (RunDirectory) {


                ///Each child
                for (int j = eSelectedNode.Node.Nodes.Count - 1; j >= 0; j--)
                {
                    TreeNode childNode = eSelectedNode.Node.Nodes[j];
                    ///Get the name of the child item

                    String Name = "";
                    TreeNode pointer = childNode;

                    do
                    {

                        Name = pointer.Text + "\\" + Name;
                        pointer = pointer.Parent;
                    } while (pointer != null);
                        
                    /// Make sure each child is a folder
                    DirectoryInfo info = new DirectoryInfo(@Name);
                    
                    if (info.Exists)
                    {
                        
                        childNode.Collapse();
                        ///If it's a folder, clear the children.
                        if (childNode.Nodes.Count > 0)
                        {
                            for (int i = childNode.Nodes.Count - 1; i >= 0; i--)
                            {
                                childNode.Nodes[i].Remove();
                            }
                        }

                        ///Add the subdirectories.

                        try
                        {
                            AddDirectoriesSubNodes(info.GetDirectories(), childNode);
                        }
                        catch (UnauthorizedAccessException)
                        {

                        }

                    }
                }
            }


            ///SelectedNode update!
            FileTreeView.SelectedNode = eSelectedNode.Node;


        }


        private void FileTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (FileTreeView.SelectedNode.IsExpanded == false)
            {
                FileTreeView.SelectedNode.Expand();
            }
            
            ListViewBox.Items.Clear();

            String Name = "";
            TreeNode pointer = FileTreeView.SelectedNode;

            do
            {

                Name = pointer.Text + "\\" + Name;
                pointer = pointer.Parent;
            } while (pointer != null);

            /// Make sure each child is a folder
            DirectoryInfo info = new DirectoryInfo(@Name);

            if (info.Exists)
            {




                //Update the FileListBox with items!
                foreach (FileInfo newFile in info.GetFiles())
                {
                    
                        //newItem = new ListViewItem(childNode.Text);
                        ListViewBox.Items.Add(newFile.Name);
                    
                }

            }
        }
    }
}
