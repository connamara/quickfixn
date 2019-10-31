def print_usage_and_die
  puts "Usage: ruby update_assembly_version.rb version csproj1 csproj2 ..."
  puts "Parameters:"
  puts "    version: Where version is a string \"vN.N.N\" (e.g. v2.0.143)"
  puts "    csprojN: a VisualStudio .csproj file"
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

vers = ARGV.shift.sub(/^v/,'') #remove the leading v

puts

ARGV.each do |csproj|
  print "Attempting to change #{csproj}: "

  unless (File.exists?(csproj) and File.writable?(csproj))
    puts "FAILED."
    puts "** Can't open file #{csproj} for writing."
    puts "** (Current path: #{Dir.pwd})"
    exit(1)
  end

  begin
    contents = IO.read(csproj)
    contents.sub!(/<Version>[^<]*<\/Version>/, "<Version>#{vers}</Version>")

    File.open(csproj,"w") {|f|
      f.write(contents)
    }
    puts "SUCCEEDED."

  rescue StandardError
    puts "FAILED."
    puts "** Exception raised."
    puts
    raise
  end
end

puts "Assembly version update complete."
