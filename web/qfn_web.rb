$LOAD_PATH << File.dirname(__FILE__)
require 'sinatra'
require 'mdengine'

set :views, ['web/views', 'tutorial']

Tilt.register MarkdownEngine, :md
Tilt.prefer   MarkdownEngine

helpers do
  def markdown(*args) 
    render(:md, *args) 
  end

  def stylesheet f, opts={}
    css_uri = opts[:remote] ? f : uri("css/#{f}.css")
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
    'QuickFIX/n - ' + upcase_words.join(' ')
  rescue => e
    puts 'PAGE TITLE ERROR: ' + e.inspect
    'QuickFIX/n'
  end
end

get '/' do
  erb :index
end

get '/download' do
  markdown :download, :layout_engine=>:erb
end

get '/help' do
  markdown :help, :layout_engine=>:erb
end

get '/about' do
  redirect '/about/about-us'
end

get '/about/:page' do |page|
  @title = page_title(page) 
  markdown :"about/#{page}", :layout_engine=>:erb
end

get '/tutorial' do
  redirect '/tutorial/creating-an-application'
end

get '/tutorial/:tutorial' do |tutorial|
  @title = page_title(tutorial) 
  markdown tutorial.to_sym, :layout_engine=>:erb
end

not_found do
  markdown :not_found, :layout_engine=>:erb
end

error do
  puts env['sinatra.error'].inspect
  markdown :error, :layout_engine=>:erb
end


