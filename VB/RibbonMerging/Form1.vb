Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraBars.Ribbon

Namespace RibbonMerging

    Public Partial Class Form1
        Inherits RibbonForm

        Public Sub New()
            InitializeComponent()
        End Sub

'#Region "#1"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Enable the form's title bar transparency
            'this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            ' Specify that the merge mechanism should be invoked when a child MDI form is maximized.
            ribbonControl1.MdiMergeStyle = RibbonMdiMergeStyle.OnlyWhenMaximized
            CreateChildForm()
        End Sub

        Private Sub btnNew_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            CreateChildForm()
        End Sub

        Private ctr As Integer = 1

        Private Sub CreateChildForm()
            ' Create an MDI child form, containing a RibbonControl
            Dim child As ReportForm = New ReportForm()
            child.Text = "Report " & ctr.ToString()
            child.MdiParent = Me
            child.Show()
            ctr += 1
        End Sub
'#End Region  ' #1
    End Class
End Namespace
