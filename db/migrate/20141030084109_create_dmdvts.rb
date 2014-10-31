class CreateDmdvts < ActiveRecord::Migration
  def change
    create_table :dmdvts do |t|
      t.integer :stt
      t.string :ten

      t.timestamps
    end
  end
end
