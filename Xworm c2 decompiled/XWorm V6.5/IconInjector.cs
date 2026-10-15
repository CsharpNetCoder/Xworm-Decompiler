using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace XWorm
{
	// Token: 0x02000038 RID: 56
	public class IconInjector
	{
		// Token: 0x060009ED RID: 2541 RVA: 0x00057EB8 File Offset: 0x000560B8
		public static void InjectIcon(string exeFileName, string iconFileName)
		{
			IconInjector.InjectIcon(exeFileName, iconFileName, 1U, 1U);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00057EC8 File Offset: 0x000560C8
		public static void InjectIcon(string exeFileName, string iconFileName, uint iconGroupID, uint iconBaseID)
		{
			IconInjector.IconFile iconFile = IconInjector.IconFile.FromFile(iconFileName);
			IntPtr hUpdate = IconInjector.NativeMethods.BeginUpdateResource(exeFileName, false);
			byte[] array = iconFile.CreateIconGroupData(iconBaseID);
			IconInjector.NativeMethods.UpdateResource(hUpdate, new IntPtr(14L), new IntPtr((long)((ulong)iconGroupID)), 0, array, array.Length);
			checked
			{
				int num = iconFile.ImageCount - 1;
				for (int i = 0; i <= num; i++)
				{
					byte[] array2 = iconFile.get_ImageData(i);
					IconInjector.NativeMethods.UpdateResource(hUpdate, new IntPtr(3L), new IntPtr((long)(unchecked((ulong)iconBaseID) + (ulong)(unchecked((long)i)))), 0, array2, array2.Length);
				}
				IconInjector.NativeMethods.EndUpdateResource(hUpdate, false);
			}
		}

		// Token: 0x02000182 RID: 386
		[SuppressUnmanagedCodeSecurity]
		private class NativeMethods
		{
			// Token: 0x06000D2F RID: 3375
			[DllImport("kernel32")]
			public static extern IntPtr BeginUpdateResource(string fileName, [MarshalAs(UnmanagedType.Bool)] bool deleteExistingResources);

			// Token: 0x06000D30 RID: 3376
			[DllImport("kernel32")]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool UpdateResource(IntPtr hUpdate, IntPtr type, IntPtr name, short language, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] data, int dataSize);

			// Token: 0x06000D31 RID: 3377
			[DllImport("kernel32")]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool EndUpdateResource(IntPtr hUpdate, [MarshalAs(UnmanagedType.Bool)] bool discard);
		}

		// Token: 0x02000183 RID: 387
		private struct ICONDIR
		{
			// Token: 0x0400061D RID: 1565
			public ushort Reserved;

			// Token: 0x0400061E RID: 1566
			public ushort Type;

			// Token: 0x0400061F RID: 1567
			public ushort Count;
		}

		// Token: 0x02000184 RID: 388
		private struct ICONDIRENTRY
		{
			// Token: 0x04000620 RID: 1568
			public byte Width;

			// Token: 0x04000621 RID: 1569
			public byte Height;

			// Token: 0x04000622 RID: 1570
			public byte ColorCount;

			// Token: 0x04000623 RID: 1571
			public byte Reserved;

			// Token: 0x04000624 RID: 1572
			public ushort Planes;

			// Token: 0x04000625 RID: 1573
			public ushort BitCount;

			// Token: 0x04000626 RID: 1574
			public int BytesInRes;

			// Token: 0x04000627 RID: 1575
			public int ImageOffset;
		}

		// Token: 0x02000185 RID: 389
		private struct BITMAPINFOHEADER
		{
			// Token: 0x04000628 RID: 1576
			public uint Size;

			// Token: 0x04000629 RID: 1577
			public int Width;

			// Token: 0x0400062A RID: 1578
			public int Height;

			// Token: 0x0400062B RID: 1579
			public ushort Planes;

			// Token: 0x0400062C RID: 1580
			public ushort BitCount;

			// Token: 0x0400062D RID: 1581
			public uint Compression;

			// Token: 0x0400062E RID: 1582
			public uint SizeImage;

			// Token: 0x0400062F RID: 1583
			public int XPelsPerMeter;

			// Token: 0x04000630 RID: 1584
			public int YPelsPerMeter;

			// Token: 0x04000631 RID: 1585
			public uint ClrUsed;

			// Token: 0x04000632 RID: 1586
			public uint ClrImportant;
		}

		// Token: 0x02000186 RID: 390
		[StructLayout(LayoutKind.Sequential, Pack = 2)]
		private struct GRPICONDIRENTRY
		{
			// Token: 0x04000633 RID: 1587
			public byte Width;

			// Token: 0x04000634 RID: 1588
			public byte Height;

			// Token: 0x04000635 RID: 1589
			public byte ColorCount;

			// Token: 0x04000636 RID: 1590
			public byte Reserved;

			// Token: 0x04000637 RID: 1591
			public ushort Planes;

			// Token: 0x04000638 RID: 1592
			public ushort BitCount;

			// Token: 0x04000639 RID: 1593
			public int BytesInRes;

			// Token: 0x0400063A RID: 1594
			public ushort ID;
		}

		// Token: 0x02000187 RID: 391
		private class IconFile
		{
			// Token: 0x170003E2 RID: 994
			// (get) Token: 0x06000D32 RID: 3378 RVA: 0x00065CDC File Offset: 0x00063EDC
			public int ImageCount
			{
				get
				{
					return (int)this.iconDir.Count;
				}
			}

			// Token: 0x170003E3 RID: 995
			// (get) Token: 0x06000D33 RID: 3379 RVA: 0x00065CFC File Offset: 0x00063EFC
			public byte[] ImageData
			{
				get
				{
					return this.iconImage[index];
				}
			}

			// Token: 0x06000D34 RID: 3380 RVA: 0x00065D16 File Offset: 0x00063F16
			private IconFile()
			{
				this.iconDir = default(IconInjector.ICONDIR);
			}

			// Token: 0x06000D35 RID: 3381 RVA: 0x00065D2C File Offset: 0x00063F2C
			public static IconInjector.IconFile FromFile(string filename)
			{
				IconInjector.IconFile iconFile = new IconInjector.IconFile();
				byte[] array = File.ReadAllBytes(filename);
				GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
				iconFile.iconDir = (IconInjector.ICONDIR)Marshal.PtrToStructure(gchandle.AddrOfPinnedObject(), typeof(IconInjector.ICONDIR));
				checked
				{
					iconFile.iconEntry = new IconInjector.ICONDIRENTRY[(int)(iconFile.iconDir.Count - 1 + 1)];
					iconFile.iconImage = new byte[(int)(iconFile.iconDir.Count - 1 + 1)][];
					int num = Marshal.SizeOf<IconInjector.ICONDIR>(iconFile.iconDir);
					Type typeFromHandle = typeof(IconInjector.ICONDIRENTRY);
					int num2 = Marshal.SizeOf(typeFromHandle);
					int num3 = (int)(iconFile.iconDir.Count - 1);
					for (int i = 0; i <= num3; i++)
					{
						IconInjector.ICONDIRENTRY icondirentry = (IconInjector.ICONDIRENTRY)Marshal.PtrToStructure(new IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + unchecked((long)num)), typeFromHandle);
						iconFile.iconEntry[i] = icondirentry;
						iconFile.iconImage[i] = new byte[icondirentry.BytesInRes - 1 + 1];
						Buffer.BlockCopy(array, icondirentry.ImageOffset, iconFile.iconImage[i], 0, icondirentry.BytesInRes);
						num += num2;
					}
					gchandle.Free();
					return iconFile;
				}
			}

			// Token: 0x06000D36 RID: 3382 RVA: 0x00065E6C File Offset: 0x0006406C
			public byte[] CreateIconGroupData(uint iconBaseID)
			{
				checked
				{
					int num = Marshal.SizeOf(typeof(IconInjector.ICONDIR)) + Marshal.SizeOf(typeof(IconInjector.GRPICONDIRENTRY)) * this.ImageCount;
					byte[] array = new byte[num - 1 + 1];
					GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
					Marshal.StructureToPtr<IconInjector.ICONDIR>(this.iconDir, gchandle.AddrOfPinnedObject(), false);
					int num2 = Marshal.SizeOf<IconInjector.ICONDIR>(this.iconDir);
					int num3 = this.ImageCount - 1;
					for (int i = 0; i <= num3; i++)
					{
						IconInjector.GRPICONDIRENTRY structure = default(IconInjector.GRPICONDIRENTRY);
						IconInjector.BITMAPINFOHEADER bitmapinfoheader = default(IconInjector.BITMAPINFOHEADER);
						GCHandle gchandle2 = GCHandle.Alloc(bitmapinfoheader, GCHandleType.Pinned);
						Marshal.Copy(this.get_ImageData(i), 0, gchandle2.AddrOfPinnedObject(), Marshal.SizeOf(typeof(IconInjector.BITMAPINFOHEADER)));
						gchandle2.Free();
						structure.Width = this.iconEntry[i].Width;
						structure.Height = this.iconEntry[i].Height;
						structure.ColorCount = this.iconEntry[i].ColorCount;
						structure.Reserved = this.iconEntry[i].Reserved;
						structure.Planes = bitmapinfoheader.Planes;
						structure.BitCount = bitmapinfoheader.BitCount;
						structure.BytesInRes = this.iconEntry[i].BytesInRes;
						structure.ID = (ushort)(unchecked((ulong)iconBaseID) + (ulong)(unchecked((long)i)));
						Marshal.StructureToPtr<IconInjector.GRPICONDIRENTRY>(structure, new IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + unchecked((long)num2)), false);
						num2 += Marshal.SizeOf(typeof(IconInjector.GRPICONDIRENTRY));
					}
					gchandle.Free();
					return array;
				}
			}

			// Token: 0x0400063B RID: 1595
			private IconInjector.ICONDIR iconDir;

			// Token: 0x0400063C RID: 1596
			private IconInjector.ICONDIRENTRY[] iconEntry;

			// Token: 0x0400063D RID: 1597
			private byte[][] iconImage;
		}
	}
}
