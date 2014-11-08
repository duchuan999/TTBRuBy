class Nhapll < ActiveRecord::Base
  belongs_to :dmnhacc
  belongs_to :dmkho
  belongs_to :dmnguon

  validates :sophieu, :presence => true, :length => {:minimum => 3}
  validates :ngaynhap, :presence => true
  validates :sohoadon, :presence => true
  validates :ngayhoadon, :presence => true
  validates :dmnhacc_id, :presence => true
  validates :dmnguon_id, :presence => true
  validates :dmkho_id, :presence => true


   def self.load
    sl=" *,to_char(ngaynhap,'dd/mm/yyyy')as ngaynhap,to_char(ngayhoadon,'dd/mm/yyyy')as ngayhoadon"
    @nhaplls=Nhapll.select(sl).order("id")
  end

end
