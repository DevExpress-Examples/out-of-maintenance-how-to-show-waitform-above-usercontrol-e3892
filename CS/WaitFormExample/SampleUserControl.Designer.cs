namespace WaitFormExample {
    public partial class SampleUserControl {
        void InitializeComponent() {
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.GroupControl = new DevExpress.XtraEditors.GroupControl();
            this.WaitTimer = new System.Windows.Forms.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl)).BeginInit();
            this.GroupControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(43, 24);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(43, 50);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 1;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(43, 75);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(100, 20);
            this.textEdit3.TabIndex = 2;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(43, 101);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(100, 20);
            this.textEdit4.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Field A";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Field B";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Field C";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 104);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Field D";
            // 
            // GroupControl
            // 
            this.GroupControl.Controls.Add(this.labelControl1);
            this.GroupControl.Controls.Add(this.labelControl4);
            this.GroupControl.Controls.Add(this.textEdit1);
            this.GroupControl.Controls.Add(this.labelControl3);
            this.GroupControl.Controls.Add(this.textEdit2);
            this.GroupControl.Controls.Add(this.labelControl2);
            this.GroupControl.Controls.Add(this.textEdit3);
            this.GroupControl.Controls.Add(this.textEdit4);
            this.GroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl.Location = new System.Drawing.Point(0, 0);
            this.GroupControl.Name = "GroupControl";
            this.GroupControl.Size = new System.Drawing.Size(150, 127);
            this.GroupControl.TabIndex = 8;
            this.GroupControl.Text = "Sample User Control";
            // 
            // WaitTimer
            // 
            this.WaitTimer.Interval = 5000;
            this.WaitTimer.Tick += new System.EventHandler(this.OnWaitTimerTick);
            // 
            // SampleUserControl
            // 
            this.Controls.Add(this.GroupControl);
            this.Name = "SampleUserControl";
            this.Size = new System.Drawing.Size(150, 127);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl)).EndInit();
            this.GroupControl.ResumeLayout(false);
            this.GroupControl.PerformLayout();
            this.ResumeLayout(false);

        }

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl GroupControl;
        private System.Windows.Forms.Timer WaitTimer;
    }
}
