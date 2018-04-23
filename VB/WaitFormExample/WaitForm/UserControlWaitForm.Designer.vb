Imports Microsoft.VisualBasic
Imports System
Namespace WaitFormExample.WaitForm
	Partial Public Class UserControlWaitForm
		Private Sub InitializeComponent()
			Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pictureEdit1
			' 
			Me.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pictureEdit1.EditValue = My.Resources.WaitText
			Me.pictureEdit1.Location = New System.Drawing.Point(0, 0)
			Me.pictureEdit1.Name = "pictureEdit1"
			Me.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			Me.pictureEdit1.Size = New System.Drawing.Size(300, 300)
			Me.pictureEdit1.TabIndex = 0
			' 
			' UserControlWaitForm
			' 
			Me.ClientSize = New System.Drawing.Size(300, 300)
			Me.Controls.Add(Me.pictureEdit1)
			Me.Name = "UserControlWaitForm"
			Me.ShowOnTopMode = DevExpress.XtraWaitForm.ShowFormOnTopMode.AboveParent
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit
	End Class
End Namespace
