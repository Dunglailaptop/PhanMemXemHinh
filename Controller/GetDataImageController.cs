using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DevExpress.Data.Filtering.Helpers.SubExprHelper;

namespace PhanMemXemHinh.Controller
{
    public class GetDataImageController
    {
        public static string SelectCsvFile(string initialDirectory = null)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn file CSV";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (!string.IsNullOrEmpty(initialDirectory) && Directory.Exists(initialDirectory))
                {
                    openFileDialog.InitialDirectory = initialDirectory;
                }

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }

                return null;
            }
        }
        public static DataTable ReadCsvFile(string filePath)
        {
            DataTable dataTable = new DataTable();

          

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                // Đọc tiêu đề
                if (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields)
                    {
                        dataTable.Columns.Add(field);
                    }
                }

                // Đọc dữ liệu
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    DataRow row = dataTable.NewRow();
                    for (int i = 0; i < fields.Length; i++)
                    {
                        row[i] = fields[i]; // +1 vì cột đầu tiên là checkbox
                    }
                    dataTable.Rows.Add(row);
                }
            }

            return dataTable;
        }

        public static List<string> FindPatientImages(string patientId, string baseImagePath)
        {
            string patientFolderPath = Path.Combine(baseImagePath, patientId);
            List<string> foundImages = new List<string>();

            if (Directory.Exists(patientFolderPath))
            {
                string[] imageExtensions = { "*.jpg", "*.jpeg", "*.png", "*.gif" };

                foreach (string extension in imageExtensions)
                {
                    string[] matchingFiles = Directory.GetFiles(patientFolderPath, extension);
                    foundImages.AddRange(matchingFiles);
                }
            }
            else
            {
                Console.WriteLine($"Không tìm thấy thư mục cho bệnh nhân có ID: {patientId}");
            }

            return foundImages;
        }

    }
}
