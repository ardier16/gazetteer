using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Gazetteer
{
    public partial class Statistics : Form
    {
        List<List<string>> list;
        string header;
        string type;


        public Statistics()
        {
            InitializeComponent();
        }

        public Statistics(List<List<string>> l, string head, string type)
        {
            list = l;
            header = head;
            this.type = type;
            InitializeComponent();
        }


        private void Statistics_Load(object sender, EventArgs e)
        {
            try
            {
                SetStatisticsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void CreateDocMenu_Click(object sender, EventArgs e)
        {
            try
            {
                Word.Application winword = new Word.Application();
                winword.Visible = false;
                winword.Documents.Application.Caption = "Statistics";

                object missing = System.Reflection.Missing.Value;
                Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                para1.Range.Font.Name = "Arial";
                para1.Range.Font.Size = 18;
                para1.Range.Font.Bold = 1;
                para1.Range.Font.Italic = 1;
                para1.Range.Font.Underline = Word.WdUnderline.wdUnderlineSingle;
                para1.Range.ParagraphFormat.SpaceAfter = 1;

                para1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                para1.Range.Text = header + "\n";
                para1.Range.InsertParagraphAfter();

                Word.Table firstTable = document.Tables.Add(para1.Range, 11, 2, ref missing, ref missing);
                firstTable.Borders.Enable = 1;
                CreateWordTable(firstTable);
                
                document.Paragraphs[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                document.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].
                    Range.Text = "Today's date: " + DateTime.Now.ToLongDateString() + "; " + 
                                 "Time: " + DateTime.Now.ToLongTimeString() + "\n" +
                                 "Copyright © 2016 Gazetteer";
                document.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].
                    Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;


                winword.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void SetStatisticsData()
        {
            HeaderLabel.Text = header;
            TypeLabel.Text = type;


            Name1.Text += " " + list[0][0];
            Value1.Text = String.Format("{0:N}", Convert.ToInt64(list[0][1]));

            Name2.Text += " " + list[1][0];
            Value2.Text = String.Format("{0:N}", Convert.ToInt64(list[1][1]));

            Name3.Text += " " + list[2][0];
            Value3.Text = String.Format("{0:N}", Convert.ToInt64(list[2][1]));

            Name4.Text += " " + list[3][0];
            Value4.Text = String.Format("{0:N}", Convert.ToInt64(list[3][1]));

            Name5.Text += " " + list[4][0];
            Value5.Text = String.Format("{0:N}", Convert.ToInt64(list[4][1]));

            Name6.Text += " " + list[5][0];
            Value6.Text = String.Format("{0:N}", Convert.ToInt64(list[5][1]));

            Name7.Text += " " + list[6][0];
            Value7.Text = String.Format("{0:N}", Convert.ToInt64(list[6][1]));

            Name8.Text += " " + list[7][0];
            Value8.Text = String.Format("{0:N}", Convert.ToInt64(list[7][1]));

            Name9.Text += " " + list[8][0];
            Value9.Text = String.Format("{0:N}", Convert.ToInt64(list[8][1]));

            Name10.Text += " " + list[9][0];
            Value10.Text = String.Format("{0:N}", Convert.ToInt64(list[9][1]));
        }

        private void CreateWordTable(Word.Table firstTable)
        {
            for (int i = 1; i <= firstTable.Rows.Count; i++)
            {
                if (i == 1)
                {
                    firstTable.Rows[i].Cells[1].Range.Font.Bold = 1;
                    firstTable.Rows[i].Cells[1].Range.Font.Name = "verdana";
                    firstTable.Rows[i].Cells[1].Range.Font.Size = 14;
                    firstTable.Rows[i].Cells[1].Shading.BackgroundPatternColor = Word.WdColor.wdColorGray25;
                    firstTable.Rows[i].Cells[1].VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalBottom;
                    firstTable.Rows[i].Cells[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    firstTable.Rows[i].Cells[1].Range.Text = "Name";

                    firstTable.Rows[i].Cells[2].Range.Font.Bold = 1;
                    firstTable.Rows[i].Cells[2].Range.Font.Name = "verdana";
                    firstTable.Rows[i].Cells[2].Range.Font.Size = 14;
                    firstTable.Rows[i].Cells[2].Shading.BackgroundPatternColor = Word.WdColor.wdColorGray25;
                    firstTable.Rows[i].Cells[2].VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalBottom;
                    firstTable.Rows[i].Cells[2].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    firstTable.Rows[i].Cells[2].Range.Text = type;
                }
                else
                {
                    firstTable.Rows[i].Cells[1].Range.Font.Bold = 1;
                    firstTable.Rows[i].Cells[1].Range.Font.Name = "verdana";
                    firstTable.Rows[i].Cells[1].Range.Font.Size = 12;
                    firstTable.Rows[i].Cells[1].VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                    firstTable.Rows[i].Cells[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                    firstTable.Rows[i].Cells[2].Range.Font.Italic = 1;
                    firstTable.Rows[i].Cells[2].Range.Font.Name = "verdana";
                    firstTable.Rows[i].Cells[2].Range.Font.Size = 12;
                    firstTable.Rows[i].Cells[2].VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                    firstTable.Rows[i].Cells[2].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                    if (i > list.Count + 1)
                    {
                        firstTable.Rows[i].Cells[1].Range.Text = i - 1 + ". No Item";
                        firstTable.Rows[i].Cells[2].Range.Text = "0";
                    }
                    else
                    {
                        firstTable.Rows[i].Cells[1].Range.Text = i - 1 + ". " + list[i - 2][0];
                        firstTable.Rows[i].Cells[2].Range.Text = String.Format("{0:N}", Convert.ToInt64(list[i - 2][1]));
                    }
                }
            }
        }
    }
}
