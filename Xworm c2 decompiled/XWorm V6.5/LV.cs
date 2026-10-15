using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm
{
	// Token: 0x0200003A RID: 58
	public class LV : ListView
	{
		// Token: 0x060009F1 RID: 2545 RVA: 0x00057F88 File Offset: 0x00056188
		public LV()
		{
			base.ColumnClick += this.ColumnClick;
			this.AllowDrop = false;
			this.Font = new Font("arial", 8f, FontStyle.Bold);
			this.Dock = DockStyle.Fill;
			base.FullRowSelect = true;
			base.View = View.Details;
			base.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			base.SetStyle(ControlStyles.EnableNotifyMessage, true);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00058004 File Offset: 0x00056204
		protected override void OnNotifyMessage(Message m)
		{
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00058014 File Offset: 0x00056214
		public new void ColumnClick(object sender, ColumnClickEventArgs e)
		{
			ColumnHeader columnHeader = (ColumnHeader)NewLateBinding.LateGet(sender, null, "Columns", new object[]
			{
				e.Column
			}, null, null, null);
			bool flag = this.m_SortingColumn == null;
			SortOrder sortOrder;
			if (flag)
			{
				sortOrder = SortOrder.Ascending;
			}
			else
			{
				bool flag2 = columnHeader.Equals(this.m_SortingColumn);
				if (flag2)
				{
					bool flag3 = this.m_SortingColumn.Text.StartsWith("+");
					if (flag3)
					{
						sortOrder = SortOrder.Descending;
					}
					else
					{
						sortOrder = SortOrder.Ascending;
					}
				}
				else
				{
					sortOrder = SortOrder.Ascending;
				}
				this.m_SortingColumn.Text = this.m_SortingColumn.Text.Substring(1);
			}
			this.m_SortingColumn = columnHeader;
			bool flag4 = sortOrder == SortOrder.Ascending;
			if (flag4)
			{
				this.m_SortingColumn.Text = "+" + this.m_SortingColumn.Text;
			}
			else
			{
				this.m_SortingColumn.Text = "-" + this.m_SortingColumn.Text;
			}
			bool flag5 = sender == null;
			if (!flag5)
			{
				NewLateBinding.LateSet(sender, null, "ListViewItemSorter", new object[]
				{
					new LV.clsListviewSorter(e.Column, sortOrder)
				}, null, null);
				NewLateBinding.LateCall(sender, null, "Sort", new object[0], null, null, null, true);
				NewLateBinding.LateSet(sender, null, "ListViewItemSorter", new object[1], null, null);
			}
		}

		// Token: 0x04000420 RID: 1056
		internal object Selected;

		// Token: 0x04000421 RID: 1057
		private ColumnHeader m_SortingColumn;

		// Token: 0x02000188 RID: 392
		public class clsListviewSorter : IComparer
		{
			// Token: 0x06000D37 RID: 3383 RVA: 0x0006602C File Offset: 0x0006422C
			public clsListviewSorter(int column_number, SortOrder sort_order)
			{
				this.m_ColumnNumber = column_number;
				this.m_SortOrder = sort_order;
			}

			// Token: 0x06000D38 RID: 3384 RVA: 0x00066044 File Offset: 0x00064244
			public int Compare(object x, object y)
			{
				ListViewItem listViewItem = (ListViewItem)x;
				ListViewItem listViewItem2 = (ListViewItem)y;
				bool flag = listViewItem.SubItems.Count <= this.m_ColumnNumber;
				string text;
				if (flag)
				{
					text = "";
				}
				else
				{
					text = listViewItem.SubItems[this.m_ColumnNumber].Text;
				}
				bool flag2 = listViewItem2.SubItems.Count <= this.m_ColumnNumber;
				string text2;
				if (flag2)
				{
					text2 = "";
				}
				else
				{
					text2 = listViewItem2.SubItems[this.m_ColumnNumber].Text;
				}
				bool flag3 = this.m_SortOrder == SortOrder.Ascending;
				int result;
				if (flag3)
				{
					bool flag4 = Versioned.IsNumeric(text) & Versioned.IsNumeric(text2);
					if (flag4)
					{
						result = Conversion.Val(text).CompareTo(Conversion.Val(text2));
					}
					else
					{
						bool flag5 = Information.IsDate(text) & Information.IsDate(text2);
						if (flag5)
						{
							result = DateTime.Parse(text).CompareTo(DateTime.Parse(text2));
						}
						else
						{
							result = string.Compare(text, text2);
						}
					}
				}
				else
				{
					bool flag6 = Versioned.IsNumeric(text) & Versioned.IsNumeric(text2);
					if (flag6)
					{
						result = Conversion.Val(text2).CompareTo(Conversion.Val(text));
					}
					else
					{
						bool flag7 = Information.IsDate(text) & Information.IsDate(text2);
						if (flag7)
						{
							result = DateTime.Parse(text2).CompareTo(DateTime.Parse(text));
						}
						else
						{
							result = string.Compare(text2, text);
						}
					}
				}
				return result;
			}

			// Token: 0x0400063E RID: 1598
			private int m_ColumnNumber;

			// Token: 0x0400063F RID: 1599
			private SortOrder m_SortOrder;
		}
	}
}
