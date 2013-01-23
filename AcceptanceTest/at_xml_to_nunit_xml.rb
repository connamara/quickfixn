module QuickFIXn

module ResultHelpers
    def result
        if success?
            "Success"
        else
            "Failure"
        end
    end

    def success
        if success?
            "True"
        else
            "False"
        end
    end
end

class Suite
    include ResultHelpers
    attr_accessor :total, :errors, :failures, :asserts, :fixtures
    
    def self.create_from_acceptance_test_xml_list xml_filename_list
        suite = Suite.new
        xml_filename_list.each { |fname| suite.add_fixture(Fixture::create_from_acceptance_test_xml(fname)) }
        suite
    end

    def initialize
        @fixtures = []
        @total = 0
        @errors = 0
        @failures = 0
        @asserts = 0
    end

    def add_fixture fixture
        @fixtures << fixture
        @total += fixture.total
        @errors += fixture.errors
        @failures += fixture.failures
        @asserts += fixture.asserts
    end

    def success?
        @failures == 0 && @errors == 0
    end

    def get_binding
        binding
    end
end

class Fixture
    include ResultHelpers
    attr_accessor :name, :total, :errors, :failures, :cases

    def self.create_from_acceptance_test_xml xml_filename
        require 'rubygems'
        require 'nokogiri'

        fixture = Fixture.new
        doc = Nokogiri::XML(File.open(xml_filename))
        doc.xpath('//at/test').each { |tc| fixture.cases << Case.new(tc['name'], tc['result'])}
        res = doc.xpath('//at/results').first
        fixture.total = res['total'].to_i
        fixture.failures = res['failures'].to_i
        fixture.name = File.basename(xml_filename, '.xml')
        fixture
    end
    
    def initialize
        @cases = []
        @total = 0
        @errors = 0
        @failures = 0
    end

    def asserts
        @cases.size
    end

    def success?
        res = true
        @cases.each do |testcase|
            res = false unless testcase.success?
        end
        res
    end
end

class Case
    include ResultHelpers
    attr_reader :name

    def initialize filename, result
        @name = File.basename(filename, '.def') # .gsub(/^definitions\/server\/\w+\//, '').gsub(/\.def/, '').strip
        @is_success = (result.downcase == "success") ? true : false
    end

    def success?
        @is_success
    end
end

end # module QuickFIXn

if $0 == __FILE__
    unless ARGV.size >= 2
        puts "usage: #{$0} OUT_FILE ERB_FILE [XML_FILE...]"
        raise SystemExit.new(2)
    end
    require 'erb'
    out_file = ARGV.shift
    template = ARGV.shift
    xml_files = (ARGV.empty?) ? Dir.glob("AcceptanceTests_*.xml") : Array.new(ARGV)
    suite = QuickFIXn::Suite::create_from_acceptance_test_xml_list(xml_files)
    erb = ERB.new(File.read(template))
    result = erb.result(binding)
    File.open(out_file, 'w') { |f| f.puts result }
end

