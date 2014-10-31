class Dmnhacc < ActiveRecord::Base
  belongs_to :dmnhomnhacc
  validates :stt, :presence => true
  validates :ma, :presence => true
  validates :ten, :presence => true, :length => {:minimum => 3}
  validates :dmnhomnhacc_id, :presence => true

  def self.search(search)
    if search
      where('ten LIKE ?', "%#{search}%")
    else
      all
    end
  end
end
