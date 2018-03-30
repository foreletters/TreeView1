using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView1
{
    public partial class Form1 : Form
    {
        TreeNode tn1 = new TreeNode();
        TreeNode tn2 = new TreeNode();
        TreeNode tn3 = new TreeNode();
        Stack<KeyValuePair<string, string>> q1 = new Stack<KeyValuePair<string, string>>();
        Stack<KeyValuePair<string, string>> q2 = new Stack<KeyValuePair<string, string>>();
        Stack<KeyValuePair<string, string>> q3 = new Stack<KeyValuePair<string, string>>();
        string topDown = "";
        string bottomUP = "";
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tn1.Text = "Cash";
            tn2.Text = "Fund";
            tn3.Text = "Non-Cash Non-Fund";
            tvListOfAssets.Nodes.Add(tn1);
            tvListOfAssets.Nodes.Add(tn2);
            tvListOfAssets.Nodes.Add(tn3);
            q1.Push(new KeyValuePair<string, string>("Cash", "USD"));
            q1.Push(new KeyValuePair<string, string>("Cash", "GBP"));
            q1.Push(new KeyValuePair<string, string>("Cash", "EUR"));
            q1.Push(new KeyValuePair<string, string>("Non-Cash Non-Fund", "CitiGroup"));
            q1.Push(new KeyValuePair<string, string>("Fund", "GLD"));
            q1.Push(new KeyValuePair<string, string>("Fund", "VIX"));
            q1.Push(new KeyValuePair<string, string>("Fund", "Something Else"));
            q1.Push(new KeyValuePair<string, string>("Non-Cash Non-Fund", "GS"));
            q1.Push(new KeyValuePair<string, string>("Non-Cash Non-Fund", "AMG"));

            q2.Push(new KeyValuePair<string, string>("AMG", "Stock"));
            q2.Push(new KeyValuePair<string, string>("CitiGroup", "Stock"));
            q2.Push(new KeyValuePair<string, string>("VIX", "ADR"));
            q2.Push(new KeyValuePair<string, string>("GBP", "ADR"));

            q3.Push(new KeyValuePair<string, string>("Stock", "Domestic Asset"));
            q3.Push(new KeyValuePair<string, string>("Stock", "Cusip"));
            q3.Push(new KeyValuePair<string, string>("ADR", "Foreign Asset"));
            q3.Push(new KeyValuePair<string, string>("Stock", "Domestic Asset"));
            q3.Push(new KeyValuePair<string, string>("Stock", "Cusip"));
            q3.Push(new KeyValuePair<string, string>("ADR", "Foreign Asset"));

            while (q1.Count > 0)
            {
                foreach (TreeNode node in tvListOfAssets.Nodes)
                {
                    AddAssets(node, q1);
                    
                }
            }
            while(q2.Count>0)
            {
                foreach(TreeNode node in tvListOfAssets.Nodes)
                {
                    foreach(TreeNode tn in node.Nodes)
                    {
                        AddAssets(tn, q2);
                    }
                }
            }
            while(q3.Count>0)
            {
                foreach(TreeNode node in tvListOfAssets.Nodes)
                {
                    foreach(TreeNode tn1 in node.Nodes)
                    {
                        foreach(TreeNode tn2 in tn1.Nodes)
                        {
                            AddAssets(tn2, q3);
                        }
                    }
                }
            }
        }
        private void AddAssets(TreeNode  node, Stack<KeyValuePair<string,string>> q)
        {
            for (int i = 0; i < q.Count; i++)
            {
                KeyValuePair<string, string> kvp = q.Pop();
                if (node.Text == kvp.Key)
                {
                    node.Nodes.Add(kvp.Value);
                }
                else
                {
                    q.Push(kvp);
                }
            }
            
            
        }

        private void btnTopDownExecute_Click(object sender, EventArgs e)
        {
            TopDown(tvListOfAssets.SelectedNode);
            MessageBox.Show(topDown);
            topDown = "";
        }
        private void TopDown(TreeNode node)
        {
            if(node.Nodes.Count>0)
            {
                foreach(TreeNode tn in node.Nodes)
                {
                    topDown = topDown.Length==0?topDown+tn.Text : topDown +", "+ tn.Text;
                    TopDown(tn);
                }
            }
            
        }
        private void BottomUp(TreeNode node)
        {
            bottomUP = bottomUP.Length == 0 ? bottomUP + node.Text : bottomUP + "," + node.Text;
            if (node.Parent != null)
            {
                
                BottomUp(node.Parent);
            }
            
        }

        private void btnBottomUpExecute_Click(object sender, EventArgs e)
        {
            BottomUp(tvListOfAssets.SelectedNode);
            MessageBox.Show(bottomUP);
            bottomUP = "";
        }
    }
}
