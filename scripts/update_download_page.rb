if ARGV[0].nil? or ARGV[1].nil?
  puts "Usage: ruby update_downloads_page.rb <PATH_TO_DOWNLOADS_PAGE> <VERSION_NO>"
  exit 1
end

page = File.join(Dir.pwd, ARGV[0])
ver = ARGV[1]

File.open(page, 'w') do |f|
    f.puts "Download\n========\n\nThe latest version of QuickFIX/n is #{ver}\n\nYou can download it [here] (http://quickfixn.s3.amazonaws.com/quickfixn-#{ver}.zip)"
end