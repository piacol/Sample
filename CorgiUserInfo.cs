using System.Collections;
using System.Net;
using System.IO;

public class CorgiUserInfo : Singleton<CorgiUserInfo> {

	public CorgiUserInfo(){

	}
	
	public void Reset()
	{
		userId = "";
		authToken = "";
		useNickname = "";
		hiveNickname = "";
		
		isNicknameOk = false;
		isHiveAuthGameServerLoginOk = false;
		isPgsLogined = false;
		isGuset = false;
	}

	public string userId;
	public string authToken;
	public string useNickname = null;
	
	public bool isGuset = false;
	public bool isNicknameOk = false;
	public bool isHiveAuthGameServerLoginOk = false;
	public bool isPgsLogined = false;
	
	//device info
	public bool isBad = false;
	public string deviceLang = "";
	
	//[hive user data]
	public string hiveNickname = "";
	
	//[xigncode cookie]
#if UNITY_IOS
	public string xigncodeCookie = "55efc029_2699b9c1983eb27e38ba9749ab44afd4_dd3b3327f64b6dded26d046a6a628e26";
#else
	public string xigncodeCookie = "";
#endif
}