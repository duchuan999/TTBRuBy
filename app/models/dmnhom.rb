class Dmnhom < ActiveRecord::Base
  belongs_to :dmnhombc
  belongs_to :dmnhomin
  validates :stt, :presence => true
  validates :ten, :presence => true, :length => {:minimum => 3}
  validates :dmnhomin_id, :presence => true
  validates :dmnhombc_id, :presence => true

  def self.search(search)
    if search
      where('ten LIKE ?', "%#{search}%")
    else
      all
    end
  end
end
