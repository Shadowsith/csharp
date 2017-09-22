echo Building:
mcs -t:library interface.cs
mcs -r:interface.dll main.cs
echo Finished!
