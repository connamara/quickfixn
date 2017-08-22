require_relative 'spec_helper'

describe 'Component Replacement' do
  let(:xml) do
    <<-HERDOC
      <fix major="4" minor="1">
        <messages>
          <message name="Advertisement" msgtype="7" msgcat="app">
            <field name="AdvId" required="Y" />
            <component name="Instrument" required="Y" />
            <field name="AdvRefID" required="N" />
          </message>
        </messages>
        <components>
          <component name="Instrument">
            <field name="Symbol" required="Y" />
            <group name="NoSecurityAltID" required="N">
              <field name="SecurityAltID" required="N" />
              <component name="SomeComponent" />
              <field name="SecurityAltIDSource" required="N" />
            </group>
            <field name="Product" required="N" />
          </component>
          <component name="SomeComponent">
            <field name="SomeSymbol" required="Y" />
          </component>
        </components>
      </fix>
    HERDOC
  end

  describe '#parse' do
    it 'does something' do
      dd = DataDictionay.new(Nokogiri::XML(xml))

      expect(dd.messages[0].fields.count).to eq(5)
      expect(dd.messages[0].fields[0].name).to eq("AdvId")
      expect(dd.messages[0].fields[1].name).to eq("Symbol")
      expect(dd.messages[0].fields[2].name).to eq("NoSecurityAltID")
      expect(dd.messages[0].fields[3].name).to eq("Product")
      expect(dd.messages[0].fields[4].name).to eq("AdvRefID")

      expect(dd.messages[0].groups.count).to eq(1)
      expect(dd.messages[0].groups[0].name).to eq("NoSecurityAltID")
      expect(dd.messages[0].groups[0].fields[0].name).to eq("SecurityAltID")
      expect(dd.messages[0].groups[0].fields[1].name).to eq("SomeSymbol")
      expect(dd.messages[0].groups[0].fields[2].name).to eq("SecurityAltIDSource")
    end

    context 'groups' do
      it 'creates a singly linked list amongst nested groups (for MessageFactory)' do
        xdoc = Nokogiri::XML(File.read("#{PROJECT_ROOT}/spec/fix/FIX50SP2.xml"))
        dd   = DataDictionay.new(xdoc)

        ioi_msg = dd.find_message('IOI')
        sub_grp_1 = ioi_msg.groups.find   { |grp| grp.name == 'NoComplexEvents' }
        sub_grp_2 = sub_grp_1.groups.find { |grp| grp.name == 'NoComplexEventDates' }
        sub_grp_3 = sub_grp_2.groups.find { |grp| grp.name == 'NoComplexEventTimes' }

        expect(sub_grp_1.parent.name).to eq('IOI')
        expect(sub_grp_2.parent.name).to eq('NoComplexEvents')
        expect(sub_grp_3.parent.name).to eq('NoComplexEventDates')
      end

      describe '#parents' do
        it 'returns the concatenated version of parent group names' do
          xdoc = Nokogiri::XML(File.read("#{PROJECT_ROOT}/spec/fix/FIX50SP2.xml"))
          dd   = DataDictionay.new(xdoc)

          ioi_msg   = dd.find_message('IOI')
          sub_grp_1 = ioi_msg.groups.find   { |grp| grp.name == 'NoComplexEvents' }
          sub_grp_2 = sub_grp_1.groups.find { |grp| grp.name == 'NoComplexEventDates' }
          sub_grp_3 = sub_grp_2.groups.find { |grp| grp.name == 'NoComplexEventTimes' }

          expect(sub_grp_2.parents).to eq("IOI.NoComplexEventsGroup")
          expect(sub_grp_3.parents).to eq("IOI.NoComplexEventsGroup.NoComplexEventDatesGroup")
        end
      end
    end
  end

  # need to pass service pack if > fix 5.0
  describe MessageBase do
    it 'parses correctly' do
      [{version: 'FIX40',    service_pack: nil},
       {version: 'FIX41',    service_pack: nil},
       {version: 'FIX42',    service_pack: nil},
       {version: 'FIX43',    service_pack: nil},
       {version: 'FIX44',    service_pack: nil},
       {version: 'FIX50',    service_pack: 'FIXT11'},
       {version: 'FIX50SP1', service_pack: 'FIXT11'},
       {version: 'FIX50SP2', service_pack: 'FIXT11'}
      ].each do |fix_versions|
        xdoc = Nokogiri::XML(File.read("#{PROJECT_ROOT}/spec/fix/#{fix_versions[:version]}.xml"))
        dd   = DataDictionay.new(xdoc)

        f_path = "#{PROJECT_ROOT}/spec/tmp/#{fix_versions[:version]}/Message.cs"
        FileUtils::mkdir_p(File.dirname(f_path))
        File.open(f_path, "w") do |f|
          f.write(MessageBase.new(dd.fix_version, fix_versions[:service_pack]).to_s)
        end

        orig_path  = "#{PROJECT_ROOT}/QuickFIXn/Message/#{dd.fix_version}/Message.cs"
        diff = `diff -u --ignore-all-space #{f_path} #{orig_path}`
        if diff.empty?
          puts "SUCCESS! PATH: #{f_path} NAME: Message"
        else
          puts "FAILURE: PATH: #{orig_path} NAME: Message"
          puts "DIFF: #{diff}"
        end
      end
    end
  end

  describe MessageFactory do
    it 'renders correctly' do
      [{version: 'FIX40',    service_pack: nil},
       {version: 'FIX41',    service_pack: nil},
       {version: 'FIX42',    service_pack: nil},
       {version: 'FIX43',    service_pack: nil},
       {version: 'FIX44',    service_pack: nil},
       {version: 'FIX50',    service_pack: 'FIXT11'},
       {version: 'FIX50SP1', service_pack: 'FIXT11'},
       {version: 'FIX50SP2', service_pack: 'FIXT11'}
      ].each do |fix_versions|
        xdoc = Nokogiri::XML(File.read("#{PROJECT_ROOT}/spec/fix/#{fix_versions[:version]}.xml"))
        dd   = DataDictionay.new(xdoc)

        f_path = "#{PROJECT_ROOT}/spec/tmp/#{fix_versions[:version]}/MessageFactory.cs"
        FileUtils::mkdir_p(File.dirname(f_path))
        File.open(f_path, "w") do |f|
          f.write(MessageFactory.new(dd).to_s)
        end

        orig_path  = "#{PROJECT_ROOT}/QuickFIXn/Message/#{dd.fix_version}/MessageFactory.cs"
        diff = `diff -u --ignore-all-space #{f_path} #{orig_path}`
        if diff.empty?
          puts "SUCCESS! PATH: #{f_path} NAME: MessageFactory"
        else
          puts "FAILURE: PATH: #{orig_path} NAME: MessageFactory"
          puts "DIFF: #{diff}"
        end
      end
    end

    describe '#flatten_groups' do
      it 'returns a flattened array of nested groups' do
        xdoc = Nokogiri::XML(File.read("#{PROJECT_ROOT}/spec/fix/FIX50SP2.xml"))
        dd   = DataDictionay.new(xdoc)
        msg  = dd.find_message('IOI')

        fact = MessageFactory.new(dd)
        groups = fact.flatten_groups(msg)
        expect(groups.map(&:name)).to eq([
          "NoSecurityAltID",
          "NoEvents",
          "NoInstrumentParties",
          "NoInstrumentPartySubIDs",
          "NoComplexEvents",
          "NoComplexEventDates",
          "NoComplexEventTimes",
          "NoUnderlyings",
          "NoUnderlyingSecurityAltID",
          "NoUnderlyingStips",
          "NoUndlyInstrumentParties",
          "NoUndlyInstrumentPartySubIDs",
          "NoStipulations",
          "NoLegs",
          "NoLegSecurityAltID",
          "NoLegStipulations",
          "NoIOIQualifiers",
          "NoRoutingIDs",
          "NoPartyIDs",
          "NoPartySubIDs"
        ])
      end
    end
  end

  describe '#find_component' do
    it 'finds components' do
      dd = DataDictionay.new(Nokogiri::XML(xml))

      comp = dd.find_component('Instrument')
      expect(comp.name).to eq('component')
      expect(comp.values).to eq(['Instrument'])

      comp = dd.find_component('SomeComponent')
      expect(comp.name).to eq('component')
      expect(comp.elements[0].values).to eq(['SomeSymbol', 'Y'])
    end
  end

  describe '#fix_version' do
    it 'correctly parses the fix versions 4.X' do
      xdoc = Nokogiri::XML(File.read("#{PROJECT_ROOT}/spec/fix/FIX41.xml"))
      dd   = DataDictionay.new(xdoc)
      expect(dd.fix_version).to eq "FIX41"
    end

    it 'correctly parses the fix versions 5.X' do
      xdoc = Nokogiri::XML(File.read("#{PROJECT_ROOT}/spec/fix/FIX50SP1.xml"))
      dd   = DataDictionay.new(xdoc)
      expect(dd.fix_version).to eq "FIX50SP1"
    end
  end

  # components within groups
  describe 'Generating News.cs' do
    it 'correctly generates the file' do
      xdoc = Nokogiri::XML(File.read("#{PROJECT_ROOT}/spec/fix/FIX41.xml"))
      dd   = DataDictionay.new(xdoc)
      message = dd.find_message("News")

      f_path = "#{PROJECT_ROOT}/spec/tmp/FIX41/News.cs"
      FileUtils::mkdir_p(File.dirname(f_path))
      File.open(f_path, "w") do |f|
        message_file_content = Mustache.render(File.read(Message::TEMPLATE), {
          version: dd.fix_version,
          msgName: message.name,
          msgType: message.message_type,
          msgConstructorArguments: message.constructor_arguments,
          hasConstructorArguments: !message.constructor_arguments.empty?,
          msgConstructorList: message.constructor_list,
          msgFields: message.fields,
          msgGroups: message.groups
        })
        f.write(message_file_content)
      end

      orig_path  = "#{PROJECT_ROOT}/QuickFIXn/Message/#{dd.fix_version}/#{message.name}.cs"
      diff = `diff -u --ignore-all-space #{f_path} #{orig_path}`
      if diff.empty?
        puts "SUCCESS! PATH: #{f_path} NAME: #{message.name}"
      else
        puts "FAILURE: PATH: #{orig_path} NAME: #{message.name}"
        puts "DIFF: #{diff}"
      end
    end
  end

  # nested groups
  describe 'Generating Allocation.cs' do
    it 'correctly generates the file' do
      xdoc = Nokogiri::XML(File.read("#{PROJECT_ROOT}/spec/fix/FIX41.xml"))
      dd   = DataDictionay.new(xdoc)
      message = dd.find_message("Allocation")

      f_path = "#{PROJECT_ROOT}/spec/tmp/FIX41/Allocation.cs"
      FileUtils::mkdir_p(File.dirname(f_path))
      File.open(f_path, "w") do |f|
        message_file_content = Mustache.render(File.read(Message::TEMPLATE), {
          version: dd.fix_version,
          msgName: message.name,
          msgType: message.message_type,
          msgConstructorArguments: message.constructor_arguments,
          hasConstructorArguments: !message.constructor_arguments.empty?,
          msgConstructorList: message.constructor_list,
          msgFields: message.fields,
          msgGroups: message.groups
        })
        f.write(message_file_content)
      end

      orig_path  = "#{PROJECT_ROOT}/QuickFIXn/Message/#{dd.fix_version}/#{message.name}.cs"
      diff = `diff -u --ignore-all-space #{f_path} #{orig_path}`
      if diff.empty?
        puts "SUCCESS! PATH: #{f_path} NAME: #{message.name}"
      else
        puts "FAILURE: PATH: #{orig_path} NAME: #{message.name}"
        puts "DIFF: #{diff}"
      end
    end
  end

  describe 'FIX 4.3 components' do
    # testing groups from components not having children destroyed
    it "should not destroy component's children while parsing" do
      xdoc = Nokogiri::XML(File.read("#{PROJECT_ROOT}/spec/fix/FIX43.xml"))
      dd   = DataDictionay.new(xdoc)
      message = dd.find_message("RegistrationInstructionsResponse")

      expect(message.groups[0].fields.map(&:name)).to eq(["PartyID", "PartyIDSource", "PartyRole", "PartySubID"])
    end

    it 'include required fields from required components in the constructor arguments' do
      xdoc = Nokogiri::XML(File.read("#{PROJECT_ROOT}/spec/fix/FIX43.xml"))
      dd   = DataDictionay.new(xdoc)
      message = dd.find_message("MarketDataSnapshotFullRefresh")

      expect(message.constructor_arguments).to eq(["Symbol"])
    end

    it 'should not include required fields in non-required components in the constructor arguments' do
      xdoc = Nokogiri::XML(File.read("#{PROJECT_ROOT}/spec/fix/FIX43.xml"))
      dd   = DataDictionay.new(xdoc)
      message = dd.find_message("OrderMassStatusRequest")

      expect(message.constructor_arguments).to eq(["MassStatusReqID", "MassStatusReqType"])
    end
  end

  # NOTE: Use this test to generate / diff an entire FIX directory / version (just change FIX<version>)
  xdescribe 'QuickFIXn 50SP1' do
    it 'generates all the files' do
      xdoc = Nokogiri::XML(File.read("#{PROJECT_ROOT}/spec/fix/FIX50SP1.xml"))
      dd   = DataDictionay.new(xdoc)
      dd.save("#{PROJECT_ROOT}/spec/tmp/")

      dd.messages.each do |message|
        new_path = "#{PROJECT_ROOT}/spec/tmp/#{dd.fix_version}/#{message.name}.cs"
        orig_path  = "#{PROJECT_ROOT}/QuickFIXn/Message/#{dd.fix_version}/#{message.name}.cs"
        diff = `diff -u --ignore-all-space #{new_path} #{orig_path}`

        if diff.empty?
          puts "SUCCESS! PATH: #{new_path} NAME: #{message.name}"
        else
          puts "FAILURE: PATH: #{orig_path} NAME: #{message.name}"
          puts "DIFF: #{diff}"
        end
      end
    end
  end
end
