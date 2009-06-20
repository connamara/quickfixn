require 'test/unit'
require 'rexml/document'
require 'container'

class ComponentTester < Test::Unit::TestCase

  def test_simple_component
     doc = REXML::Document.new( File.new( 'fixex.xml' ) )
     field_map = Field.process_all( doc.elements['fix/fields'] )
     component_map = Component.process_all( doc.elements["fix/components"], field_map )
     oqd = component_map['OrderQtyData']
     assert_not_nil oqd
     assert_equal 'OrderQtyData', oqd.name
     assert_equal 5, oqd.elements.size
     oqd.each_element { |f| assert_equal FieldEntry, f.class }
     oqd.each_element { |f| assert_equal false, f.required? }
  end
  
  def test_component_with_groups
     doc = REXML::Document.new( File.new( 'fixex.xml' ) )
     field_map = Field.process_all( doc.elements['fix/fields'] )
     component_map = Component.process_all( doc.elements["fix/components"], field_map )
     party = component_map['Parties']
     assert_not_nil party
     assert_equal 'Parties', party.name
     assert_equal 1, party.elements.length
     party.each_element do |el1|
       assert el1.group?
       assert_equal 4, el1.group.elements.size
       el1.group.each_element do |el2|
         if el2.group?
           assert_equal 2, el2.group.elements.size
           el2.group.each_element { |el3| assert el3.field? }
         else
           # verify element is one of the three fields in the xml doc
           assert el2.field?
           assert %w[448 447 452].include?( el2.field.num.to_s ), "field.num = #{el2.field.num}"
         end
       end
     end
  end
end
