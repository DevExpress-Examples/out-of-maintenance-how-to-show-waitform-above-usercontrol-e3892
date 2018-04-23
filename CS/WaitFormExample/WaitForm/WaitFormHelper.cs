using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraSplashScreen;

namespace WaitFormExample.WaitForm {
    public static class WaitFormHelper {
        static Dictionary<Control, SplashScreenManager> Managers = new Dictionary<Control, SplashScreenManager>();

        public static void ShowWaitForm(this UserControl owner) {
            if (Managers.ContainsKey(owner)) return;
            SplashScreenManager manager = new SplashScreenManager(typeof(UserControlWaitForm),
                SplashFormStartPosition.Manual, owner.Parent.PointToScreen(owner.Location),
                new SplashFormProperties());
            Managers.Add(owner, manager);
            manager.ShowWaitForm();
            manager.SendCommand(UserControlWaitFormCommand.SetSize, owner.Size);
        }

        public static void HideWaitForm(this Control owner) {
            if (!Managers.ContainsKey(owner)) return;
            SplashScreenManager manager = Managers[owner];
            Managers.Remove(owner);
            try {
                manager.CloseWaitForm();
            } finally {
                manager.Dispose();
            }
        }
    }
}
