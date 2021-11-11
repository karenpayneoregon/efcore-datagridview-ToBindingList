using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontendApplication
{
    public partial class DebugViewForm : Form
    {
        private string _content;

        public DebugViewForm()
        {
            InitializeComponent();
        }
        public DebugViewForm(string title, string content)
        {
            InitializeComponent();

            Text = title;

            _content = content;
            
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            textBox1.Text = string.IsNullOrWhiteSpace(_content) ? "No changes" : _content;
        }
    }
}
