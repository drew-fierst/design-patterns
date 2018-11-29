using System;

namespace Template
{
	public class SedanBooklet : AbstractBookletPrinter
	{
		protected internal override int PageCount
		{
			get
			{
				return 20;
			}
		}

		protected internal override void PrintFrontCover()
		{
			Console.WriteLine("Printing front cover for Sedan car booklet");
		}

		protected internal override void PrintTableOfContents()
		{
			Console.WriteLine("Printing table of contents for Sedan car booklet");
		}

		protected internal override void PrintPage(int pageNumber)
		{
			Console.WriteLine("Printing page " + pageNumber + " for Sedan car booklet");
		}

		protected internal override void PrintIndex()
		{
			Console.WriteLine("Printing index for Sedan car booklet");
		}

		protected internal override void PrintBackCover()
		{
			Console.WriteLine("Printing back cover for Sedan car booklet");
		}
	}
}
