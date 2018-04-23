using System;
using System.Drawing;

namespace WaitFormExample.WaitForm {
    public partial class UserControlWaitForm :DevExpress.XtraWaitForm.WaitForm {
        public UserControlWaitForm() {
            InitializeComponent();
        }

        public override void ProcessCommand(Enum cmd, object arg) {
            if (((UserControlWaitFormCommand)cmd) == UserControlWaitFormCommand.SetSize)
                Size = (Size)arg;
        }
    }
}
