## nocon-runner

Run an executable file without a console.

Syntax:

```
nocon-runner <COMMAND> [<ARG1>[ <ARG2>[ <ARGN>]
```

Generate the executable using the following:

```
dotnet publish -r win-x64 -c Release /p:PublishSingleFile=true /p:PublishTrimmed=true
```