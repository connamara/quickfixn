require 'at_xml_to_nunit_xml'
require 'test/unit'

class TestParser < Test::Unit::TestCase
    def test_case_success
        c = QuickFIXn::Case.new('definitions/server/fix50sp9/10_ohai.def', 'success')
        assert_equal '10_ohai', c.name 
        assert_equal 'Success', c.result
        assert_equal 'True', c.success
        assert_equal true, c.success?
    end

    def test_case_failure
        c = QuickFIXn::Case.new('definitions/server/fix50sp9/10_ohai.def', 'whatever')
        assert_equal '10_ohai', c.name 
        assert_equal 'Failure', c.result
        assert_equal 'False', c.success
        assert_equal false, c.success?
    end
end
