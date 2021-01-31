using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections.Generic;

namespace Md2Ml
{
  public static class Md2MlExtenstions
  {
		public static void WriteText(this IMd2Ml core, Paragraph paragraph, string text)
    {
			core.WriteText(paragraph, text, new FontProperties());
    }
    public static void MarkdownBulletedList(this IMd2Ml core, List<string> bulletedItems)
    {
      core.MarkdownBulletedList(bulletedItems, "ListParagraph");
    }
    public static void MarkdownNumberedList(this IMd2Ml core, List<string> bulletedItems)
    {
      core.MarkdownNumberedList(bulletedItems, "ListParagraph");
    }

    public static void WriteText(this IMd2Ml core, string text)
    {
     core.WriteText(core.CreateParagraph(), text);
    }
  }
}
