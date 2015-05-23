using System;
using System.Runtime.InteropServices;
namespace Winkhaus.Whokna.OutputManager.RTFControl
{
	[ComVisible(true), Guid("D3409E2B-F40B-11D1-AEA5-0000E8D88491"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
	public interface _DPadEvents
	{
		[DispId(1)]
		void Modified();
	}
}
