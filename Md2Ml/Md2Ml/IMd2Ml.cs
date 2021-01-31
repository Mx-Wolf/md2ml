using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections.Generic;
using System.IO;

namespace Md2Ml
{
  public interface IMd2Ml
  {
    void AddImage(Stream image);
    void AddTableRow(Table table, List<string> values);
    Paragraph CreateParagraph();
    Paragraph CreateParagraph(ParaProperties properties);
    Table CreateTable(int cols);
    void MarkdownBulletedList(List<string> bulletedItems, string paragraphStyle);
    void MarkdownNumberedList(List<string> bulletedItems, string paragraphStyle);
    void WriteText(Paragraph paragraph, string text, FontProperties fontProperties);
  }
}
