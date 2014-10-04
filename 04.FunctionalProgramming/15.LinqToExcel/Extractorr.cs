using System;
using System.Collections.Generic;
using System.Linq;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.CompoundDocumentFormat;
using System.IO;

namespace _15.LinqToExcel
{
    class Extractorr
    {
        static void Main(string[] args)
        {
            string line;
            StreamReader studentInfo = new StreamReader("Students-data.txt");

            List<Student> muchenici = new List<Student>();
            bool first = true;

            while ((line = studentInfo.ReadLine()) != null)
            {
                if (first)
                {
                    first = false;
                    continue;
                }
                string[] studentData = line.Split('\t');
                Student st = new Student(Convert.ToInt32(studentData[0]), studentData[1], studentData[2], studentData[3], studentData[4], studentData[5], Convert.ToInt32(studentData[6]),
                    Convert.ToInt32(studentData[7]), Convert.ToInt32(studentData[8]), Convert.ToDouble(studentData[9]), Convert.ToInt32(studentData[10]), Convert.ToDouble(studentData[11]));

                muchenici.Add(st);
            }

            var online =
                from st in muchenici
                where st.StudentType == "Online"
                orderby st.Result descending
                select st;

            string file = "newdoc.xls";
            Workbook workbook = new Workbook();

            //Fix problem with library
            Worksheet worksheet = new Worksheet("First Sheet");
            for (var k = 0; k < 200; k++)
            {
                worksheet.Cells[k, 0] = new Cell(null);
            }

            worksheet.Cells[0, 0] = new Cell("ID");
            worksheet.Cells[0, 1] = new Cell("First Name");
            worksheet.Cells[0, 2] = new Cell("Last Name");
            worksheet.Cells[0, 3] = new Cell("Email");
            worksheet.Cells[0, 4] = new Cell("Gender");
            worksheet.Cells[0, 5] = new Cell("Student Type");
            worksheet.Cells[0, 6] = new Cell("Exam Result");
            worksheet.Cells[0, 7] = new Cell("Homework Sent");
            worksheet.Cells[0, 8] = new Cell("Homework Evaluated");
            worksheet.Cells[0, 9] = new Cell("Teamwork");
            worksheet.Cells[0, 10] = new Cell("Attendances");
            worksheet.Cells[0, 11] = new Cell("Bonus");
            worksheet.Cells[0, 12] = new Cell("Result");

            int counter = 1;
            foreach (var item in online)
            {
                worksheet.Cells[counter, 0] = new Cell(item.ID);
                worksheet.Cells[counter, 1] = new Cell(item.FirstName);
                worksheet.Cells[counter, 2] = new Cell(item.LastName);
                worksheet.Cells[counter, 3] = new Cell(item.Email);
                worksheet.Cells[counter, 4] = new Cell(item.Gender);
                worksheet.Cells[counter, 5] = new Cell(item.StudentType);
                worksheet.Cells[counter, 6] = new Cell(item.ExamResult);
                worksheet.Cells[counter, 7] = new Cell(item.HWSent);
                worksheet.Cells[counter, 8] = new Cell(item.HWEvaluated);
                worksheet.Cells[counter, 9] = new Cell(item.Teamwork);
                worksheet.Cells[counter, 10] = new Cell(item.Attendances);
                worksheet.Cells[counter, 11] = new Cell(item.Bonus);
                worksheet.Cells[counter, 12] = new Cell(item.Result);
                counter++;
            }

            workbook.Worksheets.Add(worksheet);
            workbook.Save(file);
        }
    }
}
