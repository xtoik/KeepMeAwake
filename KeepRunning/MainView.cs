using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeepMeAwake
{
    public partial class MainView : Form
    {
        private uint m_previousExecutionState;

        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            m_previousExecutionState = NativeMethods.SetThreadExecutionState(
            NativeMethods.ES_CONTINUOUS | NativeMethods.ES_SYSTEM_REQUIRED);
            if (0 == m_previousExecutionState)
            {
                MessageBox.Show("Call to SetThreadExecutionState failed unexpectedly.");
                // No way to recover; fail gracefully
                Close();
            }
        }

        internal static class NativeMethods
        {
            // Import SetThreadExecutionState Win32 API and necessary flags
            [DllImport("kernel32.dll")]
            public static extern uint SetThreadExecutionState(uint esFlags);
            public const uint ES_CONTINUOUS = 0x80000000;
            public const uint ES_SYSTEM_REQUIRED = 0x00000001;
        }

        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Restore previous state
            if (0 == NativeMethods.SetThreadExecutionState(m_previousExecutionState))
            {
                // No way to recover; already exiting
            }
        }

        private void MainView_Resize(object sender, EventArgs e)
        {
            nicMain.Visible = WindowState == FormWindowState.Minimized;
            ShowInTaskbar = WindowState != FormWindowState.Minimized;
            if (WindowState == FormWindowState.Minimized)
            {
                nicMain.ShowBalloonTip(3000);
            }
        }

        private void nicMain_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void nicMainContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == nicMainCtxMenuItemShow)
            {
                WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem == nicMainCtxMenuItemExit)
            {
                Close();
            }
        }
    }
}
