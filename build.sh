#!/bin/sh

TARGET=$1
CONFIGURATION=$2
NET_VERSION=$3
TOOLSET_VERSION=$4

[ -z $TARGET ] && TARGET=Rebuild
[ -z $CONFIGURATION ] && CONFIGURATION=Release
[ -z $NET_VERSION ] && NET_VERSION=v4.5.2
[ -z $TOOLSET_VERSION ] && TOOLSET_VERSION=15.0

BUILD_CMD="xbuild QuickFIXn.sln /t:${TARGET} /p:Configuration=${CONFIGURATION};TargetFrameworkVersion=${NET_VERSION} /tv:${TOOLSET_VERSION}"
echo "Build command: $BUILD_CMD"
exec $BUILD_CMD
