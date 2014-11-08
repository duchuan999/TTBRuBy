class Dmnguongoc < ActiveRecord::Base

  has_many :nhapcts, :foreign_key => :dmnguongoc_id

  validates :stt, :presence => true
  validates :ten, :presence => true
end
