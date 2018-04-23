using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;

namespace RibbonMerging {
    public partial class Form1 : RibbonForm {
        public Form1() {
            InitializeComponent();

        }

        #region #1
        private void Form1_Load(object sender, EventArgs e) {
            // Enable the form's title bar transparency
            //this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            // Specify that the merge mechanism should be invoked when a child MDI form is maximized.
            this.ribbonControl1.MdiMergeStyle = RibbonMdiMergeStyle.OnlyWhenMaximized;
            CreateChildForm();
        }
        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            CreateChildForm();
        }
        int ctr = 1;
        void CreateChildForm() {
            // Create an MDI child form, containing a RibbonControl
            ReportForm child = new ReportForm();
            child.Text = "Report " + ctr.ToString();
            child.MdiParent = this;
            child.Show();
            ctr++;
        }
        #endregion #1
    }
}
