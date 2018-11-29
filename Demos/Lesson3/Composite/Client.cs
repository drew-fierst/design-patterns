using System;

namespace Composite
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();

			AbstractItem nut = new Part("Nut", 5);
			AbstractItem bolt = new Part("Bolt", 9);
			AbstractItem panel = new Part("Panel", 35);

			AbstractItem gizmo = new Assembly("Gizmo");
			gizmo.AddItem(panel);
			gizmo.AddItem(nut);
			gizmo.AddItem(bolt);

			AbstractItem widget = new Assembly("Widget");
			widget.AddItem(gizmo);
			widget.AddItem(nut);

			// Display the items
			Console.WriteLine(nut);
			Console.WriteLine(bolt);
			Console.WriteLine(panel);
			Console.WriteLine(gizmo);
			Console.WriteLine(widget);

			Console.ReadLine();
		}
	}
}
