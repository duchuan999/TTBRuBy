class CreateDmnguons < ActiveRecord::Migration
  def change
    create_table :dmnguons do |t|
      t.string :stt
      t.string :ten
      t.string :nhom

      t.timestamps
    end
  end
end
