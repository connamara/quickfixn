require 'redcarpet'
require 'albino'

class MarkdownAlbinoEngine < Tilt::Template

  class MarkdownAlbino < Redcarpet::Render::HTML
    def block_code(code, language)
      return "<pre class='highlight'>#{code}</pre>" if language.nil?
      Albino.colorize(code, language)
    end
  end

  self.default_mime_type = 'text/html'

  def self.engine_initialized?
    defined? ::MarkdownAlbino
  end

  def initialize_engine
  end

  def prepare
    @engine = Redcarpet::Markdown.new(MarkdownAlbino, :fenced_code_blocks => true)
    @output = nil
  end

  def evaluate(scope, locals, &block)
    @output ||= @engine.render(data)
  end
end

