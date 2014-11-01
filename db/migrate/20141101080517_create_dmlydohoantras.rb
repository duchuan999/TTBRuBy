class CreateDmlydohoantras < ActiveRecord::Migration
  def change
    create_table :dmlydohoantras do |t|
      t.integer :stt
      t.string :ten

      t.timestamps
    end
  end
end
