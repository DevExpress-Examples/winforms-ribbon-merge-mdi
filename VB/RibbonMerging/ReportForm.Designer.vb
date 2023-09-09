Namespace RibbonMerging

    Partial Class ReportForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RibbonMerging.ReportForm))
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ApplicationIcon = Nothing
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barButtonItem4, Me.barButtonItem5})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 5
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1, Me.ribbonPage2})
            Me.ribbonControl1.SelectedPage = Me.ribbonPage1
            Me.ribbonControl1.Size = New System.Drawing.Size(443, 115)
            Me.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "Save"
            Me.barButtonItem1.Id = 0
            Me.barButtonItem1.LargeGlyph = CType((resources.GetObject("barButtonItem1.LargeGlyph")), System.Drawing.Image)
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "Save&&Close"
            Me.barButtonItem2.Id = 1
            Me.barButtonItem2.LargeGlyph = CType((resources.GetObject("barButtonItem2.LargeGlyph")), System.Drawing.Image)
            Me.barButtonItem2.Name = "barButtonItem2"
            ' 
            ' barButtonItem3
            ' 
            Me.barButtonItem3.Caption = "Departments"
            Me.barButtonItem3.Id = 2
            Me.barButtonItem3.LargeGlyph = CType((resources.GetObject("barButtonItem3.LargeGlyph")), System.Drawing.Image)
            Me.barButtonItem3.Name = "barButtonItem3"
            ' 
            ' barButtonItem4
            ' 
            Me.barButtonItem4.Caption = "Users"
            Me.barButtonItem4.Id = 3
            Me.barButtonItem4.LargeGlyph = CType((resources.GetObject("barButtonItem4.LargeGlyph")), System.Drawing.Image)
            Me.barButtonItem4.Name = "barButtonItem4"
            ' 
            ' barButtonItem5
            ' 
            Me.barButtonItem5.Caption = "Schedule"
            Me.barButtonItem5.Id = 4
            Me.barButtonItem5.LargeGlyph = CType((resources.GetObject("barButtonItem5.LargeGlyph")), System.Drawing.Image)
            Me.barButtonItem5.Name = "barButtonItem5"
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.ribbonPageGroup2})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Reports"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem1)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem2)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "Main"
            ' 
            ' ribbonPageGroup2
            ' 
            Me.ribbonPageGroup2.ItemLinks.Add(Me.barButtonItem3)
            Me.ribbonPageGroup2.ItemLinks.Add(Me.barButtonItem4)
            Me.ribbonPageGroup2.ItemLinks.Add(Me.barButtonItem5, True)
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.Text = "Company"
            ' 
            ' ribbonPage2
            ' 
            Me.ribbonPage2.Name = "ribbonPage2"
            Me.ribbonPage2.Text = "Templates"
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.memoEdit1.EditValue = "Maximize this window to invoke the merge mechanism."
            Me.memoEdit1.Location = New System.Drawing.Point(0, 115)
            Me.memoEdit1.MenuManager = Me.ribbonControl1
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Size = New System.Drawing.Size(443, 164)
            Me.memoEdit1.TabIndex = 1
            ' 
            ' ReportForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(443, 279)
            Me.Controls.Add(Me.memoEdit1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "ReportForm"
            Me.Text = "ReportForm"
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl

        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem

        Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private barButtonItem4 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem5 As DevExpress.XtraBars.BarButtonItem

        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
    End Class
End Namespace
