# unityproj
unityproj is a file with ext .unityproj OR exe that opens a unity project when you double-click on it.

the way this works is it gets the unity version from "Project\ProjectSettings\ProjectVersion.txt" first line remove 0, 17 boom aqqierd version
then in reg we look at '"HKEY_CURRENT_USER\Software\Unity Technologies\Installer\Unity " + version + "\Location " + x64 if 64, 32 if 32' boom aqqierd location
then do Open location + '\Editor\Unity.exe', 'openProject "' + Project + '"'

Project = Environment.CurrentDirectory
