require 'rubygems'
require 'aws/s3'

if ARGV[0].nil? or ARGV[1].nil? or ARGV[2].nil?
  puts "Usage: ruby upload_to_s3.rb <ZIPFILE> <ACCESS_KEY> <SECRET_KEY>"
  exit 1
end

access_key = ARGV[1]
secret_key = ARGV[2]
bucket = "quickfixn"
file = File.join(Dir.pwd, ARGV.first)

AWS::S3::Base.establish_connection!(
	:access_key_id => access_key, 
	:secret_access_key => secret_key)

AWS::S3::S3Object.store(File.basename(file),
	open(file),
	bucket,
	:access => :public_read)


