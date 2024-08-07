using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using PhanMemXemHinh.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemXemHinh.View
{
    public partial class FormGetDataImage : DevExpress.XtraEditors.XtraForm
    {
        public string url {  get; set; }
        public FormGetDataImage()
        {
            InitializeComponent();
            gridView1.RowClick += GridView1_RowClick;
        }


        private void GridView1_RowClick(object sender, RowClickEventArgs e)
        {
            // Lấy đối tượng được click
            var view = sender as GridView;

            var secondColumnValue = view.GetRowCellValue(e.RowHandle, view.Columns[2]);
            if (secondColumnValue != null)
            {

                MessageBox.Show($"Bạn đã click vào file: {secondColumnValue}");
                labelControl2.Text = secondColumnValue.ToString();
            }
        }
        private void FormGetDataImage_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string selectedPath = GetDataImageController.SelectCsvFile("Chọn thư mục lưu ảnh");
            if (selectedPath != null)
            {
                Console.WriteLine("Thư mục đã chọn: " + selectedPath);
                url = selectedPath;
                DataTable dataTable = GetDataImageController.ReadCsvFile(selectedPath);
                gridControl1.DataSource = dataTable;
                // Thực hiện các thao tác với thư mục đã chọn
            }
            else
            {
                Console.WriteLine("Không có thư mục nào được chọn.");
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(labelControl2.Text != "0")
            {
                FormShowImage form2 = new FormShowImage();
                form2.MaBenhNhan = labelControl2.Text;
                form2.urlFolder = Path.GetDirectoryName(url);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã bệnh nhân để xem hình");
            }
          
        }
    }
}