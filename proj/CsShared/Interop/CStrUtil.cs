using System.Runtime.InteropServices;
using System.Text;

namespace CsShared.Interop;

/// <summary>
/// TODO test
/// </summary>
public static unsafe class CStrUtil{

	public static string? ToCsStr(byte* cStr){

		if (cStr == null){ return null;}

		// 計算字元串的長度
		int length = 0;
		while (*(cStr + length) != 0){ // 直到遇到null字符
			length++;
		}

		// 將字元串轉換為byte[]
		byte[] byteArray = new byte[length];
		Marshal.Copy((nint)cStr, byteArray, 0, length);

		// 將byte[]轉換為string，這裡預設為UTF-8編碼
		return Encoding.UTF8.GetString(byteArray);
	}


	public static byte* ToCStr(string? csStr){
		if (csStr == null){ return null;}
		return (byte*)Marshal.StringToCoTaskMemUTF8(csStr);
	}

}