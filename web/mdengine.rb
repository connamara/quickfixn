require 'redcarpet'

class MarkdownEngine < Tilt::Template

  self.default_mime_type = 'text/html'

  def self.engine_initialized?
    defined? ::MarkdownEngine
  end

  def initialize_engine
  end

  def prepare
    @engine = Redcarpet::Markdown.new(Redcarpet::Render::HTML, :fenced_code_blocks => true)
    @output = nil
  end

  def evaluate(scope, locals, &block)
    @output ||= @engine.render(data)
  end
end

