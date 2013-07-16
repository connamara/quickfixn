$LOAD_PATH << File.dirname(__FILE__)

require 'rubygems'
require 'fix_dictionary'
require 'fields_gen'
require 'messages_gen'
require 'proj_gen'
require 'message_factory_gen'
require 'message_types_gen'
require 'securerandom'

class Generator  
  def self.generate   
    generator = Generator.new
    
    generator.generate_project('dd15ebb0-b22b-012f-b4c9-0019b945714e', 'FIX40',    nil, nil)
    generator.generate_project('4e3125c0-b22c-012f-b4c9-0019b945714e', 'FIX41',    nil, nil)
    generator.generate_project('5985acf0-b22c-012f-b4c9-0019b945714e', 'FIX42',    nil, nil)
    generator.generate_project('622d5210-b22c-012f-b4c9-0019b945714e', 'FIX43',    nil, nil)
    generator.generate_project('627caca0-b22c-012f-b4c9-0019b945714e', 'FIX44',    nil, nil)
    generator.generate_project('62c37b70-b22c-012f-b4c9-0019b945714e', 'FIX50',    nil, nil)
    generator.generate_project('119506e5-c552-49cd-923b-847aeb592ff2', 'FIX50SP1', nil, nil)
    generator.generate_project('e3fb654c-c9ab-4701-8912-511aca2cc0b2', 'FIX50SP2', nil, nil)
	
	generator.generate_derivatives_projects()
  end
  
  def generate_derivatives_projects
    Dir[specbase + "/*/"].each { |fd| 
	  Dir[fd + "/*.xml"].each { |fs|
	    specpath = File.join(fd, File.basename(fs))
		fixver=File.basename(fs,File.extname(fs))		 	
	    generate_project(SecureRandom.uuid, fixver, fd.split('/')[-1], specpath) 
      } 
	}
  end

  def specbase
    File.join File.dirname(__FILE__), "..", "spec", "fix"
  end
  
  def spec_file_path fixver
    File.join specbase, "#{fixver}.xml"
  end
    
  def generate_project proj_uuid, fixver, fixbasever, specpath

    puts 'Generating project for ' + fixver + ' messages'

   if fixbasever == nil
     fixbasever = fixver
    end

	src_path = File.join File.dirname(__FILE__), '..', 'QuickFIXn'
	
	if specpath == nil
		specpath = spec_file_path(fixver)
	end
	
	puts "loading #{fixver} specs from #{specpath}"
    fixspec = FIXDictionary.load(specpath)
		
    # Generate csproj
    CSProjGen.generate(src_path, [ {:version=>fixver, :baseversion=>fixbasever, :messages=>fixspec.messages, :uuid=>proj_uuid} ])
	
    # Generate messages
    msgs_path = File.join(src_path, 'Message')
    MessageGen.generate(fixspec.messages,  msgs_path, fixver, fixbasever)

	fields_to_exclude = get_excluded_fields 
	
    # Generate Fields.cs and FieldTags.cs
    # TODO: Add namespace
    field_names =  fixspec.fields.keys
	
	# Generate tags before exclusion
	tags = field_names.map {|fn| fixspec.fields[fn]}
	
	field_names = field_names - fields_to_exclude

	# Generate fields after exclusion
    fields = field_names.map {|fn| fixspec.fields[fn]}
	
    fields_path = File.join(src_path, 'Message', fixver, 'Fields.cs')
    tags_path = File.join(src_path, 'Message', fixver, 'FieldTags.cs')    
	
    FieldGen.generate(fixver, fields, fields_path, tags, tags_path)
	
    # Generate message factory
    MessageFactoryGen.generate(fixspec.messages, msgs_path, fixver, fixbasever)
    
    # Generate message types
    MessageTypesGen.generate(fixspec.messages, msgs_path, fixver)

  end
  
  def get_excluded_fields
  
	src_path = File.join File.dirname(__FILE__), '..', 'QuickFIXn', 'Fields', 'Fields.cs'
	
	#fields = Set.new File.foreach(src_path).select { |line| line.index (/public sealed class .+ : .+Field/) }.map { |classdef| classdef.gsub(/^(.*public sealed class).+(: .+Field.*$)/, '') }
	fields = File.foreach(src_path).select { |line| line.index (/public sealed class .+ : .+Field/) }
	fields = fields.map { |classdef| classdef.gsub(/^(.*public sealed class) /, '') }
	fields = fields.map { |classdef| classdef.gsub(/(: .+Field.*$)/, '') }
	fields = fields.map { |classdef| classdef.strip! }

	fields = fields - ["MsgType" ,"ApplVerID"]
	
    #puts fields.to_a
	
	fields
  
  end
  
end

Generator.generate
