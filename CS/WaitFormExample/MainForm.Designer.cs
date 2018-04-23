namespace WaitFormExample {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.sucA = new WaitFormExample.SampleUserControl();
            this.sucB = new WaitFormExample.SampleUserControl();
            this.sucC = new WaitFormExample.SampleUserControl();
            this.sucD = new WaitFormExample.SampleUserControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbD = new DevExpress.XtraEditors.SimpleButton();
            this.sbC = new DevExpress.XtraEditors.SimpleButton();
            this.sbB = new DevExpress.XtraEditors.SimpleButton();
            this.sbA = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sucA
            // 
            this.sucA.Caption = "Sample User Control A";
            this.sucA.Dock = System.Windows.Forms.DockStyle.Top;
            this.sucA.Location = new System.Drawing.Point(0, 51);
            this.sucA.Name = "sucA";
            this.sucA.Size = new System.Drawing.Size(455, 128);
            this.sucA.TabIndex = 0;
            // 
            // sucB
            // 
            this.sucB.Caption = "Sample User Control B";
            this.sucB.Dock = System.Windows.Forms.DockStyle.Right;
            this.sucB.Location = new System.Drawing.Point(276, 179);
            this.sucB.Name = "sucB";
            this.sucB.Size = new System.Drawing.Size(179, 244);
            this.sucB.TabIndex = 1;
            // 
            // sucC
            // 
            this.sucC.Caption = "Sample User Control C";
            this.sucC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sucC.Location = new System.Drawing.Point(0, 308);
            this.sucC.Name = "sucC";
            this.sucC.Size = new System.Drawing.Size(276, 115);
            this.sucC.TabIndex = 2;
            // 
            // sucD
            // 
            this.sucD.Caption = "Sample User Control D";
            this.sucD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sucD.Location = new System.Drawing.Point(0, 179);
            this.sucD.Name = "sucD";
            this.sucD.Size = new System.Drawing.Size(276, 129);
            this.sucD.TabIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbD);
            this.panelControl1.Controls.Add(this.sbC);
            this.panelControl1.Controls.Add(this.sbB);
            this.panelControl1.Controls.Add(this.sbA);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(455, 51);
            this.panelControl1.TabIndex = 4;
            // 
            // sbD
            // 
            this.sbD.Location = new System.Drawing.Point(334, 13);
            this.sbD.Name = "sbD";
            this.sbD.Size = new System.Drawing.Size(109, 23);
            this.sbD.TabIndex = 3;
            this.sbD.Tag = "";
            this.sbD.Text = "Show Wait Form &D";
            this.sbD.Click += new System.EventHandler(this.OnShowWaitFormButtonClick);
            // 
            // sbC
            // 
            this.sbC.Location = new System.Drawing.Point(225, 13);
            this.sbC.Name = "sbC";
            this.sbC.Size = new System.Drawing.Size(103, 23);
            this.sbC.TabIndex = 2;
            this.sbC.Tag = "";
            this.sbC.Text = "Show Wait Form &C";
            this.sbC.Click += new System.EventHandler(this.OnShowWaitFormButtonClick);
            // 
            // sbB
            // 
            this.sbB.Location = new System.Drawing.Point(118, 13);
            this.sbB.Name = "sbB";
            this.sbB.Size = new System.Drawing.Size(101, 23);
            this.sbB.TabIndex = 1;
            this.sbB.Tag = "";
            this.sbB.Text = "Show Wait Form &B";
            this.sbB.Click += new System.EventHandler(this.OnShowWaitFormButtonClick);
            // 
            // sbA
            // 
            this.sbA.Location = new System.Drawing.Point(13, 13);
            this.sbA.Name = "sbA";
            this.sbA.Size = new System.Drawing.Size(99, 23);
            this.sbA.TabIndex = 0;
            this.sbA.Tag = "";
            this.sbA.Text = "Show Wait Form &A";
            this.sbA.Click += new System.EventHandler(this.OnShowWaitFormButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 423);
            this.Controls.Add(this.sucD);
            this.Controls.Add(this.sucC);
            this.Controls.Add(this.sucB);
            this.Controls.Add(this.sucA);
            this.Controls.Add(this.panelControl1);
            this.Name = "MainForm";
            this.Text = "DX Sample";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SampleUserControl sucA;
        private SampleUserControl sucB;
        private SampleUserControl sucC;
        private SampleUserControl sucD;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbD;
        private DevExpress.XtraEditors.SimpleButton sbC;
        private DevExpress.XtraEditors.SimpleButton sbB;
        private DevExpress.XtraEditors.SimpleButton sbA;

    }
}

