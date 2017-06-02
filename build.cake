#tool "nuget:?package=NUnit.Runners&version=2.6.4"

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

        NUnit("UnitTests.dll");
        
        XmlTransform(File("../../nunit.xsl"), File("TestResult.xml"), File("UnitTests.html"));
    }
});

Task("Default")
    .IsDependentOn("Unit-Tests");

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