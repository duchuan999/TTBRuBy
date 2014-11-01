class CreateDmlydoxuats < ActiveRecord::Migration
  def change
    create_table :dmlydoxuats do |t|
      t.integer :stt
      t.string :ten

      t.timestamps
    end
  end
end
