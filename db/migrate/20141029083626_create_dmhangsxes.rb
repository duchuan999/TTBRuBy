class CreateDmhangsxes < ActiveRecord::Migration
  def change
    create_table :dmhangsxes do |t|
      t.integer :stt
      t.string :ten
      t.references :dmnhomhangsx, index: true

      t.timestamps
    end
  end
end
