class Nhapct < ActiveRecord::Base
  belongs_to :dmttb
  belongs_to :nhapll
  belongs_to :dmnguongoc
  belongs_to :dmtinhtrang
end
