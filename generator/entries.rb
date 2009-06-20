require 'field'
require 'container'
require 'required'

class FieldEntry
  attr_reader :field
  include Required
  
  def initialize( element, req, fmap, cmap )
    @req = req
    @field = Field.new( element )
  end
end

class ComponentEntry
  attr_reader :field
  include Required

  def initialize( element, req, fmap, cmap )
    @req = req
    @component = Component.new( element, fmap, cmap )
  end
end

class GroupEntry
  attr_reader :field
  include Required

  def initialize( element, req, fmap, cmap )
    @req = req
    @group = Group.new( element, fmap, cmap )
  end
end


