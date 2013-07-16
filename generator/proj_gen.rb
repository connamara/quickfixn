require 'fileutils'

class CSProjGen
  def self.generate srcpath, fix_versions
    fix_versions.map do |fv|
      path = File.join(srcpath, "Message/#{fv[:version]}/QuickFix.#{fv[:version]}.csproj")
	  FileUtils.mkdir_p(File.dirname(path))
      File.open(path, 'w') {|f| f.puts gen_str(fv) }	  
	  update_solution(fv)
	  
    end
  end
  
  def self.update_solution fv
  
    uuid = fv[:uuid].upcase
	projectname = "QuickFix.#{fv[:version]}"
	projectpath = "QuickFIXn\\Message\\#{fv[:version]}\\QuickFix.#{fv[:version]}.csproj"
	
	searchre = Regexp.escape("Project(\"{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}\") = \"#{projectname}\", \"#{projectpath}\",")	
	replacere = searchre + ',.*$'
	slnpath = File.join File.dirname(__FILE__), "..", "QuickFIXn.sln"
	text = File.read(slnpath)
	projectref = "Project(\"{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}\") = \"#{projectname}\", \"#{projectpath}\", \"{#{uuid}}\""
    
	if text.index(/#{searchre}/) != nil then
	  new_contents = text.gsub(/#{replacere}/, projectref)
	else
	  new_contents = text.gsub(/^Global$/, projectref + "\nEndProject\nGlobal")	
	end
	
	# To write changes to the file, use:
	#puts new_contents
	File.open(slnpath, "w") {|file| file.puts new_contents }
  end

  def self.gen_str fv
    include_files = []

    include_files << "    <Compile Include=\"MessageFactory.cs\" />"
    include_files << "    <Compile Include=\"MsgTypes.cs\" />"
    include_files << "    <Compile Include=\"Messages.cs\" />"
    include_files << "    <Compile Include=\"Fields.cs\" />"
    include_files << "    <Compile Include=\"FieldTags.cs\" />"
    include_files << "    <Compile Include=\"..\\AssemblyInfo.cs\" />"
    
    master_version = fv[:version]
    master_version_relative_path = master_version
	if master_version != fv[:baseversion] then
		master_version_relative_path = "#{fv[:baseversion]}\\#{master_version}"
	end
    uuid = fv[:uuid]

<<HERE
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{#{uuid}}</ProjectGuid>
    <OutputType>Library</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>QuickFix.#{master_version}</RootNamespace>
    <AssemblyName>QuickFix.#{master_version}</AssemblyName>
    <TargetFrameworkVersion>v4.5.2</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
    <SignAssembly>false</SignAssembly>
    <TargetFrameworkProfile />
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>..\\..\\bin\\Debug\\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <Prefer32Bit>false</Prefer32Bit>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>..\\..\\bin\\Release\\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <Prefer32Bit>false</Prefer32Bit>
  </PropertyGroup>
  <PropertyGroup>
    <AssemblyOriginatorKeyFile>..\\..\\sn.snk</AssemblyOriginatorKeyFile>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <ProjectReference Include="..\\..\\QuickFix.csproj">
      <Project>{D67079DA-6C49-48B2-93AB-1C3E879F5A0B}</Project>
      <Name>QuickFix</Name>
    </ProjectReference>
  </ItemGroup>  
  <ItemGroup>
#{include_files.join("\n")}
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="..\\..\\..\\spec\\fix\\#{master_version_relative_path}.xml">
      <Link>#{master_version}.xml</Link>
    </EmbeddedResource>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\\Microsoft.CSharp.targets" />  
</Project>
HERE
  end
end

