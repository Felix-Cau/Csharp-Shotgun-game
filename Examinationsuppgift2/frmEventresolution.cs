using Examinationsuppgift2.EntityClasses;
using System.ComponentModel;

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
            buttonOk.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOk.Font = new Font("Segoe UI", 18F);
            buttonOk.Location = new Point(348, 388);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(77, 55);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "OK!";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // richTextBoxEventMessage
            // 
            richTextBoxEventMessage.Font = new Font("Segoe UI", 12F);
            richTextBoxEventMessage.Location = new Point(51, 388);
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
