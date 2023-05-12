#!/bin/sh

CONFIGURATION=$1

[ -z $CONFIGURATION ] && CONFIGURATION=Release

BUILD_CMD="dotnet build -c ${CONFIGURATION}"
echo "Build command: $BUILD_CMD"
exec $BUILD_CMD
