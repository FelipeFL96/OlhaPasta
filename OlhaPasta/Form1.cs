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

namespace OlhaPasta
{
    public partial class OlhaPastaForm : Form
    {
        int maxLevel = 3;

        public OlhaPastaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBoxMaxLevel.Checked = false;
            labelMaxLevel.Enabled = false;
            textBoxMaxLevel.Enabled = false;
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            if (checkBoxMaxLevel.Checked)
            {
                try
                {
                    maxLevel = Convert.ToInt32(textBoxMaxLevel.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Valor de profundidade máxima é inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Valor de profundidade máxima muito alto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
            try
            {
                DirectoryInfo dir = new DirectoryInfo(textBoxRootDirectory.Text);

                treeViewResult.Nodes.Clear();
                treeViewResult.BeginUpdate();
                treeViewResult.Nodes.Add(dir.Name + " [ " + ComputeSize(dir) + " ]");

                SearchDirectory(dir, 1, treeViewResult.Nodes[0]);

                treeViewResult.EndUpdate();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Caminho inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SearchDirectory(DirectoryInfo directory, int level, TreeNode node)
        {
            if (checkBoxMaxLevel.Checked && level > maxLevel)
                return;

            string log = "";
            int index = 0;
            foreach (var dir in directory.EnumerateDirectories())
            {
                try
                {
                    node.Nodes.Add(dir.Name + " [ " + ComputeSize(dir) + " ]");
                    SearchDirectory(dir, level + 1, node.Nodes[index]);
                    index++;
                }
                catch (UnauthorizedAccessException error)
                {
                    log += error.Message;
                }
            }
        }

        private int ComputeSize(DirectoryInfo directory)
        {
            if (checkBoxItemType.Checked)
            {
                return (directory.EnumerateFiles().Count());
            }
            else
            {
                return (directory.EnumerateDirectories().Count() + directory.EnumerateFiles().Count());
            }
        }

        private void checkBoxMaxLevel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMaxLevel.Checked)
            {
                labelMaxLevel.Enabled = true;
                textBoxMaxLevel.Enabled = true;
            }
            else
            {
                labelMaxLevel.Enabled = false;
                textBoxMaxLevel.Enabled = false;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            treeViewResult.Nodes.Clear();
        }
    }
}
