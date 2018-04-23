using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections.Generic;

namespace WaitFormExample {
    public sealed partial  class MainForm :XtraForm {
        public MainForm() {
            InitializeComponent();
        }

        void OnShowWaitFormButtonClick(object sender, EventArgs e) {
            switch (((Control)sender).Name) {
                case "sbA":
                    sucA.StartLengthyOperation();
                    break;
                case "sbB":
                    sucB.StartLengthyOperation();
                    break;
                case "sbC":
                    sucC.StartLengthyOperation();
                    break;
                case "sbD":
                    sucD.StartLengthyOperation();
                    break;
            }
        }
    }
}
