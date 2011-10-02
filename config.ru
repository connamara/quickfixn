$LOAD_PATH << File.dirname(__FILE__)
$LOAD_PATH << File.dirname(__FILE__) + '/web'

require 'web/qfn_web'
run Sinatra::Application

