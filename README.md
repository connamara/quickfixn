[![QuickFIX/N][1]][0]

System Setup
------------
This project requires MSBuild, NUnit, Ruby (1.9.2), and xsltproc.

You can get xsltproc via cygwin, or by installing libxslt (which requires
libxml2 and zlib).

You can get Ruby from rubyinstall.org/downloads

Code Generation
---------------
To generate the code from Data Dictionaries, you need Ruby/JRuby (http://jruby.org/download) and the Nokogiri gem:

    gem install nokogiri
    ruby generator/generate.rb


Build
-----
To build the project, run:

    build.bat

You can also override the default target, configuration, and .NET framework version by giving command line arguments:

    build.bat Rebuild Release v3.5


The build.bat script expects MSBuild.exe to be on your PATH.  If you run it
from a Visual Studio cmd shell, this should not be a problem.  However, if you
run it from some other shell (e.g. cygwin), you may need to append something
like:

    C:\WINDOWS\Microsoft.NET\Framework\v3.5

to your PATH environment variable.


Unit Tests
----------
To run the NUnit tests, run:

    unit_test.bat

An HTML report of the test results will then be available here:

    UnitTests\bin\Release\UnitTests.html

To run a Unit Test in the debugger (does not work in VS Express):

1. Right-click UnitTests project, click 'Properties'
2. Go to Debug tab
3. Change Start Action to 'Start external program: C:\Program Files\NUnit-2.5.9.10348\bin\net-2.0\nunit.exe'
   (change the path to what is appropriate for your system)
4. Set your 'Command line arguments' to 'C:\dev\qfnet\quickfix.net\UnitTests\bin\Debug\UnitTests.dll'
   (change the path to what is appropriate for your system)
5. Set your 'Working directory' to 'C:\dev\qfnet\quickfix.net\UnitTests\bin\Debug\'
   (change the path to what is appropriate for your system)
6. Open NUnit in debugger as follows:
   Right-click UnitTests, choose Debug->Start New Instance
7. NUnit GUI will open and VS will be in debugger mode.  You can choose and run tests.
   If you recompile, you may need to close and relaunch NUnit.


Acceptance Tests
----------------
To run the full suite of acceptance tests:

    acceptance_test.bat

An HTML report of the test results will then be available here:

    AcceptanceTests\AcceptanceTests.html

To run one particular acceptance test, e.g. fix42\14e_IncorrectEnumValue.def:

    cd AcceptanceTests
    runat.bat release 5001 definitions\server\fix42\14e_IncorrectEnumValue.def

The test results will then be available in AcceptanceTests\TestResults.xml and
debug information will be available in the AcceptanceTests\log directory.

To run a test with the debugger, 

  1. Open the solution file in Visual Studio
  2. Right click on "AcceptanceTest" project
  3. Open the "properties" tab
  4. Click "Debug" on the left hand nav bar
  5. Set "Command line arguments" to "cfg\at.cfg"
  6. Set the working folder to "... AcceptanceTest"
  7. Save the properties
  7. Right click the "AcceptanceTest" project, go to Debug -> Start New Instance
  8. In command terminal, go into "AcceptanceTest" directory
  9. Run: `ruby Runner.rb 127.0.0.1 5001 definitions\server\fix42\YourTestName.def`


Packaging and Releasing
-----------------------
Prerequisites: 

  1. [git] (http://code.google.com/p/msysgit/) is setup and in your Windows PATH
  2. ruby is installed and in your Windows PATH
  3. nokogiri and rubyzip gems are installed.
  4. MSBuild.exe (v3.5) is in your Windows PATH
  5. [Python 2.7] (http://www.python.org/getit/releases/2.7)
  6. [s3cmd 1.0.1] (http://sourceforge.net/projects/s3tools/files/s3cmd). After you download and extract the files, run `python setup.py install`. Then run `python C:\Python27\Scripts\s3cmd --configure`, and enter the access key (s3 account) anad secret (s3 account), found on the [wiki] (http://wiki.private.connamara.com/index.php?title=EC2)

First, make sure you're on master, and you have the most recent changes:

    git checkout master
    git pull

Next, the download page needs to be updated to point to the new zip. This must be done first, so the changes to the page will be part of the version tag. The following script will update the download page and commit the changes into git:

    update_download_page.bat <TAGNAME>
	
Then, create a tag:

    git tag -a <TAGNAME> -m "Created a tag for version <TAGNAME>"

Next, run `package_release.bat <TAGNAME>` to build, package, and upload QuickFIX/n to the web.

After the script is done, you will need to manually push the tag:
    
    git checkout master
	git push origin <TAGNAME>

Finally [Deploy the website](quickfixn/wiki/Deploying-the-website).

Website
-------

The website is a small Ruby Sinatra application.

For development, you should install Ruby 1.9.2 and the bundler gem then
bundle:

    gem install bundler
    bundle

Upon installing the gems, you can run this in the top directory to
start the website:

    thin start

`thin` automatically picks up the Rackfile `config.ru` in the top
directory.

Website specific files live in `/web`.

The website also serves tutorial files from the `/tutorial` directory

Markdown should be used for all tutorial files whenever possible, so
that viewers of the source can easily read plain text documentation.

For development purposes, you can install the `shotgun` web server;
this will re-load the website on every request. To start the website
with shotgun, simply run shotgun at the top directory:

    shotgun -p 3002


[0]: http://quickfixn.org
[1]: http://quickfixn.org/images/qfn-logo/QuickFIX-n_logo-small.png
