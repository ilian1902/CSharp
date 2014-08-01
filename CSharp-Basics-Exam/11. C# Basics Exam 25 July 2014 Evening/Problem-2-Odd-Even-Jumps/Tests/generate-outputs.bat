FOR %%f in ("*.in.txt") DO (
	SETLOCAL EnableDelayedExpansion
    SET "file=%%f"
    jumps.exe < "%%f" > "!file:.in.txt=.out.txt!"
)
