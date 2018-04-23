Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing

Namespace WaitFormExample.WaitForm
	Partial Public Class UserControlWaitForm
		Inherits DevExpress.XtraWaitForm.WaitForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
			If (CType(cmd, UserControlWaitFormCommand)) = UserControlWaitFormCommand.SetSize Then
				Size = CType(arg, Size)
			End If
		End Sub
	End Class
End Namespace
