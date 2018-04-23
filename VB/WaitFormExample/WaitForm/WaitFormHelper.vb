Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports DevExpress.XtraSplashScreen

Namespace WaitFormExample.WaitForm
	Public Module WaitFormHelper
        Private Managers As New Dictionary(Of Control, SplashScreenManager)()

        <System.Runtime.CompilerServices.Extension()> _
  Public Sub ShowWaitForm(ByVal owner As UserControl)
            If Managers.ContainsKey(owner) Then
                Return
            End If
            Dim manager As New SplashScreenManager(GetType(UserControlWaitForm), SplashFormStartPosition.Manual, owner.Parent.PointToScreen(owner.Location), New SplashFormProperties())
            Managers.Add(owner, manager)
            manager.ShowWaitForm()
            manager.SendCommand(UserControlWaitFormCommand.SetSize, owner.Size)
        End Sub

        <System.Runtime.CompilerServices.Extension()> _
        Public Sub HideWaitForm(ByVal owner As Control)
            If (Not Managers.ContainsKey(owner)) Then
                Return
            End If
            Dim manager As SplashScreenManager = Managers(owner)
            Managers.Remove(owner)
            Try
                manager.CloseWaitForm()
            Finally
                manager.Dispose()
            End Try
        End Sub
	End Module
End Namespace
