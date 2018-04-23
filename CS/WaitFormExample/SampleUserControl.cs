using System;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.XtraEditors;
using WaitFormExample.WaitForm;

namespace WaitFormExample {
    public partial class SampleUserControl :XtraUserControl {
        const string DefaultCaption = "Sample User Control";

        public SampleUserControl() {
            InitializeComponent();
            GroupControl.Text = DefaultCaption;
        }

        [DefaultValue(DefaultCaption)]
        public string Caption {
            get { return GroupControl.Text; }
            set { GroupControl.Text = value; }
        }

        void OnWaitTimerTick(object sender, EventArgs e) {
            WaitTimer.Stop();
            this.HideWaitForm();
        }

        public void StartLengthyOperation() {
            if (WaitTimer.Enabled) return;
            this.ShowWaitForm();
            WaitTimer.Start();
        }
    }
}
