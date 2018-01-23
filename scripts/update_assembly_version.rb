

def print_usage_and_die
  puts "Usage: ruby update_assembly_version.rb version csproj_filepath"
  puts "Parameters:"
  puts "    version: Where version is a string \"vN.N.N\" (e.g. v2.0.143)"
  puts "    assembly_filepath: Path to a VisualStudio .csproj file"
  exit(1)
end

def is_correct_pattern? ver
  return ver.match(/^v[\d]+[.][\d]+[.][\d]+$/)
end


if ARGV[0].nil? or ARGV[1].nil?
  print_usage_and_die
end

if not is_correct_pattern? ARGV[0]
  puts "Invalid version string."
  print_usage_and_die
end

vers = ARGV[0].sub(/^v/,"") #remove the leading v
csprojpath = ARGV[1]


if not (File.exists?(csprojpath) and File.writable?(csprojpath))
  puts "Can't open file \"#{csprojpath}\" for writing."
  puts "(Current path: #{Dir.pwd})"
  print_usage_and_die
end

contents = IO.read(csprojpath)
contents.sub!(/<Version>[^<]*<\/Version>/, "<Version>#{vers}</Version>")

File.open(csprojpath,"w") {|f|
  f.write(contents)
}


