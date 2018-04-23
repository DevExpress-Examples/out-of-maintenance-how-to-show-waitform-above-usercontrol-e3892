Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Collections.Generic

Namespace WaitFormExample
	Public NotInheritable Partial Class MainForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnShowWaitFormButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles sbD.Click, sbC.Click, sbB.Click, sbA.Click
			Select Case (CType(sender, Control)).Name
				Case "sbA"
					sucA.StartLengthyOperation()
				Case "sbB"
					sucB.StartLengthyOperation()
				Case "sbC"
					sucC.StartLengthyOperation()
				Case "sbD"
					sucD.StartLengthyOperation()
			End Select
		End Sub
	End Class
End Namespace
