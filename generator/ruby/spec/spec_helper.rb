require 'rspec'
require_relative '../generator'

PROJECT_ROOT = File.expand_path("./../../../../", __FILE__)

RSpec.configure do |config|
  config.filter_run :focus
  config.run_all_when_everything_filtered = true
  config.order = :random
end
