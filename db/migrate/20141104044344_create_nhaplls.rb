class CreateNhaplls < ActiveRecord::Migration
  def change
    create_table :nhaplls do |t|
      t.string :sophieu
      t.datetime :ngaynhap
      t.string :sohoadon
      t.datetime :ngayhoadon
      t.string :bbkiem
      t.datetime :ngaykiem
      t.string :loai
      t.string :nguoigiao
      t.references :dmnhacc, index: true
      t.references :dmkho, index: true
      t.references :dmnguon, index: true
      t.string :no
      t.string :co
      t.integer :paid
      t.string :lydo
      t.decimal :chietkhau

      t.timestamps
    end
  end
end
