class CreateDmnoiscs < ActiveRecord::Migration
  def change
    create_table :dmnoiscs do |t|
      t.integer :stt
      t.string :ma
      t.string :ten
      t.string :diachi

      t.timestamps
    end
  end
end
