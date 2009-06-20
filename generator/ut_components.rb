require 'test/unit'
require 'rexml/document'
require 'container'

class ComponentTester < Test::Unit::TestCase

  def test_process_components
     doc = REXML::Document.new( File.new( 'fixex.xml' ) )
     field_map = Field.ProcessAll( doc.elements['fix/fields'] )
     component_map = Component.ProcessAll( doc.elements["fix/components"], field_map )
     oqd = component_map['OrderQtyData']
     assert_not_nil oqd
     assert_equal 'OrderQtyData', oqd.name
     assert_equal 5, oqd.elements.size
     oqd.elements.each { |f| assert_equal FieldEntry, f.class }
  end
end
