replace Capture.exe ^
%KIYO_BIN%\DirectShell

replace Capture.pdb ^
%KIYO_BIN%\DirectShell

::�w���v�t�@�C���̃R�s�[
::replace "./doc/capture.man" ^
::%KIYO_BIN%\Help\man
::�˃A�z�Ȃ��Ƃ�replace�ł́A���΃p�X�w�肪�ł��Ȃ�
copy /Y .\doc\*.man %KIYO_BIN%\\Help\man

@pause
