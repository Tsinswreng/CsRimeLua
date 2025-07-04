namespace CsRimeLua.Core.Logger_;

public class Logger{
	protected static Logger? _Inst = null;
	public static Logger Inst => _Inst??= new Logger();
	public static nil Log_(str msg){
		return Inst.Log(msg);
	}

	public str Path = "./CsRimeLua.log";//TODO 同文中 pwd潙根目錄、則此無權限
	public nil Log(str msg){
		try{
			File.AppendAllText(
				Path
				,DateTime.Now.ToString()+"\t"+msg+"\n"
			);
		}
		catch (System.Exception e){
			Console.WriteLine(e);
			//throw;
		}
		return Nil;
	}

}