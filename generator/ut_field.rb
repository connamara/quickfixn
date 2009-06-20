require 'test/unit'
require 'rexml/document'
require 'field'

class FieldTester < Test::Unit::TestCase

  def test_field
     doc = REXML::Document.new( File.new( 'fixex.xml' ) )
     doc.elements["fix/fields"].elements.each do |field| 
       @xml_side = field if 'Side'.eql?( field.attributes['name'] )
       @xml_sci = field if 'SenderCompID'.eql?( field.attributes['name'] )
     end
     
     side = Field.new( @xml_side )
     assert_equal 'Side', side.name
     assert_equal '54', side.num
     assert_equal 'CHAR', side.ftype
     assert_equal 16, side.values.length
     
     sender_comp_id = Field.new( @xml_sci )
     assert_equal '49', sender_comp_id.num
     assert_equal 'SenderCompID', sender_comp_id.name
     assert_equal 'STRING', sender_comp_id.ftype
     assert_equal 0, sender_comp_id.values.length
  end
  
  def test_process_fields
    doc = REXML::Document.new( File.new( 'fixex.xml' ) )
    fields = Field.ProcessAll( doc.elements["fix/fields"] )
    
    side = fields['Side']
    assert_equal 'Side', side.name
    assert_equal '54', side.num
    assert_equal 'CHAR', side.ftype
    assert_equal 16, side.values.length
    
    sender_comp_id = fields['SenderCompID']
    assert_equal '49', sender_comp_id.num
    assert_equal 'SenderCompID', sender_comp_id.name
    assert_equal 'STRING', sender_comp_id.ftype
    assert_equal 0, sender_comp_id.values.length
  end
end
