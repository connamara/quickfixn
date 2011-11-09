require 'zip/zip'
require 'zip/zipfilesystem'

if ARGV[0].nil? or ARGV[1].nil?
  puts "Usage: ruby create_zip.rb <SRC DIR> <DEST_ZIP_FILE>"
  exit 1
end

src = File.join(Dir.pwd, ARGV[0])
dest = File.join(Dir.pwd, ARGV[1])

Zip::ZipFile.open(dest, 'w') do |zipfile|
    Dir["#{src}/**/**"].reject{|f|f==dest}.each do |file|
      zipfile.add(file.sub(src+'/',''),file)
    end
end