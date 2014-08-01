FOR %%f in ("*.in.txt") DO (
	SETLOCAL EnableDelayedExpansion
    SET "file=%%f"
    eletricity.exe < "%%f" > "!file:.in.txt=.out.txt!"
)
