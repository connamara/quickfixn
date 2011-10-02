require 'sinatra'
require 'mdalbino'

set :views, ['web/views', 'tutorial']

Tilt.register MarkdownAlbinoEngine, :md
Tilt.prefer MarkdownAlbinoEngine

helpers do
  def mdalbino(*args) 
    render(:md, *args) 
  end

  def stylesheet f
    css_uri = uri("css/#{f}.css")
    "<link rel='stylesheet' href='#{css_uri}' type='text/css'>"
  end

  def find_template(views, name, engine, &block)
    Array(views).each { |v| super(v, name, engine, &block) }
  end

  def page_title f
    words = File.basename(f, '.md').split('-')
    upcase_words = words.map {|w| w[0].upcase + w[1..-1] }
    'QuickFIX/N - ' + upcase_words.join(' ')
  rescue => e
    puts 'PAGE TITLE ERROR: ' + e.inspect
    'QuickFIX/N'
  end
end

get '/' do
end

get '/tutorial/:file' do |file|
  @title = page_title(file) 
  mdalbino file.to_sym, :layout_engine=>:erb
end
