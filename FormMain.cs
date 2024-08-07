using DevExpress.XtraBars;
using PhanMemXemHinh.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemXemHinh
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }
        void openchild(Form form)
        {
            // Kiểm tra xem form đã được mở chưa
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == form.GetType())
                {
                    frm.Activate();
                    return;
                }
            }

            // Nếu form chưa được mở, thiết lập MDI parent và hiển thị nó
            form.MdiParent = this;
            form.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            openchild(new FormGetDataImage());
        }
    }
}