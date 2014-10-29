class CreateDmnhomnhaccs < ActiveRecord::Migration
  def change
    create_table :dmnhomnhaccs do |t|
      t.integer :stt
      t.string :ten

      t.timestamps
    end
  end
end
