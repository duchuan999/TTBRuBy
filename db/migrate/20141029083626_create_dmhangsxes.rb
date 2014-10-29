class CreateDmhangsxes < ActiveRecord::Migration
  def change
    create_table :dmhangsxes do |t|
      t.integer :stt
      t.string :ten

      t.timestamps
    end
  end
end
