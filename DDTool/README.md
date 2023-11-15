# DDTool
DataDictionary analyzer/codegen for QuickFIX/n

It doesn't do much analyzing yet.

It intentionally has minimal dependencies, and the UTs use
Microsoft's default TestFramework
(which isn't great, but good enough for this).

## To run

To parse DDs, but only analyze (not generate):  
`> dotnet run --project DDTool <ddFile> <ddFile>...`

To parse DDs and generate:  
`> dotnet run --project DDTool --outputdir <qfRepoDir> <ddFile> <ddFile>...`
