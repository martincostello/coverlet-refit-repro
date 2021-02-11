#! /usr/bin/pwsh
dotnet test -c debug -verbosity:diagnostic -bl:msbuild.binlog -noconsolelogger
