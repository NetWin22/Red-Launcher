using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Configuration;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace RedLauncher
{
    public partial class RedLauncher : Form
    {
        private readonly string SaveFile = Path.Combine(Application.StartupPath, "treeData.json");

        public RedLauncher()
        {
            InitializeComponent();
            this.Load += RedLauncher_Load;
            this.FormClosing += RedLauncher_FormClosing;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK && TreeView1.SelectedNode != null)
            {
                TreeNode newRoot = TreeView1.SelectedNode.Nodes.Add(Path.GetFileName(openFileDialog1.FileName));
                newRoot.Tag = openFileDialog1.FileName;
                newRoot.Parent.Expand();
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (TreeView1.SelectedNode != null)
            {
                TreeView1.SelectedNode.Remove();
            }
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            if (TreeView1.SelectedNode != null)
            {
                object tag = TreeView1.SelectedNode.Tag;
                if (tag != null)
                {
                    try
                    {
                        Process.Start(tag.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error starting the program: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No path found.");
                }
            }
            else
            {
                MessageBox.Show("No selected node.");
            }
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            if (TreeView1.SelectedNode != null)
            {
                string newName = Interaction.InputBox(
                    "Enter new name for the node:",
                    "Rename Node",
                    TreeView1.SelectedNode.Text
                );

                if (!string.IsNullOrWhiteSpace(newName))
                {
                    TreeView1.SelectedNode.Text = newName;
                }
            }
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RedLauncher_Load(object sender, EventArgs e)
        {
            LoadTree(SaveFile);
        }

        private void RedLauncher_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTree(SaveFile);
        }

        public class TreeNodeData
        {
            public string Name { get; set; }
            public string Path { get; set; }
            public List<TreeNodeData> Children { get; set; } = new List<TreeNodeData>();
        }

        private TreeNodeData ConvertNode(TreeNode node)
        {
            var data = new TreeNodeData { Name = node.Text, Path = node.Tag?.ToString() };
            foreach (TreeNode child in node.Nodes)
            {
                data.Children.Add(ConvertNode(child));
            }
            return data;
        }

        private List<TreeNodeData> GetTreeData()
        {
            var list = new List<TreeNodeData>();
            foreach (TreeNode node in TreeView1.Nodes)
            {
                list.Add(ConvertNode(node));
            }
            return list;
        }

        private void SaveTree(string filePath)
        {
            var treeData = GetTreeData();
            var json = JsonSerializer.Serialize(treeData, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        private void LoadTree(string filePath)
        {
            if (!File.Exists(filePath)) return;
            var json = File.ReadAllText(filePath);
            var treeData = JsonSerializer.Deserialize<List<TreeNodeData>>(json);
            TreeView1.Nodes.Clear();
            if (treeData != null)
            {
                foreach (var data in treeData)
                {
                    TreeView1.Nodes.Add(ConvertToTreeNode(data));
                }
            }
        }

        private TreeNode ConvertToTreeNode(TreeNodeData data)
        {
            var node = new TreeNode(data.Name) { Tag = data.Path };
            foreach (var child in data.Children)
            {
                node.Nodes.Add(ConvertToTreeNode(child));
            }
            return node;
        }

        private void GroupBtn_Click(object sender, EventArgs e)
        {
            string newName = Interaction.InputBox(
                "Enter new name for the group:",
                "Name group",
                "Default"
            );

            if (!string.IsNullOrWhiteSpace(newName))
            {
                TreeView1.Nodes.Add(newName);
            }
        }
    }
}
