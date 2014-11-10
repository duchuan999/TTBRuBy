class Nhapct < ActiveRecord::Base
  belongs_to :dmttb, foreign_key: 'dmttb_id'
  belongs_to :nhapll,foreign_key: 'nhapll_id'
  belongs_to :dmnguongoc,foreign_key: 'dmnguongoc_id'
  belongs_to :dmtinhtrang, :foreign_key => :dmtinhtrang_id
  validates :dmttb_id, :presence => true
end
