How To Use These Scripts To Release a New Build
===============================================

About each script
-----------------

These are all Powershell scripts, so make sure you have Powershell installed.

Run them with `pwsh <script>`.  Some take a version param e.g. `v1.23.45`.

### `Generate-Message-Sources.ps1`

Runs the code generator, to regenerate the message/field classes from the Data Dictionary xml files.

If you didn't change the DD, then this should have no effect.

### `Delete-Generated-Sources.ps1`

Deletes all generated sources.  Occasionally useful.

### `Bump-Versions.ps1`

Updates the "Version" tag in each csproj file.

### `Build-Zip-Release.ps1`

Builds zips for each project and puts them in `<reporoot>/tmp/zip`.

It will also leave unzipped archive dirs as artifacts.  
You can delete those if you don't need to see them.  
(This script deletes old artifacts when it starts each run.)

### `Build-NuGets.ps1`

Builds NuGet packages and puts them in `<reporoot>/tmp/nuget`

### `Push-NuGets.ps1`

Pushes the packages to NuGet.org.

You need to set env var `NUGET_QFN_API_KEY`.  To get a key, you need
to make a nuget.org account and then then generate one in your profile.
And then Grant needs to add you to the project.

(You could instead manually upload all 10 packages to nuget.org via the web page,
but that is painfully tedious.)



Release-Creation Procedure
--------------------------

This is documented here, for Connamara staff only:

https://sites.google.com/connamara.com/internal-qfn-release-procedure/


