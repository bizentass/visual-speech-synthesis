Option Strict Off
Option Explicit On
Module TTSAppMod
	
	Declare Function GetSysColor Lib "user32" (ByVal index As Integer) As Integer
	
	Public Const COLOR_BTNFACE As Short = 15
	Public Const COLOR_3DFACE As Short = COLOR_BTNFACE
End Module