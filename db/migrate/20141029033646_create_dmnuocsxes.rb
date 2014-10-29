class CreateDmnuocsxes < ActiveRecord::Migration
  def change
    create_table :dmnuocsxes do |t|
      t.integer :stt
      t.string :ten
      t.references :dmnhomnuocsx, index: true

      t.timestamps
    end
  end
end
