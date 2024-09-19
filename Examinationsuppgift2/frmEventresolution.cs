using Examinationsuppgift2.EntityClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examinationsuppgift2
{
    public partial class frmEventresolution : Form
    {
        public frmEventresolution(Player player)
        {
            InitializeComponent();
            richTextBoxEventMessage.Text = player.EventMessage;
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmEventresolution));
            buttonOk = new Button();
            richTextBoxEventMessage = new RichTextBox();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.BackgroundImage = (Image)resources.GetObject("buttonOk.BackgroundImage");
            buttonOk.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOk.Location = new Point(166, 329);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(129, 123);
            buttonOk.TabIndex = 0;
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // richTextBoxEventMessage
            // 
            richTextBoxEventMessage.Font = new Font("Segoe UI", 12F);
            richTextBoxEventMessage.Location = new Point(89, 48);
            richTextBoxEventMessage.Name = "richTextBoxEventMessage";
            richTextBoxEventMessage.Size = new Size(291, 55);
            richTextBoxEventMessage.TabIndex = 1;
            richTextBoxEventMessage.Text = "";
            // 
            // frmEventresolution
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(465, 464);
            Controls.Add(richTextBoxEventMessage);
            Controls.Add(buttonOk);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEventresolution";
            ResumeLayout(false);
        }

        private Button buttonOk;
        private RichTextBox richTextBoxEventMessage;

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
