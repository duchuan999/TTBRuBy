class CreateNhapcts < ActiveRecord::Migration
  def change
    create_table :nhapcts do |t|
      t.integer :stt
      t.references :dmttb, index: true
      t.string :handung
      t.string :losx
      t.decimal :vat
      t.decimal :soluong
      t.decimal :dongia
      t.decimal :sotien
      t.decimal :giaban
      t.decimal :giamua
      t.decimal :tylekhauhao
      t.decimal :cuocvanchuyen
      t.decimal :chaythu
      t.string :tailieu
      t.references :nhapll, index: true
      t.string :namsx
      t.decimal :baohanh
      t.references :dmnguongoc, index: true
      t.references :dmtinhtrang, index: true
      t.string :sothe
      t.decimal :chietkhau

      t.timestamps
    end
  end
end
