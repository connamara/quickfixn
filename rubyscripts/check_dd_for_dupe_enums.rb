require 'rubygems'
require 'nokogiri'

# Script to check issue #114 (duplicate enum values in DDs)
# Shows all enums for which there are dupe values.

# Takes one param: the path to a DD.
# If no params, runs on all DDs in <gitroot>/spec


def hash_has_dupes h
  h.each {|k,v| return true if v>1 }
  false
end


dds = []

if ARGV.length == 0
  dds = Dir.glob("../spec/fix/*xml")
else
  dds = Array.new(ARGV)
end

dds.each {|ddfile|
  puts "== Processing #{ddfile}"
  doc = Nokogiri::XML(open(ddfile))
  doc.xpath("//fields//field").each {|f|
    field_name = "#{f.attribute("name")}/#{f.attribute("number")}"

    enums = f.element_children
    if enums.count > 0
      h = {}
      enums.each {|e|
        enumval = e.attribute("enum").value
        h[enumval] = 0 unless h.has_key?(enumval)
        h[enumval] += 1
      }

      if hash_has_dupes(h)
        puts "   * field #{field_name}"
        h.each {|k,v|
          puts "     - #{k}: #{v} times" if v > 1
        }
      end
    end
  }
}

