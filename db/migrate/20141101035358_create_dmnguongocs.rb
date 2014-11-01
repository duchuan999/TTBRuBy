class CreateDmnguongocs < ActiveRecord::Migration
  def change
    create_table :dmnguongocs do |t|
      t.integer :stt
      t.string :ten

      t.timestamps
    end
  end
end
