class CreateDmkhos < ActiveRecord::Migration
  def change
    create_table :dmkhos do |t|
      t.integer :stt
      t.string :ten
      t.references :dmloaikho, index: true

      t.timestamps
    end
  end
end
