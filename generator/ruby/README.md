### Ruby Generator (temporary)

This little project is an interim FIX generator to transition from ruby to powershell. It simply serves to clean up existing ruby code.

To run tests:

```
bundle install
cd generator/ruby
rspec spec
```

To generate all files:

```
generator/ruby/bin/generate
```

To diff all generated files from those existing in `QuickFIXn/Message/<Version>/`

Jump into generator_spec.rb and change the data dictionary to the desired version, remove the leading "x" from the test, and place a `:focus` on the test:

(Example:)
```
  describe 'QuickFIXn FIX50SP1' do
    it 'generates all the files', :focus do
      xdoc = Nokogiri::XML(File.read("#{PROJECT_ROOT}/spec/fix/FIX50SP1.xml"))
```
