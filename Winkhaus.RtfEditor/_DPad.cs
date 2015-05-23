using System;
using System.Runtime.InteropServices;
namespace Winkhaus.Whokna.OutputManager.RTFControl
{
	[Guid("D3409E2A-F40B-11D1-AEA5-0000E8D88491")]
	public interface _DPad
	{
		[DispId(1)]
		long Height
		{
			get;
			set;
		}
		[DispId(2)]
		long MaxWidth
		{
			get;
			set;
		}
		[DispId(3)]
		long MaxHeight
		{
			get;
			set;
		}
		[DispId(4)]
		bool Modified
		{
			get;
			set;
		}
		[DispId(5)]
		void AppendText(object text);
		[DispId(6)]
		void SelectAll(bool bSel);
		[DispId(7)]
		void SetData(object data);
		[DispId(8)]
		object GetData();
		[DispId(9)]
		long DrawToMetaFile(long pDC, bool draw);
	}
}
