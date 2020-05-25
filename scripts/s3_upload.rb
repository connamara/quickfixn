require 'rubygems'
require 'aws-sdk'

if ARGV[0].nil? or ARGV[1].nil? or ARGV[2].nil?
  puts "Usage: ruby upload_to_s3.rb <ZIPFILE> <ACCESS_KEY> <SECRET_KEY>"
  exit 1
end

access_key = ARGV[1]
secret_key = ARGV[2]
bucket = "quickfixn"
file = File.join(Dir.pwd, ARGV.first)

Aws.use_bundled_cert!
s3 = Aws::S3::Resource.new(
	access_key_id: access_key,
	secret_access_key: secret_key,
	region: 'us-east-1'
)

obj = s3.bucket(bucket).object(File.basename(file))
if obj.upload_file(file, acl: 'public_read')
	puts "Uploaded #{file} to bucket #{bucket}"
else
	puts "Could not upload #{file} to bucket #{bucket}!"
end
