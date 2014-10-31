class CreateDmloaiphieus < ActiveRecord::Migration
  def change
    create_table :dmloaiphieus do |t|
      t.integer :stt
      t.string :ten
      t.timestamps
    end
  end
end
