FOR %%f in ("*.in.txt") DO (
	SETLOCAL EnableDelayedExpansion
    SET "file=%%f"
    house.exe < "%%f" > "!file:.in.txt=.out.txt!"
)
