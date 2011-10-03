$LOAD_PATH << File.dirname(__FILE__)
require 'sinatra'
require 'mdengine'

set :views, ['web/views', 'tutorial']

Tilt.register MarkdownEngine, :md
Tilt.prefer   MarkdownEngine

helpers do
  def mdalbino(*args) 
    render(:md, *args) 
  end

  def stylesheet f
    css_uri = uri("css/#{f}.css")
    "<link rel='stylesheet' href='#{css_uri}' type='text/css'>"
  end

  def js f
    js_uri = uri("js/#{f}.js")
    "<script type='text/javascript' src='#{js_uri}'></script>"
  end

  def img f, opts={}
    img_uri = uri("images/#{f}")
    alt = opts[:alt] || f
    "<img src='#{img_uri}' alt='#{alt}'></img>"
  end

  def nav_div nav, curnav
    css_class = curnav == nav ? 'navitem navitem-sel' : 'navitem'
    "<div class='#{css_class}'>"
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
  @curnav = 'docs'
  mdalbino file.to_sym, :layout_engine=>:erb
end
