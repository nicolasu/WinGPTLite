using System;
using System.Windows.Forms;

namespace WinGPTLite
{
    public class MainForm : Form
    {
        private Button helloButton;

        public MainForm()
        {
            Text = "WinGPTLite - Hello World";
            Width = 400;
            Height = 200;

            helloButton = new Button();
            helloButton.Text = "Dire Bonjour";
            helloButton.Width = 120;
            helloButton.Height = 40;
            helloButton.Top = 60;
            helloButton.Left = (ClientSize.Width - helloButton.Width) / 2;
            helloButton.Anchor = AnchorStyles.None;

            helloButton.Click += (sender, e) =>
            {
                MessageBox.Show("Bonjour depuis WinGPTLite !");
            };

            Controls.Add(helloButton);
        }
    }
}
