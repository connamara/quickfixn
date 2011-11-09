require 'rubygems'
require 'aws/s3'

if ARGV[0].nil?
  puts "Usage: ruby upload_to_s3.rb <ZIPFILE>"
  exit 1
end

access_key = "0X9JG3E4ARW3TGYX68G2"
secret_key = "ZHg5yFD+O86npvzSzGT5EOYWINqm+sMkTdnh+V8d"
bucket = "quickfixn"
file = File.join(Dir.pwd, ARGV.first)

AWS::S3::Base.establish_connection!(
	:access_key_id => access_key, 
	:secret_access_key => secret_key)

AWS::S3::S3Object.store(File.basename(file),
	open(file),
	bucket,
	:access => :public_read)

