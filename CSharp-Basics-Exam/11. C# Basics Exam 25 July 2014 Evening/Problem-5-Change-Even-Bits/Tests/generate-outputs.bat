FOR %%f in ("*.in.txt") DO (
	SETLOCAL EnableDelayedExpansion
    SET "file=%%f"
    evenbits.exe < "%%f" > "!file:.in.txt=.out.txt!"
)
