Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace RibbonMerging
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
			DevExpress.Skins.SkinManager.EnableFormSkins()
			DevExpress.Skins.SkinManager.EnableMdiFormSkins()
			Application.Run(New Form1())
		End Sub
	End Class
End Namespace
