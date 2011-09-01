class CSProjGen
  def self.generate path, fix_versions
    File.open(path, 'w') {|f| f.puts gen_str(fix_versions) }
  end

  def self.gen_str fix_versions
    include_files = fix_versions.map do |fv|
      fv[:messages].map do |msg|
        "    <Compile Include=\"Message\\#{fv[:version]}\\#{msg[:name]}.cs\" />"
      end
    end

    fix_versions.each do |fv|
      include_files << "    <Compile Include=\"Message\\#{fv[:version]}\\MessageFactory.cs\" />"
      include_files << "    <Compile Include=\"Message\\#{fv[:version]}\\Message.cs\" />"
    end

<<HERE
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="3.5" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <ItemGroup>
#{include_files.join("\n")}
  </ItemGroup>
</Project>
HERE
  end
end

