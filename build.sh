#!/bin/sh

TARGET=$1
CONFIGURATION=$2
NET_VERSION=$3

[ -z $TARGET ] && TARGET=Rebuild
[ -z $CONFIGURATION ] && CONFIGURATION=Release
[ -z $NET_VERSION ] && NET_VERSION=v3.5

BUILD_CMD="xbuild QuickFIXn.sln /t:${TARGET} /p:Configuration=${CONFIGURATION};TargetFrameworkVersion=${NET_VERSION}"
echo "Build command: $BUILD_CMD"
exec $BUILD_CMD
