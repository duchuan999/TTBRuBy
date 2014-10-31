class CreateDmnhaccs < ActiveRecord::Migration
  def change
    create_table :dmnhaccs do |t|
      t.integer :stt
      t.string :ma
      t.string :ten
      t.string :diachi
      t.string :masothue
      t.string :dt
      t.string :sotk
      t.string :daidien
      t.references :dmnhomnhacc, index: true

      t.timestamps
    end
  end
end
