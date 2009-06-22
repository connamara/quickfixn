class Value
  attr_reader :enum, :desc
  def initialize( e, d )
    @enum = e
    @desc = d
  end
end