class CreateDmnhomhangsxes < ActiveRecord::Migration
  def change
    create_table :dmnhomhangsxes do |t|
      t.integer :stt
      t.string :ten

      t.timestamps
    end
  end
end
