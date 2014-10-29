class CreateDmnhomins < ActiveRecord::Migration
  def change
    create_table :dmnhomins do |t|
      t.string :ten
      t.integer :stt

      t.timestamps
    end
  end
end
