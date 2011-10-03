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

  def nav_div nav
    css_class = 'navitem'
    css_class += ' navitem-sel' if @request.path_info =~ Regexp.new(nav)
    "<a href='/#{nav}' class='#{css_class}'>"
  end

  def find_template(views, name, engine, &block)
    Array(views).each { |v| super(v, name, engine, &block) }
  end

  def side_nav href, text
    css_class = 'side-link span-7 last'
    css_class += ' side-link-sel' if href == @request.path_info
    "<a href='#{href}' class='#{css_class}'>#{text}</a>"
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

get '/download' do
  mdalbino :download, :layout_engine=>:erb
end

get '/help' do
  mdalbino :help, :layout_engine=>:erb
end

get '/about' do
  mdalbino :about, :layout_engine=>:erb
end

get %r{/tutorial/?(.*)} do |tutorial|
  tutorial = 'creating-an-application' if tutorial.nil? or tutorial.empty?
  @title = page_title(tutorial) 
  @curnav = 'docs'
  mdalbino tutorial.to_sym, :layout_engine=>:erb
end
