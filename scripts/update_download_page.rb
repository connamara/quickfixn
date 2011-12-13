require 'rubygems'
require 'mustache'

if ARGV[0].nil? or ARGV[1].nil?
  puts "Usage: ruby update_downloads_page.rb <PATH_TO_DOWNLOADS_PAGE> <VERSION_NO>"
  exit 1
end

Mustache.template_file = File.join(File.dirname(__FILE__), 'downloads.mustache')
view = Mustache.new
view[:latest_version] = ARGV[1]
view[:previous_versions] = prev_versions = `git tag -l`.split("\n").reverse

File.open(File.join(Dir.pwd, ARGV[0]), 'w') do |f|
    f.puts view.render
end
