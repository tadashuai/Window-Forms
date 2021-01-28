﻿using System;
using System.Runtime.InteropServices;

namespace Window
{
	/// <summary>
	/// 场景窗口类型基类
	/// </summary>
	[StructLayout( LayoutKind.Sequential, CharSet = CharSet.Auto )]
	public class SceneWindows
	{
		public int structSize = 0;
		public IntPtr dlgOwner = IntPtr.Zero;
		public IntPtr instance = IntPtr.Zero;
		public String filter = null;
		public String customFilter = null;
		public int maxCustFilter = 0;
		public int filterIndex = 0;
		public String file = null;
		public int maxFile = 0;
		public String fileTitle = null;
		public int maxFileTitle = 0;
		public String initialDir = null;
		public String title = null;
		public int flags = 0;
		public short fileOffset = 0;
		public short fileExtension = 0;
		public String defExt = null;
		public IntPtr custData = IntPtr.Zero;
		public IntPtr hook = IntPtr.Zero;
		public String templateName = null;
		public IntPtr reservedPtr = IntPtr.Zero;
		public int reservedInt = 0;
		public int flagsEx = 0;
	}

	[StructLayout( LayoutKind.Sequential, CharSet = CharSet.Auto )]
	public class OpenFile : SceneWindows
	{

	}

	public class OpenFileWindow
	{
		[DllImport( "Comdlg32.dll", SetLastError = true, ThrowOnUnmappableChar = true, CharSet = CharSet.Auto )]

		public static extern bool GetOpenFileName( [In, Out] OpenFile ofd );
	}

	public class SaveFileWindow
	{
		[DllImport( "Comdlg32.dll", SetLastError = true, ThrowOnUnmappableChar = true, CharSet = CharSet.Auto )]
		public static extern bool GetSaveFileName( [In, Out] SaveFile ofd );
	}

	[StructLayout( LayoutKind.Sequential, CharSet = CharSet.Auto )]
	public class SaveFile : SceneWindows
	{

	}

}