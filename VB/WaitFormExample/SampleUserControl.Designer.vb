Imports Microsoft.VisualBasic
Imports System
Namespace WaitFormExample
	Partial Public Class SampleUserControl
		Private Sub InitializeComponent()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit3 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit4 = New DevExpress.XtraEditors.TextEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.GroupControl = New DevExpress.XtraEditors.GroupControl()
			Me.WaitTimer = New System.Windows.Forms.Timer()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.GroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupControl.SuspendLayout()
			Me.SuspendLayout()
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(43, 24)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(100, 20)
			Me.textEdit1.TabIndex = 0
			' 
			' textEdit2
			' 
			Me.textEdit2.Location = New System.Drawing.Point(43, 50)
			Me.textEdit2.Name = "textEdit2"
			Me.textEdit2.Size = New System.Drawing.Size(100, 20)
			Me.textEdit2.TabIndex = 1
			' 
			' textEdit3
			' 
			Me.textEdit3.Location = New System.Drawing.Point(43, 75)
			Me.textEdit3.Name = "textEdit3"
			Me.textEdit3.Size = New System.Drawing.Size(100, 20)
			Me.textEdit3.TabIndex = 2
			' 
			' textEdit4
			' 
			Me.textEdit4.Location = New System.Drawing.Point(43, 101)
			Me.textEdit4.Name = "textEdit4"
			Me.textEdit4.Size = New System.Drawing.Size(100, 20)
			Me.textEdit4.TabIndex = 3
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(6, 27)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(32, 13)
			Me.labelControl1.TabIndex = 4
			Me.labelControl1.Text = "Field A"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(6, 53)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(31, 13)
			Me.labelControl2.TabIndex = 5
			Me.labelControl2.Text = "Field B"
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(6, 78)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(32, 13)
			Me.labelControl3.TabIndex = 6
			Me.labelControl3.Text = "Field C"
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(6, 104)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(32, 13)
			Me.labelControl4.TabIndex = 7
			Me.labelControl4.Text = "Field D"
			' 
			' GroupControl
			' 
			Me.GroupControl.Controls.Add(Me.labelControl1)
			Me.GroupControl.Controls.Add(Me.labelControl4)
			Me.GroupControl.Controls.Add(Me.textEdit1)
			Me.GroupControl.Controls.Add(Me.labelControl3)
			Me.GroupControl.Controls.Add(Me.textEdit2)
			Me.GroupControl.Controls.Add(Me.labelControl2)
			Me.GroupControl.Controls.Add(Me.textEdit3)
			Me.GroupControl.Controls.Add(Me.textEdit4)
			Me.GroupControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.GroupControl.Location = New System.Drawing.Point(0, 0)
			Me.GroupControl.Name = "GroupControl"
			Me.GroupControl.Size = New System.Drawing.Size(150, 127)
			Me.GroupControl.TabIndex = 8
			Me.GroupControl.Text = "Sample User Control"
			' 
			' WaitTimer
			' 
			Me.WaitTimer.Interval = 5000
'			Me.WaitTimer.Tick += New System.EventHandler(Me.OnWaitTimerTick);
			' 
			' SampleUserControl
			' 
			Me.Controls.Add(Me.GroupControl)
			Me.Name = "SampleUserControl"
			Me.Size = New System.Drawing.Size(150, 127)
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.GroupControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupControl.ResumeLayout(False)
			Me.GroupControl.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private textEdit2 As DevExpress.XtraEditors.TextEdit
		Private textEdit3 As DevExpress.XtraEditors.TextEdit
		Private textEdit4 As DevExpress.XtraEditors.TextEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private GroupControl As DevExpress.XtraEditors.GroupControl
		Private WithEvents WaitTimer As System.Windows.Forms.Timer
	End Class
End Namespace
