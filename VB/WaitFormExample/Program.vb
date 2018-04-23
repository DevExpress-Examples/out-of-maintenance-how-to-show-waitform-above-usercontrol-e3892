Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.UserSkins
Imports DevExpress.LookAndFeel

Namespace WaitFormExample
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			SkinManager.EnableFormSkins()
			BonusSkins.Register()
			UserLookAndFeel.Default.SkinName = "Office 2007 Silver"
			Application.Run(New MainForm())
		End Sub
	End Class
End Namespace
