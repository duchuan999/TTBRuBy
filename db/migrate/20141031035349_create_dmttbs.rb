class CreateDmttbs < ActiveRecord::Migration
  def change
    create_table :dmttbs do |t|
      t.integer :stt
      t.string :ma
      t.string :ten
      t.string :model
      t.string :hamluong
      t.string :congsuat
      t.string :tylekh
      t.string :sodk
      t.string :sothe
      t.string :hinh
      t.references :dmdvt, index: true
      t.references :dmnhom, index: true
      t.references :dmhangsx, index: true
      t.references :dmnuocsx, index: true
      t.references :dmnhombc, index: true
      t.references :dmnhomin, index: true

      t.timestamps
    end
  end
end
