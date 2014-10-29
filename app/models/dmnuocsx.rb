class Dmnuocsx < ActiveRecord::Base
  belongs_to :dmnhomnuocsx
  validates :stt, :presence => true
  validates :ten, :presence => true, :length => {:minimum => 3}
  validates :dmnhomnuocsx_id, :presence => true

  def self.search(search)
    if search
      where('ten LIKE ?', "%#{search}%")
    else
      all
    end
  end
end
