Imports System
Imports System.Windows.Forms

Namespace RibbonMerging

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            DevExpress.Skins.SkinManager.EnableFormSkins()
            DevExpress.Skins.SkinManager.EnableMdiFormSkins()
            Call Application.Run(New Form1())
        End Sub
    End Module
End Namespace
