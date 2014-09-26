using System;
using Novacode;
using System.Diagnostics;
using System.IO;

namespace _05.WordDocumentGenerator
{
    class WordGenerator
    {
        static void Main(string[] args)
        {
            string fileName = @"SoftUniContest.docx";
            string headlineText = "SoftUni OOP Game Contest";
            string paraOne = ""
                + "SoftUni is organazing a contest for the best role playing game from the OOP teamwork projects. "
                + "The winning teams will receive a grand prize!";

            //Title styling
            var headLineFormat = new Formatting();
            headLineFormat.FontFamily = new System.Drawing.FontFamily("Arial Black");
            headLineFormat.Size = 22D;
            headLineFormat.Position = 12;
            headLineFormat.Bold = true;

            //Bottom styling
            var bottom = new Formatting();
            bottom.FontFamily = new System.Drawing.FontFamily("Arial Black");
            bottom.Size = 16D;
            bottom.Position = 12;
            bottom.Bold = true;

            //Handshake format
            var handshakeFormat = new Formatting();
            handshakeFormat.FontFamily = new System.Drawing.FontFamily("Arial Black");
            handshakeFormat.Size = 22D;
            handshakeFormat.Position = 12;
            handshakeFormat.Bold = true;
            handshakeFormat.UnderlineStyle = UnderlineStyle.singleLine;

            //Paragraph Format
            var paraFormat = new Formatting();
            paraFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
            paraFormat.Size = 14D;

            var doc = DocX.Create(fileName);

            Paragraph title = doc.InsertParagraph(headlineText, false, headLineFormat);
            title.Alignment = Alignment.center;

            //Create Image + Insert It
            using (MemoryStream ms = new MemoryStream())
            {
                System.Drawing.Image myImg = System.Drawing.Image.FromFile(@"rpg-game.png");

                myImg.Save(ms, myImg.RawFormat);
                ms.Seek(0, SeekOrigin.Begin);

                Novacode.Image img = doc.AddImage(ms);

                Paragraph p = doc.InsertParagraph("", false);

                Picture pic1 = img.CreatePicture();
                pic1.Height = 250;
                pic1.Width = 650;

                p.InsertPicture(pic1, 0);

                doc.Save();
            }

            doc.InsertParagraph(Environment.NewLine);
            doc.InsertParagraph(paraOne, false, paraFormat);
            doc.InsertParagraph("The Game should be:", false, paraFormat);
            doc.InsertParagraph("                   -Properly Structured and allow good OOP practices", false, paraFormat);
            doc.InsertParagraph("                   -Awesome", false, paraFormat);
            doc.InsertParagraph("                   -..Very Awesome", false, paraFormat);
            doc.InsertParagraph(Environment.NewLine);

            //Add Table
            Table t = doc.AddTable(4, 3);

            t.Alignment = Alignment.center;
            t.Design = TableDesign.LightGridAccent1;
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    t.Rows[j].Cells[i].Width = 200;
                }
            }

            t.Rows[0].Cells[0].InsertParagraph("Team", false, paraFormat);
            t.Rows[0].Cells[1].InsertParagraph("Game", false, paraFormat);
            t.Rows[0].Cells[2].InsertParagraph("Points", false, paraFormat);

            t.Rows[1].Cells[0].InsertParagraph("-", false, paraFormat);
            t.Rows[1].Cells[1].InsertParagraph("-", false, paraFormat);
            t.Rows[1].Cells[2].InsertParagraph("-", false, paraFormat);
            t.Rows[2].Cells[0].InsertParagraph("-", false, paraFormat);
            t.Rows[2].Cells[1].InsertParagraph("-", false, paraFormat);
            t.Rows[2].Cells[2].InsertParagraph("-", false, paraFormat);
            t.Rows[3].Cells[0].InsertParagraph("-", false, paraFormat);
            t.Rows[3].Cells[1].InsertParagraph("-", false, paraFormat);
            t.Rows[3].Cells[2].InsertParagraph("-", false, paraFormat);

            // Insert the Table into the document.
            doc.InsertTable(t);
            doc.InsertParagraph(Environment.NewLine);
            doc.InsertParagraph(Environment.NewLine);
            doc.InsertParagraph(Environment.NewLine);
            //Bottom
            Paragraph title1 = doc.InsertParagraph("The top 3 teams will receive a SPECTACULAR prize: ", false, bottom);
            title1.Alignment = Alignment.center;
            Paragraph title2 = doc.InsertParagraph("A HANDSHAKE FROM NAKOV", false, handshakeFormat);
            title2.Color(System.Drawing.Color.Blue);
            title2.Alignment = Alignment.center;
            
            doc.Save();

            Process.Start("WINWORD.EXE", fileName);
        }
    }
}
