class CreateDmloaikhos < ActiveRecord::Migration
  def change
    create_table :dmloaikhos do |t|
      t.integer :stt
      t.string :ten
      t.timestamps
    end
  end
end
