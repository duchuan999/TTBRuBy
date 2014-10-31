class CreateDmnhoms < ActiveRecord::Migration
  def change
    create_table :dmnhoms do |t|
      t.string :stt
      t.string :ten
      t.references :dmnhombc, index: true
      t.references :dmnhomin, index:true

      t.timestamps
    end
  end
end
