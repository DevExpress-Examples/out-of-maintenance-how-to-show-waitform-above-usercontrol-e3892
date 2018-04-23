Imports Microsoft.VisualBasic
Imports System
Namespace WaitFormExample
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.sucA = New WaitFormExample.SampleUserControl()
			Me.sucB = New WaitFormExample.SampleUserControl()
			Me.sucC = New WaitFormExample.SampleUserControl()
			Me.sucD = New WaitFormExample.SampleUserControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.sbD = New DevExpress.XtraEditors.SimpleButton()
			Me.sbC = New DevExpress.XtraEditors.SimpleButton()
			Me.sbB = New DevExpress.XtraEditors.SimpleButton()
			Me.sbA = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' sucA
			' 
			Me.sucA.Caption = "Sample User Control A"
			Me.sucA.Dock = System.Windows.Forms.DockStyle.Top
			Me.sucA.Location = New System.Drawing.Point(0, 51)
			Me.sucA.Name = "sucA"
			Me.sucA.Size = New System.Drawing.Size(455, 128)
			Me.sucA.TabIndex = 0
			' 
			' sucB
			' 
			Me.sucB.Caption = "Sample User Control B"
			Me.sucB.Dock = System.Windows.Forms.DockStyle.Right
			Me.sucB.Location = New System.Drawing.Point(276, 179)
			Me.sucB.Name = "sucB"
			Me.sucB.Size = New System.Drawing.Size(179, 244)
			Me.sucB.TabIndex = 1
			' 
			' sucC
			' 
			Me.sucC.Caption = "Sample User Control C"
			Me.sucC.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.sucC.Location = New System.Drawing.Point(0, 308)
			Me.sucC.Name = "sucC"
			Me.sucC.Size = New System.Drawing.Size(276, 115)
			Me.sucC.TabIndex = 2
			' 
			' sucD
			' 
			Me.sucD.Caption = "Sample User Control D"
			Me.sucD.Dock = System.Windows.Forms.DockStyle.Fill
			Me.sucD.Location = New System.Drawing.Point(0, 179)
			Me.sucD.Name = "sucD"
			Me.sucD.Size = New System.Drawing.Size(276, 129)
			Me.sucD.TabIndex = 3
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.sbD)
			Me.panelControl1.Controls.Add(Me.sbC)
			Me.panelControl1.Controls.Add(Me.sbB)
			Me.panelControl1.Controls.Add(Me.sbA)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(455, 51)
			Me.panelControl1.TabIndex = 4
			' 
			' sbD
			' 
			Me.sbD.Location = New System.Drawing.Point(334, 13)
			Me.sbD.Name = "sbD"
			Me.sbD.Size = New System.Drawing.Size(109, 23)
			Me.sbD.TabIndex = 3
			Me.sbD.Tag = ""
			Me.sbD.Text = "Show Wait Form &D"
'			Me.sbD.Click += New System.EventHandler(Me.OnShowWaitFormButtonClick);
			' 
			' sbC
			' 
			Me.sbC.Location = New System.Drawing.Point(225, 13)
			Me.sbC.Name = "sbC"
			Me.sbC.Size = New System.Drawing.Size(103, 23)
			Me.sbC.TabIndex = 2
			Me.sbC.Tag = ""
			Me.sbC.Text = "Show Wait Form &C"
'			Me.sbC.Click += New System.EventHandler(Me.OnShowWaitFormButtonClick);
			' 
			' sbB
			' 
			Me.sbB.Location = New System.Drawing.Point(118, 13)
			Me.sbB.Name = "sbB"
			Me.sbB.Size = New System.Drawing.Size(101, 23)
			Me.sbB.TabIndex = 1
			Me.sbB.Tag = ""
			Me.sbB.Text = "Show Wait Form &B"
'			Me.sbB.Click += New System.EventHandler(Me.OnShowWaitFormButtonClick);
			' 
			' sbA
			' 
			Me.sbA.Location = New System.Drawing.Point(13, 13)
			Me.sbA.Name = "sbA"
			Me.sbA.Size = New System.Drawing.Size(99, 23)
			Me.sbA.TabIndex = 0
			Me.sbA.Tag = ""
			Me.sbA.Text = "Show Wait Form &A"
'			Me.sbA.Click += New System.EventHandler(Me.OnShowWaitFormButtonClick);
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(455, 423)
			Me.Controls.Add(Me.sucD)
			Me.Controls.Add(Me.sucC)
			Me.Controls.Add(Me.sucB)
			Me.Controls.Add(Me.sucA)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "MainForm"
			Me.Text = "DX Sample"
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private sucA As SampleUserControl
		Private sucB As SampleUserControl
		Private sucC As SampleUserControl
		Private sucD As SampleUserControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents sbD As DevExpress.XtraEditors.SimpleButton
		Private WithEvents sbC As DevExpress.XtraEditors.SimpleButton
		Private WithEvents sbB As DevExpress.XtraEditors.SimpleButton
		Private WithEvents sbA As DevExpress.XtraEditors.SimpleButton

	End Class
End Namespace

