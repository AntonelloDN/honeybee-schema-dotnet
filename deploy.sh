#!/usr/bin/env bash

nuget pack src/HoneybeeDotNet/HoneybeeDotNet.csproj -Properties Configuration=Release -Version $BUILD_VERSION -Verbosity detailed && \
nuget push HoneybeeDotNet.$BUILD_VERSION.nupkg -ApiKey $NUGET_API_KEY -Source https://api.nuget.org/v3/index.json