class Dmnguon < ActiveRecord::Base
  validates :stt, :presence => true
  validates :ten, :presence => true
end
