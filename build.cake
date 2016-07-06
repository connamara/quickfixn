#tool "nuget:?package=NUnit.Runners&version=2.6.0"

using System.Xml.Xsl;

var target = Argument<string>("target", "Default");
var buildTarget = Argument<string>("buildTarget", "Rebuild");
var buildConfiguration = Argument<string>("buildConfiguration", "Release");
var netVersion = Argument<string>("netVersion", "v3.5");

Task("Build")
    .Does(() =>
{
    DotNetBuild("./QuickFIXn.sln", settings => settings
        .WithTarget(buildTarget)
        .SetConfiguration(buildConfiguration)
        .WithProperty("TargetFrameworkVersion", netVersion));
});

Task("Unit-Tests")
    .IsDependentOn("Build")
    .Does(() =>
{
    using (new CurrentDirectory("UnitTests/bin/Release/"))
    {
        DeleteFiles("TestResult.xml");
        DeleteFiles("UnitTests.html");
        
        try 
        {
            NUnit("UnitTests.dll");
        } 
        catch (Exception exception) 
        {
            // Report Nunit exit code -100 (unhandled exceptions in test assembly)
            Error(exception.Message);
        }
        
        XsltProcessor("TestResult.xml", "../../nunit.xsl", "UnitTests.html");
    }
});

Task("Default")
    .IsDependentOn("Unit-Tests");

// As suggested here: https://github.com/connamara/quickfixn/issues/104
public void XsltProcessor(string inputFile, string styleSheet, string outputFile)
{
    var xslTransform = new XslCompiledTransform();

    xslTransform.Load(styleSheet);
    
    xslTransform.Transform(inputFile, outputFile);
}

class CurrentDirectory : IDisposable
{
    private readonly string previousCurrentDir;
    
    public CurrentDirectory(string currentDirectory)
    {
        previousCurrentDir = System.IO.Directory.GetCurrentDirectory();
        Environment.CurrentDirectory = currentDirectory;
    }
    
    public void Dispose()
    {
        Environment.CurrentDirectory =  previousCurrentDir;
    }
}

RunTarget(target);