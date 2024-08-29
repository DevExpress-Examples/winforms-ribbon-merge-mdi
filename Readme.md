<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128617227/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1917)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Ribbon - MDI Ribbon merge

This example demonstrates automatic menu merging for MDI applications. The main and child MDI forms contain a Ribbon UI. The child form's `RibbonControl` is merged into the main form's RibbonControl when the child form is maximized.

![](https://raw.githubusercontent.com/DevExpress-Examples/how-to-merge-ribbon-controls-e1917/13.1.4%2B/media/winforms-ribbon-merge-mdi.png)

```csharp
private void Form1_Load(object sender, EventArgs e) {
    ribbonControl1.MdiMergeStyle = RibbonMdiMergeStyle.OnlyWhenMaximized;
    CreateChildForm();
}
```


## Files to Review

* [Form1.cs](./CS/RibbonMerging/Form1.cs) (VB: [Form1.vb](./VB/RibbonMerging/Form1.vb))
* [ReportForm.cs](./CS/RibbonMerging/ReportForm.cs) (VB: [ReportForm.vb](./VB/RibbonMerging/ReportForm.vb))


## Documentation

* [MDI Merging - WinForms Toolbars and Ribbon UI](https://docs.devexpress.com/WindowsForms/1099/controls-and-libraries/ribbon-bars-and-menu/bars/mdi-merging)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-ribbon-merge-mdi&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-ribbon-merge-mdi&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
