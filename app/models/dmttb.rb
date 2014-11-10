class Dmttb < ActiveRecord::Base
  belongs_to :dmdvt
  belongs_to :dmnhom
  belongs_to :dmhangsx
  belongs_to :dmnuocsx
  belongs_to :dmnhombc
  belongs_to :dmnhomin
  validates :stt, :presence => true
  validates :ma, :presence => true
  validates :ten, :presence => true, :length => {:minimum => 3}
  validates :dmdvt_id, :presence => true
  validates :dmnhom_id, :presence => true
  validates :dmhangsx_id, :presence => true
  validates :dmnuocsx_id, :presence => true
  validates :dmnhombc_id, :presence => true
  validates :dmnhomin_id, :presence => true
  def self.search(search)
    if search
      where('ten LIKE ?', "%#{search}%")
    else
      all
    end
  end

  def self.loadall
    sql='select a.id,a.ma,a.ten, b.ten as dvt,model,congsuat,c.ten as hang,d.ten as nuoc from medibv.dmttbs a left join medibv.dmdvts b on a.dmdvt_id=b.id left join medibv.dmhangsxes c on a.dmhangsx_id=c.id left join medibv.dmnuocsxes d on a.dmnuocsx_id=d.id'

    @dmttb= Dmttb.find_by_sql(sql)

  end
end
