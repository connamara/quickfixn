require 'test/unit'
require 'rexml/document'
require 'entries'

class EntryTester < Test::Unit::TestCase

  def test_field_entry
    doc = REXML::Document.new( File.new( 'fixex.xml' ) )
    doc.elements["fix/fields"].elements.each do |field| 
      @xml_side = field if 'Side'.eql?( field.attributes['name'] )
    end
    entry = FieldEntry.new( @xml_side, true, nil, nil )
    assert_equal 'Side', entry.field.name
    assert_equal '54', entry.field.num
    assert_equal 'CHAR', entry.field.ftype
    assert_equal 16, entry.field.values.length
    assert entry.required?
    entry = FieldEntry.new( @xml_side, false, nil, nil )
    assert !entry.required?
  end
end
