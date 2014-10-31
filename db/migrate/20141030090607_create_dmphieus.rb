class CreateDmphieus < ActiveRecord::Migration
  def change
    create_table :dmphieus do |t|
      t.integer :stt
      t.string :ten
      t.references :dmloaiphieu, index: true
      t.timestamps
    end
  end
end
