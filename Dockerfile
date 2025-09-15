# Step 1: Use .NET runtime (Windows container)
FROM mcr.microsoft.com/dotnet/runtime:8.0-windowsservercore-ltsc2022 AS runtime

# Step 2: Set working directory
WORKDIR C:\\app

# Step 3: Copy compiled WinForms binaries (handle spaces)
COPY ["HOTELMANGMENT SYSTEM/HOTELMANGMENT SYSTEM/bin/Debug/net8.0-windows/", "."]

# Step 4: ENTRYPOINT with exact EXE name (space escaped)
ENTRYPOINT ["HOTELMANGMENT SYSTEM.exe"]
