using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PTM_Pizzakiszallitas
{
	public static class ControlRefresh
	{
		private static Action EmptyDelegate = delegate ()
		{
		};

		public static void Refresh (this UIElement uiElement)
		{
			uiElement.Dispatcher.Invoke (System.Windows.Threading.DispatcherPriority.Render, EmptyDelegate);

			return;
		}
	}
}
