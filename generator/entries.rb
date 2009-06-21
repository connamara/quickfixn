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
    name = element.attributes['name']
    @field = fmap[name]
  end
end

class ComponentEntry
  attr_reader :component
  include Required, TypeHelper

  def initialize( element, req, fmap, cmap )
    @req = req
    component_name = element.attributes['name']
    if cmap.has_key?( component_name )
      @component = cmap[component_name]
    else
      @component = Component.new( element, fmap, cmap )
    end
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


