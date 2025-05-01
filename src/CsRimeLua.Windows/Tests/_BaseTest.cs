using CsRimeLua.Core.Logger_;

namespace CsRimeLua.Windows.Tests;
unsafe public class _BaseTest{
	public static i32 i = 0;
	public static void I(){
		Logger.Log_(i+++"");
	}

	
}