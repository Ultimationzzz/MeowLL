using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeowLL.Helpers;
using MeowLL.MeowFace;

namespace MeowLL
{
    public partial class MainForm : Form
    {
        public MeowPipe Pipe { get; set; }
        public MainForm()
        {
            InitializeComponent();
            Pipe = new MeowPipe();
            listenIpInput.Items.AddRange(NetworkHelper.GetInterfaceAddresses());
            if (listenIpInput.Items.Count > 0)
            {
                listenIpInput.SelectedIndex = 0;
            }
            Settings.Load();
            var idx = listenIpInput.Items.IndexOf(Settings.Instance.MeowListenIp);
            if (idx > -1)
                listenIpInput.SelectedIndex = idx;
            listenPortInput.Value = Settings.Instance.MeowListenPort;
            sendIpInput.Text = Settings.Instance.LiveLinkIp;
            sendPortInput.Value = Settings.Instance.LiveLinkPort;
            phoneIpInput.Text = Settings.Instance.PhoneIp;
            trackFacialCheckbox.Checked = Settings.Instance.TrackFacial;
            trackHeadCheckbox.Checked = Settings.Instance.TrackHead;
        }

        private void listenIpInput_SelectedValueChanged(object sender, EventArgs e)
        {
            Settings.Instance.MeowListenIp = Pipe.ListenIp = listenIpInput.Text;
        }

        private void phoneIpInput_TextChanged(object sender, EventArgs e)
        {
            Settings.Instance.PhoneIp = Pipe.PhoneIp = phoneIpInput.Text;
        }

        private void listenPortInput_ValueChanged(object sender, EventArgs e)
        {
            Settings.Instance.MeowListenPort=Pipe.ListenPort = (int)listenPortInput.Value;
        }

        private void sendIpInput_TextChanged(object sender, EventArgs e)
        {
            Settings.Instance.LiveLinkIp=Pipe.SendIp = sendIpInput.Text;
        }

        private void sendPortInput_ValueChanged(object sender, EventArgs e)
        {
            Settings.Instance.LiveLinkPort = Pipe.SendPort = (int)sendPortInput.Value;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!Pipe.Active)
            {
                Settings.Save();
                Pipe.Start();
                lookForwardButton.Enabled = true;
                startButton.Text = "Stop";
            }
            else
            {
                lookForwardButton.Enabled = false;
                Pipe.End();
                startButton.Text = "Start";
            }
        }

        private void lookForwardButton_Click(object sender, EventArgs e)
        {
            if (Pipe.Active)
                Pipe.LookForward();
        }

        private void trackFacialCheckbox_CheckedChanged(object sender, EventArgs e)
        {
           Settings.Instance.TrackFacial= Pipe.TrackExpression = trackFacialCheckbox.Checked;
        }

        private void trackHeadCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Instance.TrackHead = Pipe.TrackRotation=trackHeadCheckbox.Checked;
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            var about = new AboutForm();
            about.ShowDialog();
        }
    }
}
