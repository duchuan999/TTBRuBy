class CreateDmnhombcs < ActiveRecord::Migration
  def change
    create_table :dmnhombcs do |t|
      t.integer :stt
      t.string :ten

      t.timestamps
    end
  end
end
