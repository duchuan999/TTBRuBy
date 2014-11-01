class CreateDmtinhtrangs < ActiveRecord::Migration
  def change
    create_table :dmtinhtrangs do |t|
      t.integer :stt
      t.string :ten

      t.timestamps
    end
  end
end
