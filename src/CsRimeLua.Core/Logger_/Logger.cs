namespace CsRimeLua.Core.Logger_;

public class Logger{
	protected static Logger? _Inst = null;
	public static Logger Inst => _Inst??= new Logger();

	public str Path = "./CsRimeLua.log";
	public nil Log(str msg){
		File.AppendAllText(
			Path
			,DateTime.Now.ToString()+"\t"+msg+"\n"
		);
		return null!;
	}

}