FOR %%f in ("*.in.txt") DO (
	SETLOCAL EnableDelayedExpansion
    SET "file=%%f"
    matching.exe < "%%f" > "!file:.in.txt=.out.txt!"
)
