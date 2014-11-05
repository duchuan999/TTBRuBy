# encoding: UTF-8
# This file is auto-generated from the current state of the database. Instead
# of editing this file, please use the migrations feature of Active Record to
# incrementally modify your database, and then regenerate this schema definition.
#
# Note that this schema.rb definition is the authoritative source for your
# database schema. If you need to create the application database on another
# system, you should be using db:schema:load, not running all the migrations
# from scratch. The latter is a flawed and unsustainable approach (the more migrations
# you'll amass, the slower it'll run and the greater likelihood for issues).
#
# It's strongly recommended that you check this file into your version control system.

ActiveRecord::Schema.define(version: 20141104045706) do

  # These are extensions that must be enabled in order to support this database
  enable_extension "plpgsql"

  create_table "dmdvts", force: true do |t|
    t.integer  "stt"
    t.string   "ten"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmhangsxes", force: true do |t|
    t.integer  "stt"
    t.string   "ten"
    t.integer  "dmnhomhangsx_id"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  add_index "dmhangsxes", ["dmnhomhangsx_id"], name: "index_dmhangsxes_on_dmnhomhangsx_id", using: :btree

  create_table "dmkhos", force: true do |t|
    t.integer  "stt"
    t.string   "ten"
    t.integer  "dmloaikho_id"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  add_index "dmkhos", ["dmloaikho_id"], name: "index_dmkhos_on_dmloaikho_id", using: :btree

  create_table "dmloaikhos", force: true do |t|
    t.integer  "stt"
    t.string   "ten"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmloaiphieus", force: true do |t|
    t.integer  "stt"
    t.string   "ten"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmlydohoantras", force: true do |t|
    t.integer  "stt"
    t.string   "ten"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmlydoxuats", force: true do |t|
    t.integer  "stt"
    t.string   "ten"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmnguongocs", force: true do |t|
    t.integer  "stt"
    t.string   "ten"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmnguons", force: true do |t|
    t.string   "stt"
    t.string   "ten"
    t.string   "nhom"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmnhaccs", force: true do |t|
    t.integer  "stt"
    t.string   "ma"
    t.string   "ten"
    t.string   "diachi"
    t.string   "masothue"
    t.string   "dt"
    t.string   "sotk"
    t.string   "daidien"
    t.integer  "dmnhomnhacc_id"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  add_index "dmnhaccs", ["dmnhomnhacc_id"], name: "index_dmnhaccs_on_dmnhomnhacc_id", using: :btree

  create_table "dmnhombcs", force: true do |t|
    t.integer  "stt"
    t.string   "ten"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmnhomhangsxes", force: true do |t|
    t.integer  "stt"
    t.string   "ten"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmnhomins", force: true do |t|
    t.string   "ten"
    t.integer  "stt"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmnhomnhaccs", force: true do |t|
    t.integer  "stt"
    t.string   "ten"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmnhomnuocsxes", force: true do |t|
    t.string   "ten"
    t.integer  "stt"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmnhoms", force: true do |t|
    t.string   "stt"
    t.string   "ten"
    t.integer  "dmnhombc_id"
    t.integer  "dmnhomin_id"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  add_index "dmnhoms", ["dmnhombc_id"], name: "index_dmnhoms_on_dmnhombc_id", using: :btree
  add_index "dmnhoms", ["dmnhomin_id"], name: "index_dmnhoms_on_dmnhomin_id", using: :btree

  create_table "dmnoiscs", force: true do |t|
    t.integer  "stt"
    t.string   "ma"
    t.string   "ten"
    t.string   "diachi"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmnuocsxes", force: true do |t|
    t.integer  "stt"
    t.string   "ten"
    t.integer  "dmnhomnuocsx_id"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  add_index "dmnuocsxes", ["dmnhomnuocsx_id"], name: "index_dmnuocsxes_on_dmnhomnuocsx_id", using: :btree

  create_table "dmphieus", force: true do |t|
    t.integer  "stt"
    t.string   "ten"
    t.integer  "dmloaiphieu_id"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  add_index "dmphieus", ["dmloaiphieu_id"], name: "index_dmphieus_on_dmloaiphieu_id", using: :btree

  create_table "dmtinhtrangs", force: true do |t|
    t.integer  "stt"
    t.string   "ten"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "dmttbs", force: true do |t|
    t.integer  "stt"
    t.string   "ma"
    t.string   "ten"
    t.string   "model"
    t.string   "hamluong"
    t.string   "congsuat"
    t.string   "tylekh"
    t.string   "sodk"
    t.string   "sothe"
    t.string   "hinh"
    t.integer  "dmdvt_id"
    t.integer  "dmnhom_id"
    t.integer  "dmhangsx_id"
    t.integer  "dmnuocsx_id"
    t.integer  "dmnhombc_id"
    t.integer  "dmnhomin_id"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  add_index "dmttbs", ["dmdvt_id"], name: "index_dmttbs_on_dmdvt_id", using: :btree
  add_index "dmttbs", ["dmhangsx_id"], name: "index_dmttbs_on_dmhangsx_id", using: :btree
  add_index "dmttbs", ["dmnhom_id"], name: "index_dmttbs_on_dmnhom_id", using: :btree
  add_index "dmttbs", ["dmnhombc_id"], name: "index_dmttbs_on_dmnhombc_id", using: :btree
  add_index "dmttbs", ["dmnhomin_id"], name: "index_dmttbs_on_dmnhomin_id", using: :btree
  add_index "dmttbs", ["dmnuocsx_id"], name: "index_dmttbs_on_dmnuocsx_id", using: :btree

  create_table "nhapcts", force: true do |t|
    t.integer  "stt"
    t.integer  "dmttb_id"
    t.string   "handung"
    t.string   "losx"
    t.decimal  "vat"
    t.decimal  "soluong"
    t.decimal  "dongia"
    t.decimal  "sotien"
    t.decimal  "giaban"
    t.decimal  "giamua"
    t.decimal  "tylekhauhao"
    t.decimal  "cuocvanchuyen"
    t.decimal  "chaythu"
    t.string   "tailieu"
    t.integer  "nhapll_id"
    t.string   "namsx"
    t.decimal  "baohanh"
    t.integer  "dmnguongoc_id"
    t.integer  "dmtinhtrang_id"
    t.string   "sothe"
    t.decimal  "chietkhau"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  add_index "nhapcts", ["dmnguongoc_id"], name: "index_nhapcts_on_dmnguongoc_id", using: :btree
  add_index "nhapcts", ["dmtinhtrang_id"], name: "index_nhapcts_on_dmtinhtrang_id", using: :btree
  add_index "nhapcts", ["dmttb_id"], name: "index_nhapcts_on_dmttb_id", using: :btree
  add_index "nhapcts", ["nhapll_id"], name: "index_nhapcts_on_nhapll_id", using: :btree

  create_table "nhaplls", force: true do |t|
    t.string   "sophieu"
    t.datetime "ngaynhap"
    t.string   "sohoadon"
    t.datetime "ngayhoadon"
    t.string   "bbkiem"
    t.datetime "ngaykiem"
    t.string   "loai"
    t.string   "nguoigiao"
    t.integer  "dmnhacc_id"
    t.integer  "dmkho_id"
    t.integer  "dmnguon_id"
    t.string   "no"
    t.string   "co"
    t.integer  "paid"
    t.string   "lydo"
    t.decimal  "chietkhau"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  add_index "nhaplls", ["dmkho_id"], name: "index_nhaplls_on_dmkho_id", using: :btree
  add_index "nhaplls", ["dmnguon_id"], name: "index_nhaplls_on_dmnguon_id", using: :btree
  add_index "nhaplls", ["dmnhacc_id"], name: "index_nhaplls_on_dmnhacc_id", using: :btree

end
