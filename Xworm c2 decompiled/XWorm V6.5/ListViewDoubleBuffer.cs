using System;
using System.Reflection;
using System.Windows.Forms;

namespace XWorm
{
	// Token: 0x02000039 RID: 57
	public class ListViewDoubleBuffer
	{
		// Token: 0x060009F0 RID: 2544 RVA: 0x00057F54 File Offset: 0x00056154
		public static void Enable(ListView listView)
		{
			PropertyInfo property = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			property.SetValue(listView, true, null);
		}
	}
}
