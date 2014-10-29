class CreateDmnhomnuocsxes < ActiveRecord::Migration
  def change
    create_table :dmnhomnuocsxes do |t|
      t.string :ten
      t.integer :stt

      t.timestamps
    end
  end
end
