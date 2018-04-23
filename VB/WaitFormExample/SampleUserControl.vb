Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports WaitFormExample.WaitForm

Namespace WaitFormExample
	Partial Public Class SampleUserControl
		Inherits XtraUserControl
		Private Const DefaultCaption As String = "Sample User Control"

		Public Sub New()
			InitializeComponent()
			GroupControl.Text = DefaultCaption
		End Sub

		<DefaultValue(DefaultCaption)> _
		Public Property Caption() As String
			Get
				Return GroupControl.Text
			End Get
			Set(ByVal value As String)
				GroupControl.Text = value
			End Set
		End Property

		Private Sub OnWaitTimerTick(ByVal sender As Object, ByVal e As EventArgs) Handles WaitTimer.Tick
			WaitTimer.Stop()
			Me.HideWaitForm()
		End Sub

		Public Sub StartLengthyOperation()
			If WaitTimer.Enabled Then
				Return
			End If
			Me.ShowWaitForm()
			WaitTimer.Start()
		End Sub
	End Class
End Namespace
