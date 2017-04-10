replace Capture.exe ^
%KIYO_BIN%\DirectShell

replace Capture.pdb ^
%KIYO_BIN%\DirectShell

::ヘルプファイルのコピー
::replace "./doc/capture.man" ^
::%KIYO_BIN%\Help\man
::⇒アホなことにreplaceでは、相対パス指定ができない
copy /Y .\doc\*.man %KIYO_BIN%\\Help\man

@pause
