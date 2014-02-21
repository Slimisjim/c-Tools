using System;
using System.Diagnostics;
public class Hello {
	public static void Main() {
		
		string strCmdText;
		strCmdText= "/K path = C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319";
		System.Diagnostics.Process.Start("CMD.exe",strCmdText);
		
		}
	}
