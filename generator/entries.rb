require 'field'
require 'container'
require 'required'

module TypeHelper
  def field?
    self.class == FieldEntry
  end
  
  def component?
    self.class == ComponentEntry
  end
  
  def group?
    self.class == GroupEntry
  end
end

class FieldEntry
  attr_reader :field
  include Required, TypeHelper
  
  def initialize( element, req, fmap, cmap )
    @req = req
    @field = Field.new( element )
  end
end

class ComponentEntry
  attr_reader :component
  include Required, TypeHelper

  def initialize( element, req, fmap, cmap )
    @req = req
    @component = Component.new( element, fmap, cmap )
  end
end

class GroupEntry
  attr_reader :group
  include Required, TypeHelper

  def initialize( element, req, fmap, cmap )
    @req = req
    @group = Group.new( element, fmap, cmap )
  end
end


