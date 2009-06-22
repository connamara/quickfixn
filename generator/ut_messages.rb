require 'test/unit'
require 'rexml/document'
require 'message'

class MessageTester < Test::Unit::TestCase

  def test_simple_message
    doc = REXML::Document.new( File.new( 'fixex.xml' ) )
    field_map = Field.process_all( doc.elements['fix/fields'] )
    component_map = Component.process_all( doc.elements["fix/components"], field_map )
    messages = Message.process_all( doc.elements["fix/messages"], field_map, component_map )
    reject = messages.select { |m| m.name == 'Reject' }.pop
    assert_not_nil reject
    assert_equal 'Reject', reject.name
    assert_equal '3', reject.msgtype
    assert_equal 'admin', reject.msgcat
    assert_equal 7, reject.num_elements
    reject.each_element { |f| assert_equal FieldEntry, f.class }
    refseqnum = reject.elements.select { |el| el.field.name.eql?('RefSeqNum') }.pop
    assert refseqnum.required?
    assert_equal 'RefSeqNum', refseqnum.field.name
    assert_equal '45', refseqnum.field.num
    assert_equal 'SEQNUM', refseqnum.field.ftype
  end
  
  def test_message_with_groups
    doc = REXML::Document.new( File.new( 'fixex.xml' ) )
    field_map = Field.process_all( doc.elements['fix/fields'] )
    component_map = Component.process_all( doc.elements["fix/components"], field_map )
    messages = Message.process_all( doc.elements["fix/messages"], field_map, component_map )
    ioi = messages.select { |m| m.name == 'IndicationOfInterest' }.pop
    assert_not_nil ioi
    assert_equal 'IndicationOfInterest', ioi.name
    assert_equal '6', ioi.msgtype
    assert_equal 'app', ioi.msgcat
    assert_equal 27, ioi.num_elements

    ioi.each_element do |el1|
      if el1.group? and el1.group.name.eql?( 'NoLegs' )
        assert_equal 3, el1.group.num_elements
        el1.group.each_element do |el2|
          if el2.component? and el2.component.name.eql?( 'LegStipulations' )
            assert_equal 1, el2.component.num_elements
            el2.component.each_element do |el3|
              assert el3.group?
              assert !el3.required?
              assert_equal 2, el3.group.num_elements
            end
          end
        end
      end
    end
  end
end
